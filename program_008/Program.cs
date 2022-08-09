// принимаем на вход число и выдаем все четные от 0 до выданного числа

System.Console.WriteLine("Введите число: ");
int number = int.Parse(System.Console.ReadLine());
int i = 0;
string rt = "";
while (i<= number)
{
    if (i%2==0) {
        if (i==0) {i++; continue;}
        else if (rt=="") rt+=i;
        else rt+=", " + i;
    }
    i++;
    
}
System.Console.WriteLine(rt);