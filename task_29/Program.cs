Console.Clear();


int[] MassMethod()
{
// //[1,0,1,1,0,1,0,0]
    int[] n = new int[8];
    for (int i=0;i<8;i++)
    n[i] = new Random().Next(100);
   
       
    return n;
}
Console.Write("[");
Console.Write(String.Join(" ",MassMethod()));
Console.WriteLine("]");