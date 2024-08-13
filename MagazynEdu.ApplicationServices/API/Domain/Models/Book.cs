using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazynEdu.ApplicationServices.API.Domain.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Type { get; set; }
        public string SubType { get; set; }
        public int PageNumber { get; set; }
        public string Publisher { get; set; }
        public int BookCaseId { get; set; }
        public int AuthorId { get; set; }
    }
}
