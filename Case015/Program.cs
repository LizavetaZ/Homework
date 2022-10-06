Console.WriteLine ("Введите число");
string value = Console.ReadLine();
int a = int.Parse(value);
if (a==6 || a==7)
{
    Console.Write ("выходной");
}
else if (a>0 && a<6)
{
    Console.Write ("будний");
}
else 
{
    Console.Write ("ошибка");
}