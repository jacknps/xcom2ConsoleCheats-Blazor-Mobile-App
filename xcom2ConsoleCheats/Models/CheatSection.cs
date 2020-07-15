using System;
using System.Collections.Generic;
using System.Text;

namespace xcom2ConsoleCheats.Models
{
    public class CheatSection
    {
        public string Title { get; set; }
        public long Id { get; set; }
        public List<CheatEntryModel> Entries { get; set; }
    }
}
