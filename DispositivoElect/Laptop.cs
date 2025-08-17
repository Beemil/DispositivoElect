

namespace DispositivoElect
{
    public class Laptop : IDispositivoElectronico
    {
        public String Marca { get; set; }
        public String Modelo { get; set; }
        public bool EstaEncendido { get; set; }
        public int NivelBateria { get; set; }

        public void Encender()
        {
            EstaEncendido = true;
            Console.WriteLine($"La laptop {Marca} {Modelo} está encendida.");
        }

        public void Apagar()
        {
            EstaEncendido = false;
            Console.WriteLine($"La laptop {Marca} {Modelo} está apagada.");
        }

        public void MostrarEstado()
        {
            string estado;
            if (EstaEncendido)
            {
                estado = "encendida";
            }
            else
            {
                estado = "apagada";
            }
            Console.WriteLine($"La laptop {Marca} {Modelo} está {estado} y su nivel de batería es {NivelBateria}%.");
        }
    }
}
