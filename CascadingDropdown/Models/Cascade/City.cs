using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CascadingDropdown.Models.Cascade
{
    public class City
    {
        public int Id { get; set; }
        public string name { get; set; }
        public State state { get; set; }

    }
}
