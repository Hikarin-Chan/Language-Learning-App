using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_01_WF_cour_work_
{
  public partial class FlashCardsForm : Form
  {
    
    internal FlashCardsForm(List<Word> words, int currentWordIndex)
    {
      InitializeComponent();
      this.words = words;
      WordOrig.Text = words[currentWordIndex].english;
      TranslateWord.Text = words[currentWordIndex].russian;
    }

    List<Word> words;

    private void FlashCardsForm_Load(object sender, EventArgs e)
    {
      string jsonFilePath = "Words.json";
      if (System.IO.File.Exists(jsonFilePath))
      {
        string jsonData = System.IO.File.ReadAllText(jsonFilePath);
        words = System.Text.Json.JsonSerializer.Deserialize<List<Word>>(jsonData);
      }
      else
      {
        MessageBox.Show("Data file not found.");
        words = new List<Word>();
      }
    }

    private void SearchWords_Click(object sender, EventArgs e)
    {
      string searchText = SearchPannel.Text.ToLower().Trim()??"";
      var results = words.Where(w => w.english.ToLower().Contains(searchText) || w.russian.ToLower().Contains(searchText)).ToList();

      if (results.Count > 0)
      {
        ResOfSearch.Text = "Search Results:\n----------------";
        ResOfSearch.Visible = true;
        foreach (var result in results)
        {
          ResOfSearch.Text += $"\nEnglish: {result.english}, \nRussian: {result.russian}, \nTranacription: {result.transcription}";
        }
      }
      else
      {
        ResOfSearch.Text = "No results found.";
        ResOfSearch.Visible = true;
      }
    }

    private void ShowMoreFC_Click(object sender, EventArgs e)
    {
      WordOrig.Visible = false;
      TipForYou.Visible = false;
      Space.Visible = false;
      SearchPannel.Visible = true;
      ShowMore.Visible = false;
      Search.Visible = true;

      TranslateWord.Location = new Point(220, 140);
      SearchPannel.Location = new Point(220, 170);
      Search.Location = new Point(220, 200);
      CloseWin.Location = new Point(220, 230);

      TranslateWord.Text = "Enter search word:";
    }

    private void CloseWin_Click(object sender, EventArgs e)
    {
      Hide();

      TipForYou.Visible = true;
      WordOrig.Visible = true;
      Space.Visible = true;
      SearchPannel.Visible = false;
      ResOfSearch.Visible = false;
      Search.Visible = false;
      ShowMore.Visible = true;

      TranslateWord.Location = new Point(280, 180);
      SearchPannel.Location = new Point(1, 1);
      Search.Location = new Point(1, 25);
      CloseWin.Location = new Point(150, 200);

      TranslateWord.Text = "";
    }
  }
}
