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
using System.Text.Json;
using System.IO;

namespace test_01_WF_cour_work_
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      LoadData();
      ShowNextWord();
    }

    private int currentWordIndex = 0;
    private List<Word> words;

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
      EWord.Text = words[currentWordIndex].english;
      TOfWord.Text = words[currentWordIndex].transcription;
      AnswerLine.Clear();
    }

    private void Check_Click(object sender, EventArgs e)
    {
      if (AnswerLine.Text.ToLower().Trim() == words[currentWordIndex].russian.ToLower())
      {
        MessageBox.Show("Currect answer!");
        Next_Click(sender, e);
      }
      else
      {
        MessageBox.Show("Incurrect answer!");
        Tip.Text = "Forgot the word? Use flashcards!";
        AnswerLine.Clear();
      }
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

    private void Flashcards_Click(object sender, EventArgs e)
    {
      FlashCardsForm flashCardsForm = new FlashCardsForm(words, currentWordIndex);
      flashCardsForm.ShowDialog();
    }

    private void Exit_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }
  }
}
