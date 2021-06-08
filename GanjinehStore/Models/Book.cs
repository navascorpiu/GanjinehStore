using System.Collections.Generic;

namespace GanjinehStore.Models
{
    public class Book
    {
        public Book()
        {
            BooksGenres = new List<BooksGenre>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Abstraction { get; set; }
        public int PagesCount { get; set; }
        public string IBSN { get; set; }
        public int AuthorId { get; set; }
        public int PublicationId { get; set; }
        public ICollection<BooksGenre> BooksGenres { get; set; }
    }
}
