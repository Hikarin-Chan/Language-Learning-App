using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;


namespace test_01_WF_cour_work_
{
  internal static class DataSave
  {
    // ========= Fields ==========
    private static readonly string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Save.json");
    private static readonly string wordsJsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Words.json");
    private static readonly string sentenceJsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Sentences.json");

    // ========= Methods ==========
    public static void SaveData(int currentIndex, int currentSentenceIndex)
    {
      var data = new {CurrentWordIndex = currentIndex, CurrentSentenceIndex = currentSentenceIndex};

      string jsonData = JsonConvert.SerializeObject(data, Formatting.Indented);
      File.WriteAllText(jsonFilePath, jsonData);
    }

    public static (List<Word>, int, List<Sentence>, int) LoadData()
    {
      List<Word> words = null;
      int currentWordIndex = 0;
      
      List<Sentence> sentences = null;
      int currentSentenceIndex = 0;

      try
      {
        if (File.Exists(wordsJsonFilePath))
        {
          string jsonData = File.ReadAllText(wordsJsonFilePath);
          words = JsonConvert.DeserializeObject<List<Word>>(jsonData);
        }
        else
        {
          MessageBox.Show("Words data file not found.");
        }

        if (File.Exists(sentenceJsonFilePath))
        {
          string jsonData = File.ReadAllText(sentenceJsonFilePath);
          sentences = JsonConvert.DeserializeObject<List<Sentence>>(jsonData);
        }
        else
        {
          MessageBox.Show("Sentences data file not found.");
        }

        if (File.Exists(jsonFilePath))
        {
          string jsonData = File.ReadAllText(jsonFilePath);
          var data = JsonConvert.DeserializeObject<Data>(jsonData);

          if (data != null && data.CurrentWordIndex <= words.Count && data.CurrentWordIndex >= 0 && data.CurrentSentenceIndex <= words.Count && data.CurrentSentenceIndex >= 0)
          {
            currentWordIndex = data.CurrentWordIndex;
            currentSentenceIndex = data.CurrentSentenceIndex;
          }
          else
          {
            currentWordIndex = 0;
            currentSentenceIndex = 0;
          }
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show($"Error loading data: {ex.Message}");
        words = new List<Word>();
        sentences = new List<Sentence>();
      }
      return (words, currentWordIndex, sentences, currentSentenceIndex);
    }
  }
}
