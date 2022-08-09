// принимаем на вход 2 числа и выдаем наибольшее

System.Console.WriteLine("Ведите первое число: ");
int n_1 = int.Parse(System.Console.ReadLine());
System.Console.WriteLine("Ведите второе число: ");
int n_2 = int.Parse(System.Console.ReadLine());

if (n_1 < n_2 || n_1 != n_2){
    System.Console.WriteLine($"Наибольшее число - {n_2}");
}
else if (n_1 > n_2 || n_1 != n_2) {
    System.Console.WriteLine($"Наибольшее число - {n_1}");
}
else {
    System.Console.WriteLine("Они равны");
}
