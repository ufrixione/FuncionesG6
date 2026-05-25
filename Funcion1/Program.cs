//Crear un menu de pciones para el usuario doinde pueda elegeri 
// la siguientes opciones
//1. sumar dos numeros
//2. restar dos numeros
//3. multiplicar dos numeros
//4. dividir dos numeros
//5. Salir
int num1, num2, resultado, opcion;


int menu(int opcion);
{
    Console.WriteLine("Seleccione una opcion:");
    Console.WriteLine("1. Sumar dos numeros");
    Console.WriteLine("2. Restar dos numeros");
    Console.WriteLine("3. Multiplicar dos numeros");
    Console.WriteLine("4. Dividir dos numeros");
    Console.WriteLine("5. Salir");
    opcion = Convert.ToInt32(Console.ReadLine());
    return opcion;
}
