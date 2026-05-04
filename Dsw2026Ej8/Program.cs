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

            Product prod = new Product("Celular");
            Problema3 q = new Problema3();
            string resultado1 = q.CompararCopias(5, prod);
            Console.WriteLine(resultado1);

            Problema4 c = new Problema4();
            Console.WriteLine("Caso 1: " + c.CalcularPromedio(6, 8, 10));
            Console.WriteLine("Caso 2: " + c.CalcularPromedio(8, null, 3));
            Console.WriteLine("Caso 3: " + c.CalcularPromedio(null, null, null));

        }
    }
}
