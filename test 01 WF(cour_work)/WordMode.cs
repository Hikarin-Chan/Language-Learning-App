using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace test_01_WF_cour_work_
{
  public partial class WordModeForm : Form
  {
    private int currentWordIndex = 0;
    private List<Word> words;

    public WordModeForm()
    {
      InitializeComponent();
      LoadData();
      ShowNextWord();
    }

    private void LoadData()
    {
      string jsonFilePath = "Words.json";
      if (File.Exists(jsonFilePath))
      {
        string jsonData = File.ReadAllText(jsonFilePath);
        words = JsonSerializer.Deserialize<List<Word>>(jsonData);
      }
      else
      {
        MessageBox.Show("Data file not found.");
      }
    }

    public void ShowNextWord()
    {
      wordToTranslate.Text = words[currentWordIndex].english;
      TOfWord.Text = words[currentWordIndex].transcription;
      answerLine.Clear();
    }

    private void Check_Click(object sender, EventArgs e)
    {
      if (answerLine.Text.ToLower().Trim() == words[currentWordIndex].russian.ToLower())
      {
        MessageBox.Show("Currect answer!");
        Next_Click(sender, e);
        DisableTip();
      }
      else
      {
        MessageBox.Show("Incurrect answer!");
        tipFlashCard.Text = "Forgot the word? Use flashcards!";
        tipFlashCard.Visible = true;
        tipFlashCard.BackColor = Color.FromArgb(38, 115, 101);
        answerLine.Clear();
      }
    }

    private void DisableTip()
    {
      tipFlashCard.Visible = false;
      tipFlashCard.Text = string.Empty;
      tipFlashCard.BackColor = Color.Transparent;
    }

    private void Next_Click(object sender, EventArgs e)
    {
      if (currentWordIndex < words.Count - 1)
      {
        currentWordIndex++;
        ShowNextWord();
      }
      else
      {
        MessageBox.Show("Вы завершили все тесты!!!");
        currentWordIndex = 0;
      }
    }

    private void WordModeForm_FormClosing(object sender, EventArgs e)
    {
      new flashCardsForm(words, currentWordIndex);
    }
  }
}
