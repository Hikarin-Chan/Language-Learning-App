using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.CodeDom;
using System.Diagnostics.Tracing;

namespace test_01_WF_cour_work_
{
  public partial class WordModeForm : Form
  {
    // ========= Fields ==========
    private int currentWordIndex = 0;
    private List<Word> words;

    // ========= Delegate ==========
    public event MainForm.IndexChangedEventHandler IndexCganged;

    // ========= Constructor ==========
    internal WordModeForm(List<Word> words, int currentWordIndex)
    {
      this.words = words;
      this.currentWordIndex = currentWordIndex;
      InitializeComponent();
      ShowNextWord();
    }

    // ========= Methods/Invoke ==========
    public void ShowNextWord()
    {
      if (words == null || words.Count == 0)
      {
        MessageBox.Show("No words available for the word mode.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      
      wordToTranslate.Text = words[currentWordIndex].English;
      TOfWord.Text = words[currentWordIndex].Transcription;
      answerLine.Clear();

      IndexCganged?.Invoke(currentWordIndex);
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

    // ========= Events ==========
    private void Check_Click(object sender, EventArgs e)
    {
      if (answerLine.Text.ToLower().Trim() == words[currentWordIndex].Ukrainian.ToLower())
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
  }
}
