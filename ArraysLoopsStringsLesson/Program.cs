namespace ArraysLoopsStringsLesson;

class Program
{
    static void Main(string[] args)
    {
		
		int[] array = new int[] {9,9,9,9};
		UpdateArray(array);
		Console.WriteLine(string.Join(", ", array));
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
	
	static bool CheckThreeAndFiveCombination(int number)
	{
		if (number == 3 || number == 5)
		{
			return true;
		}
		
		return number % 3 == 0 
			? CheckThreeAndFiveCombination(number / 3) 
			: number % 5 == 0 
				? CheckThreeAndFiveCombination(number / 5)
				: false;
	}
	
	static void DivadedEight (uint number)
	{
		for (int i = 8; i <= number; i += 8)
		{
			Console.WriteLine(i);
		}
	}
	
	static int[] PlusOneInArray(int[] array)
	{
		for (int i = array.Length - 1; i >= 0; i--)
		{
			if (array[i] != 9)
			{
				array[i] = array[i] + 1;
				return array;
			}
			else 
			{
				array[i] = 0;
			}	
		}
		int[] newArray =  new int[array.Length + 1];
		newArray[0] = 1;
		return newArray;
	}	
	
	static void UpdateArray(int[] array)
	{
		for (int i = array.Length - 1; i >= 0; i--)
		{
			if (array[i] % 2 != 0)
			{
				array[i]++;
			}
		}
	}
}
