using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    public class TabelFavorite
    {
        public string id { get; set; }
        public string nume { get; set; }
        public string artist { get; set; }
        public string gen { get; set; }
        public string an { get; set; }
        public string album { get; set; }
        public string durata { get; set; }
    }
    public class Favorite
    {
        public List<TabelFavorite> tabel_favorite { get; set; }
    }

    public class RootFavorite
    {
        public Favorite favorite { get; set; }
    }
}
