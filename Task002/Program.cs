// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да 
//a = 2, b = 10 -> нет 
//a = 9, b = -3 -> да 
//a = -3 b = 9 -> нет

Console.WriteLine("a: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("b: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine($"{Math.Pow(b,2) == a}");
if(Math.Pow(b,2) == a){
    Console.WriteLine("a квадрат b");
}else
{
    Console.WriteLine("a не квадрат b");
}
Console.WriteLine($"{a}, {b}");
