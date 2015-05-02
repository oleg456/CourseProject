using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CourseProject
{
    public partial class MainForm : Form
    {
        Dictionary<string, char> TranslationDictionary = new Dictionary<string, char>()
        {
            {"a", 'а'},
            {"b", 'б'},
            {"c", 'ц'},
            {"d", 'д'},
            {"e", 'е'},
            {"f", 'ф'},
            {"g", 'г'},
            {"h", 'х'},
            {"i", 'и'},
            {"j", 'й'},
            {"k", 'к'},
            {"l", 'л'},
            {"m", 'м'},
            {"n", 'н'},
            {"o", 'о'},
            {"p", 'п'},
            {"r", 'р'},
            {"s", 'с'},
            {"t", 'т'},
            {"u", 'у'},
            {"v", 'в'},
            {"x", 'х'},
            {"y", 'ы'},
            {"z", 'з'},
            {"zh", 'ж'},
            {"ch", 'ч'},
            {"sh", 'ш'},
            {"shch", 'щ'},
            {"shh", 'щ'},
            {"yu", 'ю'},
            {"ju", 'ю'},
            {"io", 'ё'},
            {"jo", 'ё'},
            {"yo", 'ё'},
            {"je", 'э'},
            {"ts", 'ц'},
            {"tc", 'ц'},
            {"ja", 'я'},
            {"jj", 'й'},
            {"kh", 'х'},
            {"'", 'ь'},
        };

        List<char> TwoSymbolsTranslation = new List<char>()
        {
            'z',
            'c',
            's',
            'y',
            't',
            'i',
            't',
            'j',
            'k',
        };

        List<char> ThreeSymbolsTranslation = new List<char>()
        {
            's',
        };

        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonDoTranslation_Click(object sender, EventArgs e)
        {
            string latinText = TextBoxLatin.Text;
            string translatedText = null;

            for (int i = 0; i < latinText.Length; i++)
            {
                string character = latinText[i].ToString().ToLower();
                if (TranslationDictionary.ContainsKey(character))
                {
                    //explain on examples: artjom
                    if (ThreeSymbolsTranslation.Contains(char.Parse(character)) && i + 2 <= latinText.Length
                        && !String.IsNullOrWhiteSpace(latinText[i + 1].ToString())
                        && !String.IsNullOrWhiteSpace(latinText[i + 2].ToString()))
                    {
                        //explain on example chasha
                        //explain p'janyj (out of bounds array)
                        character += latinText[i + 1].ToString() + latinText[i + 2].ToString();
                        i += 2;
                    }
                    else if (TwoSymbolsTranslation.Contains(char.Parse(character)) && i + 1 <= latinText.Length
                        && !String.IsNullOrWhiteSpace(latinText[i + 1].ToString()))
                    {
                        i += 1;
                        character += latinText[i].ToString();
                    }

                    if (TranslationDictionary.ContainsKey(character))
                    {
                        translatedText += TranslationDictionary[character];
                    }
                    else
                    {
                        if (TwoSymbolsTranslation.Contains(character[0]))
                        {
                            //on example chasha
                            character = character.Substring(0, character.Length - 1);
                            i -= 1;
                            if (TranslationDictionary.ContainsKey(character))
                            {
                                translatedText += TranslationDictionary[character];
                            }
                            else
                            {
                                translatedText += TranslationDictionary[character[0].ToString()];
                                i -= 1;
                            }
                        }
                        else
                        {
                            character = character.Substring(0, character.Length - 2);
                            translatedText += TranslationDictionary[character];
                            i -= 2;
                        }
                    }
                }
                else
                {
                    translatedText += character;
                }
            }

            TextBoxTranslated.Text = translatedText;
        }

        private void uploadFile_Click(object sender, EventArgs e)
        {
            string latinString = null;
            Stream openedFile = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Text files (*.txt)|*.txt";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    openedFile = openFileDialog.OpenFile();
                    if (openedFile != null)
                    {
                        using (openedFile)
                        {
                            using (StreamReader reader = new StreamReader(openedFile))
                            {
                                latinString = reader.ReadToEnd();
                                if (latinString.Length == 0)
                                {
                                    throw new InvalidOperationException();
                                }
                                TextBoxLatin.Text = latinString;
                            }
                        }
                    }
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show(openFileDialog.FileName + " is empty", "=(", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (IOException)
                {
                    MessageBox.Show("Error occured during reading the file", "Oh, no!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void about_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
