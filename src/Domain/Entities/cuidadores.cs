namespace Domain.Entities
{
    using System;
    using Domain.Abstractions;

    public sealed class Cuidadores : Entity<Guid>
    {
        private Cuidadores(Guid id, string nombre, string especialidad, int edad, Guid zoologicoId) : base(id)
        {
            Nombre = nombre;
            Especialidad = especialidad;
            Edad = edad;
            ZoologicoId = zoologicoId;
        }

        // Constructor for EF Core
        private Cuidadores() { }

        public string Nombre { get; private set; } = "";
        public string Especialidad { get; private set; } = "";
        public int Edad { get; private set; } = 0;
        public Guid ZoologicoId { get; private set; }

        

        public static Cuidadores Create(string nombre, string especialidad, int edad, Guid zoologicoId)
        {
            var id = Guid.NewGuid(); // Generar un nuevo Guid para el id
            var cuidadores = new Cuidadores(id, nombre, especialidad, edad, zoologicoId);
            return cuidadores;
        }
    }
}
