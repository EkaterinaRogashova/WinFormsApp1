using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Analiz
    {
        public int Id {  get; set; }
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public int PatientId { get; set; }
        public Patient Patient { get; set; } = null!;
    }
}
