Console.WriteLine ("Введите число");
string value = Console.ReadLine();
int a = int.Parse(value);
int b = a/100;
if (b<1)
{
    Console.Write ("третьей цифры нет");
}
else
{
    string c = a.ToString();
    Console.Write ("третья цифра " + c[2]);
}
