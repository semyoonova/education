namespace Homework;

class Program
{
    static void Main(string[] args)
    {
		//Console.WriteLine("Введите делитель: ");
		//int number1 = int.Parse(Console.ReadLine());
		//Console.WriteLine("Введите делимое: ");
		//double number2 = double.Parse(Console.ReadLine());
		//try
		//{
		//    Console.WriteLine(Divide(number1, number2));
		//}
		//catch (ArgumentException)
		//{
		//    Console.WriteLine("На ноль делить нельзя");
		//}
		//Console.WriteLine("Введите число для округления: ");
		//double number3 = double.Parse(Console.ReadLine());
		//Console.WriteLine(RoundAndCheck(number3));
		//Console.WriteLine("Введите номер символа (от 0 до 255): ");
		//byte number4 = byte.Parse(Console.ReadLine());
		//Console.WriteLine(ConvertToChar(number4));
		//int x1 = 5;
		//int y1 = 5;
		//int x2 = 7;
		//int y2 = 4;
		//IsMainChess(x1, y1, x2, y2);
		//Greet();
		//DetermineSesson();
		//CompareZero();
		//IsTriangle();
    }
}



static double Divide(int a, double b)
{
    if (b == 0)
    {
        throw new ArgumentException();
    }
    return a / b;
}
static int? RoundAndCheck(double value)
{
    int rounded;
    try
    {
        checked {
        rounded = (int)Math.Round(value);
        }
        return rounded;
    }
    catch (OverflowException)
    {
       Console.WriteLine("Число выходит за рамки допустимых значений");
       return null;
    }   
}
static char ConvertToChar(byte number)
{
    return (char)number;
}
static void IsMainChess(int x1, int y1, int x2, int y2)
{
    List<string> result = new List<string>() {"Король", "Ферзь", "Ладья", "Слон", "Конь"};
    int x = Math.Abs(x1 - x2);
    int y = Math.Abs(y1 - y2);
    if (x>1||y>1)
    {
        result.Remove("Король");
    }
    if (x==y || x1 == x2 || y1 == y2)
    {
        result.Remove("Конь");
        if (x!=y)
        {
            result.Remove("Слон");
        }
        else
        {
            result.Remove("Ладья");
        }
    }
    else
    {
        result.Remove("Ферзь");
        result.Remove("Ладья");
        result.Remove("Слон");
        if (x>2||y>2)
        {
            result.Remove("Конь");
        }
    }
    foreach (string chessPiece in result)
    {
        Console.WriteLine(chessPiece);
    }
}
static void Greet()
{
    int hour;
    Console.WriteLine("Введите час: ");
    try
    {
        hour = int.Parse(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("Что-то не так");
        Greet();
        hour = 27;
    }
    if (hour >= 6 && hour<=11)
    {
        Console.WriteLine("Доброе утро!");
    }
    else if (hour >= 12 && hour <= 17)
        {
        Console.WriteLine("Добрый день!");
        }
    else if (hour >= 18 && hour <= 22)
    {
        Console.WriteLine("Добрый вечер!");
    }
    else if (hour == 23 || hour <= 6)
    {
        Console.WriteLine("Доброй ночи!");
    }
    else
    {
        Console.WriteLine("Попоруйте еще раз");
        Greet();
    }
}
static void DetermineSesson()
{
    int mounth;
    Console.WriteLine("Введите номер месяца: ");
    try
    {
        mounth = int.Parse(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("Что-то не так");
        DetermineSesson();
        mounth = 27;
    }
    switch (mounth)
    {
        case 1: case 2: case 12:
            Console.WriteLine("Зима");
            break;
        case 3: case 4: case 5:
            Console.WriteLine("Весна");
            break;
        case 6: case 7: case 8:
            Console.WriteLine("Лето");
            break;
         case 9:case 10:case 11:
            Console.WriteLine("Осень");
            break;
    default:
        Console.WriteLine("Попоруйте еще раз");
        DetermineSesson();
        break;
    }
}
static void CompareZero()
{
    int? number;
    Console.WriteLine("Введите число: ");
    try
    {
        number = int.Parse(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("Что-то не так");
        CompareZero();
        number = null;
    }
    if (number == 0)
    {
        Console.WriteLine("Ноль");
    }
    else if (number > 0)
    {
        Console.WriteLine("Положительное");
    }
    else if (number < 0)
    {
        Console.WriteLine("Отрицательное");
    }
}
static void IsTriangle()
{

    uint [] lenghts = new uint [3];
    for (int i = 0; i < 3; i ++)
    {
        Console.WriteLine($"Введите длину {i+1} стороны: ");
        try
        {
            lenghts[i]=uint.Parse(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Что-то не так");
            break;
        }
    }
    Console.WriteLine( (lenghts[0] + lenghts[1] > lenghts[2] && lenghts[0] + lenghts[2] > lenghts[1] &&
        lenghts[2] + lenghts[1] > lenghts[0])? "Треугольник существует": "Треугольник не существует");
}