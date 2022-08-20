// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int n = new Random().Next(10,99);
Console.Write("Данное число: ");
Console.WriteLine(n);
int a = n / 10;
int b = n % 10;
int max = 0;
if (a > b)
{
    max = a;
}
else
{
    max = b;
}
Console.Write("Наибольшая цифра числа: ");
Console.WriteLine(max);