using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using FontAwesome.Sharp;

namespace test_01_WF_cour_work_
{
  public partial class MainForm : Form
  {
    private IconButton currentButton;
    private Panel leftBorder;
    private Form currentChildForm;
    private List<Word> words = new List<Word>();
    private int currentWordIndex = 0;
    Color MainFormBC;

    public delegate void IndexChangedEventHandler(int index);

    [DllImport("user32.DLL",EntryPoint = "ReleaseCapture")]
    private extern static void ReleaseCapture();

    [DllImport("user32.DLL", EntryPoint = "SendMessage")]
    private extern static void SendMessage(IntPtr hWnd,int wMsg,int wParam,int IParam);

    [DllImport("dwmapi.dll")]
    private static extern int DwmGetColorizationColor(out uint pcrColorization, [MarshalAs(UnmanagedType.Bool)] out bool pfOpaqueBlend);

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

    private struct RGBColor
    {
      public static Color color1 = Color.FromArgb(242, 203, 5);
      public static Color color2 = Color.FromArgb(242, 159, 5);
      public static Color color3 = Color.FromArgb(242, 135, 5);
      public static Color color4 = Color.FromArgb(242, 48, 48);
    }

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

    private void LoadData()
    {
      var (loadedWords, loadedCurrentIndex) = DataSave.LoadData();

      Words = loadedWords;
      CurrentWordIndex = loadedCurrentIndex;
    }

    private void ActivateButton(object sender, Color color)
    {
      DisableButton();

      if (sender != null)
      {
        currentButton = (IconButton)sender;
        currentButton.BackColor = Color.FromArgb(50, 153, 134);
        currentButton.ForeColor = color;
        currentButton.TextAlign = ContentAlignment.MiddleCenter;
        currentButton.IconColor = color;
        currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
        currentButton.ImageAlign = ContentAlignment.MiddleRight;

        leftBorder.BackColor = color;
        leftBorder.Location = new Point(0, currentButton.Location.Y);
        leftBorder.Visible = true;
        leftBorder.BringToFront();

        TopScreenPanel.BackColor = color;
        Exit.BackColor = color;
      }
    }

    private void DisableButton()
    {
      if (currentButton != null)
      {
        currentButton.BackColor = Color.FromArgb(38, 115, 101);
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
    }

    private void WordIndexChanged(int index)
    {
      currentWordIndex = index;
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

    }

    private void HomePage_Click(object sender, EventArgs e)
    {
      ActivateButton(sender, RGBColor.color4);
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
      }
      else
      {
        WindowState = FormWindowState.Maximized;
        Padding = new Padding(0, 0, 0, 0);
      }
    }

    private void ScreenMinimize_Click(object sender, EventArgs e)
    {
      WindowState = FormWindowState.Minimized;
    }

    private void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {
      //DataSave.SaveData(CurrentWordIndex);
    }

    private void Exit_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }
  }
}
