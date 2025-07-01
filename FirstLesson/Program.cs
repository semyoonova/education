namespace FirstLesson;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(IsPolindrom(1221));
    }
	static int Calculate(int number) 
	{
		return number%10 + number%100/10 + number/100;
	}
	static char NextChar(char simbol) 
	{
		int numberOfChar = simbol+1;
		return (char) numberOfChar;
	}
	static bool IsPolindrom(int number)
	{
		return (number/1000 == number%10 && number%100/10 == number%1000/100);
	}
	
	
	
}

