// Показать вторую цифру трёхзначного числа

Console.WriteLine("Введите трехзначное число n: ");
int n = int.Parse(Console.ReadLine());
int secondNumber = (n / 10) % 10;
Console.Write("Второе число: ");
Console.WriteLine(secondNumber); 