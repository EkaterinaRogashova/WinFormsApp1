using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    //[PrimaryKey("Id")]
    public class Patient
    {
        //public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Palata { get; set; } = string.Empty;
        //public ICollection<Analiz> Analyzes { get; set; } = new List<Analiz>();

    }
}
