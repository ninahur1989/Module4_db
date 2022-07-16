using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_db
{
    public class Artist
    {
        public int? Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? InstagramUrl { get; set; } = null!;
        public virtual List<Song> Songs { get; set; } = new List<Song>();
        public int SongId { get; set; } 
    }
}
