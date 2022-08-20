// Найти третью цифру числа или сообщить, что её нет

int n = new Random().Next(1,999);
Console.Write("Заданное число: ");
Console.WriteLine(n);
if (n < 100)
{
    Console.WriteLine("В числе нет третьей цифры");
}
else
{
    Console.Write("Третья цифра в числе: ");
    Console.WriteLine(n % 10);
}