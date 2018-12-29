using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugApp.Models
{
    public class Bug
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }

    }
}