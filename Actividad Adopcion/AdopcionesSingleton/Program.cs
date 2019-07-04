using System;

namespace AdopcionesSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Datos datos1 = Datos.GetInstancia();
            Program program = new Program();
            datos1.ListaPerros.Add(new Perro() { Id = 1, Nombre = "perro #1", Edad=1});
            datos1.ListaPerros.Add(new Perro() { Id = 2, Nombre = "perro #2", Edad=2 });
            datos1.ListaPerros.Add(new Perro() { Id = 3, Nombre = "perro #3", Edad=3 });
            datos1.ListaPerros.Add(new Perro() { Id = 4, Nombre = "perro #4", Edad=4 });
            datos1.ListaPerros.Add(new Perro() { Id = 5, Nombre = "perro #5", Edad=5});
            program.perroA(datos1);
            

            foreach(Perro perro in datos1.ListaPerros)
            {
                Console.WriteLine("Id= " + perro.Id + " Nombre: " + perro.Nombre + " Edad: "+ perro.Edad);
            }
            Console.Read();
        }


         void perroA (Datos datos1)
        {
            datos1.ListaPerros.Add(new Perro() { Id = 1, Nombre = "perro #6", Edad=3 });
            datos1.ListaPerros.Add(new Perro() { Id = 2, Nombre = "perro #7", Edad=2 });
            datos1.ListaPerros.Add(new Perro() { Id = 3, Nombre = "perro #8",Edad=1 });
            datos1.ListaPerros.Add(new Perro() { Id = 4, Nombre = "perro #9", Edad=4 });
            datos1.ListaPerros.Add(new Perro() { Id = 5, Nombre = "perro #10", Edad=5 });
        }
    }
}
