using System;
using System.Windows.Forms;

namespace laba_34583458634587345
{
  public partial class Form1 : Form
  {
    int[] Mas = new int[15];
    int sum = 0;
  
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Random rand = new Random();
      textBox1.Text = "";
      for (int i = 0; i < 15; i++)
      {
        Mas[i] = rand.Next(0, 4);
        textBox1.Text += "Mas[" + Convert.ToString(i) + "] = "
            + Convert.ToString(Mas[i]) + Environment.NewLine;
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      for (int i = 0; i < 15; i++)
      {
        if (Mas[i] > 0)
        {
          sum += Mas[i];
        }
      }
      textBox2.Text += Convert.ToString(sum) + Environment.NewLine;
    }
  }
}
