namespace Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using Domain.Abstractions;

    public sealed class Zoologico : Entity<Guid>
    {
        private Zoologico(Guid id, string nombre, string ubicacion, string rfc, Guid animalesId, Animales animales) : base(id)
        {
            Nombre = nombre;
            Ubicacion = ubicacion;
            RFC = rfc;
            AnimalesId = animalesId;
            Animales = animales; 
            _cuidadores = new List<Cuidadores>();
        }

        // Constructor privado para EF Core
        
        private readonly List<Cuidadores> _cuidadores;

        public string Nombre { get; private set; } = "";
        public string Ubicacion { get; private set; } = "";
        public string RFC { get; private set; } = "";
        public Guid AnimalesId { get; private set; }

        public Animales Animales { get; private set; }

        // Exponer colecciones hijas
        public IReadOnlyCollection<Cuidadores> Cuidadores => _cuidadores;

        public static Zoologico Create(string nombre, string ubicacion, string rfc, Guid animalesId, Animales animales)
        {
            var id = Guid.NewGuid(); 
            var zoologico = new Zoologico(id, nombre, ubicacion, rfc, animalesId, animales);
            return zoologico;
        }

        
    }
}
