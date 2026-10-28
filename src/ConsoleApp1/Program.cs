int a, b, c;
Console.Write("Escribe el valor de a: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Escribe el valor de b: ");
b= Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Los valores originales son: {a} y {b}");

//proceso
c = a;
a = b;
b = a;
//Salida
Console.WriteLine($"Los valores intercambiados son: {c} y {a}");

