using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MagazynEdu.DataAccess.Entities
{
    public class Book : EntityBase
    {
        public int BookCaseId { get; set; }

        public BookCase BookCase { get; set; }

        public int AuthorId { get; set; }

        [Required]
        [MaxLength(250)]
        public string Title { get; set; }
        public string Author { get; set; }
        public string Type { get; set; }
        public string SubType { get; set; }
        public int PageNumber { get; set; }
        public string Publisher { get; set; }
    }
}
