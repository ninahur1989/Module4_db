using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_db
{
    public class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleasedDate { get; set; }
        public string Duration { get; set; }
        public virtual List<Artist> Artists { get; set; } = new List<Artist>();
        public int ArtistId { get; set; }
        public int GenreId { get; set; }


    }
}
