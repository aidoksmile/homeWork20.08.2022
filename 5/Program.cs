// Показать четные числа от 1 до N

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());
int count = 1;
while (count <= n)
{
    if (count % 2 == 0)
    {
        Console.Write(" " + count);
    }
    count = count + 1;
}
Console.WriteLine();