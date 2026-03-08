Random random = new Random();
int n = random.Next(1, 101);
int popitka = 0;
Console.WriteLine("Угадай число от 1 до 100");
int ch = 0;
while (ch != n)
{
    Console.Write("Введите число: ");
    ch = Convert.ToInt32(Console.ReadLine());
    popitka++;
    if (ch > n)
    {
        Console.WriteLine("Больше");
    }
    else if (ch < n)
    {
        Console.WriteLine("Меньше");
    }
    
}
Console.WriteLine("Вы угадали!");
Console.WriteLine("Попыток: " + popitka);