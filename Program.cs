using responsabilidad__SRP_;

class Program
{
    static void Main(string[] args)
    {
        Persona persona = new Persona("Juan Perez", 30, "Calle Falsa 123", "juan.perez@example.com");

        Impresora Impresora = new Impresora();
        Impresora.ImprimirDatos(persona);

        EmailService emailService = new EmailService();
        emailService.EnviarCorreoElectronico("Hola Juan, este es un mensaje de prueba.", persona.GetCorreoElectronico());
    }
}
