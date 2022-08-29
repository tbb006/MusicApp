using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    public class TabelMelodii
    {
        public string id { get; set; }
        public string nume { get; set; }
        public string artist { get; set; }
        public string gen { get; set; }
        public string an { get; set; }
        public string album { get; set; }
        public string durata { get; set; }
    }
    public class Melodii
    {
        public List<TabelMelodii> tabel_melodii { get; set; }
    }

    public class RootMelodii
    {
        public Melodii melodii { get; set; }
    }
}
