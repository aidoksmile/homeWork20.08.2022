// Выяснить, кратно ли число заданному, если нет, вывести остаток

int n = new Random().Next(1,99);
Console.Write("Заданное число: ");
Console.WriteLine(n);
Console.Write("Введите число для проверки кратности: ");
int a = int.Parse(Console.ReadLine());
if (n % a == 0)
{
    Console.WriteLine("Заданное число кратно введеному числу");
}
else
{
    Console.Write("Заданное число не кратно введеному числу. Остаток равен: ");
    Console.WriteLine(n % a);
}