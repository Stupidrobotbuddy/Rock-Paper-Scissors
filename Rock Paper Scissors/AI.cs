using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    internal class AI
    {
        Random random = new Random();
        public int MakeDecision()
        {
            return random.Next(3) + 1;
        }
    }
}
