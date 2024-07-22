
namespace responsabilidad__SRP_
{
    public class Persona
    {
        private string nombre;
        private int edad;
        private string direccion;
        private string correoElectronico;

        public Persona(string nombre, int edad, string direccion, string correoElectronico)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.direccion = direccion;
            this.correoElectronico = correoElectronico;
        }

        public string GetNombre() => nombre;
        public int GetEdad() => edad;
        public string GetDireccion() => direccion;
        public string GetCorreoElectronico() => correoElectronico;
    }
}
