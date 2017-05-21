using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatriculaUPC
{
    static class Validators
    {
        public static bool TextoVacio(String texto)
        {
            return (texto.Replace(" ", String.Empty).Replace(System.Environment.NewLine, String.Empty) == "");
        }

        public static bool TextoEsPorcetaje(String texto)
        {
            decimal value;

            if (Decimal.TryParse(texto, out value) == false)
            {
                return false;
            }

            if (value >= 0 && value <= 100)
                return true;

            return false;
        }

        public static void GetOnlyDecimals(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }
    }
}
