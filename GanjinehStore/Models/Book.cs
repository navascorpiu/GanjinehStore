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

        [Display(Name = "چکیده")]
        [Required(ErrorMessage = "{0} الزامی است.")]
        [StringLength(1500, ErrorMessage = "{0} نمی تواند از {1} بیشتر باشد.")]
        public string Abstraction { get; set; }

        [Display(Name = "تعداد صفحات")]
        [Required(ErrorMessage = "{0} الزامی است.")]
        public int PagesCount { get; set; }

        [Display(Name = "شابک")]
        [Required(ErrorMessage = "{0} الزامی است.")]
        [StringLength(32, ErrorMessage = "{0} نمی تواند از {1} بیشتر باشد.")]
        public string IBSN { get; set; }

        [Display(Name = "کاور")]
        [StringLength(128, ErrorMessage = "{0} نمی تواند از {1} بیشتر باشد.")]
        public string Cover { get; set; }

        [Display(Name = "نویسنده")]
        [Required(ErrorMessage = "{0} الزامی است.")]
        public int AuthorId { get; set; }

        [Display(Name = "ناشر")]
        [Required(ErrorMessage = "{0} الزامی است.")]
        public int PublicationId { get; set; }
        public ICollection<BooksGenre> BooksGenres { get; set; }
    }
}
