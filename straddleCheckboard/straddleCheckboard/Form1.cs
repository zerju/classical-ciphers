using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace straddleCheckboard
{
    public partial class Form1 : Form
    {
        string alphabet = "ABCČDEFGHIJKLMNOPRSŠTUVZŽ".ToLower();
        string textInFile;

        public Form1()
        {
            InitializeComponent();
        }

        private void encBtn_Click(object sender, EventArgs e)
        {
            string[] parts = sparePositions.Text.Split(' ');
            int[] spares = new int[2] { Int32.Parse(parts[0]), Int32.Parse(parts[1]) };
            string encText = encrypt(textInFile, keyText.Text, spares);
            fileTextOutput.Text = encText;
            System.IO.File.WriteAllText(@Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\encryptedStraddle.txt", encText);

        }

        private void decBtn_Click(object sender, EventArgs e)
        {
            string[] parts = sparePositions.Text.Split(' ');
            int[] spares = new int[2] { Int32.Parse(parts[0]), Int32.Parse(parts[1]) };
            string decText = decrypt(textInFile, keyText.Text, spares);
            fileTextOutput.Text = decText;
            System.IO.File.WriteAllText(@Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\decryptedStraddle.txt", decText);

        }

        private string encrypt(string text, string key, int[] spares)
        {
            List<char> keyList = key.ToList();
            key = key.Insert(spares[0], "x");
            key = key.Insert(spares[1], "y");
            string encNumbers = "";
            Hashtable charKeys = generateCharKeys(key, spares);
            encNumbers = textToNumbers(text, charKeys);
            
            return encNumbers;
        }

        private string decrypt(string text, string key, int[] spares)
        {
            List<char> keyList = key.ToList();
            key = key.Insert(spares[0], "x");
            key = key.Insert(spares[1], "y");
            Hashtable numberKeys = generateNumberKeys(key, spares);
            string decText = numbersToText(text, numberKeys, spares);

            return decText;
        }

        private Hashtable generateCharKeys(string key, int[] spares)
        {
            Hashtable table = new Hashtable();

            for(int i = 0; i < key.Length; i++)
            {
                if(i <= 9)
                {
                    table.Add(key[i].ToString(), i.ToString());
                } else if(i > 9 && i <= 19)
                {
                    table.Add(key[i].ToString(), spares[0].ToString() + (i % 10).ToString());
                } else
                {
                    table.Add(key[i].ToString(), spares[1].ToString() + (i % 10).ToString());
                }
            }


            return table;
        }

        private Hashtable generateNumberKeys(string key, int[] spares)
        {
            Hashtable table = new Hashtable();

            for (int i = 0; i < key.Length; i++)
            {
                if (i <= 9)
                {
                    table.Add(i.ToString(), key[i].ToString());
                }
                else if (i > 9 && i <= 19)
                {
                    table.Add(spares[0].ToString() + (i % 10).ToString(), key[i].ToString());
                }
                else
                {
                    table.Add(spares[1].ToString() + (i % 10).ToString(), key[i].ToString());
                }
            }
            return table;
        }


        private string textToNumbers(string text, Hashtable keyValue)
        {
            string encNumbers = "";
            for(int i = 0; i < text.Length; i++)
            {
                if (alphabet.IndexOf(text[i]) > -1) { 
                    encNumbers = encNumbers + keyValue[text[i].ToString()];
                } else
                {
                    encNumbers = encNumbers + "#" + text[i];
                }
            }

            return encNumbers;
        }


        private string numbersToText(string numbers, Hashtable key, int[] spares)
        {
            string text = "";
            for(int i = 0; i< numbers.Length; i++)
            {
                if(numbers[i].ToString() == "#")
                {
                    ++i;
                    text = text + numbers[i];
                } else
                { 
                    if(numbers[i].ToString() == spares[0].ToString())
                    {
                        ++i;
                        text = text + key[spares[0].ToString() + numbers[i].ToString()];

                    }else if(numbers[i].ToString() == spares[1].ToString())
                    {
                        ++i;
                        text = text + key[spares[1].ToString() + numbers[i].ToString()];
                    }                
                    else
                    {
                        text = text + key[numbers[i].ToString()];

                    }
                }
            }
            return text;
        }


        
        private void selFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text Files|*.txt";
            openFileDialog1.Title = "Select a text File";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                textInFile = System.IO.File.ReadAllText(@filename);
                fileTextOutput.Text = textInFile;
            }
        }
    }
}
