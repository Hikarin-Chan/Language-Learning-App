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
      ShowNextWord();
      LoadData();
    }

    private int currentWordIndex = 0;
    private List<Word> words;

    private void LoadData()
    {
      string jsonFilePath = "words.json";
      if (File.Exists(jsonFilePath))
      {
        string jsonData = File.ReadAllText(jsonFilePath);
        words = JsonSerializer.Deserialize<List<Word>>(jsonData);
      }
      else
      {
        MessageBox.Show("Файл с данными не найден.");
      }
    }

    public void ShowNextWord()
    {
      label1.Text = words[currentWordIndex].English;
      textBox1.Clear();
    }

    private void check_Click(object sender, EventArgs e)
    {
      MessageBox.Show(textBox1.Text.ToLower().Trim() == words[currentWordIndex].Russian.ToLower() ? "Правильно!" : "Неправильно!");
    }

    private void next_Click(object sender, EventArgs e)
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
    }    // add label for transcription, test code
  }
}
