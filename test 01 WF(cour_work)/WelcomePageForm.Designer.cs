namespace test_01_WF_cour_work_
{
  partial class WelcomePageForm
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
      this.WelcomeTitle = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // WelcomeTitle
      // 
      this.WelcomeTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.WelcomeTitle.BackColor = System.Drawing.Color.Transparent;
      this.WelcomeTitle.Font = new System.Drawing.Font("Ubuntu", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.WelcomeTitle.ForeColor = System.Drawing.Color.Green;
      this.WelcomeTitle.Location = new System.Drawing.Point(370, 220);
      this.WelcomeTitle.Name = "WelcomeTitle";
      this.WelcomeTitle.Padding = new System.Windows.Forms.Padding(2);
      this.WelcomeTitle.Size = new System.Drawing.Size(320, 90);
      this.WelcomeTitle.TabIndex = 1;
      this.WelcomeTitle.Text = "Welcome";
      this.WelcomeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // WelcomePageForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(44)))));
      this.BackgroundImage = global::test_01_WF_cour_work_.Properties.Resources.wallpapersden_com_windows_11_4k_green_glow_3840x2400;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(1060, 600);
      this.Controls.Add(this.WelcomeTitle);
      this.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "WelcomePageForm";
      this.Text = "WelcomePageForm";
      this.ResumeLayout(false);

    }

    #endregion

    public System.Windows.Forms.Label WelcomeTitle;
  }
}