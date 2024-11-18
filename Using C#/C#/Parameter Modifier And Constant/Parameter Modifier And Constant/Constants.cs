using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameter_Modifier_And_Constant
{
 
    // enum is set of constants
    enum Days : short
    {
        Saturday, // default value = 0
        Sunday, // default value = 1
        Monday, // default value = 2
        Tuesday = 0, // assigned value = 0
        Wednesday, // default value = 1
        Thursday, // default value = 2
        Friday // default value = 3
    }
    internal class Constants
    {
        // const
        public const int x = 5; // const must be initialized when declare, it can't be change anywhere else
        public readonly int y; // init of readonly is optional. it can be change inside constructors 
        public Constants()
        {
            y = 10;
        }
    }
}
