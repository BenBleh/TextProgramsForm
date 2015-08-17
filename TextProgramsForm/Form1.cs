using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Linq;

namespace TextProgramsForm
{
    public partial class TextProgramis : Form
    {
        public TextProgramis()
        {
            InitializeComponent();
            
            
        }


        private void Menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FizzBuzzRun_Click_1(object sender, EventArgs e)
        {
            
            
            int i;
            for (i = 1; i <= 100; i++)
            {
                if ((i % 5) == 0 && (i % 3) == 0)
                {
                    FizzBuzzOutput.Text += "FizzBuzz\t";
                }
                else if ((i % 5) == 0)
                {
                    FizzBuzzOutput.Text += "Buzz\t";
                }
                else if ((i % 3) == 0)
                {
                    FizzBuzzOutput.Text += "Fizz\t";
                }
                else
                {
                    if(i == 1)
                    {
                        FizzBuzzOutput.Text += "\t";
                    }
                    FizzBuzzOutput.Text += i + "\t";
                }
            }
        }

        private void RSButRun_Click(object sender, EventArgs e)
        {
           
            // initilise the output text incase this isnt the first time the program ran
            ReverseStringOutput.Text = "";
            ReverseStringOutput.Text = StringExtensions.reverseString(reverseStringInput.Text);            
        }

        private void PigLatRun_Click(object sender, EventArgs e)
        {

            //get input and put individual words into array
            string input = PgLtInput.Text;
            string[] words = StringExtensions.getWords(input);
            PgltOutput.Text = "";
            // convert words to pig latin
            
            for (int i =0; i< words.Length; i++)
            {
                string word = words[i];
                if (word[i].IsVowel())
                {
                    words[i] = word + "yay";
                }
                else
                {
                    string constanWord = "";
                    for (int j=1; j< word.Length; j++)
                    {
                        constanWord += word[j];
                    }
                    words[i] = constanWord + char.ToLower(word[0]) + "ay";
                }
                
                 


            }
            //print words
            for( int i =0; i< words.Length; i++) 
                {
                
                PgltOutput.Text += words[i] +" ";   

                }

        }

        private void CountVowelsRun_Click(object sender, EventArgs e)
        {
            //get words
            string[] words = StringExtensions.getWords(CountVowelsInput.Text);
            //count vowels
            int NoVowels = 0;
            for(int i=0; i < words.Length; i++)
            {

                string currentWord = words[i];
                for(int j=0;j< currentWord.Length; j++)
                {
                    if (CharExtensions.IsVowel(currentWord[j]))
                    {
                        NoVowels++;
                    }
                }
            }
            CountVowelsOutput.Text = "Number of Vowels in the input text is :" + NoVowels;
        }

        private void PalindromeRun_Click(object sender, EventArgs e)
        {
            //split words in to string
            string[] words = StringExtensions.getWords(PalindromeInput.Text);
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == StringExtensions.reverseString(words[i]))
                {
                    PalindromeOutput.Text += "The word \"" + words[i] + "\" is a Palindrome \n";
                }
                else
                {
                    PalindromeOutput.Text += "The word \"" + words[i] + "\" is not a Palindrome \n";
                }
            }
        }

        private void CountWords_Click(object sender, EventArgs e)
        {

        }

        private void CountWordsRun_Click(object sender, EventArgs e)
        {
           String[] words = StringExtensions.getWords(CountWordsInput.Text);
           // CountWordsInput.Text.Count(Char.IsWhiteSpace);
           CountWordsOutput.Text="The input has " + CountWordsInput.Text.Count(Char.IsWhiteSpace) + "words.";
            Console.Write(words);
        }
    }

    public static class CharExtensions
    {
        public static bool IsVowel(this char character)
        {
            //checks if the chracter is a vowel
            return new[] { 'a', 'e', 'i', 'o', 'u' }.Contains(char.ToLower(character));
        }
    }
    public static class StringExtensions
    {

        public static string[] getWords(string input)
        {
            // splits indiviual words from string and returns a array of these words as strings
            string[] words = Regex.Split(input, @"\W|_");
            // strip white space
            int i = 0;
            foreach(string word in words)
            {
                words[i].Trim();
            }
            return words;
        }
        public static string reverseString(string input)
        {
            // returns a reversed version on of the input string
            string output = "";
            for (int i = 0; i < input.Length; i++)
                {
                    output += input[input.Length - i - 1];
                }
            return output;
                
        }
    }
}
