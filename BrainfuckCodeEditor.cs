using LongTech.Core;
using LongTech.Portable;
using LongTech.Protocol.BrainFuck;
using LongTech.UI.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace LongTech.BrainFuckIDE
{
  public partial class BrainfuckCodeEditor : Form
  {
    private string mCurrentFile = "";
    private bool mIsModified = false;
    private const int mMemorySize = 5120;
    private static Thread worker;
    private static bool mContinue = false;

    public BrainfuckCodeEditor()
    {
      InitializeComponent();
    }

    private void Editor_Load(object sender, EventArgs e)
    {
      ulong[] b = new ulong[mMemorySize];
      bool dir = false;

      for (int i = 0; i < mMemorySize; i++)
      {
        b[i] = (byte)(dir ? (i % 256) : (256 - i) % 256);
        if (i % 256 == 0)
        {
          dir = !dir;
        }
      }

      MemoryView1.Memory = b;
      MemoryView1.ActiveCell = 0;
    }

    private void ToolStripButtonNew_Click(object sender, EventArgs e)
    {
      if (mIsModified)
      {
        DialogResult res = MessageBox.Show(string.Format("Save {0} before closing?", mCurrentFile),
              "BrainFuck IDE", MessageBoxButtons.YesNoCancel);

        if (res == DialogResult.Yes)
        {
          ToolStripButtonSave_Click(null, null);
        }
        else if (res == DialogResult.No)
        {
          //Don't save, just close
        }
        else
        {
          //Cancel, don't do anything
          return;
        }
      }

      //Clear everything out
      mCurrentFile = "";
      TextBoxCode.Text = "";
      TextBoxOutput.Text = "";
      mIsModified = false;

      //Reset memory view to a bunch of nothing
      MemoryView1.Memory = new ulong[mMemorySize];
      MemoryView1.ActiveCell = -1;
    }

    private void ToolStripButtonOpen_Click(object sender, EventArgs e)
    {
      OpenFileDialog1.FileName = mCurrentFile;
      if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
      {
        try
        {
          Stream myStream;
          if ((myStream = OpenFileDialog1.OpenFile()) != null)
          {
            TextBoxCode.Text = "";
            TextBoxOutput.Text = "";

            using (myStream)
            {
              int b;
              do
              {
                b = myStream.ReadByte();
                if (b != -1)
                {
                  TextBoxCode.Text += (char)b;
                }
              } while (b != -1);
            }
          }

          //Track which file is opened
          mCurrentFile = OpenFileDialog1.FileName;
          mIsModified = false;
        }
        catch
        {
          MessageBox.Show("Error opening " + SaveFileDialog1.FileName);
        }
      }
    }

    private void ToolStripButtonSave_Click(object sender, EventArgs e)
    {
      SaveFileDialog1.FileName = mCurrentFile;
      if (mCurrentFile != "")
      {
        try
        {
          StreamWriter myStream = new StreamWriter(SaveFileDialog1.FileName);
          myStream.Write(TextBoxCode.Text);
          myStream.Close();

          mIsModified = false;
        }
        catch
        {
          MessageBox.Show("Error saving " + OpenFileDialog1.FileName);
        }
      }
      else
      {
        SaveFileDialog1.OverwritePrompt = true;
        if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
        {
          try
          {
            StreamWriter myStream = new StreamWriter(SaveFileDialog1.FileName);
            myStream.Write(TextBoxCode.Text);
            myStream.Close();

            mIsModified = false;
          }
          catch
          {
            MessageBox.Show("Error saving " + OpenFileDialog1.FileName);
          }
        }
      }
    }

    private void ToolStripButtonUndo_Click(object sender, EventArgs e)
    {

    }

    private void TtoolStripButtonRedo_Click(object sender, EventArgs e)
    {

    }

    private void ToolStripButtonCompile_Click(object sender, EventArgs e)
    {
      ToolStripStatusLabel1.Text = string.Format("Compiling {0} ...", mCurrentFile);
      //Call BF compiler, do work...
      ToolStripStatusLabel1.Text = mCurrentFile + " compiled successfully!";
    }

    private void ToolStripButtonStart_Click(object sender, EventArgs e)
    {
      ToolStripStatusLabel1.Text = string.Format("Running {0} ...", mCurrentFile);
      worker = new Thread(FuckingWorker);
      worker.Start();
    }

    private void ToolStripButtonStop_Click(object sender, EventArgs e)
    {
      ToolStripStatusLabel1.Text = "Stopping interpreter ...";

      //Stop BF interpreter
      if (worker != null)
      {
        worker.Abort();
        worker.Join();
        worker = null;
      }

      ToolStripStatusLabel1.Text = "";
    }

    private void ToolStripStepForward_Click(object sender, EventArgs e)
    {
      //Step forward to next instruction
      mContinue = true;
    }

    private void ToolStripButtonStepOut_Click(object sender, EventArgs e)
    {
      //Step out of current loop (or run to EOF if not in a loop)
    }

    private void TextBoxCode_TextChanged(object sender, EventArgs e)
    {
      //Code was modified
      mIsModified = true;
    }

    private string GetCode()
    {
      string ret = null;
      if (InvokeRequired)
      {
        IAsyncResult res = BeginInvoke(new StringVoid(GetCode));
        ret = (string)EndInvoke(res);
      }
      else
      {
        ret = TextBoxCode.Text;
      }
      return ret;
    }

    private void UpdateOutput(string msg)
    {
      if (InvokeRequired)
      {
        BeginInvoke(new VoidString(UpdateOutput), msg);
      }
      else
      {
        TextBoxOutput.Text += msg;
      }
    }

    private List<int> GetBreakpoints()
    {
      List<int> ret = null;
      if (InvokeRequired)
      {
        IAsyncResult res = BeginInvoke(new ListVoid(GetBreakpoints));
        ret = (List<int>)EndInvoke(res);
      }
      else
      {
        ret = TextBoxCode.Breakpoints;
      }
      return ret;
    }

    private void FuckingWorker()
    {
      //Call BF interpreter, do work...
      int size = Convert.ToInt32(ToolStripTextBoxMemorySize.Text);
      List<int> breakpoints = GetBreakpoints();
      BrainFuck bf = new BrainFuck(size);
      string code = TextBoxCode.Text;//GetCode();

      int len = code.Length;
      object buf = 0;
      bool refresh = false;

      for (int i = 0; i < len; i++)
      {
        refresh = false;

        if (breakpoints.Contains(i))
        {
          breakpoints.Remove(i);
          mContinue = false;
          //Wait until we step again
          do
          {
            Thread.Sleep(1);
          } while (!mContinue);
        }

        try
        {
          switch (code[i])
          {
            case '>': bf.IncPtr(); break;
            case '<': bf.DecPtr(); break;
            case '+': bf.Inc(); refresh = true; break;
            case '-': bf.Dec(); refresh = true; break;
            case '.': bf.Out(ref buf); UpdateOutput(((char)buf).ToString()); refresh = true; break;
            case ',':
              {
                //buf = (byte)PortableLib.Log.Read();
                using (var f = new BFInputCharForm())
                {
                  if (f.ShowDialog() == DialogResult.OK)
                  {
                    buf = (byte)f.Input;
                    bf.In(ref buf);
                  }
                }

                refresh = true;
              }
              break;
            case '[': bf.StartLoop(i); break;
            case ']': i = bf.StopLoop(i); break;
            default: break;
          }

          if (refresh)
          {
            RefreshMemoryView(bf.PtrLocation, bf.Memory);

            // Give the MemoryView a chance to update
            Thread.Sleep(10);
          }
        }
        catch { }
      }

      SetStatus("End of script reached.");
    }

    private void SetStatus(string msg)
    {
      if (InvokeRequired)
      {
        BeginInvoke((Action)(() => { SetStatus(msg); }));
        return;
      }

      ToolStripStatusLabel1.Text = msg;
    }

    private void RefreshMemoryView(int ptr, ulong[] mem)
    {
      if (InvokeRequired)
      {
        BeginInvoke((Action)(() => { RefreshMemoryView(ptr, mem); }));
        return;
      }

      MemoryView1.Memory = mem;
      MemoryView1.ActiveCell = ptr;
    }

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      PortableLib.Initialize();

      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new BrainfuckCodeEditor());
    }
  }
}
