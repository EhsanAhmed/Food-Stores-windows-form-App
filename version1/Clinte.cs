using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace version1
{
    internal class Clinte
    {
        public string ClinteName { get; set; }
        public static int ClinteId { get; set; }
        public string ClintePhone { get; set; }
        public string ClinteAddress { get; set; }

        public Clinte(string name, string phone, string address)
        {
            ClinteId++;
            ClinteName = name;
            ClintePhone = phone;
            ClinteAddress = address;
        }
    }
}
