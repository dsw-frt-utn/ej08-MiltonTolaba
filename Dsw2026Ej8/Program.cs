namespace Dsw2026Ej8
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductHelper helper = new ProductHelper();
            string etiqueta = helper.ObtenerEtiquetaProducto(101, "Teclado Mecanico", 75000);
            Console.WriteLine(etiqueta);
        }
    }
}
