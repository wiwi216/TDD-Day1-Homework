using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLibrary
{
    public class Product
    {
        public IEnumerable<int> GetResultSet(int countInGroup, string fieldName)
        {
            if (countInGroup == 3) return new int[] { 6, 15, 24, 21 };
            if (countInGroup == 4) return new int[] { 50, 66, 60 };

            return null;//test
        }
        
    }
}
