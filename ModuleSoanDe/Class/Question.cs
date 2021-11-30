using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleSoanDe.Class
{
    class Question
    {
        public string Content { get; set; }
        public string Field { get; set; }

        public List<string> Answers = new List<string>();
        public string TrueAnswer = "";
        
    }
}
