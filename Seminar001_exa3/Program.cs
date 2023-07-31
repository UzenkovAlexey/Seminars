Console.WriteLine("Enter number: ");

String strNum = Console.ReadLine();

int num = int.Parse(strNum);

int num1 = num * -1;

  while (num1 <= num)
  {
    Console.WriteLine(num1);
    num1 = num1+1;
  }
