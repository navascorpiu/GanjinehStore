using System;
using System.Collections.Generic;

namespace GanjinehStore.Models
{
    public class Publication
    {
        public Publication()
        {
            books = new List<Book>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Fax { get; set; }
        public string Mobile { get; set; }
        public DateTime RegisterDate { get; set; }
        public ICollection<Book> books { get; set; }
    }
}
