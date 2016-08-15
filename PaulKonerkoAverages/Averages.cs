using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaulKonerkoAverages
{
    class Averages
    {
        





        public void RunLists()
        {

            var statInfo = new[] { "Games: ", "At Bats: ", "Runs: ", "Hits: " };
            var statType = new[] { 81, 208, 15, 43 };
            

            

            foreach (var TI in statType.Zip(statInfo, Tuple.Create))
            {
                Console.WriteLine(TI.Item2 + TI.Item1);
            }



        }


    }
}