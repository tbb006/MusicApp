using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    public class TabelArtisti
    {
        public string id { get; set; }
        public string nume { get; set; }
        public string an { get; set; }
        public string gen { get; set; }
        public string colaborari { get; set; }
        public string album { get; set; }
    }
    public class Artisti
    {
        public List<TabelArtisti> tabel_artisti { get; set; }
    }

    public class Root
    {
        public Artisti artisti { get; set; }
    }
}
