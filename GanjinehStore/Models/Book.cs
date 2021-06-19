using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GanjinehStore.Models
{
    public class Book
    {
        public Book()
        {
            BooksGenres = new List<BooksGenre>();
        }

        [Key]
        public int BookId { get; set; }

        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "{0} الزامی است.")]
        [StringLength(256, ErrorMessage = "{0} نمی تواند از {1} بیشتر باشد.")]
        public string Title { get; set; }

        [Display(Name = "خلاصه")]
        [Required(ErrorMessage = "{0} الزامی است.")]
        [StringLength(1500, ErrorMessage = "{0} نمی تواند از {1} بیشتر باشد.")]
        public string Abstraction { get; set; }

        [Required(ErrorMessage = "{0} الزامی است.")]
        public int PagesCount { get; set; }

        [Display(Name = "شابک")]
        [Required(ErrorMessage = "{0} الزامی است.")]
        [StringLength(32, ErrorMessage = "{0} نمی تواند از {1} بیشتر باشد.")]
        public string IBSN { get; set; }

        public int AuthorId { get; set; }
        public int PublicationId { get; set; }
        public ICollection<BooksGenre> BooksGenres { get; set; }
    }
}
