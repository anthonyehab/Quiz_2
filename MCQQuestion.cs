﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_2
{
    internal class MCQQuestion : Question
    {
        public MCQQuestion(string header, string body, int mark)
            : base(header, body, mark)
        {
            Answers = new Answer[4];
        }
    }
}