using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using FontAwesome.Sharp;

namespace test_01_WF_cour_work_
{
  public partial class Form1 : Form
  {
    private IconButton currentButton;
    private Panel leftBorder;
    private Form currentChildForm;
    private List<Word> words = new List<Word>();
    private int currentWordIndex = 0;

    public delegate void IndexChangedEventHandler(int index);

    public Form1()
    {
      InitializeComponent();
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

    private void Exit_Click(object sender, EventArgs e)
    {
      Application.Exit();

    }

    private void Exit_MouseHover(object sender, EventArgs e)
    {
      Exit.BackColor = Color.FromArgb(242, 48, 48);
    }

    private void Exit_MouseLeave(object sender, EventArgs e)
    {
      Exit.BackColor = leftBorder.BackColor;
    }
    
    private void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {
      DataSave.SaveData(CurrentWordIndex);
    }
  }
}
