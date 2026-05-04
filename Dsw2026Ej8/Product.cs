using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Product
    {
        public string Descripcion { get; set; }
        public Product(string descripcion)
        {
            Descripcion = descripcion;
        }
        public void CambiarDescripcion(string nuevaDescripcion)
        {
            Descripcion = nuevaDescripcion;
        }
    }
}
