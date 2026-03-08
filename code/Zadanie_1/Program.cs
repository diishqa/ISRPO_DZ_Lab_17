Console.Write("Введите вес: ");
double ves = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите рост: ");
double rost = Convert.ToDouble(Console.ReadLine());
double imt = ves/(rost*rost);
if (imt <18.5)
{
    Console.WriteLine("Недостаточный вес");
    Console.WriteLine("Ешьте больше");

}
else if (imt >=18.5 & imt <= 24.9)
{
    Console.WriteLine("Нормальный вес");
    Console.WriteLine("Все норм");
}
else if (imt >=25 & imt <= 29.9)
{
    Console.WriteLine("Избыточный вес");
    Console.WriteLine("Ешьте меньше");
}
else
{
    Console.WriteLine("Ожирение");
    Console.WriteLine("Худейте");
}