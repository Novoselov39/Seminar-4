Console.Clear();
Console.WriteLine("Введите первое число");
int num = int.Parse(Console.ReadLine());


int SumNum(int n)
{
    int sum =0;
   while (n>0)
   {
    sum=sum+(n%10);
    n=n/10;

   }
    return sum;
}
Console.WriteLine(SumNum(num));