using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatriculaUPC
{
    static class Validators
    {
        public static bool TextoVacio(String texto)
        {
            return (texto.Replace(" ", String.Empty).Replace(System.Environment.NewLine, String.Empty) == "");
        }
    }
}
