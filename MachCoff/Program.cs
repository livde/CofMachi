using System;

class Program
{
    static void Main(string[] args)
    {
        var maquinaDeCafe = new MaquinaDeCafe();
        
        Console.WriteLine("Bienvenido a la máquina de café.");
        Console.WriteLine("¿Hay café disponible? (si/no)");
        if (Console.ReadLine().ToLower() != "si") 
        {
            Console.WriteLine("Vuelva en un momento.");
            return;
        }

        // Selección de tipo de vaso
        Console.WriteLine("Seleccione el tamaño de vaso: pequeño, mediano, grande");
        var tipoVaso = Console.ReadLine().ToLower();
        var vasoSeleccionado = maquinaDeCafe.GetTipoDeVaso(tipoVaso);

        if (vasoSeleccionado == null || !vasoSeleccionado.HasVasos(1))
        {
            Console.WriteLine("No hay vasos disponibles.");
            return;
        }

        Console.WriteLine("Seleccione la cantidad de azúcar (gramos):");
        int cantidadAzucar = int.Parse(Console.ReadLine());

        if (!maquinaDeCafe.Azucarero.HasAzucar(cantidadAzucar))
        {
            Console.WriteLine("No hay suficiente azúcar.");
            return;
        }

        // Mostrar pedido
        var resultado = maquinaDeCafe.GetVasoDeCafe(vasoSeleccionado, 1, cantidadAzucar);
        Console.WriteLine(resultado);
    }
}
