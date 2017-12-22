﻿using LongTech.UI.Controls;

namespace LongTech.BrainFuckIDE
{
  partial class BrainfuckCodeEditor
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrainfuckCodeEditor));
      this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
      this.ToolStripButtonNew = new System.Windows.Forms.ToolStripButton();
      this.ToolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
      this.ToolStripButtonSave = new System.Windows.Forms.ToolStripButton();
      this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.ToolStripButtonUndo = new System.Windows.Forms.ToolStripButton();
      this.ToolStripButtonRedo = new System.Windows.Forms.ToolStripButton();
      this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.ToolStripButtonCompile = new System.Windows.Forms.ToolStripButton();
      this.ToolStripButtonStart = new System.Windows.Forms.ToolStripButton();
      this.ToolStripButtonStop = new System.Windows.Forms.ToolStripButton();
      this.ToolStripStepForward = new System.Windows.Forms.ToolStripButton();
      this.ToolStripButtonStepOut = new System.Windows.Forms.ToolStripButton();
      this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.ToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
      this.ToolStripTextBoxMemorySize = new System.Windows.Forms.ToolStripTextBox();
      this.ToolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
      this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
      this.ToolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
      this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
      this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
      this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
      this.SplitContainer2 = new System.Windows.Forms.SplitContainer();
      this.TextBoxCode = new LongTech.UI.Controls.DebuggingControl();
      this.TextBoxOutput = new TextBox();
      this.MemoryView1 = new LongTech.UI.Controls.MemoryView();
      this.ToolStrip1.SuspendLayout();
      this.StatusStrip1.SuspendLayout();
      this.SplitContainer1.Panel1.SuspendLayout();
      this.SplitContainer1.Panel2.SuspendLayout();
      this.SplitContainer1.SuspendLayout();
      this.SplitContainer2.Panel1.SuspendLayout();
      this.SplitContainer2.Panel2.SuspendLayout();
      this.SplitContainer2.SuspendLayout();
      this.SuspendLayout();
      // 
      // toolStrip1
      // 
      this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButtonNew,
            this.ToolStripButtonOpen,
            this.ToolStripButtonSave,
            this.ToolStripSeparator1,
            this.ToolStripButtonUndo,
            this.ToolStripButtonRedo,
            this.ToolStripSeparator2,
            this.ToolStripButtonCompile,
            this.ToolStripButtonStart,
            this.ToolStripButtonStop,
            this.ToolStripStepForward,
            this.ToolStripButtonStepOut,
            this.ToolStripSeparator3,
            this.ToolStripLabel1,
            this.ToolStripTextBoxMemorySize,
            this.ToolStripLabel2});
      this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
      this.ToolStrip1.Name = "ToolStrip1";
      this.ToolStrip1.Size = new System.Drawing.Size(624, 25);
      this.ToolStrip1.TabIndex = 0;
      this.ToolStrip1.Text = "ToolStrip1";
      // 
      // toolStripButtonNew
      // 
      this.ToolStripButtonNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      //this.ToolStripButtonNew.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonNew.Image")));
      this.ToolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.ToolStripButtonNew.Name = "ToolStripButtonNew";
      this.ToolStripButtonNew.Size = new System.Drawing.Size(23, 22);
      this.ToolStripButtonNew.Text = "New";
      this.ToolStripButtonNew.Click += new System.EventHandler(this.ToolStripButtonNew_Click);
      // 
      // toolStripButtonOpen
      // 
      this.ToolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      //this.ToolStripButtonOpen.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonOpen.Image")));
      this.ToolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.ToolStripButtonOpen.Name = "ToolStripButtonOpen";
      this.ToolStripButtonOpen.Size = new System.Drawing.Size(23, 22);
      this.ToolStripButtonOpen.Text = "Open";
      this.ToolStripButtonOpen.Click += new System.EventHandler(this.ToolStripButtonOpen_Click);
      // 
      // toolStripButtonSave
      // 
      this.ToolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
     // this.ToolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonSave.Image")));
      this.ToolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.ToolStripButtonSave.Name = "ToolStripButtonSave";
      this.ToolStripButtonSave.Size = new System.Drawing.Size(23, 22);
      this.ToolStripButtonSave.Text = "Save";
      this.ToolStripButtonSave.Click += new System.EventHandler(this.ToolStripButtonSave_Click);
      // 
      // toolStripSeparator1
      // 
      this.ToolStripSeparator1.Name = "ToolStripSeparator1";
      this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
      // 
      // toolStripButtonUndo
      // 
      this.ToolStripButtonUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
     // this.ToolStripButtonUndo.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonUndo.Image")));
      this.ToolStripButtonUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.ToolStripButtonUndo.Name = "ToolStripButtonUndo";
      this.ToolStripButtonUndo.Size = new System.Drawing.Size(23, 22);
      this.ToolStripButtonUndo.Text = "Undo";
      this.ToolStripButtonUndo.Click += new System.EventHandler(this.ToolStripButtonUndo_Click);
      // 
      // toolStripButtonRedo
      // 
      this.ToolStripButtonRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      //this.ToolStripButtonRedo.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonRedo.Image")));
      this.ToolStripButtonRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.ToolStripButtonRedo.Name = "ToolStripButtonRedo";
      this.ToolStripButtonRedo.Size = new System.Drawing.Size(23, 22);
      this.ToolStripButtonRedo.Text = "Redo";
      this.ToolStripButtonRedo.Click += new System.EventHandler(this.TtoolStripButtonRedo_Click);
      // 
      // toolStripSeparator2
      // 
      this.ToolStripSeparator2.Name = "ToolStripSeparator2";
      this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 25);
      // 
      // toolStripButtonCompile
      // 
      this.ToolStripButtonCompile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      //this.ToolStripButtonCompile.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonCompile.Image")));
      this.ToolStripButtonCompile.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.ToolStripButtonCompile.Name = "ToolStripButtonCompile";
      this.ToolStripButtonCompile.Size = new System.Drawing.Size(23, 22);
      this.ToolStripButtonCompile.Text = "Compile";
      this.ToolStripButtonCompile.Click += new System.EventHandler(this.ToolStripButtonCompile_Click);
      // 
      // toolStripButtonStart
      // 
      this.ToolStripButtonStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      //this.ToolStripButtonStart.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonStart.Image")));
      this.ToolStripButtonStart.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.ToolStripButtonStart.Name = "ToolStripButtonStart";
      this.ToolStripButtonStart.Size = new System.Drawing.Size(23, 22);
      this.ToolStripButtonStart.Text = "Run";
      this.ToolStripButtonStart.Click += new System.EventHandler(this.ToolStripButtonStart_Click);
      // 
      // toolStripButtonStop
      // 
      this.ToolStripButtonStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      //this.ToolStripButtonStop.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonStop.Image")));
      this.ToolStripButtonStop.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.ToolStripButtonStop.Name = "ToolStripButtonStop";
      this.ToolStripButtonStop.Size = new System.Drawing.Size(23, 22);
      this.ToolStripButtonStop.Text = "Stop";
      this.ToolStripButtonStop.Click += new System.EventHandler(this.ToolStripButtonStop_Click);
      // 
      // toolStripStepForward
      // 
      this.ToolStripStepForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      //this.ToolStripStepForward.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripStepForward.Image")));
      this.ToolStripStepForward.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.ToolStripStepForward.Name = "ToolStripStepForward";
      this.ToolStripStepForward.Size = new System.Drawing.Size(23, 22);
      this.ToolStripStepForward.Text = "Step Forward";
      this.ToolStripStepForward.Click += new System.EventHandler(this.ToolStripStepForward_Click);
      // 
      // toolStripButtonStepOut
      // 
      this.ToolStripButtonStepOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      //this.ToolStripButtonStepOut.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonStepOut.Image")));
      this.ToolStripButtonStepOut.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.ToolStripButtonStepOut.Name = "ToolStripButtonStepOut";
      this.ToolStripButtonStepOut.Size = new System.Drawing.Size(23, 22);
      this.ToolStripButtonStepOut.Text = "Step Out";
      this.ToolStripButtonStepOut.Click += new System.EventHandler(this.ToolStripButtonStepOut_Click);
      // 
      // toolStripSeparator3
      // 
      this.ToolStripSeparator3.Name = "ToolStripSeparator3";
      this.ToolStripSeparator3.Size = new System.Drawing.Size(6, 25);
      // 
      // toolStripLabel1
      // 
      this.ToolStripLabel1.Name = "ToolStripLabel1";
      this.ToolStripLabel1.Size = new System.Drawing.Size(71, 22);
      this.ToolStripLabel1.Text = "Memory Size:";
      // 
      // toolStripTextBoxMemorySize
      // 
      this.ToolStripTextBoxMemorySize.Name = "ToolStripTextBoxMemorySize";
      this.ToolStripTextBoxMemorySize.Size = new System.Drawing.Size(38, 25);
      this.ToolStripTextBoxMemorySize.Text = "300";
      this.ToolStripTextBoxMemorySize.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // toolStripLabel2
      // 
      this.ToolStripLabel2.Name = "ToolStripLabel2";
      this.ToolStripLabel2.Size = new System.Drawing.Size(34, 22);
      this.ToolStripLabel2.Text = "bytes";
      // 
      // statusStrip1
      // 
      this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripProgressBar1,
            this.ToolStripStatusLabel1});
      this.StatusStrip1.Location = new System.Drawing.Point(0, 420);
      this.StatusStrip1.Name = "StatusStrip1";
      this.StatusStrip1.Size = new System.Drawing.Size(624, 22);
      this.StatusStrip1.TabIndex = 1;
      this.StatusStrip1.Text = "StatusStrip1";
      // 
      // toolStripProgressBar1
      // 
      this.ToolStripProgressBar1.Name = "ToolStripProgressBar1";
      this.ToolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
      // 
      // toolStripStatusLabel1
      // 
      this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
      this.ToolStripStatusLabel1.Size = new System.Drawing.Size(141, 17);
      this.ToolStripStatusLabel1.Text = "Brainfuck IDE - Version 1.0b";
      // 
      // openFileDialog1
      // 
      this.OpenFileDialog1.DefaultExt = "bf";
      this.OpenFileDialog1.Filter = "Brainfuck Script|*.bf|All Files|*.*";
      // 
      // saveFileDialog1
      // 
      this.SaveFileDialog1.DefaultExt = "bf";
      this.SaveFileDialog1.Filter = "Brainfuck Script|*.bf|All Files|*.*";
      // 
      // splitContainer1
      // 
      this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.SplitContainer1.Location = new System.Drawing.Point(0, 25);
      this.SplitContainer1.Name = "SplitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.SplitContainer1.Panel1.Controls.Add(this.SplitContainer2);
      // 
      // splitContainer1.Panel2
      // 
      this.SplitContainer1.Panel2.Controls.Add(this.MemoryView1);
      this.SplitContainer1.Size = new System.Drawing.Size(624, 395);
      this.SplitContainer1.SplitterDistance = 378;
      this.SplitContainer1.TabIndex = 2;
      // 
      // splitContainer2
      // 
      this.SplitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
      this.SplitContainer2.Location = new System.Drawing.Point(0, 0);
      this.SplitContainer2.Name = "SplitContainer2";
      this.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer2.Panel1
      // 
      this.SplitContainer2.Panel1.Controls.Add(this.TextBoxCode);
      // 
      // splitContainer2.Panel2
      // 
      this.SplitContainer2.Panel2.Controls.Add(this.TextBoxOutput);
      this.SplitContainer2.Size = new System.Drawing.Size(376, 395);
      this.SplitContainer2.SplitterDistance = 305;
      this.SplitContainer2.TabIndex = 0;
      // 
      // textBoxCode
      // 
      this.TextBoxCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
      //this.textBoxCode.Breakpoints = ((LongTech.Core.Collection2D<int>)(resources.GetObject("textBoxCode.Breakpoints")));
      this.TextBoxCode.IsModified = false;
      this.TextBoxCode.Location = new System.Drawing.Point(0, 0);
      this.TextBoxCode.Name = "TextBoxCode";
      this.TextBoxCode.Size = new System.Drawing.Size(373, 303);
      this.TextBoxCode.TabIndex = 0;
      // 
      // textBoxOutput
      // 
      this.TextBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
      this.TextBoxOutput.Location = new System.Drawing.Point(0, 0);
      this.TextBoxOutput.Multiline = true;
      this.TextBoxOutput.Name = "TextBoxOutput";
      this.TextBoxOutput.Size = new System.Drawing.Size(376, 86);
      this.TextBoxOutput.TabIndex = 0;
      // 
      // memoryView1
      // 
      this.MemoryView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
      this.MemoryView1.AutoScroll = true;
      this.MemoryView1.DisplayAs = LongTech.UI.Controls.MemoryView.DisplayMode.ASCII;
      this.MemoryView1.Location = new System.Drawing.Point(0, 0);
      this.MemoryView1.Name = "MemoryView1";
      this.MemoryView1.Size = new System.Drawing.Size(239, 395);
      this.MemoryView1.TabIndex = 0;
      // 
      // BrainfuckCodeEditor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(624, 442);
      this.Controls.Add(this.SplitContainer1);
      this.Controls.Add(this.StatusStrip1);
      this.Controls.Add(this.ToolStrip1);
      this.Name = "BrainfuckCodeEditor";
      this.Text = "BrainFuck IDE";
      this.Load += new System.EventHandler(this.Editor_Load);
      this.ToolStrip1.ResumeLayout(false);
      this.ToolStrip1.PerformLayout();
      this.StatusStrip1.ResumeLayout(false);
      this.StatusStrip1.PerformLayout();
      this.SplitContainer1.Panel1.ResumeLayout(false);
      this.SplitContainer1.Panel2.ResumeLayout(false);
      this.SplitContainer1.ResumeLayout(false);
      this.SplitContainer2.Panel1.ResumeLayout(false);
      this.SplitContainer2.Panel2.ResumeLayout(false);
      this.SplitContainer2.Panel2.PerformLayout();
      this.SplitContainer2.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ToolStrip ToolStrip1;
    private System.Windows.Forms.ToolStripButton ToolStripButtonNew;
    private System.Windows.Forms.ToolStripButton ToolStripButtonOpen;
    private System.Windows.Forms.ToolStripButton ToolStripButtonSave;
    private System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
    private System.Windows.Forms.ToolStripButton ToolStripButtonUndo;
    private System.Windows.Forms.ToolStripButton ToolStripButtonRedo;
    private System.Windows.Forms.StatusStrip StatusStrip1;
    private System.Windows.Forms.OpenFileDialog OpenFileDialog1;
    private System.Windows.Forms.SaveFileDialog SaveFileDialog1;
    private System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
    private System.Windows.Forms.ToolStripButton ToolStripButtonCompile;
    private System.Windows.Forms.ToolStripButton ToolStripButtonStart;
    private System.Windows.Forms.ToolStripButton ToolStripButtonStop;
    private System.Windows.Forms.ToolStripButton ToolStripStepForward;
    private System.Windows.Forms.ToolStripButton ToolStripButtonStepOut;
    private System.Windows.Forms.SplitContainer SplitContainer1;
    private LongTech.UI.Controls.MemoryView MemoryView1;
    private System.Windows.Forms.SplitContainer SplitContainer2;
    private TextBox TextBoxOutput;
    private System.Windows.Forms.ToolStripProgressBar ToolStripProgressBar1;
    private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1;
    private System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;
    private System.Windows.Forms.ToolStripLabel ToolStripLabel1;
    private System.Windows.Forms.ToolStripTextBox ToolStripTextBoxMemorySize;
    private System.Windows.Forms.ToolStripLabel ToolStripLabel2;
    private LongTech.UI.Controls.DebuggingControl TextBoxCode;
  }
}