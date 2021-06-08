using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GanjinehStore.Models
{
    public class BooksGenre
    {
        public int Id { get; set; }
        public int GenreId { get; set; }
        public int BookId { get; set; }
    }
}
