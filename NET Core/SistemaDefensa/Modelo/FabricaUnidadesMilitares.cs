namespace SistemaDefensa.Modelo;

public abstract class FabricaUnidadesMilitares
{
    public static IUnidadMilitar CrearUnidad(string tipo)
    {
        switch (tipo)
        {
            case "Transporte":
                return CrearTransporte();
            case "TanqueAtaque":
                return CrearTanqueAtaque();
            case "TransporteRapido":
                return CrearTransporteRapido();
            case "Sanitario":
                return CrearSanitario();
            case "CanionAntiaereo":
                return CrearCanionAntiaereo();
            case "TorpedoMovil":
                return CrearTorpedoMovil();
            case "Canion":
                return CrearCanion();
            case "InfanteriaBasica":
                return CrearInfanteriaBasica();
            case "Ametrallador":
                return CrearAmetrallador();
            default:
                throw new Exception("Tipo de unidad militar no válido.");
        }
    }

    protected static IUnidadMilitar CrearTransporte()
    {
        return new Transporte();
    }

    protected static IUnidadMilitar CrearTanqueAtaque()
    {
        return new TanqueAtaque();
    }

    protected static IUnidadMilitar CrearTransporteRapido()
    {
        return new TransporteRapido();
    }

    protected static IUnidadMilitar CrearSanitario()
    {
        return new Sanitario();
    }

    protected static IUnidadMilitar CrearCanionAntiaereo()
    {
        return new CanionAntiaereo();
    }

    protected static IUnidadMilitar CrearTorpedoMovil()
    {
        return new TorpedoMovil();
    }

    protected static IUnidadMilitar CrearCanion()
    {
        return new Canion();
    }

    protected static IUnidadMilitar CrearInfanteriaBasica()
    {
        return new InfanteriaBasica();
    }

    protected static IUnidadMilitar CrearAmetrallador()
    {
        return new Ametrallador();
    }
}