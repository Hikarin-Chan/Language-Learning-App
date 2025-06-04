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

namespace test_01_WF_cour_work_
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      InitialData();
    }

    public void InitialData()
    {
      // Инициализация данных, если необходимо
      // Например, можно заполнить элементы управления данными
      // или выполнить другие начальные настройки
      label1.Text = words[0,0];
    }
    
    public int index = 0;
    public string[,] words = { 
      {"Dog", "собака" },
      {"Car","машина" } 
    };

    private void button1_Click(object sender, EventArgs e)
    {
      if (textBox1.Text.ToLower().Equals(words[index, 1]))
      {
        MessageBox.Show("Правильно!");
      }
      else
      {
        MessageBox.Show("Неправильно, попробуйте еще раз.");
      } 
    }

    private void button2_Click(object sender, EventArgs e)
    {
      index++;

      if (index >= words.Length / 2)
      {
        index = 0;
        MessageBox.Show("Вы завершили тест!!!");
        return;
      }

      textBox1.Clear();
      label1.Text = words[index, 0];
    }
  }
}
