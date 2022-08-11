// принимаем на вход число и выдаем все четные от 0 до выданного числа

System.Console.WriteLine("Введите число: ");
int number = int.Parse(System.Console.ReadLine());
int i = 0;
string[] rt = new string[number/2];
int Count_rt = 0;
while (i<= number)
{
    if (i%2==0) {
        if (i==0) {i++; continue;}
        else {
            rt[Count_rt] = i.ToString();
            Count_rt++;
        }
    }
    i++;
    
}
System.Console.WriteLine(String.Join(",", rt));