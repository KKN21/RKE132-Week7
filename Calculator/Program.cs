using System.Numerics;

Console.WriteLine("Enter the operation (+/-)");
char userOperator = Char.Parse(Console.ReadLine());

Console.WriteLine("Enter X");
int firstNum = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter Y");
int secondNum = Int32.Parse(Console.ReadLine());

switch (userOperator)
{
    case '+':
        Addition(firstNum, secondNum);
        break;
    case '-':
        Subtraction(firstNum, secondNum);
        break;
    default:
        Console.WriteLine("invalid operator");
        break;

}

static void Addition(int X, int Y)
{
    Console.WriteLine($"{X} + {Y} = {X + Y}");
}

static void Subtraction(int X, int Y)
{
    Console.WriteLine($"{X} - {Y} = {X - Y}");
}
