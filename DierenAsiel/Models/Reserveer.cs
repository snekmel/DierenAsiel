using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DierenAsiel.Models
{
    internal class Reserveer
    {
        public DateTime Reserveerdatum { get; set; }
        public DateTime Ophaaldatum { get; set; }
        public bool IsOpgehaald { get; set; }
    }
}