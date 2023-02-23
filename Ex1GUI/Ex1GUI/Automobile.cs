using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1GUI
{
    public class Automobile
    {
        public string maXe { get; set; }
        public string tenXe { get; set; }
        public string dongXe { get; set; }
        public string phienBan { get; set; }
        public double giaBan { get; set; }

        public Automobile(string maXe, string tenXe, string dongXe, string phienBan, double giaBan)
        {
            this.maXe = maXe;
            this.tenXe = tenXe;
            this.dongXe = dongXe;
            this.phienBan = phienBan;
            this.giaBan = giaBan;
        }
        public override string ToString()
        {
            return $"{maXe} - {tenXe} - {dongXe} - {phienBan} - {giaBan}\n";
        }
    }
}
