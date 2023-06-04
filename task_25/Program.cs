Console.Clear();
Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine());

double Power(int n1, int n2)
{
   
    return Math.Pow(n1,n2);
}
Console.WriteLine(Power(num1,num2));