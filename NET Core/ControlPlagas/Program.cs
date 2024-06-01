using ControlPlagas.Enum;
using ControlPlagas.Interface;
using ControlPlagas.Modelo;

internal class Program
{
    private static void Main(string[] args)
    {
        // Crear clientes
        var cliente1 = new Cliente
        {
            NombreCompleto = "Juan Pérez",
            Telefono = "123456789",
            Email = "juan.perez@example.com",
            CodigoPostal = "12345"
        };

        var cliente2 = new Cliente
        {
            NombreCompleto = "María Gómez",
            Telefono = "987654321",
            Email = "maria.gomez@example.com",
            CodigoPostal = "54321"
        };

        // Crear trabajadores
        var jefeEquipo = new Trabajador
        {
            Nombre = "Pedro Rodríguez",
            Ingreso = 200.0m,
            Tipo = TipoTrabajador.JefeEquipo
        };

        var peon1 = new Trabajador
        {
            Nombre = "Ana Sánchez",
            Ingreso = 150.0m,
            Tipo = TipoTrabajador.Peon
        };

        var peon2 = new Trabajador
        {
            Nombre = "Luis Fernández",
            Ingreso = 150.0m,
            Tipo = TipoTrabajador.Peon
        };

        var gerente = new Trabajador
        {
            Nombre = "Sofía Martínez",
            Ingreso = 500.0m,
            Tipo = TipoTrabajador.Gerente
        };

        // Crear lista de ITrabajador
        var trabajadores = new List<ITrabajador>
        {
            jefeEquipo,
            peon1,
            peon2,
            gerente
        };

        // Crear equipos
        var equipo1 = new Equipo
        {
            JefeEquipo = jefeEquipo,
            Peones = trabajadores.Where(t => t.Tipo == TipoTrabajador.Peon).ToList(),
            Gasto = 650.0m
        };

        // Crear venenos
        var veneno1 = new Veneno
        {
            Nombre = "Cianuro",
            UnidadMedida = UnidadMedida.Gramos,
            CostoUnidad = 1.0m,
            Cantidad = 10.0m
        };

        var veneno2 = new Veneno
        {
            Nombre = "Insecticida",
            UnidadMedida = UnidadMedida.Mililitros,
            CostoUnidad = 2.5m,
            Cantidad = 50.0m
        };

        // Crear lista de IVeneno
        var venenos = new List<IVeneno>
        {
            veneno1,
            veneno2
        };

        // Crear servicios
        var servicio1 = new Servicio
        {
            Cliente = cliente1,
            Equipo = equipo1,
            Venenos = venenos,
            Ingreso = 1000.0m,
            Gasto = 800.0m
        };

        var servicio2 = new Servicio
        {
            Cliente = cliente2,
            Equipo = equipo1,
            Venenos = new List<IVeneno> { veneno2 },
            Ingreso = 1500.0m,
            Gasto = 1200.0m
        };

        // Crear empresa
        var empresa = new Empresa();
        empresa.AgregarServicio(servicio1);
        empresa.AgregarServicio(servicio2);
        empresa.AgregarTrabajador(jefeEquipo);
        empresa.AgregarTrabajador(peon1);
        empresa.AgregarTrabajador(peon2);
        empresa.AgregarTrabajador(gerente);
        empresa.AgregarVeneno(veneno1);
        empresa.AgregarVeneno(veneno2);
        empresa.AgregarRecurso(new Recurso { Nombre = "Furgoneta", CostoServicio = 20.0m });
        empresa.AgregarRecurso(new Recurso { Nombre = "Coche", CostoServicio = 15.0m });
        empresa.AgregarRecurso(new Recurso { Nombre = "Mascarillas", CostoServicio = 2.0m });

        // Calcular resultados
        var ingresoTotal = empresa.CalcularIngresoTotal();
        var gastoTotal = empresa.CalcularGastoTotal();
        var resultado = empresa.CalcularResultado();

        Console.WriteLine($"Ingreso total: {ingresoTotal:C}");
        Console.WriteLine($"Gasto total: {gastoTotal:C}");
        Console.WriteLine($"Resultado: {resultado:C}");
    }
}