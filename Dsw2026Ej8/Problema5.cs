using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace Dsw2026Ej8
{
    public class Problema5
    {
        public decimal ObtenerInformeFinal(Sale sale)
        {
            return sale.CalculateTotal();
        }
    }
}
