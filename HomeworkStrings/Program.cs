namespace HomeworkStrings;

class Program
{
    static void Main(string[] args)
    {
		int[] array = new int[] {6, 5, 1, 9, 0, 3, 4};
		//Console.WriteLine(array.Sum());
		//Console.WriteLine(array.Max());
		//Console.WriteLine(NumOfEven(array));
		//char[] charArray = ['a', 'b', 'e', ' ', 'i'];
		//Console.WriteLine(NumOfVowels(charArray));
		//Console.WriteLine(Array.IndexOf(charArray , ' '));
		//bool[] boolArray = [true, true, true, false];
		//Console.WriteLine(Array.Exists(boolArray, i=> i==false));
		//string[] stringArray = GetWinners(array);
		//Console.WriteLine(string.Join(", ", stringArray));
		//Console.WriteLine(string.Join(", ", array));
		//Array.Sort(array);
		//Console.WriteLine(string.Join(", ", array));
		//Console.WriteLine(GetIndex(array, 5));
		//decimal[] prices = new decimal[] {1234.3456m, 123.456m, 87654.345m, 98765.345m};
		//Console.WriteLine(GetProfit(prices));
		string input = "Это   строка    с   лишними  пробелами."; 
		//Console.WriteLine(DeleteSpace(input));
		//ReverseWords(input);
		//Console.WriteLine(DeleteSimbols(input));
		//Console.WriteLine(ChangeToWordsUpperRegister(input));
		Console.WriteLine(NumOfWords(input));
    }
	
	static int NumOfEven(int[] array)
	{
		int result = 0;
		
		for (int i = 0; i < array.Length; i++)
		{
			result = i % 2 == 0 ? result + 1 : result;
		}
		
		return result;
	}
	
	static int NumOfVowels(char[] array)
	{
		int result = 0;
		
		for (int i = 0; i < array.Length; i++)
		{
			switch (array[i])
			{
				case 'a':
				case 'e':
				case 'o':
				case 'i':
				case 'u':
				case 'A':
				case 'O':
				case 'I':
				case 'U':
				case 'E':
				{
					result++;
					break;
				}
			}
		}
		
		return result;
	}
	
	static string[] GetWinners(int[] array)
	{
		Array.Sort(array);
		Array.Reverse(array);
		string[] result = new string[array.Length];
		
		for (int i = 0; i < 3; i++)
		{
			result[i] = $"{i+1} место";
		}
		
		for (int i = 3; i < array.Length; i++)
		{
			result[i] = $"{array[i]}";
		}
		
		return result;
	}
	
	static (int[] lessArr, int[] moreArr) Partition(int[] array)
	{
		int index = array.Length / 2;
		int[] lessArr = new int[index];
		int[] moreArr = new int[array.Length-index];
		Array.Copy(array, 0, lessArr, 0, index);
		Array.Copy(array, index, moreArr, 0, array.Length-index);
		return (lessArr, moreArr);
	}
	
	static int GetIndex(int[] array, int value)
	{
		if (value == 0)
		{
			return 0; 
		}
		
		int index = 0;
		
		while (array.Length / 2 != 0)
		{
			if (value <= array[array.Length / 2])
			{
				var parts = Partition(array);
				array = parts.lessArr;
			}
			else 
			{
				index += array.Length / 2;
				var parts = Partition(array);
				array = parts.moreArr;
			}
		}
		
		if (value == array[0])
		{
			index++;
		}
		
		if (value > array[0])
		{
			index++;
		}
		
		return index;	
	}

	static decimal GetProfit(decimal[] prices)
	{
		decimal max = 0;
		
		for (int i = 0; i < prices.Length; i++)
		{
			max = prices[i] > max ? prices[i] : max;
		}
		
		decimal min = max;
		
		for (int i = 0; i < prices.Length; i++)
		{
			min = prices[i] < max ? prices[i] : min;
		}
		return max - min;
	}

	static string DeleteSpace(string input)
	{
		while (input.Contains("  "))
		{
			input = input.Replace("  ", " ");
		}
		
		return input;
	}

	static string ReverseWords(string input)
	{
		input = DeleteSpace(input);
		string[] words = input.Split(' ');
		
		for (int i = 0; i < words.Length; i++)
		{
			string word = words[i];
			int length = word.Length;
			
			for (int j = 0; j < length / 2; j++)
			{
				string leftLetter = word[j].ToString();
				string rightLetter = word[length - j - 1].ToString();
				word = word.Remove(0 + j, 1);
				word = word.Remove(length - j - 2, 1);
				word = word.Insert(j, rightLetter);
				word = word.Insert(length - j- 1, leftLetter);
				words[i] = word;
			}
		}
		
		return String.Join(" ", words);
	}

	static string DeleteSimbols(string input)
	{
		char[] simbols = input.ToCharArray();
		
		for (int i = 0; i < simbols.Length; i++)
		{
			int number = (int)simbols[i];
			
			if (number < 32 || (number > 32 && number < 65)
				|| (number > 65 && number < 97)
				|| (number > 90 && number < 97)
				|| (number > 122 && number < 192))
			{
				input = input.Remove(input.IndexOf(simbols[i]), 1);
			}
		}
		
		return input;
	}

	static string ChangeToWordsUpperRegister(string input)
	{
		input = input.ToLower();
		input = DeleteSpace(input);
		string[] words = input.Split(' ');
		
		for (int i = 0; i < words.Length; i++)
		{
			int numberOfLetter = (int) words[i][0];
			char UpperFirstLetter = (char) (numberOfLetter - 32);
			
			words[i] = words[i].Remove(0, 1);
			words[i] = words[i].Insert(0, UpperFirstLetter.ToString());
		}
		
		return String.Join(" ", words);
	}
	
	static int NumOfWords(string input)
	{
		input = DeleteSpace(input);
		return input.Split(' ').Length;
	}
}
