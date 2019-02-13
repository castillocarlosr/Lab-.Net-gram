using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetGram.Models
{
    public class WorkGram
    {
        public int ID { get; set; }

        public string UserName { get; set; }

        public string Title { get; set; }

        public string URL { get; set; }

        public string Comments { get; set; }

        public int Views { get; set; }
    }
}
