
Console.WriteLine("Enter num:");
string strNum1 = Console.ReadLine();

Console.WriteLine("Enter num:");
string strNum2 = Console.ReadLine();

int num1 = int.Parse(strNum1);
int num2 = int.Parse(strNum2);

int square  = num2 * num2;
if (square == num1)
{
Console.WriteLine($"Yes, the number {num1} is the square of the number {num2}");
}
else
{
    Console.WriteLine($"number {num1} is not a square of {num2}");
}