namespace GestionVentasOrdenadores.Modelo;

// Implementación de Validador
public class Validador : IValidador
{
    public bool EsValido(int precio, int tiempoGarantia)
    {
        return precio > 0 && tiempoGarantia > 0;
    }
}