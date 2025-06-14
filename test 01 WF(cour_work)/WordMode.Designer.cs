namespace test_01_WF_cour_work_
{
  partial class WordModeForm
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
      this.answerLine = new System.Windows.Forms.TextBox();
      this.wordToTranslate = new System.Windows.Forms.Label();
      this.checkAnswer = new System.Windows.Forms.Button();
      this.TOfWord = new System.Windows.Forms.Label();
      this.transcription = new System.Windows.Forms.Label();
      this.tipFlashCard = new System.Windows.Forms.Label();
      this.wordModePanel = new System.Windows.Forms.Panel();
      this.wordModePanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // answerLine
      // 
      this.answerLine.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.answerLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(153)))), ((int)(((byte)(134)))));
      this.answerLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.answerLine.Location = new System.Drawing.Point(504, 230);
      this.answerLine.Margin = new System.Windows.Forms.Padding(4);
      this.answerLine.Name = "answerLine";
      this.answerLine.Size = new System.Drawing.Size(140, 22);
      this.answerLine.TabIndex = 2;
      // 
      // wordToTranslate
      // 
      this.wordToTranslate.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.wordToTranslate.AutoSize = true;
      this.wordToTranslate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(153)))), ((int)(((byte)(134)))));
      this.wordToTranslate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.wordToTranslate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.wordToTranslate.Location = new System.Drawing.Point(209, 232);
      this.wordToTranslate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.wordToTranslate.Name = "wordToTranslate";
      this.wordToTranslate.Size = new System.Drawing.Size(2, 19);
      this.wordToTranslate.TabIndex = 1;
      // 
      // checkAnswer
      // 
      this.checkAnswer.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.checkAnswer.AutoSize = true;
      this.checkAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(153)))), ((int)(((byte)(134)))));
      this.checkAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.checkAnswer.Location = new System.Drawing.Point(340, 340);
      this.checkAnswer.Margin = new System.Windows.Forms.Padding(4);
      this.checkAnswer.Name = "checkAnswer";
      this.checkAnswer.Padding = new System.Windows.Forms.Padding(2);
      this.checkAnswer.Size = new System.Drawing.Size(120, 50);
      this.checkAnswer.TabIndex = 0;
      this.checkAnswer.Text = "Check";
      this.checkAnswer.UseVisualStyleBackColor = false;
      this.checkAnswer.Click += new System.EventHandler(this.Check_Click);
      // 
      // TOfWord
      // 
      this.TOfWord.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.TOfWord.AutoSize = true;
      this.TOfWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.TOfWord.Location = new System.Drawing.Point(209, 267);
      this.TOfWord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.TOfWord.Name = "TOfWord";
      this.TOfWord.Size = new System.Drawing.Size(0, 17);
      this.TOfWord.TabIndex = 4;
      // 
      // transcription
      // 
      this.transcription.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.transcription.AutoSize = true;
      this.transcription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.transcription.Location = new System.Drawing.Point(99, 267);
      this.transcription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.transcription.Name = "transcription";
      this.transcription.Size = new System.Drawing.Size(98, 17);
      this.transcription.TabIndex = 6;
      this.transcription.Text = "Transcription:";
      // 
      // tipFlashCard
      // 
      this.tipFlashCard.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.tipFlashCard.AutoSize = true;
      this.tipFlashCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.tipFlashCard.Location = new System.Drawing.Point(305, 157);
      this.tipFlashCard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.tipFlashCard.Name = "tipFlashCard";
      this.tipFlashCard.Size = new System.Drawing.Size(0, 17);
      this.tipFlashCard.TabIndex = 7;
      this.tipFlashCard.Visible = false;
      // 
      // wordModePanel
      // 
      this.wordModePanel.AutoSize = true;
      this.wordModePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(115)))), ((int)(((byte)(101)))));
      this.wordModePanel.Controls.Add(this.answerLine);
      this.wordModePanel.Controls.Add(this.tipFlashCard);
      this.wordModePanel.Controls.Add(this.wordToTranslate);
      this.wordModePanel.Controls.Add(this.checkAnswer);
      this.wordModePanel.Controls.Add(this.transcription);
      this.wordModePanel.Controls.Add(this.TOfWord);
      this.wordModePanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.wordModePanel.Location = new System.Drawing.Point(0, 0);
      this.wordModePanel.Name = "wordModePanel";
      this.wordModePanel.Size = new System.Drawing.Size(800, 500);
      this.wordModePanel.TabIndex = 8;
      // 
      // WordModeForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.ClientSize = new System.Drawing.Size(800, 500);
      this.Controls.Add(this.wordModePanel);
      this.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "WordModeForm";
      this.Text = "WordMode";
      this.wordModePanel.ResumeLayout(false);
      this.wordModePanel.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox answerLine;
    private System.Windows.Forms.Label wordToTranslate;
    private System.Windows.Forms.Button checkAnswer;
    private System.Windows.Forms.Label TOfWord;
    private System.Windows.Forms.Label transcription;
    private System.Windows.Forms.Label tipFlashCard;
    private System.Windows.Forms.Panel wordModePanel;
  }
}