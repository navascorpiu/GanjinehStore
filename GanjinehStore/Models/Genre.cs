using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GanjinehStore.Models
{
    public class Genre
    {
        public Genre()
        {
            BooksGenres = new List<BooksGenre>();
        }

        [Key]
        public int Id { get; set; }
        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "{0} الزامی است.")]
        [StringLength(256, ErrorMessage = "{0} نمی تواند از {1} بیشتر باشد.")]
        public string Title { get; set; }

        public ICollection<BooksGenre> BooksGenres { get; set; }
    }
}
