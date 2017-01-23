using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_hang_a_man
{
    class EndData
    {
        public string word { get; set; }
        public string definition { get; set; }
        public bool win { get; set; }

        public EndData(string Word, string Definition, bool Win)
        {
            this.word = Word;
            definition = Definition;
            win = Win;
        }
    }
}
