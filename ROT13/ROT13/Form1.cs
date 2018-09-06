using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROT13
{
    public partial class Form1 : Form
    {
        string alphabet = "ABCČDEFGHIJKLMNOPRSŠTUVZŽ".ToLower();
        string rot13alph = "MNOPRSŠTUVZŽABCČDEFGHIJKL".ToLower();
        string textInFile;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        private void encBtn_Click(object sender, EventArgs e)
        {
            string encText = encrypt(textInFile.ToLower());
            fileTextOutput.Text = encText;
            System.IO.File.WriteAllText(@Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\encryptedRot13.txt", encText);

        }

        private void decBtn_Click(object sender, EventArgs e)
        {
            string decText = decrypt(textInFile.ToLower());
            fileTextOutput.Text = decText;
            System.IO.File.WriteAllText(@Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\decryptedsRot13.txt", decText);
        }

        private string encrypt(string text)
        {
            string encryptedText = "";

            for(int i = 0; i < text.Length; i++)
            {
                if(alphabet.IndexOf(text[i]) > -1)
                {
                    int alphIndex = alphabet.IndexOf(text[i]);
                    encryptedText = encryptedText + rot13alph[alphIndex];
                } else
                {
                    encryptedText = encryptedText + text[i];
                }
            }

            return encryptedText;
        }

        private string decrypt(string text)
        {
            string decryptedText = "";

            for(int i = 0; i < text.Length; i++)
            {
                if(alphabet.IndexOf(text[i]) > -1)
                {
                    int rot13Index = rot13alph.IndexOf(text[i]);
                    decryptedText = decryptedText + alphabet[rot13Index];
                } else
                {
                    decryptedText = decryptedText + text[i];
                }
            }

            return decryptedText;
        }
    }
}
