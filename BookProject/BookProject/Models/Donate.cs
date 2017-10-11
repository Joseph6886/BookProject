using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookProject.Models
{
    public class Donate
    {
        public int ID { get; set; }
        public int ISBNNumber { get; set; }
        public string Title { get; set; }
        //[Display(Name = "Author")]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public string Author { get; set; }

    }
    //public class paperbackDBContext : DbContext
    //{
    //    public DbSet<paperback> Paperback { get; set; }
    //    public DbSet<Request> Request { get; set; }
        
    //}
}