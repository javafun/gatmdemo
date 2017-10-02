using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GATMDemo.Models
{
    public class ContactViewModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string From { get; set; }

        [Required]
        public string Subject { get; set; }

        [Required]
        public string Message { get; set; }
    }
}
