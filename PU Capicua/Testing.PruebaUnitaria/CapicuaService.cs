using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.PruebaUnitaria
{
    public class CapicuaService
    {
        public bool VerifyCapicua(int number) {

            bool result = false;

            string numString = number.ToString();
            char[] numberArray = numString.ToCharArray();

            string numInvertido = string.Empty;
          
            for (int index = numString.Length-1; index>= 0; index--) {
               numInvertido+=numberArray[index];
            }
            if (numString.Equals(numInvertido)) {
                result = true;
          }
            return result;
        
        }
    }
}
