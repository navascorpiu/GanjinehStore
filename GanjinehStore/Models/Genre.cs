using System.Collections.Generic;

namespace GanjinehStore.Models
{
    public class Genre
    {
        public Genre()
        {
            BooksGenres = new List<BooksGenre>();
        }

        public int Id { get; set; }
        public string Title { get; set; }

        public ICollection<BooksGenre> BooksGenres { get; set; }
    }
}
