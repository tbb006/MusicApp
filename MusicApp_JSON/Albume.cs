using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    public class TabelAlbume
    {
        public string id { get; set; }
        public string nume { get; set; }
        public string artist { get; set; }
        public string an { get; set; }
        public string gen { get; set; }
        public string durata { get; set; }
        
    }
    public class Albume
    {
        public List<TabelAlbume> tabel_albume { get; set; }
    }

    public class RootAlbum
    {
        public Albume albume { get; set; }
    }
}
