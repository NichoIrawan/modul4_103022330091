using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4
{
    internal class FanLaptop
    {
        public enum laptopState
        {
            QUIET, BALANCED, PERFORMANCE, TURBO
        }

        public laptopState state = laptopState.QUIET;

        public void modeUp()
        {
            if ((int)state < (int)laptopState.TURBO) 
            {
                state++;
                Console.WriteLine($"Fan {state - 1} telah berubah menjadi Fan {state}");
            }
        }

        public void modeDown()
        {
            if ((int)state > (int)laptopState.QUIET)
            {
                state--;
                Console.WriteLine($"Fan {state + 1} telah berubah menjadi Fan {state}");
            }
        }

        public void turboShorcut()
        {
            laptopState stateAwal = state;

            if (state == laptopState.QUIET){ 
                state = laptopState.TURBO;
            }
            else if (state == laptopState.TURBO){ 
                state = laptopState.QUIET;
            }
            Console.WriteLine($"Fan {stateAwal} telah berubah menjadi Fan {state}");
        }
    }
}
