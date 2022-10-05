Console.WriteLine ("Введите число");
string value = Console.ReadLine();
int a = int.Parse(value);
int b = a/100;
if (Math.Abs(b) < 1)
{
    Console.Write ("третьей цифры нет");
}
else
{
    if (a>0)
    {
        string c = a.ToString();
        Console.Write ("третья цифра " + c[2]);
    }
    else 
    {
        string c = a.ToString();
        Console.Write ("третья цифра " + c[3]);
    }
}
