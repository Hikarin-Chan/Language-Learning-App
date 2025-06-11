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
      this.rightArrow = new FontAwesome.Sharp.IconPictureBox();
      this.flashCardOrig = new System.Windows.Forms.Button();
      this.flashTranslate = new System.Windows.Forms.Button();
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
      this.flashCardPanel.Padding = new System.Windows.Forms.Padding(15, 16, 15, 16);
      this.flashCardPanel.Size = new System.Drawing.Size(1200, 808);
      this.flashCardPanel.TabIndex = 9;
      // 
      // rightArrow
      // 
      this.rightArrow.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.rightArrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(153)))), ((int)(((byte)(134)))));
      this.rightArrow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
      this.rightArrow.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
      this.rightArrow.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
      this.rightArrow.IconFont = FontAwesome.Sharp.IconFont.Solid;
      this.rightArrow.IconSize = 60;
      this.rightArrow.Location = new System.Drawing.Point(570, 372);
      this.rightArrow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.rightArrow.Name = "rightArrow";
      this.rightArrow.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
      this.rightArrow.Size = new System.Drawing.Size(60, 65);
      this.rightArrow.TabIndex = 12;
      this.rightArrow.TabStop = false;
      // 
      // flashCardOrig
      // 
      this.flashCardOrig.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.flashCardOrig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(115)))), ((int)(((byte)(101)))));
      this.flashCardOrig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.flashCardOrig.Location = new System.Drawing.Point(248, 194);
      this.flashCardOrig.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.flashCardOrig.Name = "flashCardOrig";
      this.flashCardOrig.Size = new System.Drawing.Size(262, 420);
      this.flashCardOrig.TabIndex = 11;
      this.flashCardOrig.UseVisualStyleBackColor = false;
      // 
      // flashTranslate
      // 
      this.flashTranslate.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.flashTranslate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(115)))), ((int)(((byte)(101)))));
      this.flashTranslate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.flashTranslate.Location = new System.Drawing.Point(690, 194);
      this.flashTranslate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.flashTranslate.Name = "flashTranslate";
      this.flashTranslate.Size = new System.Drawing.Size(262, 420);
      this.flashTranslate.TabIndex = 10;
      this.flashTranslate.UseVisualStyleBackColor = false;
      this.flashTranslate.Click += new System.EventHandler(this.flashTranslate_Click);
      // 
      // flashCardsForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.ClientSize = new System.Drawing.Size(1200, 808);
      this.Controls.Add(this.flashCardPanel);
      this.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.ForeColor = System.Drawing.SystemColors.Control;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "flashCardsForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "FlashCardsForm";
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