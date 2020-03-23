using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryNetCore.Entities
{
    public class Album
    {
      
        public int AlbumId { get; set; }
        public ICollection<AlbumArtist> AlbumArtists { get; set; }
        public string AlbumName { get; set; }

        protected Album()
        {
        }
    }
}
