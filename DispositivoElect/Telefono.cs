

namespace DispositivoElect
{
    public class Telefono : IDispositivoElectronico
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public bool EstaEncendido { get; set; }

        public void Encender()
        {
            EstaEncendido = true;
            
            Console.WriteLine($"El teléfono {Marca} {Modelo} está encendido.");
        }

        public void Apagar()
        {
            EstaEncendido = false;
            
            Console.WriteLine($"El teléfono {Marca} {Modelo} está apagado.");
        }

        public void MostrarEstado()
        {
            string estado;

            if (EstaEncendido)
            {
                estado = "encendido";
            }
            else
            {
                estado = "apagado";
            }
               

            Console.WriteLine($"El teléfono {Marca} {Modelo} está {estado}.");
        }
    }
}
