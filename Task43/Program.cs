//Задача 43: Напишите программу, которая найдёт точку пересечения 
//двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Найдем точку пересечения двух прямых с помощью уравнения y = k1 * x + b1, y = k2 * x + b2; ");
Console.WriteLine("Введите значения для уравнения ");
Console.Write("b1 =  ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("k1 =  ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("b2 =  ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("k2 =  ");
double k2 = Convert.ToDouble(Console.ReadLine());
//y = k1 * x + b1, y = k2 * x + b2;
if ((b1 == b2) && (k1 == k2))
{
    Console.WriteLine("Прямые совподают!");
}
else if (b1 == b2)
{
    Console.WriteLine("Прямые параллельны!");

}
else
{
    double X = (b2 - b1) / (k1 - k2);
    double Y = (k1 * (b2 - b1)) / (k1 - k2) + b1;
    Console.WriteLine($"({X},{Y})");
}



