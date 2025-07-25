﻿using System;
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
  public partial class flashCardsForm : Form
  {
    // ========= Fields ==========
    private int currentWordIndex;
    private List<Word> words;

    // ========= Delegate ==========
    public event MainForm.IndexChangedEventHandler IndexChanged;

    // ========= Constructor ==========
    internal flashCardsForm(List<Word> words, int currentWordIndex)
    {
      InitializeComponent();
      this.words = words;
      this.currentWordIndex = currentWordIndex;

      flashCardOrig.Text = words[currentWordIndex].English;
    }

    // ========= Constructor ==========
    private void flashTranslate_Click(object sender, EventArgs e)
    {
      int width = flashTranslate.Size.Width;
      for (int i = 0; i < width; i++)
      {
        flashTranslate.Size = new Size(flashTranslate.Size.Width - 1, flashTranslate.Size.Height);
        if (i % 2 == 0)
        {
          flashTranslate.Location = new Point(flashTranslate.Location.X + 1, flashTranslate.Location.Y);
        }
      }

      flashTranslate.Text = words[currentWordIndex].Ukrainian;

      for (int i = 0; i < width; i++)
      {
        flashTranslate.Size = new Size(flashTranslate.Size.Width + 1, flashTranslate.Size.Height);
        if (i % 2 == 0)
        {
          flashTranslate.Location = new Point(flashTranslate.Location.X - 1, flashTranslate.Location.Y);
        }
      }
    }
  }
}
