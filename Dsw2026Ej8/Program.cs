namespace Dsw2026Ej8
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductHelper helper = new ProductHelper();
            string etiqueta = helper.ObtenerEtiquetaProducto(101, "Teclado Mecanico", 75000);
            Console.WriteLine(etiqueta);

            Problema2 p = new Problema2();
            string resultado = p.CrearResumenVenta(102, "Mouse", 4, 75000);
            Console.WriteLine(resultado);
        }
    }
}
