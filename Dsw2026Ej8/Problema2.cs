using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema2
    {
        public string CrearResumenVenta(long productCode, string productDescription, int quantity, decimal unitPrice)
        {
            decimal total = quantity > 0 ? quantity * unitPrice: 0;

            var venta = new
            {
                code = productCode,
                description = productDescription,
                quantity = quantity,
                total = total
            };

            return $"{venta.code}-{venta.description}-{venta.total}";
        }
    }
}
