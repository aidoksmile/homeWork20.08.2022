// Удалить вторую цифру трёхзначного числа

Console.WriteLine("Введите трехзначное число n: ");
int n = int.Parse(Console.ReadLine());
int firstNumber = n / 100;
int lastNumber = n % 10;
Console.Write("При удалении второй цифры получаем число: ");
Console.WriteLine(firstNumber * 10 + lastNumber); 