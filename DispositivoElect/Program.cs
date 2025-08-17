using DispositivoElect;

Telefono telefono = new Telefono();
telefono.Marca = "Samsung";
telefono.Modelo = "Galaxy S23";
telefono.EstaEncendido = true;

Laptop laptop = new Laptop();
laptop.Marca = "Dell";
laptop.Modelo = "XPS 15";
laptop.EstaEncendido = false;
laptop.NivelBateria = 45;


telefono.MostrarEstado();
laptop.MostrarEstado();
Console.WriteLine("Encendiendo el dispositivo...");
Console.WriteLine();

telefono.Encender();
laptop.Encender();
Console.WriteLine();

telefono.MostrarEstado();
laptop.MostrarEstado();
Console.WriteLine("Apagando el dispositivo...");
Console.WriteLine();

telefono.Apagar();
laptop.Apagar();
Console.WriteLine();

telefono.MostrarEstado();
laptop.MostrarEstado();




