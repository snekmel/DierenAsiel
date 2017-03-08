using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DierenAsiel.Models
{
    public class Reservering
    {
        public DateTime Reserveerdatum { get; set; }
        public DateTime Ophaaldatum { get; set; }
        public bool IsOpgehaald { get; set; }
        public Persoon Persoon { get; set; }
        public Dier Dier { get; set; }
        public string Note { get; set; }
    }
}