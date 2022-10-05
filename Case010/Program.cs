Console.WriteLine ("Введите число");
string value = Console.ReadLine();
int a = int.Parse(value);
int c = a%100;
int d = c/10;
Console.Write ("Вторая цифра трехзначного числа " + d);

//второй вариант
//Console.WriteLine ("Введите число");
//string value = Console.ReadLine().ToString();
//Console.Write ("Вторая цифра трехзначного числа " + value[1]);
