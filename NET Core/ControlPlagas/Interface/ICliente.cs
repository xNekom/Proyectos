﻿namespace ControlPlagas.Interface;

public interface ICliente
{
    string NombreCompleto { get; set; }
    string Telefono { get; set; }
    string Email { get; set; }
    string CodigoPostal { get; set; }
}