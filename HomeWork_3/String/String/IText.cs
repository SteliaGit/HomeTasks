﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    interface IText
    {
        void LoadString();
        void SaveWord(string str, int count);
        void SaveSentences(string str, int count, string massage);
    }
}
