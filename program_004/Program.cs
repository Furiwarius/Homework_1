// принимает на вход 3 числа и выдает максимальное из этих чисел 
System.Console.WriteLine("Введите первое число: ");
int a = int.Parse(System.Console.ReadLine());

System.Console.WriteLine("Введите вротое число: ");
int b = int.Parse(System.Console.ReadLine());

System.Console.WriteLine("Введите третье число: ");
int c = int.Parse(System.Console.ReadLine());

int[] numbers = {a, b, c};
int max = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i]>max)
    {
        max = numbers[i];
    }
}

System.Console.WriteLine($"Из чисел {numbers[0]}, {numbers[1]}, {numbers[2]}");
System.Console.WriteLine($"число {max} является максимальным");


