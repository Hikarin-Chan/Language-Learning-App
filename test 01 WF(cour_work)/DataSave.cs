using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text.Json;
using System.Diagnostics.Tracing;
using System.IO;
using System.Windows.Forms;


namespace test_01_WF_cour_work_
{
  internal static class DataSave
  {
    private static readonly string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Save.json");
    private static readonly string wordsJsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Words.json");
    private static int currentWordIndex = 0;

    public static int CurrentWordIndex { get; set; } = 0;

    public static void SaveData(int currentIndex)
    {
      var data = new {CurrentWordIndex = currentIndex};

      string jsonData = JsonConvert.SerializeObject(data, Formatting.Indented);
      File.WriteAllText(jsonFilePath, jsonData);
    }

    public static (List<Word>, int) LoadData()
    {
      List<Word> words = null;
      int currentWordIndex = 0;

      try
      {
        if (File.Exists(wordsJsonFilePath))
        {
          string jsonData = File.ReadAllText(wordsJsonFilePath);
          words = JsonConvert.DeserializeObject<List<Word>>(jsonData);
        }
        else
        {
          MessageBox.Show("Data file not found.");
        }

        if (File.Exists(jsonFilePath))
        {
          string jsonData = File.ReadAllText(jsonFilePath);
          var data = JsonConvert.DeserializeObject<Data>(jsonData);

          if (data != null && data.CurrentWordIndex <= words.Count && data.CurrentWordIndex >= 0)
          {
            currentWordIndex = data.CurrentWordIndex;
          }
          else
          {
            currentWordIndex = 0;
          }
        }
    }
      catch (Exception ex)
      {
        MessageBox.Show($"Error loading data: {ex.Message}");
        words = new List<Word>();
      }
      return (words, currentWordIndex);
    }
  }
}
