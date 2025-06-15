namespace test_01_WF_cour_work_
{
  partial class SentenceModeForm
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
      this.OriginSentence = new System.Windows.Forms.Label();
      this.TranslateSentence = new System.Windows.Forms.Label();
      this.CheckSentence = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // OriginSentence
      // 
      this.OriginSentence.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.OriginSentence.AutoSize = true;
      this.OriginSentence.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.OriginSentence.ForeColor = System.Drawing.SystemColors.Control;
      this.OriginSentence.Location = new System.Drawing.Point(428, 197);
      this.OriginSentence.Name = "OriginSentence";
      this.OriginSentence.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.OriginSentence.Size = new System.Drawing.Size(4, 27);
      this.OriginSentence.TabIndex = 0;
      // 
      // TranslateSentence
      // 
      this.TranslateSentence.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.TranslateSentence.AutoSize = true;
      this.TranslateSentence.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.TranslateSentence.ForeColor = System.Drawing.SystemColors.Control;
      this.TranslateSentence.Location = new System.Drawing.Point(428, 260);
      this.TranslateSentence.Name = "TranslateSentence";
      this.TranslateSentence.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.TranslateSentence.Size = new System.Drawing.Size(4, 27);
      this.TranslateSentence.TabIndex = 1;
      // 
      // CheckSentence
      // 
      this.CheckSentence.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.CheckSentence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(69)))));
      this.CheckSentence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.CheckSentence.ForeColor = System.Drawing.SystemColors.Control;
      this.CheckSentence.Location = new System.Drawing.Point(546, 444);
      this.CheckSentence.Name = "CheckSentence";
      this.CheckSentence.Size = new System.Drawing.Size(101, 55);
      this.CheckSentence.TabIndex = 2;
      this.CheckSentence.Text = "Check";
      this.CheckSentence.UseVisualStyleBackColor = false;
      this.CheckSentence.Click += new System.EventHandler(this.CheckSentence_Click);
      this.CheckSentence.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
      this.CheckSentence.MouseHover += new System.EventHandler(this.Button_MouseHover);
      // 
      // SentenceModeForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(69)))));
      this.ClientSize = new System.Drawing.Size(1192, 741);
      this.Controls.Add(this.CheckSentence);
      this.Controls.Add(this.TranslateSentence);
      this.Controls.Add(this.OriginSentence);
      this.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "SentenceModeForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "SenatanceModeForm";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label OriginSentence;
    private System.Windows.Forms.Label TranslateSentence;
    private System.Windows.Forms.Button CheckSentence;
  }
}