using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static test_01_WF_cour_work_.MainForm;

namespace test_01_WF_cour_work_
{
  public partial class SentenceModeForm : Form
  {
    // ========= Fields ==========
    private List<Sentence> words;
    private int currentSentenceIndex;
    private string currentSentence = "";
    private List<Button> buttons = new List<Button>();

    // ========= Delegate ==========
    public event IndexChangedEventHandler IndexChanged;

    // ========= Constructor ==========
    internal SentenceModeForm(List<Sentence> words, int currentSentenceIndex)
    {
      InitializeComponent();
      this.words = words;
      this.currentSentenceIndex = currentSentenceIndex;
      SetupSentanceMode();
    }

    // ========= Methods ==========
    private void SetupSentanceMode()
    {
      if (words == null || words.Count <= currentSentenceIndex)
      {
        MessageBox.Show("No words available for the sentence mode.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      OriginSentence.Text = words[currentSentenceIndex].English;

      foreach (Button button in buttons)
      {
        Controls.Remove(button);
      }

      buttons.Clear();

      string[] sentanse = words[currentSentenceIndex].Ukrainian.Split(' ');
      for (int i = 0; i < sentanse.Length; i++)
      {
        Button button = new Button
        {
          Text = sentanse[i],
          Name = $"button_{i}",
          Size = new Size(100, 30),
          BackColor = Color.FromArgb(1, 96, 69),
          ForeColor = Color.White,
          FlatStyle = FlatStyle.Flat,
          AutoSize = true
        };

        button.MouseHover += Button_MouseHover;
        button.MouseLeave += Button_MouseLeave;
        button.Click += Button_Click;
        buttons.Add(button);
      }
      SetupRundomButtons();
    }

    private void SetupRundomButtons()
    {
      Random random = new Random();
      int buttonCount = buttons.Count;

      for (int i = 0; i < buttonCount; i++)
      {
        int randomIndex = random.Next(buttonCount);
        Button curButton = buttons[i];
        buttons[i] = buttons[randomIndex];
        buttons[randomIndex] = curButton;
      }

      for (int i = 0; i < buttonCount; i++)
      {
        if (i == 0)
        {
          buttons[i].Location = new Point(100 + (i * 110) + 100, 300);
          Controls.Add(buttons[i]);
          continue;
        }
        buttons[i].Location = new Point(buttons[i - 1].Location.X + buttons[i - 1].Width + 15, 300);
        
        Controls.Add(buttons[i]);
      }
    }

    private void ResetSentenseForm()
    {
      currentSentence = "";
      TranslateSentence.Text = "";
      foreach (Button button in buttons)
      {
        button.Enabled = true;
      }
    }

    private void CheckSentence_Click(object sender, EventArgs e)
    {
      if (currentSentenceIndex >= words.Count)
      {
        MessageBox.Show("You have completed all sentences!", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      if (string.IsNullOrWhiteSpace(TranslateSentence.Text))
      {
        MessageBox.Show("Please complete the sentence before checking.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      if (TranslateSentence.Text.Trim() == words[currentSentenceIndex].Ukrainian.Trim())
      {
        MessageBox.Show(Text = "Correct!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        currentSentenceIndex++;

        IndexChanged?.Invoke(currentSentenceIndex);
        ResetSentenseForm();
        SetupSentanceMode();
      }
      else
      {
        MessageBox.Show(Text = "Incorrect. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        ResetSentenseForm();
      }
    }

    // ========= Events ==========
    private void Button_MouseHover(object sender, EventArgs e)
    {
      ((Button)sender).BackColor = Color.FromArgb(38, 115, 101);
    }

    private void Button_MouseLeave(object sender, EventArgs e)
    {
      ((Button)sender).BackColor = Color.FromArgb(1, 96, 69);
    }

    private void Button_Click(object sender, EventArgs e)
    {
      Button clickedButton = sender as Button;
      if (clickedButton != null)
      {
        currentSentence += clickedButton.Text + " ";
        TranslateSentence.Text = currentSentence.Trim();
        clickedButton.Enabled = false;
      }
    }
  }
}
