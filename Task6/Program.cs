Console.WriteLine("Введите число:");
int a1 = Convert.ToInt32(Console.ReadLine());

if ( a1% 2 == 1)
{
    Console.WriteLine("Число " +  a1 + " является: нечетным ");
}
else
{
    Console.WriteLine("Число " +  a1 + "является: четным ");
}
Console.ReadKey();
