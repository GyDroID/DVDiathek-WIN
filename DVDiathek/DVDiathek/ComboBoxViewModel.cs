using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDiathek
{
    class ComboBoxViewModel
    {
        public List<string> MediaSection { get; set; }

        public ComboBoxViewModel() => MediaSection = new List<string>()
            {
                "Filme",
                "Serien",
            };
    }
}
