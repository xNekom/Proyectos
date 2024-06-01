namespace GestionVentasOrdenadores.Modelo;

// Clase base Ordenador
public abstract class Ordenador
{
    public Ordenador(int precio, int ram, int almacenamiento)
    {
        this.precio = precio;
        this.ram = ram;
        this.almacenamiento = almacenamiento;
    }

    public int precio { get; protected set; }
    public int ram { get; protected set; }
    public int almacenamiento { get; protected set; }

    public virtual string Descripcion()
    {
        return $"Ordenador: Precio={precio}, RAM={ram}, Almacenamiento={almacenamiento}";
    }
}

// Clase Ordenador base
public class OrdenadorBase : Ordenador
{
    public OrdenadorBase() : base(100, 10, 100)
    {
    }
}

// Decorador RAM Máxima
public class DecoradorRAMMaxima : Ordenador
{
    private readonly Ordenador ordenador;

    public DecoradorRAMMaxima(Ordenador ordenador) : base(ordenador.precio + 200, 100, ordenador.almacenamiento)
    {
        this.ordenador = ordenador;
    }

    public override string Descripcion()
    {
        return $"{ordenador.Descripcion()} (RAM Máxima)";
    }
}

// Decorador Disco Sólido
public class DecoradorDiscoSolido : Ordenador
{
    private readonly Ordenador ordenador;

    public DecoradorDiscoSolido(Ordenador ordenador) : base(ordenador.precio + 100, ordenador.ram,
        ordenador.almacenamiento * 2)
    {
        this.ordenador = ordenador;
    }

    public override string Descripcion()
    {
        return $"{ordenador.Descripcion()} (Disco Sólido)";
    }
}

// Decorador A Ver si Cuela
public class DecoradorAVersiCuela : Ordenador
{
    private readonly Ordenador ordenador;

    public DecoradorAVersiCuela(Ordenador ordenador) : base(ordenador.precio * 2, ordenador.ram,
        ordenador.almacenamiento)
    {
        this.ordenador = ordenador;
    }

    public override string Descripcion()
    {
        return $"{ordenador.Descripcion()} (A Ver si Cuela)";
    }
}