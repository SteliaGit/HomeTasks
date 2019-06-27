using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class CountsLetters
    {
        Repository repository = new Repository();
        public int valCheck;
        public string keyCheck;
        public void GetMostCommonLetter()
        {
            Dictionary<string, int> CommonLetter = new Dictionary<string, int>();
            CommonLetter.Add("A", ClearText.a.Count(x => x == 'A'));
            CommonLetter.Add("B", ClearText.a.Count(x => x == 'B'));
            CommonLetter.Add("C", ClearText.a.Count(x => x == 'C'));
            CommonLetter.Add("D", ClearText.a.Count(x => x == 'D'));
            CommonLetter.Add("E", ClearText.a.Count(x => x == 'E'));
            CommonLetter.Add("F", ClearText.a.Count(x => x == 'F'));
            CommonLetter.Add("G", ClearText.a.Count(x => x == 'G'));
            CommonLetter.Add("H", ClearText.a.Count(x => x == 'H'));
            CommonLetter.Add("I", ClearText.a.Count(x => x == 'I'));
            CommonLetter.Add("J", ClearText.a.Count(x => x == 'J'));
            CommonLetter.Add("K", ClearText.a.Count(x => x == 'K'));
            CommonLetter.Add("L", ClearText.a.Count(x => x == 'L'));
            CommonLetter.Add("M", ClearText.a.Count(x => x == 'M'));
            CommonLetter.Add("N", ClearText.a.Count(x => x == 'N'));
            CommonLetter.Add("O", ClearText.a.Count(x => x == 'O'));
            CommonLetter.Add("P", ClearText.a.Count(x => x == 'P'));
            CommonLetter.Add("Q", ClearText.a.Count(x => x == 'Q'));
            CommonLetter.Add("R", ClearText.a.Count(x => x == 'R'));
            CommonLetter.Add("S", ClearText.a.Count(x => x == 'S'));
            CommonLetter.Add("T", ClearText.a.Count(x => x == 'T'));
            CommonLetter.Add("U", ClearText.a.Count(x => x == 'U'));
            CommonLetter.Add("V", ClearText.a.Count(x => x == 'V'));
            CommonLetter.Add("W", ClearText.a.Count(x => x == 'W'));
            CommonLetter.Add("X", ClearText.a.Count(x => x == 'X'));
            CommonLetter.Add("Y", ClearText.a.Count(x => x == 'Y'));
            CommonLetter.Add("Z", ClearText.a.Count(x => x == 'Z'));

            CommonLetter.Add("a", ClearText.a.Count(x => x == 'a'));
            CommonLetter.Add("b", ClearText.a.Count(x => x == 'b'));
            CommonLetter.Add("c", ClearText.a.Count(x => x == 'c'));
            CommonLetter.Add("d", ClearText.a.Count(x => x == 'd'));
            CommonLetter.Add("e", ClearText.a.Count(x => x == 'e'));
            CommonLetter.Add("f", ClearText.a.Count(x => x == 'f'));
            CommonLetter.Add("g", ClearText.a.Count(x => x == 'g'));
            CommonLetter.Add("h", ClearText.a.Count(x => x == 'h'));
            CommonLetter.Add("i", ClearText.a.Count(x => x == 'i'));
            CommonLetter.Add("j", ClearText.a.Count(x => x == 'j'));
            CommonLetter.Add("k", ClearText.a.Count(x => x == 'k'));
            CommonLetter.Add("l", ClearText.a.Count(x => x == 'l'));
            CommonLetter.Add("m", ClearText.a.Count(x => x == 'm'));
            CommonLetter.Add("n", ClearText.a.Count(x => x == 'n'));
            CommonLetter.Add("o", ClearText.a.Count(x => x == 'o'));
            CommonLetter.Add("p", ClearText.a.Count(x => x == 'p'));
            CommonLetter.Add("q", ClearText.a.Count(x => x == 'q'));
            CommonLetter.Add("r", ClearText.a.Count(x => x == 'r'));
            CommonLetter.Add("s", ClearText.a.Count(x => x == 's'));
            CommonLetter.Add("t", ClearText.a.Count(x => x == 't'));
            CommonLetter.Add("u", ClearText.a.Count(x => x == 'u'));
            CommonLetter.Add("v", ClearText.a.Count(x => x == 'v'));
            CommonLetter.Add("w", ClearText.a.Count(x => x == 'w'));
            CommonLetter.Add("x", ClearText.a.Count(x => x == 'x'));
            CommonLetter.Add("y", ClearText.a.Count(x => x == 'y'));
            CommonLetter.Add("z", ClearText.a.Count(x => x == 'z'));
     
            var val = CommonLetter.Values.Max();
            
            foreach (var item in CommonLetter)
            {
                if (item.Value == val )
                {
                     valCheck = item.Value;
                     keyCheck = item.Key.ToString();
                }
                else
                {
                    continue;
                }                
            }
            repository.SaveSentences(keyCheck, valCheck, "The most common letter");
        }
        int check = 0;
        int check2 = 0;
        string Senta;
        public void GetLongestSentence()
        {
             check = 0;
             Senta = "";
            foreach (var item in Sentences.Sent)
            {
                if (item.Count() >= check)
                {
                    check = item.Count();
                    Senta = item;
                }
                else
                {
                    continue;
                }
            }           
            repository.SaveSentences(Senta, check, "Longest sentence by character count");
        }
        public void GetLongestSentenceWords()
        {
           
           // string[] data;
            check = 0;

            Senta = "";
            foreach (var item in Sentences.Sent)
            {
                string[] data;
                data = item.Split(' ');
                check2 = 0;
                for (int i = 0; i < data.Length; i++)
                {
                   check2 = check2 + 1;
                }

                if (check2 >= check)
                {
                    check = check2;
                    Senta = item;
                }
                else
                {
                    continue;
                }
            }
            repository.SaveSentences(Senta, check, "Word sentence shortest");
        }
    }
}



















































