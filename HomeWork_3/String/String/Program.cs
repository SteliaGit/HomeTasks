using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 1;
            while (input != 6)
            {
                Console.WriteLine(new string('-', 10));
                Console.WriteLine("Working with strings");
                Console.WriteLine(new string('-', 5));
                Console.WriteLine("1 - Parse the document - Sentences");
                Console.WriteLine("2 - Parse the document - Word");
                Console.WriteLine("3 - Parse the document - Punctuation");
                Console.WriteLine(new string('-', 5));
                Console.WriteLine("4 - Print words in alphabetical order to another file, indicating the number of uses of this word");
                Console.WriteLine(new string('-', 5));
                Console.WriteLine("5 - Longest sentence by character count");
                Console.WriteLine("  - Word sentence shortest");
                Console.WriteLine("  - The most common letter");
                Console.WriteLine(new string('-', 5));
                Console.WriteLine("6 - Exit");

                ClearText clear = new ClearText();
                clear.GetClearString();
                
                int.TryParse(Console.ReadLine(), out input);
                switch (input)
                {
                    case 1:
                        {
                            Sentences sente = new Sentences();
                            sente.GetSenteces();
                            Console.WriteLine("File uploaded, cleaned and splited on sentences");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 2:
                        {
                            Word word = new Word();
                            word.GetSenteces();
                            Console.WriteLine("File uploaded, cleaned and splited on words");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 3:
                        {
                            Punctuation Punct = new Punctuation();
                            Punct.GetSenteces();
                            Console.WriteLine("File uploaded, cleaned and splited on Punctuations");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Calculations are made. Wait....");
                            Word word = new Word();
                            word.GetSenteces();
                            AlphabetWords alphabet = new AlphabetWords();
                            alphabet.GetWordsAlphabet();
                            Console.WriteLine("Write to file made. Finish.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Calculations are made. Wait....");
                            CountsLetters Letter = new CountsLetters();
                            Sentences sente = new Sentences();                                                     
                            sente.GetSenteces();
                            Letter.GetLongestSentence();                           
                            Letter.GetLongestSentenceWords();
                            Letter.GetMostCommonLetter();
                            Console.WriteLine("Write to file made. Finish.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 6:
                        {                           
                            Console.WriteLine("The program will now exit. ");
                            Console.WriteLine("To continue, click - ENTER");
                            Console.ReadKey();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("You have entered incorrect data, try again");
                            Console.WriteLine("To continue, click - ENTER");
                            Console.ReadKey();
                            break;
                        }
                }
                Console.Clear();
            }
        }
    }
}
