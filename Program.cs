Console.WriteLine("Введите число A");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите чило B");
int numB = Convert.ToInt32(Console.ReadLine());

if (numA>numB)
{
    Console.WriteLine("MAX число "+numA);
    Console.WriteLine("MIN число "+numB);
}
else
{
    Console.WriteLine("MAX число "+numB);
    Console.WriteLine("Min число "+numA);
}
