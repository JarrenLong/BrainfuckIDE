namespace LongTech.BrainFuckIDE
{
  partial class MemoryView2
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemoryView2));
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.ToolStripButtonFirst = new System.Windows.Forms.ToolStripButton();
      this.ToolStripButtonBack = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripLabelPage = new System.Windows.Forms.ToolStripLabel();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.ToolStripButtonNext = new System.Windows.Forms.ToolStripButton();
      this.ToolStripButtonLast = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
      this.aSCIIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.hexadecimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.decimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.octalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // toolStrip1
      // 
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButtonFirst,
            this.ToolStripButtonBack,
            this.toolStripSeparator1,
            this.toolStripLabelPage,
            this.toolStripSeparator2,
            this.ToolStripButtonNext,
            this.ToolStripButtonLast,
            this.toolStripSeparator3,
            this.toolStripDropDownButton1});
      this.toolStrip1.Location = new System.Drawing.Point(0, 0);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(256, 25);
      this.toolStrip1.TabIndex = 1;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // ToolStripButtonFirst
      // 
      this.ToolStripButtonFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.ToolStripButtonFirst.Image = global::LongTech.BrainFuckIDE.Properties.Resources.media_skip_backward;
      this.ToolStripButtonFirst.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.ToolStripButtonFirst.Name = "ToolStripButtonFirst";
      this.ToolStripButtonFirst.Size = new System.Drawing.Size(23, 22);
      this.ToolStripButtonFirst.Text = "toolStripButton1";
      this.ToolStripButtonFirst.Click += new System.EventHandler(this.ToolStripButtonFirst_Click);
      // 
      // ToolStripButtonBack
      // 
      this.ToolStripButtonBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.ToolStripButtonBack.Image = global::LongTech.BrainFuckIDE.Properties.Resources.media_seek_backward;
      this.ToolStripButtonBack.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.ToolStripButtonBack.Name = "ToolStripButtonBack";
      this.ToolStripButtonBack.Size = new System.Drawing.Size(23, 22);
      this.ToolStripButtonBack.Text = "toolStripButton2";
      this.ToolStripButtonBack.Click += new System.EventHandler(this.ToolStripButtonBack_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
      // 
      // toolStripLabelPage
      // 
      this.toolStripLabelPage.Name = "toolStripLabelPage";
      this.toolStripLabelPage.Size = new System.Drawing.Size(77, 22);
      this.toolStripLabelPage.Text = "Page 00 of 99";
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
      // 
      // ToolStripButtonNext
      // 
      this.ToolStripButtonNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.ToolStripButtonNext.Image = global::LongTech.BrainFuckIDE.Properties.Resources.media_seek_forward;
      this.ToolStripButtonNext.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.ToolStripButtonNext.Name = "ToolStripButtonNext";
      this.ToolStripButtonNext.Size = new System.Drawing.Size(23, 22);
      this.ToolStripButtonNext.Text = "toolStripButton3";
      this.ToolStripButtonNext.Click += new System.EventHandler(this.ToolStripButtonNext_Click);
      // 
      // ToolStripButtonLast
      // 
      this.ToolStripButtonLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.ToolStripButtonLast.Image = global::LongTech.BrainFuckIDE.Properties.Resources.media_skip_forward;
      this.ToolStripButtonLast.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.ToolStripButtonLast.Name = "ToolStripButtonLast";
      this.ToolStripButtonLast.Size = new System.Drawing.Size(23, 22);
      this.ToolStripButtonLast.Text = "toolStripButton4";
      this.ToolStripButtonLast.Click += new System.EventHandler(this.ToolStripButtonLast_Click);
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
      // 
      // toolStripDropDownButton1
      // 
      this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aSCIIToolStripMenuItem,
            this.hexadecimalToolStripMenuItem,
            this.decimalToolStripMenuItem,
            this.octalToolStripMenuItem});
      this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
      this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
      this.toolStripDropDownButton1.Size = new System.Drawing.Size(92, 19);
      this.toolStripDropDownButton1.Text = "Display Mode";
      // 
      // aSCIIToolStripMenuItem
      // 
      this.aSCIIToolStripMenuItem.Name = "aSCIIToolStripMenuItem";
      this.aSCIIToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.aSCIIToolStripMenuItem.Text = "ASCII";
      this.aSCIIToolStripMenuItem.Click += new System.EventHandler(this.aSCIIToolStripMenuItem_Click);
      // 
      // hexadecimalToolStripMenuItem
      // 
      this.hexadecimalToolStripMenuItem.Name = "hexadecimalToolStripMenuItem";
      this.hexadecimalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.hexadecimalToolStripMenuItem.Text = "Hexadecimal";
      this.hexadecimalToolStripMenuItem.Click += new System.EventHandler(this.hexadecimalToolStripMenuItem_Click);
      // 
      // decimalToolStripMenuItem
      // 
      this.decimalToolStripMenuItem.Name = "decimalToolStripMenuItem";
      this.decimalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.decimalToolStripMenuItem.Text = "Decimal";
      this.decimalToolStripMenuItem.Click += new System.EventHandler(this.decimalToolStripMenuItem_Click);
      // 
      // octalToolStripMenuItem
      // 
      this.octalToolStripMenuItem.Name = "octalToolStripMenuItem";
      this.octalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.octalToolStripMenuItem.Text = "Octal";
      this.octalToolStripMenuItem.Click += new System.EventHandler(this.octalToolStripMenuItem_Click);
      // 
      // MemoryView2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.toolStrip1);
      this.Name = "MemoryView2";
      this.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintView);
      this.Size = new System.Drawing.Size(256, 287);
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripButton ToolStripButtonFirst;
    private System.Windows.Forms.ToolStripButton ToolStripButtonBack;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripLabel toolStripLabelPage;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripButton ToolStripButtonNext;
    private System.Windows.Forms.ToolStripButton ToolStripButtonLast;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
    private System.Windows.Forms.ToolStripMenuItem aSCIIToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem hexadecimalToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem decimalToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem octalToolStripMenuItem;
  }
}
