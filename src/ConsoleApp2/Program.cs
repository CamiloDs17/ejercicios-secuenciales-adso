//Definicion de las variables
int a, b;
Console.Write("Escribe el primer valor: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Escribe el segundo valor: ");
b = Convert.ToInt32(Console.ReadLine());
//Proceso
a = a + b;
b = a - b;
a = a - b;

//Salida
Console.WriteLine($"Los valores intercambiados son = {a} {b}");

