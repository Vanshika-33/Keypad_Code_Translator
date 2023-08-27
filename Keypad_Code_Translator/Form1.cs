using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keypad_Code_Translator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void ConvertToText(object sender, EventArgs e)
        {
            var code = CodeBox.Text;
            string[] allcodewords = code.Trim().Split(' ');
            string TextWords = string.Empty;
            string allTextWords= string.Empty;

            foreach (string item in allcodewords)
            {
                char[] signlecodeWord = item.ToArray();//{2,2,3,3,4,5}
                //tostore code for each alphabet  22,33,4,5
                List<string> charcodelist = new List<string>();
                string character = string.Empty;
                int lastindex = 0;
                int count = 0;
                for (int i =0;i<signlecodeWord.Length;i++)
                {
                    if(i!=signlecodeWord.Length-1)
                    {
                        if (signlecodeWord[i] == signlecodeWord[i + 1])
                        {
                            count++;
                            //lastindex = i+1;
                            continue;
                        }
                        else
                        {
                            lastindex= i;
                            character = string.Empty;

                            for (int j = 0; j <= count; j++)
                            {
                                character += signlecodeWord[lastindex];
                                --lastindex;
                            }
                            count = 0;
                            lastindex = 0;
                            charcodelist.Add(character);
                        }
                    }                   
                    else
                    {
                        lastindex = i;
                        character = string.Empty;
                        for (int j=0;j<=count;j++)
                        {
                            character += signlecodeWord[lastindex];
                            --lastindex;
                        }
                        charcodelist.Add(character);
                    }
                }
                TextWords = string.Empty;
                foreach(var letter in charcodelist)
                {
                    if(letter == ".")
                    {
                        continue;
                    }
                    var text = (Code)Int32.Parse(letter.ToString());
                    if (!Regex.IsMatch(text.ToString(), "[a-z]"))
                    {
                        msgLabel.Text = "Please check the input!";
                        break;

                    }
                    TextWords += text;
                }
                allTextWords += TextWords + " ";
            }
            TextBox.Text = allTextWords;
        }

        private void ConvertToCode(object sender, EventArgs e)
        {
            var code = TextBox.Text;
            string[] allcodewords = code.ToLower().Trim().Split(' ');
            string TextWords = string.Empty;
            string allTextWords = string.Empty;
            

            foreach (string item in allcodewords)
            {
                char[] signlecodeWord = item.ToArray();//{2,2,3,3,4,5}
                //tostore code for each alphabet  22,33,4,5
                TextWords = string.Empty;
                foreach (var letter in signlecodeWord)
                {
                    Code charac;
                    
                    Enum.TryParse(letter.ToString(), out charac);
                    var text = (uint)charac;
                    var lastChar = TextWords != string.Empty?TextWords.Substring(TextWords.Length-1)
                        :string.Empty;
                    if (lastChar == text.ToString().Substring(0,1))
                        TextWords += ".";
                    TextWords += text;
                }
                allTextWords += TextWords + " ";  
            }
            CodeBox.Text = allTextWords;

        }

        private void OnClick_ConvertToText(object sender, EventArgs e)
        {
            var code = CodeBox.Text;

        }
        private void OnClick_ConvertToCode(object sender, EventArgs e)
        {
            var code = CodeBox.Text;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
