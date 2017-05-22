using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatriculaUPC
{
    public class IntegerDecimal
    {
        public int _int { get; set; }
        public decimal _decimal { get; set; }

        public IntegerDecimal(int p_int, decimal p_decimal)
        {
            _int = p_int;
            _decimal = p_decimal;
        }
    }
}
