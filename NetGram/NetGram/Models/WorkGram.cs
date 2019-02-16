using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetGram.Models
{
    public class WorkGram
    {
        public int ID { get; set; }

        [Required]
        public string UserName { get; set; }

        public string Title { get; set; }

        public string URL { get; set; }

        public string Comments { get; set; }

        [Display(Name = "Views")]
        public int Views { get; set; }
    }
}
