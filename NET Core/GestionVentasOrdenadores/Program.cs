namespace GestionVentasOrdenadores.Modelo;

internal class Program
{
    private static void Main(string[] args)
    {
        // Manolo: Ordenador básico
        Ordenador manolo = new OrdenadorBase();
        Console.WriteLine(manolo.Descripcion());

        // Ana: Ordenador básico con RAM Máxima
        Ordenador ana = new DecoradorRAMMaxima(new OrdenadorBase());
        Console.WriteLine(ana.Descripcion());

        // Luisa: Ordenador básico con RAM Máxima y Disco Sólido
        Ordenador luisa = new DecoradorDiscoSolido(new DecoradorRAMMaxima(new OrdenadorBase()));
        Console.WriteLine(luisa.Descripcion());

        // Gerónimo: Ordenador básico con Disco Sólido y "A Ver si Cuela"
        Ordenador geronimo = new DecoradorAVersiCuela(new DecoradorDiscoSolido(new OrdenadorBase()));
        Console.WriteLine(geronimo.Descripcion());

        // Tienda
        var tienda = new Tienda();
        tienda.AgregarOrdenador(manolo);
        tienda.AgregarOrdenador(ana);
        tienda.AgregarOrdenador(luisa);
        tienda.AgregarOrdenador(geronimo);
        tienda.Listado();

        Console.WriteLine($"Total facturado: {tienda.TotalFacturado()}");
        Console.WriteLine($"Número de ordenadores vendidos: {tienda.NumeroOrdenadoresVendidos()}");
        Console.WriteLine($"Ordenador más barato: {tienda.OrdenadorMasBarato().Descripcion()}");
        Console.WriteLine($"Ordenador más caro: {tienda.OrdenadorMasCaro().Descripcion()}");
        Console.WriteLine($"Precio medio: {tienda.PrecioMedio()}");
        Console.WriteLine($"Número de ordenadores con precio superior a 125€: {tienda.NumeroOrdenadoresMayores125()}");
        Console.WriteLine("Pulsa una tecla para salir...");
        Console.ReadKey();
    }
}