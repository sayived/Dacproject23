using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Book
    {
        public int? Id { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Publication { get; set; }

        public float? price { get; set; }

        public char Booktype { get; set; }

        public DateTime created { get; set; }=DateTime.Now;
        public DateTime updated { get; set; }=DateTime.Now;

        public Book(int? id, string? title, string? author, string? publication, float? price, char booktype, DateTime created, DateTime updated)
        {
            Id = id;
            Title = title;
            Author = author;
            Publication = publication;
            this.price = price;
            Booktype = booktype;
            this.created = created;
            this.updated = updated;
        }

        public Book() { }

       

    }
}
