namespace ArraysLoopsStringsLesson;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(GetFactorial(100000));
		
    }
	static int GetFactorial(int n)
	{
		return n > 1 ? n * GetFactorial(n - 1) : 1;
	}
	static int GetFactorialLoops(int n)
	{
		int f = 1;
		for (int i=1; i<=n; i++)
		{
			f=f*i;
		}
		return f;
	}
}
