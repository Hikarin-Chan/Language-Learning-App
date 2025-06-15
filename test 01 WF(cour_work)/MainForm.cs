using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using FontAwesome.Sharp;

namespace test_01_WF_cour_work_
{
  public partial class MainForm : Form
  {
    //WelcomeTitle problem

    // ========= Fields ==========
    private IconButton currentButton;
    private Panel leftBorder;
    private Form currentChildForm;
    private List<Word> words = new List<Word>();
    private List<Sentence> sentence = new List<Sentence>();
    private int currentWordIndex = 0;
    private int currentSentenceIndex = 0;
    Color MainFormBC;
    private bool minimizeMenu = false;

    // ========= Delegate ==========
    public delegate void IndexChangedEventHandler(int index);

    // ========= Constructor ==========
    public MainForm()
    {
      InitializeComponent();
      SetSystemColor();
      LoadData();

      leftBorder = new Panel();
      leftBorder.Size = new Size(7, 51);
      LeftMenu.Controls.Add(leftBorder);

      HomePage_Click(HomePage, EventArgs.Empty);
    }

    // ========= Structs ==========
    private struct RGBColor
    {
      public static Color color1 = Color.FromArgb(242, 203, 5);
      public static Color color2 = Color.FromArgb(242, 159, 5);
      public static Color color3 = Color.FromArgb(242, 135, 5);
      public static Color color4 = Color.FromArgb(242, 48, 48);
    }

    // ========= Properties ==========
    internal List<Word> Words
    {
      get => words;
      set => words = value;
    }

    public int CurrentWordIndex
    {
      get => currentWordIndex;
      set => currentWordIndex = value;
    }

    internal List<Sentence> Sentences
    {
      get => sentence;
      set => sentence = value;
    }

    public int CurrentSentenceIndex
    {
      get => currentSentenceIndex;
      set => currentSentenceIndex = value;
    }

    // ========= P/Invoke Methods ==========
    [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
    private extern static void ReleaseCapture();

    [DllImport("user32.DLL", EntryPoint = "SendMessage")]
    private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int IParam);

    [DllImport("dwmapi.dll")]
    private static extern int DwmGetColorizationColor(out uint pcrColorization, [MarshalAs(UnmanagedType.Bool)] out bool pfOpaqueBlend);

    private void SetSystemColor()
    {
      if (DwmGetColorizationColor(out uint color, out bool _) == 0)
      {
        byte a = 255;
        byte r = (byte)(color >> 16);
        byte g = (byte)(color >> 8);
        byte b = (byte)(color);
        MainFormBC = Color.FromArgb(a, r, g, b);
      }
      else
      {
        BackColor = SystemColors.Control;
      }
    }

    private void SetMenuSize()
    {
      if (minimizeMenu)
      {
        LeftMenu.Width = 60;
        foreach (Control control in LeftMenu.Controls)
        {
          if (control is IconButton iconButton)
          {
            iconButton.ImageAlign = ContentAlignment.MiddleCenter;
            iconButton.Text = string.Empty;
          }
        }
      }
      else
      {
        LeftMenu.Width = 200;
        foreach (Control control in LeftMenu.Controls)
        {
          if (control is IconButton iconButton)
          {
            iconButton.ImageAlign = ContentAlignment.MiddleLeft;
            if (iconButton.Name is "Flashcards")
            {
              iconButton.Text = "Flashcards";
            }
            else if (iconButton.Name is "WordMode")
            {
              iconButton.Text = "Word Mode";
            }
            else if (iconButton.Name is "SentenceMode")
            {
              iconButton.Text = "Sentence Mode";
            }
            else if (iconButton.Name is "HomePage")
            {
              iconButton.Text = "Home";
            }
          }
        }
      }
    }

    private void LoadData()
    {
      var (loadedWords, loadedWordIndex, loadedSentences, loadedSentenceIndex) = DataSave.LoadData();

      Words = loadedWords;
      CurrentWordIndex = loadedWordIndex;
      Sentences = loadedSentences;
      CurrentSentenceIndex = loadedSentenceIndex;
    }

    private void ActivateButton(object sender, Color color)
    {
      DisableButton();

      if (sender != null)
      {
        if (minimizeMenu)
        {
          currentButton = (IconButton)sender;
          currentButton.BackColor = Color.FromArgb(1, 96, 69);
          currentButton.ForeColor = color;
          currentButton.IconColor = color;
        }
        else
        {
          currentButton = (IconButton)sender;
          currentButton.BackColor = Color.FromArgb(1, 96, 69);
          currentButton.ForeColor = color;
          currentButton.IconColor = color;
        }

        leftBorder.BackColor = color;
        leftBorder.Location = new Point(0, currentButton.Location.Y);
        leftBorder.Visible = true;
        leftBorder.BringToFront();
      }
    }

    private void DisableButton()
    {
      if (currentButton != null)
      {
        currentButton.BackColor = Color.FromArgb(0, 43, 44);
        currentButton.ForeColor = Color.FromArgb(240, 240, 240);
        currentButton.TextAlign = ContentAlignment.MiddleLeft;
        currentButton.IconColor = Color.FromArgb(240, 240, 240);
        currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
        currentButton.ImageAlign = ContentAlignment.MiddleLeft;
      }
    }

    private void OpenChildForm(Form childForm)
    {
      if (currentChildForm != null)
      {
        currentChildForm.Close();
      }

      currentChildForm = childForm;
      childForm.TopLevel = false;
      childForm.FormBorderStyle = FormBorderStyle.None;
      childForm.Dock = DockStyle.Fill;
      mainDesktopPanel.Controls.Add(childForm);
      mainDesktopPanel.Tag = childForm;
      childForm.BringToFront();
      childForm.Show();
      childForm.Size = mainDesktopPanel.Size;

      if (childForm is WordModeForm wordModeForm)
      {
        wordModeForm.IndexCganged += WordIndexChanged;
      }
      else if (childForm is flashCardsForm flashCardsForm)
      {
        flashCardsForm.IndexChanged += WordIndexChanged;
      }
      
      if (childForm is SentenceModeForm sentenceModeForm)
      {
        sentenceModeForm.IndexChanged += SentenceIndexChanged;
      }
    }

    private void WordIndexChanged(int index)
    {
      currentWordIndex = index;
    }

    private void SentenceIndexChanged(int index)
    {
      currentSentenceIndex = index;
    }

    // ========= Events ==========
    private void MinimizeMenu_Click(object sender, EventArgs e)
    {
      if (minimizeMenu)
      {
        minimizeMenu = false;
        SetMenuSize();
      }
      else
      {
        minimizeMenu = true;
        SetMenuSize();
      }
    }

    private void Flashcards_Click(object sender, EventArgs e)
    {
      ActivateButton(sender, RGBColor.color1);

      OpenChildForm(new flashCardsForm(Words, CurrentWordIndex));
    }

    private void WordMode_Click(object sender, EventArgs e)
    {
      ActivateButton(sender, RGBColor.color2);

      OpenChildForm(new WordModeForm(Words, CurrentWordIndex));
    }

    private void SentanceMode_Click(object sender, EventArgs e)
    {
      ActivateButton(sender, RGBColor.color3);

      OpenChildForm(new SentenceModeForm(Sentences, CurrentSentenceIndex));
    }

    private void HomePage_Click(object sender, EventArgs e)
    {
      ActivateButton(sender, RGBColor.color4);

      OpenChildForm(new WelcomePageForm());
    }

    private void MainForm_Activated(object sender, EventArgs e)
    {
      BackColor = MainFormBC;
    }

    private void MainForm_Deactivated(object sender, EventArgs e)
    {
      BackColor = LeftMenu.BackColor;
    }

    private void Exit_MouseHover(object sender, EventArgs e)
    {
      Exit.BackColor = Color.FromArgb(242, 48, 48);
    }

    private void Exit_MouseLeave(object sender, EventArgs e)
    {
      Exit.BackColor = TopScreenPanel.BackColor;
    }

    private void ScreenMinimize_MouseHover(object sender, EventArgs e)
    {
      ScreenMinimize.BackColor = Color.FromArgb(1, 96, 69);
    }

    private void ScreenMinimize_MouseLeave(object sender, EventArgs e)
    {
      ScreenMinimize.BackColor = TopScreenPanel.BackColor;
    }

    private void ScreenMaximize_MouseHover(object sender, EventArgs e)
    {
      ScreenMaximize.BackColor = Color.FromArgb(1, 96, 69);
    }

    private void ScreenMaximize_MouseLeave(object sender, EventArgs e)
    {
      ScreenMaximize.BackColor = TopScreenPanel.BackColor;
    }

    private void TopScreenPanel_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        ReleaseCapture();
        SendMessage(Handle, 0x112, 0xf012, 0);
      }
    }

    private void ScreenMaximize_Click(object sender, EventArgs e)
    {
      if (WindowState == FormWindowState.Maximized)
      {
        WindowState = FormWindowState.Normal;
        Padding = new Padding(2);
        if (currentChildForm is WelcomePageForm welcomePageForm)
        {
          welcomePageForm.WelcomeTitle.AutoSize = true;
          welcomePageForm.WelcomeTitle.Font = new Font("Ubuntu", 48, FontStyle.Bold);
        }
      }
      else
      {
        WindowState = FormWindowState.Maximized;
        Padding = new Padding(0, 0, 0, 0);
        if (currentChildForm is WelcomePageForm welcomePageForm)
        {
          welcomePageForm.WelcomeTitle.AutoSize = true;
          welcomePageForm.WelcomeTitle.Font = new Font("Ubuntu", 60, FontStyle.Bold);
        }
      }
    }

    private void ScreenMinimize_Click(object sender, EventArgs e)
    {
      WindowState = FormWindowState.Minimized;
    }

    private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      DataSave.SaveData(CurrentWordIndex, CurrentSentenceIndex);
    }

    private void Exit_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }
  }
}
