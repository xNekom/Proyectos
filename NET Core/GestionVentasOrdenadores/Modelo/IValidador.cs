namespace GestionVentasOrdenadores.Modelo;

// Interfaz IValidador
public interface IValidador
{
    bool EsValido(int precio, int tiempoGarantia);
}