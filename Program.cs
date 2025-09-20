Console.WriteLine("Введите номер месяца");
int a = Convert.ToInt32(Console.ReadLine());
if (a >= 1 & a <=2 | a == 12) {
    Console.WriteLine("зима");
}
else if (a >= 2 & a <= 5)
{
    Console.WriteLine("весна");
}
else if (a >= 5 & a <= 8)
{
    Console.WriteLine("лето");
}
else if (a >= 8 & a <= 11)
{
    Console.WriteLine("осень");
}
else
{
    Console.WriteLine("введен некорректный месяц");

}
