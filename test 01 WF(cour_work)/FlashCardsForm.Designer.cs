namespace test_01_WF_cour_work_
{
  partial class FlashCardsForm
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
      this.WordOrig = new System.Windows.Forms.Label();
      this.TranslateWord = new System.Windows.Forms.Label();
      this.CloseWin = new System.Windows.Forms.Button();
      this.ShowMore = new System.Windows.Forms.Button();
      this.Space = new System.Windows.Forms.Label();
      this.SearchPannel = new System.Windows.Forms.TextBox();
      this.ResOfSearch = new System.Windows.Forms.Label();
      this.Search = new System.Windows.Forms.Button();
      this.TipForYou = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // WordOrig
      // 
      this.WordOrig.AutoSize = true;
      this.WordOrig.Location = new System.Drawing.Point(150, 180);
      this.WordOrig.Name = "WordOrig";
      this.WordOrig.Size = new System.Drawing.Size(0, 13);
      this.WordOrig.TabIndex = 0;
      // 
      // TranslateWord
      // 
      this.TranslateWord.AutoSize = true;
      this.TranslateWord.Location = new System.Drawing.Point(275, 180);
      this.TranslateWord.Name = "TranslateWord";
      this.TranslateWord.Size = new System.Drawing.Size(0, 13);
      this.TranslateWord.TabIndex = 1;
      // 
      // CloseWin
      // 
      this.CloseWin.Location = new System.Drawing.Point(150, 200);
      this.CloseWin.Name = "CloseWin";
      this.CloseWin.Size = new System.Drawing.Size(75, 25);
      this.CloseWin.TabIndex = 2;
      this.CloseWin.Text = "Close";
      this.CloseWin.UseVisualStyleBackColor = true;
      this.CloseWin.Click += new System.EventHandler(this.CloseWin_Click);
      // 
      // ShowMore
      // 
      this.ShowMore.Location = new System.Drawing.Point(275, 200);
      this.ShowMore.Name = "ShowMore";
      this.ShowMore.Size = new System.Drawing.Size(75, 25);
      this.ShowMore.TabIndex = 3;
      this.ShowMore.Text = "Show more";
      this.ShowMore.UseVisualStyleBackColor = true;
      this.ShowMore.Click += new System.EventHandler(this.ShowMoreFC_Click);
      // 
      // Space
      // 
      this.Space.AutoSize = true;
      this.Space.Location = new System.Drawing.Point(235, 180);
      this.Space.Name = "Space";
      this.Space.Size = new System.Drawing.Size(31, 13);
      this.Space.TabIndex = 4;
      this.Space.Text = "--------";
      // 
      // SearchPannel
      // 
      this.SearchPannel.Location = new System.Drawing.Point(1, 1);
      this.SearchPannel.Name = "SearchPannel";
      this.SearchPannel.Size = new System.Drawing.Size(100, 20);
      this.SearchPannel.TabIndex = 5;
      this.SearchPannel.Visible = false;
      // 
      // ResOfSearch
      // 
      this.ResOfSearch.AutoSize = true;
      this.ResOfSearch.Dock = System.Windows.Forms.DockStyle.Right;
      this.ResOfSearch.Location = new System.Drawing.Point(494, 0);
      this.ResOfSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.ResOfSearch.MaximumSize = new System.Drawing.Size(150, 400);
      this.ResOfSearch.Name = "ResOfSearch";
      this.ResOfSearch.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
      this.ResOfSearch.Size = new System.Drawing.Size(6, 23);
      this.ResOfSearch.TabIndex = 6;
      this.ResOfSearch.Visible = false;
      // 
      // Search
      // 
      this.Search.Location = new System.Drawing.Point(1, 25);
      this.Search.Name = "Search";
      this.Search.Size = new System.Drawing.Size(75, 25);
      this.Search.TabIndex = 7;
      this.Search.Text = "Search";
      this.Search.UseVisualStyleBackColor = true;
      this.Search.Visible = false;
      this.Search.Click += new System.EventHandler(this.SearchWords_Click);
      // 
      // TipForYou
      // 
      this.TipForYou.AutoSize = true;
      this.TipForYou.Location = new System.Drawing.Point(220, 153);
      this.TipForYou.Name = "TipForYou";
      this.TipForYou.Size = new System.Drawing.Size(65, 13);
      this.TipForYou.TabIndex = 8;
      this.TipForYou.Text = "Your word is";
      // 
      // FlashCardsForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(500, 400);
      this.Controls.Add(this.TipForYou);
      this.Controls.Add(this.Search);
      this.Controls.Add(this.ResOfSearch);
      this.Controls.Add(this.SearchPannel);
      this.Controls.Add(this.Space);
      this.Controls.Add(this.ShowMore);
      this.Controls.Add(this.CloseWin);
      this.Controls.Add(this.TranslateWord);
      this.Controls.Add(this.WordOrig);
      this.Name = "FlashCardsForm";
      this.Text = "FlashCardsForm";
      this.Load += new System.EventHandler(this.FlashCardsForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label WordOrig;
    private System.Windows.Forms.Label TranslateWord;
    private System.Windows.Forms.Button CloseWin;
    private System.Windows.Forms.Button ShowMore;
    private System.Windows.Forms.TextBox SearchPannel;
    internal System.Windows.Forms.Label Space;
    public System.Windows.Forms.Label ResOfSearch;
    private System.Windows.Forms.Button Search;
    internal System.Windows.Forms.Label TipForYou;
  }
}