// Найти максимальное из трех чисел

Console.Write("Введите число 1: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Введите число 3: ");
int number3 = int.Parse(Console.ReadLine());
int max = 0;
if (number1 > number2) 
{
    max = number1;
}
else
{
    max = number2;
}
if (number3 > max) 
{
    max = number3;
}
Console.Write("Максимальное число = ");
Console.WriteLine(max);
