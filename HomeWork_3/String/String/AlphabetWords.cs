﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class AlphabetWords
    {
        public void GetWordsAlphabet()
        {
            
            Repository repository = new Repository();
            Sentences sentences = new Sentences();
            sentences.GetSenteces();
            if (Word.word.Count > 0)
            {
               Word.word.Sort();
               var dis = Word.word.Distinct();
                foreach (var str in dis)
                {                
                   int count = Word.word.Count(x => x == str);
                   repository.SaveWord(str, count); 
                }
            }
            Console.ReadLine();
        }
    }
}