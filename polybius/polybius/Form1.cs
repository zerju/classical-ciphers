using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace polybius
{
    public partial class Form1 : Form
    {
        string alphabet = "ABCČDEFGHIJKLMNOPRSŠTUVZŽ".ToLower();
        string sideLetters = "ABCDE".ToLower();
        string textInFile;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private char[,] createSquare()
        {
            string phrase = passText.Text.ToString().ToLower();
            int lastIndex = 0;
            int currentPhraseIndex = 0;
            char[,] square = new char[5, 5];
            List<char> alreadyUsed = new List<char>();
            for(int i = 0; i < 5; i++) {
                for(int j = 0; j < 5;j++)
                {
                    if(currentPhraseIndex > phrase.Length -1)
                    {
                        int alphIndex = (lastIndex + 1) % 25;
                        while (alreadyUsed.IndexOf(alphabet[alphIndex]) > -1 && alreadyUsed.Count < 25)
                        {

                            alphIndex = (lastIndex + 1) % 25;
                            ++lastIndex;
                        }
                        square[i, j] = alphabet[alphIndex];
                        alreadyUsed.Add(alphabet[alphIndex]);
                    } else
                    {
                        char currentPhraseChar = phrase[currentPhraseIndex];
                        while (alreadyUsed.IndexOf(currentPhraseChar) > -1 && currentPhraseIndex <= phrase.Length - 1)
                        {
                            currentPhraseChar = phrase[currentPhraseIndex];
                            ++currentPhraseIndex;
                        }
                        if (alreadyUsed.IndexOf(currentPhraseChar) < 0) { 
                            square[i, j] = currentPhraseChar;
                            lastIndex = alphabet.IndexOf(currentPhraseChar);
                            alreadyUsed.Add(currentPhraseChar);
                            if (currentPhraseIndex < phrase.Length) { 
                                currentPhraseIndex++;
                            }
                        } else
                        {
                            --j;
                        }
                    }
                }
            }
            return square;
        }

        private string encryptText(char[,] square, string text)
        {
            string encrypted = "";
            for(int i = 0;i < text.Length; i++)
            {
                char charToEncrypt = text[i];
                if(alphabet.IndexOf(charToEncrypt) > -1) {
                    Tuple<int, int> coordinates = Util.CoordinatesOf(square, charToEncrypt);
                    encrypted = encrypted + sideLetters[coordinates.Item1] + sideLetters[coordinates.Item2];
                } else
                {
                    encrypted = encrypted + charToEncrypt;
                }
            }
               return encrypted;
        }

        private string decryptText(char[,] square, string text)
        {
            string decrypted = "";
            for(int i = 0;i < text.Length; i++)
            {
                if(alphabet.IndexOf(text[i]) > -1) { 
                    string encryptedChar = text[i].ToString() + text[i + 1];
                    int coord1 = sideLetters.IndexOf(text[i]);
                    int coord2 = sideLetters.IndexOf(text[i + 1]);
                    char decryptedChar = square[coord1, coord2];
                    decrypted = decrypted + decryptedChar;
                    ++i;
                } else
                {
                    decrypted = decrypted + text[i];
                }

            }

            return decrypted;
        }

        private void passText_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[,] square = createSquare();
            string encryptedText = encryptText(square, textInFile);
            fileTextOutput.Text = encryptedText;
            System.IO.File.WriteAllText(@Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\encryptedPolybius.txt", encryptedText);
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

        private void decryptBtn_Click(object sender, EventArgs e)
        {
            char[,] square = createSquare();
            string decryptedText = decryptText(square, textInFile);
            fileTextOutput.Text = decryptedText;
            System.IO.File.WriteAllText(@Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\decryptedPolybius.txt", decryptedText);

        }
    }
}
