namespace Domain.Entities
{
    using System;
    using Domain.Abstractions;

    public record Animales(
        string Nombre, 
        string Especie, 
        string Tipo, 
        int Edad);
}
