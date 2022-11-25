
Console.WriteLine("Введите M");
int num1=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите N");
int num2=Convert.ToInt32(Console.ReadLine());
int sum=0;

PrintNumber(num1,num2);

Console.WriteLine($"{sum}");

void PrintNumber(int num1,int num2)
{
if (num1<=num2)
{
 sum=sum+num1;
num1++;
PrintNumber(num1,num2);
}
}


