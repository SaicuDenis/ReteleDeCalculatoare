using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cifrul_Lui_Cezar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Criptbutton_Click(object sender, EventArgs e)
        {
            textBoxMCD.Text = "";
            int cheia = 0;
            string[] array = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

            try
            {
                cheia = Convert.ToInt32(textBoxKey.Text);
            }
            catch
            {
                MessageBox.Show("Introduceti o cheie valida");
                return;
            }
            string[] array2;
            array2 = array.Skip(cheia).Concat(array.Take(cheia)).ToArray();
            string text = TextBoxMO.Text;

            foreach (char character in text)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (character.ToString().ToLower() == array[i])
                    {
                        textBoxMCD.Text += array2[i];
                        break;
                    }
                    else
                    {
                        if (character.ToString() == " " || character.ToString() == "." || character.ToString() == "," || character.ToString() == ":" || character.ToString() == ";" || character.ToString() == "!" || character.ToString() == "?")
                        {
                            textBoxMCD.Text += " ";
                            break;
                        }
                    }
                }
            }
        }

        private void Decriptbutton_Click(object sender, EventArgs e)
        {
            textBoxMCD.Text = "";
            int cheia = 0;
            string[] array = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            try
            {
                cheia = Convert.ToInt32(textBoxKey.Text);
            }
            catch
            {
                MessageBox.Show("Introduceti o cheie valida");
                return;
            }
            string[] array2;
            array2 = array.Skip(26-cheia).Concat(array.Take(26-cheia)).ToArray();
            string text = TextBoxMO.Text;

            foreach (char character in text)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (character.ToString().ToLower() == array[i])
                    {
                        textBoxMCD.Text += array2[i];
                        break;
                    }
                    else
                    {
                        if (character.ToString() == " " || character.ToString() == "." || character.ToString() == "," || character.ToString() == ":" || character.ToString() == ";" || character.ToString() == "!" || character.ToString() == "?")
                        {
                            textBoxMCD.Text += " ";
                            break;
                        }
                    }
                }
            }
        }

        private void Resetbutton_Click(object sender, EventArgs e)
        {
            textBoxKey.ResetText();
            textBoxMCD.ResetText();
            TextBoxMO.ResetText();
        }
    }
}
