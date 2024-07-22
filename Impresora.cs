
namespace responsabilidad__SRP_
{
    public class Impresora
    {
        public void ImprimirDatos(Persona persona)
        {
            Console.WriteLine($"Nombre: {persona.GetNombre()}");
            Console.WriteLine($"Edad: {persona.GetEdad()}");
            Console.WriteLine($"Dirección: {persona.GetDireccion()}");
            Console.WriteLine($"Correo electrónico: {persona.GetCorreoElectronico()}");
        }
    }
}
