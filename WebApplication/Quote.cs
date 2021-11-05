using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication
{
    public class Quote
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Text { get; set; }
        public string Author { get; set; }
        [Required]
        public DateTime InsertDate { get; set; }
    }
}
