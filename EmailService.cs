
namespace responsabilidad__SRP_
{
    public class EmailService
    {
        public void EnviarCorreoElectronico(string mensaje, string correoDestino)
        {
            // Lógica para enviar correo electrónico
            Console.WriteLine($"Enviando correo a {correoDestino}: {mensaje}");
        }
    }
}
