// принимаем на вход число и выдаем True если оно четное, False нечетное

System.Console.WriteLine("Введите число: ");
int number = int.Parse(System.Console.ReadLine());

if (number%2 == 0) System.Console.WriteLine(true);
else System.Console.WriteLine(false);
