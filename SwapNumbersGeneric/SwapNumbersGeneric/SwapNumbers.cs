using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapNumbersGeneric
{
    class SwapNumbers<Tnum>
    {

        private Tnum var1;
        private Tnum var2;

        public Tnum Var1
        {
            get { return var1; }
            set { var1 = value; }
        }
        public Tnum Var2
        {
            get { return var2; }
            set { var2 = value; }
        }
        public void Swap()
        {
            Tnum temp = Var1;
            Var1 = Var2;
            Var2 = temp;
        }

        
    }
}
