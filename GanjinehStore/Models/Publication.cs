using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GanjinehStore.Models
{
    public class Publication
    {
        public Publication()
        {
            books = new List<Book>();
        }

        [Key]
        public int Id { get; set; }

        [Display(Name = "نام")]
        [Required(ErrorMessage = "{0} الزامی است.")]
        [StringLength(128, ErrorMessage = "{0} نمی تواند از {1} بیشتر باشد.")]
        public string Name { get; set; }

        [Display(Name = "شماره تماس")]
        [Required(ErrorMessage = "{0} الزامی است.")]
        [StringLength(64, ErrorMessage = "{0} نمی تواند از {1} بیشتر باشد.")]
        public string PhoneNumber { get; set; }

        [Display(Name = "فکس")]
        [StringLength(32, ErrorMessage = "{0} نمی تواند از {1} بیشتر باشد.")]
        public string Fax { get; set; }

        [Display(Name = "موبایل")]
        [StringLength(32, ErrorMessage = "{0} نمی تواند از {1} بیشتر باشد.")]
        public string Mobile { get; set; }

        [DataType(DataType.Date)]
        public DateTime RegisterDate { get; set; }

        public ICollection<Book> books { get; set; }
    }
}
