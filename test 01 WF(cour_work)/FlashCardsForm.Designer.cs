namespace test_01_WF_cour_work_
{
  partial class flashCardsForm
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
      this.flashCardPanel = new System.Windows.Forms.Panel();
      this.flashCardOrig = new System.Windows.Forms.Button();
      this.flashTranslate = new System.Windows.Forms.Button();
      this.rightArrow = new FontAwesome.Sharp.IconPictureBox();
      this.flashCardPanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.rightArrow)).BeginInit();
      this.SuspendLayout();
      // 
      // flashCardPanel
      // 
      this.flashCardPanel.AutoSize = true;
      this.flashCardPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(153)))), ((int)(((byte)(134)))));
      this.flashCardPanel.Controls.Add(this.rightArrow);
      this.flashCardPanel.Controls.Add(this.flashCardOrig);
      this.flashCardPanel.Controls.Add(this.flashTranslate);
      this.flashCardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.flashCardPanel.Location = new System.Drawing.Point(0, 0);
      this.flashCardPanel.Margin = new System.Windows.Forms.Padding(0);
      this.flashCardPanel.Name = "flashCardPanel";
      this.flashCardPanel.Padding = new System.Windows.Forms.Padding(10);
      this.flashCardPanel.Size = new System.Drawing.Size(800, 500);
      this.flashCardPanel.TabIndex = 9;
      // 
      // flashCardOrig
      // 
      this.flashCardOrig.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.flashCardOrig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(115)))), ((int)(((byte)(101)))));
      this.flashCardOrig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.flashCardOrig.Location = new System.Drawing.Point(165, 120);
      this.flashCardOrig.Name = "flashCardOrig";
      this.flashCardOrig.Size = new System.Drawing.Size(175, 260);
      this.flashCardOrig.TabIndex = 11;
      this.flashCardOrig.UseVisualStyleBackColor = false;
      // 
      // flashTranslate
      // 
      this.flashTranslate.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.flashTranslate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(115)))), ((int)(((byte)(101)))));
      this.flashTranslate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.flashTranslate.Location = new System.Drawing.Point(460, 120);
      this.flashTranslate.Name = "flashTranslate";
      this.flashTranslate.Size = new System.Drawing.Size(175, 260);
      this.flashTranslate.TabIndex = 10;
      this.flashTranslate.UseVisualStyleBackColor = false;
      this.flashTranslate.Click += new System.EventHandler(this.button1_Click);
      // 
      // rightArrow
      // 
      this.rightArrow.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.rightArrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(153)))), ((int)(((byte)(134)))));
      this.rightArrow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
      this.rightArrow.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
      this.rightArrow.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
      this.rightArrow.IconFont = FontAwesome.Sharp.IconFont.Solid;
      this.rightArrow.IconSize = 40;
      this.rightArrow.Location = new System.Drawing.Point(380, 230);
      this.rightArrow.Name = "rightArrow";
      this.rightArrow.Padding = new System.Windows.Forms.Padding(2);
      this.rightArrow.Size = new System.Drawing.Size(40, 40);
      this.rightArrow.TabIndex = 12;
      this.rightArrow.TabStop = false;
      // 
      // flashCardsForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.ClientSize = new System.Drawing.Size(800, 500);
      this.Controls.Add(this.flashCardPanel);
      this.ForeColor = System.Drawing.SystemColors.Control;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "flashCardsForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "FlashCardsForm";
      this.Load += new System.EventHandler(this.FlashCardsForm_Load);
      this.flashCardPanel.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.rightArrow)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Panel flashCardPanel;
    private System.Windows.Forms.Button flashTranslate;
    private System.Windows.Forms.Button flashCardOrig;
    private FontAwesome.Sharp.IconPictureBox rightArrow;
  }
}