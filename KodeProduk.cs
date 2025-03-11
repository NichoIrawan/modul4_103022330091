using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4
{
    internal class KodeProduk
    {
        public enum produkElektronik
        {
            LAPTOP, SMARTPHONE, TABLET, HEADSET, KEYBOARD, MOUSE, PRINTER, MONITOR, SMARTWATCH, KAMERA
        };
        public string[] kodeProduk =
        {
            "E100", "E101", "E102", "E103", "E104", "E105", "E106", "E107", "E108", "E109"
        };

        public string GetKodeProduk(produkElektronik i)
        {
            return kodeProduk[(int) i];
        }
    }
}
