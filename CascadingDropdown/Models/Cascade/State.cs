using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CascadingDropdown.Models.Cascade
{
    public class State
    {
        public int Id { get; set; }
        public string name { get; set; }
        public Country country { get; set; }

    }
}
