﻿using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LongTech.BrainFuckIDE
{
  public partial class MemoryView2 : UserControl
  {
    /// <summary>
    /// 
    /// </summary>
    public enum DisplayMode
    {
      /// <summary>
      /// 
      /// </summary>
      ASCII = 0,
      /// <summary>
      /// 
      /// </summary>
      Octal = 1,
      /// <summary>
      /// 
      /// </summary>
      Decimal = 2,
      /// <summary>
      /// 
      /// </summary>
      Hexadecimal = 3,
    };

    private long mPageID = 0;
    private long mPages = 0;
    private DisplayMode mDisplayMode = DisplayMode.ASCII;
    private MemoryStream mMemStream = new MemoryStream();
    private byte[] mLastUpdate = new byte[256];

    /// <summary>
    /// 
    /// </summary>
    public MemoryStream Memory
    {
      get { return mMemStream; }
      set
      {
        mMemStream = value;

        mPages = mMemStream.Length / 256;
        if (mMemStream.Length % 256 > 0)
        {
          mPages++;
        }

        // Populate with page 1 data
        ToolStripButtonFirst_Click(null, EventArgs.Empty);
      }
    }

    private int mLastActiveCell = -1, activeCell = -1;
    /// <summary>
    /// 
    /// </summary>
    public int ActiveCell
    {
      get { return activeCell; }
      set { mLastActiveCell = activeCell; activeCell = value; }
    }

    /// <summary>
    /// 
    /// </summary>
    public DisplayMode DisplayAs
    {
      get { return mDisplayMode; }
      set { mDisplayMode = value; }
    }

    public MemoryView2()
    {
      DoubleBuffered = true;

      InitializeComponent();
    }

    private void ToolStripButtonFirst_Click(object sender, EventArgs e)
    {
      mPageID = 0;
      SetPageText();
      Refresh();
    }

    private void ToolStripButtonBack_Click(object sender, EventArgs e)
    {
      if (mPageID > 0) mPageID--;
      else mPageID = mPages - 1;
      SetPageText();
      Refresh();
    }

    private void ToolStripButtonNext_Click(object sender, EventArgs e)
    {
      if (mPageID < mPages - 1) mPageID++;
      else mPageID = 0;
      SetPageText();
      Refresh();
    }

    private void ToolStripButtonLast_Click(object sender, EventArgs e)
    {
      mPageID = mPages - 1;
      SetPageText();
      Refresh();
    }

    private void ASCIIToolStripMenuItem_Click(object sender, EventArgs e)
    {
      mDisplayMode = DisplayMode.ASCII;
      SetPageText();
      Refresh();
    }

    private void HexadecimalToolStripMenuItem_Click(object sender, EventArgs e)
    {
      mDisplayMode = DisplayMode.Hexadecimal;
      SetPageText();
      Refresh();
    }

    private void DecimalToolStripMenuItem_Click(object sender, EventArgs e)
    {
      mDisplayMode = DisplayMode.Decimal;
      SetPageText();
      Refresh();
    }

    private void OctalToolStripMenuItem_Click(object sender, EventArgs e)
    {
      mDisplayMode = DisplayMode.Octal;
      SetPageText();
      Refresh();
    }

    private void SetPageText()
    {
      toolStripLabelPage.Text = string.Format("Page {0} of {1}", mPageID + 1, mPages);
    }

    private Pen border = new Pen(Color.Black, 1);
    private Brush brush = new SolidBrush(Color.Black);
    private Brush activeCellBrush = new SolidBrush(Color.LightSalmon);

    private void PaintView(object sender, PaintEventArgs e)
    {
      Graphics g = e.Graphics;
      int topOffset = toolStrip1.Location.Y + toolStrip1.Height;
      int xOff = (Width - Location.X) / 16;
      int yOff = (Height - topOffset - Location.Y) / 16;

      byte[] data = new byte[256];
      long start = mPageID * 256, count = 256;
      if (start > mMemStream.Length - 256)
        count = mMemStream.Length - start;

      //Grab [count] bytes starting at [start] offset
      //data = getPage(ref mMemStream, start, count);
      try
      {
        mMemStream.Position = start;
        mMemStream.Read(data, 0, (int)count);
      }
      catch { return; }

      if (data == mLastUpdate)
        return;

      byte cValue = 0;
      string outStr = "";
      SizeF fontSize = new SizeF(0, 0);

      for (int x = 0; x < 16; x++)
      {
        for (int y = 0; y < 16; y++)
        {
          // Draw the cell border if the active cell has changed
          g.DrawRectangle(border, new Rectangle(x * xOff, y * yOff + topOffset, xOff, yOff));
          // If the active cell has changed, fill it in
          if (ActiveCell == start + y * 16 + x)
            g.FillRectangle(activeCellBrush, new Rectangle(x * xOff + 1, y * yOff + topOffset + 1, xOff - 1, yOff - 1));

          // Draw the current character
          cValue = data[y * 16 + x];

          switch (mDisplayMode)
          {
            case DisplayMode.ASCII:
              if (char.IsControl((char)cValue))
                outStr = "??";
              else
                outStr = ((char)cValue).ToString();
              break;
            case DisplayMode.Octal:
              outStr = Convert.ToString(cValue, 8);
              break;
            case DisplayMode.Decimal:
              outStr = cValue.ToString();
              break;
            case DisplayMode.Hexadecimal:
              outStr = cValue.ToString("X2");
              break;
            default:
              throw new Exception();
          }

          fontSize = g.MeasureString(outStr, Font);
          g.DrawString(outStr, Font, brush, new PointF(x * xOff + (xOff / 2) - (fontSize.Width / 2), y * yOff + (yOff / 2) - (fontSize.Height / 2) + topOffset));
        }
      }
    }
  }
}
