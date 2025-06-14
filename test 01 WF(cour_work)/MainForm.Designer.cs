namespace test_01_WF_cour_work_
{
  partial class MainForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.LeftMenu = new System.Windows.Forms.Panel();
      this.HomePage = new FontAwesome.Sharp.IconButton();
      this.SentanceMode = new FontAwesome.Sharp.IconButton();
      this.WordMode = new FontAwesome.Sharp.IconButton();
      this.Flashcards = new FontAwesome.Sharp.IconButton();
      this.HideMenu = new System.Windows.Forms.Panel();
      this.Menu = new FontAwesome.Sharp.IconButton();
      this.TopScreenPanel = new System.Windows.Forms.Panel();
      this.Exit = new FontAwesome.Sharp.IconButton();
      this.ScreenMinimize = new FontAwesome.Sharp.IconButton();
      this.ScreenMaximize = new FontAwesome.Sharp.IconButton();
      this.mainDesktopPanel = new System.Windows.Forms.Panel();
      this.LeftMenu.SuspendLayout();
      this.HideMenu.SuspendLayout();
      this.TopScreenPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // LeftMenu
      // 
      this.LeftMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(44)))));
      this.LeftMenu.Controls.Add(this.HomePage);
      this.LeftMenu.Controls.Add(this.SentanceMode);
      this.LeftMenu.Controls.Add(this.WordMode);
      this.LeftMenu.Controls.Add(this.Flashcards);
      this.LeftMenu.Controls.Add(this.HideMenu);
      this.LeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
      this.LeftMenu.Location = new System.Drawing.Point(2, 2);
      this.LeftMenu.Name = "LeftMenu";
      this.LeftMenu.Size = new System.Drawing.Size(200, 696);
      this.LeftMenu.TabIndex = 10;
      // 
      // HomePage
      // 
      this.HomePage.Dock = System.Windows.Forms.DockStyle.Top;
      this.HomePage.FlatAppearance.BorderSize = 0;
      this.HomePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.HomePage.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.HomePage.ForeColor = System.Drawing.SystemColors.Control;
      this.HomePage.IconChar = FontAwesome.Sharp.IconChar.House;
      this.HomePage.IconColor = System.Drawing.SystemColors.Control;
      this.HomePage.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.HomePage.IconSize = 40;
      this.HomePage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.HomePage.Location = new System.Drawing.Point(0, 203);
      this.HomePage.Name = "HomePage";
      this.HomePage.Padding = new System.Windows.Forms.Padding(10, 2, 3, 3);
      this.HomePage.Size = new System.Drawing.Size(200, 50);
      this.HomePage.TabIndex = 15;
      this.HomePage.Text = "Home";
      this.HomePage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.HomePage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.HomePage.UseVisualStyleBackColor = true;
      this.HomePage.Click += new System.EventHandler(this.HomePage_Click);
      // 
      // SentanceMode
      // 
      this.SentanceMode.AutoSize = true;
      this.SentanceMode.Dock = System.Windows.Forms.DockStyle.Top;
      this.SentanceMode.FlatAppearance.BorderSize = 0;
      this.SentanceMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.SentanceMode.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.SentanceMode.ForeColor = System.Drawing.SystemColors.Control;
      this.SentanceMode.IconChar = FontAwesome.Sharp.IconChar.AlignLeft;
      this.SentanceMode.IconColor = System.Drawing.SystemColors.Control;
      this.SentanceMode.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.SentanceMode.IconSize = 40;
      this.SentanceMode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.SentanceMode.Location = new System.Drawing.Point(0, 152);
      this.SentanceMode.Name = "SentanceMode";
      this.SentanceMode.Padding = new System.Windows.Forms.Padding(10, 2, 3, 3);
      this.SentanceMode.Size = new System.Drawing.Size(200, 51);
      this.SentanceMode.TabIndex = 14;
      this.SentanceMode.Text = "Sentance Mode";
      this.SentanceMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.SentanceMode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.SentanceMode.UseVisualStyleBackColor = true;
      this.SentanceMode.Click += new System.EventHandler(this.SentanceMode_Click);
      // 
      // WordMode
      // 
      this.WordMode.AutoSize = true;
      this.WordMode.Dock = System.Windows.Forms.DockStyle.Top;
      this.WordMode.FlatAppearance.BorderSize = 0;
      this.WordMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.WordMode.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.WordMode.ForeColor = System.Drawing.SystemColors.Control;
      this.WordMode.IconChar = FontAwesome.Sharp.IconChar.VoteYea;
      this.WordMode.IconColor = System.Drawing.SystemColors.Control;
      this.WordMode.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.WordMode.IconSize = 40;
      this.WordMode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.WordMode.Location = new System.Drawing.Point(0, 101);
      this.WordMode.Name = "WordMode";
      this.WordMode.Padding = new System.Windows.Forms.Padding(10, 2, 3, 3);
      this.WordMode.Size = new System.Drawing.Size(200, 51);
      this.WordMode.TabIndex = 13;
      this.WordMode.Text = "Words Mode";
      this.WordMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.WordMode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.WordMode.UseVisualStyleBackColor = true;
      this.WordMode.Click += new System.EventHandler(this.WordMode_Click);
      // 
      // Flashcards
      // 
      this.Flashcards.AutoSize = true;
      this.Flashcards.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.Flashcards.Dock = System.Windows.Forms.DockStyle.Top;
      this.Flashcards.FlatAppearance.BorderSize = 0;
      this.Flashcards.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.Flashcards.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Flashcards.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.Flashcards.IconChar = FontAwesome.Sharp.IconChar.Language;
      this.Flashcards.IconColor = System.Drawing.SystemColors.Control;
      this.Flashcards.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.Flashcards.IconSize = 40;
      this.Flashcards.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.Flashcards.Location = new System.Drawing.Point(0, 50);
      this.Flashcards.Name = "Flashcards";
      this.Flashcards.Padding = new System.Windows.Forms.Padding(10, 2, 3, 3);
      this.Flashcards.Size = new System.Drawing.Size(200, 51);
      this.Flashcards.TabIndex = 12;
      this.Flashcards.Text = "Flashcards";
      this.Flashcards.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.Flashcards.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.Flashcards.UseVisualStyleBackColor = true;
      this.Flashcards.Click += new System.EventHandler(this.Flashcards_Click);
      // 
      // HideMenu
      // 
      this.HideMenu.Controls.Add(this.Menu);
      this.HideMenu.Dock = System.Windows.Forms.DockStyle.Top;
      this.HideMenu.Location = new System.Drawing.Point(0, 0);
      this.HideMenu.Name = "HideMenu";
      this.HideMenu.Size = new System.Drawing.Size(200, 50);
      this.HideMenu.TabIndex = 11;
      // 
      // Menu
      // 
      this.Menu.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.Menu.BackgroundImage = global::test_01_WF_cour_work_.Properties.Resources._8665130_bars_data_icon;
      this.Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.Menu.Cursor = System.Windows.Forms.Cursors.Arrow;
      this.Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.Menu.IconChar = FontAwesome.Sharp.IconChar.None;
      this.Menu.IconColor = System.Drawing.Color.Black;
      this.Menu.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.Menu.Location = new System.Drawing.Point(13, 13);
      this.Menu.Name = "Menu";
      this.Menu.Size = new System.Drawing.Size(25, 25);
      this.Menu.TabIndex = 0;
      this.Menu.UseVisualStyleBackColor = true;
      // 
      // TopScreenPanel
      // 
      this.TopScreenPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(44)))));
      this.TopScreenPanel.Controls.Add(this.Exit);
      this.TopScreenPanel.Controls.Add(this.ScreenMinimize);
      this.TopScreenPanel.Controls.Add(this.ScreenMaximize);
      this.TopScreenPanel.Dock = System.Windows.Forms.DockStyle.Top;
      this.TopScreenPanel.Location = new System.Drawing.Point(202, 2);
      this.TopScreenPanel.Name = "TopScreenPanel";
      this.TopScreenPanel.Size = new System.Drawing.Size(1096, 50);
      this.TopScreenPanel.TabIndex = 11;
      this.TopScreenPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopScreenPanel_MouseDown);
      // 
      // Exit
      // 
      this.Exit.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exit.BackgroundImage")));
      this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.Exit.FlatAppearance.BorderSize = 0;
      this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.Exit.IconChar = FontAwesome.Sharp.IconChar.None;
      this.Exit.IconColor = System.Drawing.Color.Black;
      this.Exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.Exit.Location = new System.Drawing.Point(1071, 5);
      this.Exit.Name = "Exit";
      this.Exit.Padding = new System.Windows.Forms.Padding(2);
      this.Exit.Size = new System.Drawing.Size(20, 20);
      this.Exit.TabIndex = 2;
      this.Exit.UseVisualStyleBackColor = true;
      this.Exit.Click += new System.EventHandler(this.Exit_Click);
      this.Exit.MouseLeave += new System.EventHandler(this.Exit_MouseLeave);
      this.Exit.MouseHover += new System.EventHandler(this.Exit_MouseHover);
      // 
      // ScreenMinimize
      // 
      this.ScreenMinimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.ScreenMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ScreenMinimize.BackgroundImage")));
      this.ScreenMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.ScreenMinimize.FlatAppearance.BorderSize = 0;
      this.ScreenMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ScreenMinimize.IconChar = FontAwesome.Sharp.IconChar.None;
      this.ScreenMinimize.IconColor = System.Drawing.Color.Black;
      this.ScreenMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.ScreenMinimize.Location = new System.Drawing.Point(1021, 5);
      this.ScreenMinimize.Name = "ScreenMinimize";
      this.ScreenMinimize.Padding = new System.Windows.Forms.Padding(2);
      this.ScreenMinimize.Size = new System.Drawing.Size(18, 20);
      this.ScreenMinimize.TabIndex = 1;
      this.ScreenMinimize.UseVisualStyleBackColor = true;
      this.ScreenMinimize.Click += new System.EventHandler(this.ScreenMinimize_Click);
      this.ScreenMinimize.MouseLeave += new System.EventHandler(this.ScreenMinimize_MouseLeave);
      this.ScreenMinimize.MouseHover += new System.EventHandler(this.ScreenMinimize_MouseHover);
      // 
      // ScreenMaximize
      // 
      this.ScreenMaximize.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.ScreenMaximize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ScreenMaximize.BackgroundImage")));
      this.ScreenMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.ScreenMaximize.FlatAppearance.BorderSize = 0;
      this.ScreenMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ScreenMaximize.ForeColor = System.Drawing.SystemColors.Control;
      this.ScreenMaximize.IconChar = FontAwesome.Sharp.IconChar.None;
      this.ScreenMaximize.IconColor = System.Drawing.Color.White;
      this.ScreenMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.ScreenMaximize.Location = new System.Drawing.Point(1046, 5);
      this.ScreenMaximize.Name = "ScreenMaximize";
      this.ScreenMaximize.Padding = new System.Windows.Forms.Padding(2);
      this.ScreenMaximize.Size = new System.Drawing.Size(20, 20);
      this.ScreenMaximize.TabIndex = 0;
      this.ScreenMaximize.UseVisualStyleBackColor = true;
      this.ScreenMaximize.Click += new System.EventHandler(this.ScreenMaximize_Click);
      this.ScreenMaximize.MouseLeave += new System.EventHandler(this.ScreenMaximize_MouseLeave);
      this.ScreenMaximize.MouseHover += new System.EventHandler(this.ScreenMaximize_MouseHover);
      // 
      // mainDesktopPanel
      // 
      this.mainDesktopPanel.AutoSize = true;
      this.mainDesktopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(69)))));
      this.mainDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.mainDesktopPanel.Location = new System.Drawing.Point(202, 52);
      this.mainDesktopPanel.Name = "mainDesktopPanel";
      this.mainDesktopPanel.Size = new System.Drawing.Size(1096, 646);
      this.mainDesktopPanel.TabIndex = 12;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.BackColor = System.Drawing.Color.Red;
      this.ClientSize = new System.Drawing.Size(1300, 700);
      this.Controls.Add(this.mainDesktopPanel);
      this.Controls.Add(this.TopScreenPanel);
      this.Controls.Add(this.LeftMenu);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.MinimumSize = new System.Drawing.Size(900, 500);
      this.Name = "MainForm";
      this.Padding = new System.Windows.Forms.Padding(2);
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Activated += new System.EventHandler(this.MainForm_Activated);
      this.Deactivate += new System.EventHandler(this.MainForm_Deactivated);
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
      this.LeftMenu.ResumeLayout(false);
      this.LeftMenu.PerformLayout();
      this.HideMenu.ResumeLayout(false);
      this.TopScreenPanel.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Panel LeftMenu;
    private System.Windows.Forms.Panel HideMenu;
    private FontAwesome.Sharp.IconButton Flashcards;
    private FontAwesome.Sharp.IconButton SentanceMode;
    private FontAwesome.Sharp.IconButton WordMode;
    private FontAwesome.Sharp.IconButton Menu;
    private FontAwesome.Sharp.IconButton HomePage;
    private System.Windows.Forms.Panel TopScreenPanel;
    private System.Windows.Forms.Panel mainDesktopPanel;
    private FontAwesome.Sharp.IconButton Exit;
    private FontAwesome.Sharp.IconButton ScreenMinimize;
    private FontAwesome.Sharp.IconButton ScreenMaximize;
  }
}

