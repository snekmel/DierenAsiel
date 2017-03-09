using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DierenAsiel.Models
{
    public class Cat : Dier
    {
        private string _extraInfo;

        public string ExtraInfo { get; set; }
    }
}