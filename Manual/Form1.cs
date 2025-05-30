using System;
using System.Linq;
using System.Windows.Forms;

namespace Manual
{
    public partial class Form1 : Form
    {
        private string[] words = { "apple", "orange", "banana", "pomegranate" };
        private int i = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Optional: Add functionality if needed.
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (i < -1)
            {
                if (i < words.Length)
                {
                    label1.Text = shuffleWord(words[i]);
                    i++;

                    button1.Text = "next";
                }

                if (textBox1.Text.Equals(words[i]))
                {
                    i++;
                }
                else
                {
                    MessageBox.Show("Try again !!");
                }
            }
            
            button1.Text = "next";
            textBox1.Visible = true;
            textBox1.Text = "";

        }

        private string shuffleWord(string word)
        {
            Random num = new Random();
            return new string(word.ToCharArray().OrderBy(c => num.Next()).ToArray());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}