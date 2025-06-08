namespace test_01_WF_cour_work_
{
  partial class Form1
  {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.Check = new System.Windows.Forms.Button();
      this.EWord = new System.Windows.Forms.Label();
      this.AnswerLine = new System.Windows.Forms.TextBox();
      this.Next = new System.Windows.Forms.Button();
      this.TOfWord = new System.Windows.Forms.Label();
      this.EnglishWord = new System.Windows.Forms.Label();
      this.Transcription = new System.Windows.Forms.Label();
      this.Tip = new System.Windows.Forms.Label();
      this.Flashcards = new System.Windows.Forms.Button();
      this.Exit = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // Check
      // 
      this.Check.Location = new System.Drawing.Point(492, 399);
      this.Check.Name = "Check";
      this.Check.Size = new System.Drawing.Size(75, 23);
      this.Check.TabIndex = 0;
      this.Check.Text = "Check";
      this.Check.UseVisualStyleBackColor = true;
      this.Check.Click += new System.EventHandler(this.Check_Click);
      // 
      // EWord
      // 
      this.EWord.AutoSize = true;
      this.EWord.Location = new System.Drawing.Point(509, 338);
      this.EWord.Name = "EWord";
      this.EWord.Size = new System.Drawing.Size(0, 13);
      this.EWord.TabIndex = 1;
      // 
      // AnswerLine
      // 
      this.AnswerLine.Location = new System.Drawing.Point(644, 331);
      this.AnswerLine.Name = "AnswerLine";
      this.AnswerLine.Size = new System.Drawing.Size(100, 20);
      this.AnswerLine.TabIndex = 2;
      // 
      // Next
      // 
      this.Next.Location = new System.Drawing.Point(658, 399);
      this.Next.Name = "Next";
      this.Next.Size = new System.Drawing.Size(75, 23);
      this.Next.TabIndex = 3;
      this.Next.Text = "Next";
      this.Next.UseVisualStyleBackColor = true;
      this.Next.Click += new System.EventHandler(this.Next_Click);
      // 
      // TOfWord
      // 
      this.TOfWord.AutoSize = true;
      this.TOfWord.Location = new System.Drawing.Point(509, 365);
      this.TOfWord.Name = "TOfWord";
      this.TOfWord.Size = new System.Drawing.Size(0, 13);
      this.TOfWord.TabIndex = 4;
      // 
      // EnglishWord
      // 
      this.EnglishWord.AutoSize = true;
      this.EnglishWord.Location = new System.Drawing.Point(426, 331);
      this.EnglishWord.Name = "EnglishWord";
      this.EnglishWord.Size = new System.Drawing.Size(67, 13);
      this.EnglishWord.TabIndex = 5;
      this.EnglishWord.Text = "English word";
      // 
      // Transcription
      // 
      this.Transcription.AutoSize = true;
      this.Transcription.Location = new System.Drawing.Point(425, 365);
      this.Transcription.Name = "Transcription";
      this.Transcription.Size = new System.Drawing.Size(68, 13);
      this.Transcription.TabIndex = 6;
      this.Transcription.Text = "Transcription";
      // 
      // Tip
      // 
      this.Tip.AutoSize = true;
      this.Tip.Location = new System.Drawing.Point(426, 304);
      this.Tip.Name = "Tip";
      this.Tip.Size = new System.Drawing.Size(0, 13);
      this.Tip.TabIndex = 7;
      // 
      // Flashcards
      // 
      this.Flashcards.Location = new System.Drawing.Point(12, 12);
      this.Flashcards.Name = "Flashcards";
      this.Flashcards.Size = new System.Drawing.Size(75, 23);
      this.Flashcards.TabIndex = 8;
      this.Flashcards.Text = "Flashcards";
      this.Flashcards.UseVisualStyleBackColor = true;
      this.Flashcards.Click += new System.EventHandler(this.Flashcards_Click);
      // 
      // Exit
      // 
      this.Exit.AutoSize = true;
      this.Exit.Location = new System.Drawing.Point(575, 399);
      this.Exit.Name = "Exit";
      this.Exit.Size = new System.Drawing.Size(75, 23);
      this.Exit.TabIndex = 9;
      this.Exit.Text = "Exit";
      this.Exit.UseVisualStyleBackColor = true;
      this.Exit.Click += new System.EventHandler(this.Exit_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.ClientSize = new System.Drawing.Size(1269, 681);
      this.Controls.Add(this.Exit);
      this.Controls.Add(this.Flashcards);
      this.Controls.Add(this.Tip);
      this.Controls.Add(this.Transcription);
      this.Controls.Add(this.EnglishWord);
      this.Controls.Add(this.TOfWord);
      this.Controls.Add(this.Next);
      this.Controls.Add(this.AnswerLine);
      this.Controls.Add(this.EWord);
      this.Controls.Add(this.Check);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button Check;
    private System.Windows.Forms.Label EWord;
    private System.Windows.Forms.TextBox AnswerLine;
    private System.Windows.Forms.Button Next;
    private System.Windows.Forms.Label TOfWord;
    private System.Windows.Forms.Label EnglishWord;
    private System.Windows.Forms.Label Transcription;
    private System.Windows.Forms.Label Tip;
    private System.Windows.Forms.Button Flashcards;
    private System.Windows.Forms.Button Exit;
  }
}

