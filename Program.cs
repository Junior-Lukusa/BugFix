using System;
using System.Collections.Generic;

public class Program
{ 	
	public static bool isUserAuthorized(int max_tries, string secret_code)
	{
		List<string> alreadyEnteredCodes = new List<string>();
		int i = max_tries;

		while (i > 0)
		{
			Console.WriteLine($"i = {i}. Enter sercet code:");
			string code = Console.ReadLine();

			if( code == secret_code)
			{
				return true;
			}
			else if (alreadyEnteredCodes.Contains(code))
			{
				i -= 2;
			}
			else
			{
				alreadyEnteredCodes.Add(code);
				i -= 1;
			}
		}
		return false;
	}
	public static void Main(string[] args)
	{
		int MAX_TRIES = 10;
		string SECRET_CODE = "azerty";
		isUserAuthorized(MAX_TRIES, SECRET_CODE);
	}
}