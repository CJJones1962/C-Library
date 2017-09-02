using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CJ_sComics.Models
{
    public class ComicBookManager
    {
        public static List<ComicBook> GetComicBooks() {
            return new List<ComicBook> {
                new ComicBook {ComicBookId =1, ComicTitle ="Marvel Comics", EpisodeNumber = 173, EpisodeTitle ="The Uncanny X-Men", Characters = new List<Character> {new Character { CharacterId =1, Name="Wolverine"} }  },
                new ComicBook {ComicBookId =2, ComicTitle ="DC Comics", EpisodeNumber = 201, EpisodeTitle ="Wonder Woman", Characters = new List<Character> {new Character { CharacterId =1, Name="Wonder Woman"},  new Character { CharacterId =2, Name="Batman"} }  },
                new ComicBook {ComicBookId =3, ComicTitle ="Top Cow", EpisodeNumber = 178, EpisodeTitle ="Witchblade", Characters = new List<Character> {new Character { CharacterId =1, Name="Sara Pezzini"} }  }
            };

        }
    }

    public class ComicBook
    {
        public int ComicBookId { get; set; }
        public string ComicTitle { get; set; }
        public int EpisodeNumber { get; set; }
        public string EpisodeTitle { get; set; }
        public List<Character> Characters { get; set; }
    }

    public class Character
    {
        public int CharacterId { get; set; }
        public string Name { get; set; }
    }
}