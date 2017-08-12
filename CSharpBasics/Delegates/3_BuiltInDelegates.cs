using System;
using CSharpBasics.Delegates.Models;

namespace CSharpBasics.Delegates
{

	/* Topic: Built-in system delegates
	 * 
	 * <Tr> Func <T, Tr>	
	 * Input of type T, return of type Tr
	 * Overloaded to have 0-16 input parameters.						
	 * 
	 * void Action <T>
	 * Input 1 or more params of type T, return void
	 * 
	 * 
	 * bool Predicate <T>:
	 * Used to verify a criteria of method, returns bool
	 * Typically used to find elements in a collection that satify a criteria
	 * 
	 * 
	 */

	public enum BuiltInDelegateOption {
		FuncBasic,
		FuncParameterized,
		Action,
		Predicate
	}
	public class BuiltInDelegates
	{

		public void Execute(BuiltInDelegateOption option) {

			switch (option) {
			case BuiltInDelegateOption.FuncBasic:
				BasicFuncDelegate (100, 20);
				break;
			case BuiltInDelegateOption.FuncParameterized:
				ParameterizedFuncDelegate ();
				break;
			case BuiltInDelegateOption.Action:
				BasicActionDelegate ();
				break;
			case BuiltInDelegateOption.Predicate:
				PredicateExample ();
				break;
			}
		}

		#region Func Delegate

		public void BasicFuncDelegate (int x, int y)
		{
			int num1 = 10, num2 = 20;
			Func<int,int, int> func = Adder.Add;
			int iResult = func(num1, num2);

			Console.WriteLine ("BasicFuncDelegate: {0} + {1} = {2}", num1, num2, iResult);

			//Func<double, double, double> func1 = (double a, double b) => { return a + b ;};
			//float fResult = func1(1.1,2.2);
		}


		public static void ParameterizedFuncDelegate()
		{
			Func<string, int, string[]> extractMethod = ExtractWords;
			string title = "Farmville Tropic Escape";


			Console.WriteLine("ParameterizedFuncDelegate:  Words are -");
			foreach (string word in extractMethod(title, 5))
				Console.WriteLine(word);
		}
			

		private static string[] ExtractWords(string phrase, int limit)
		{
			char[] delimiters = new char[] {' '};
			if (limit > 0)
				return phrase.Split(delimiters, limit);
			else
				return phrase.Split(delimiters);
		}

		#endregion


		#region Action Delegate 

		public void BasicActionDelegate(){

			Action<string> action = PrintLog;  

			if (action != null) {
				action ("Hello World!!"); 
			}
		}

		private void PrintLog(string message) {
			Console.WriteLine ("BasicActionDelegate: Logger message: {0}", message);
			Console.WriteLine ();
		}

		#endregion

		#region Predicate Delegate

		public void PredicateExample() {
			
			Point[] points = { new Point (100, 200), 
				new Point (150, 250), new Point (250, 375), 
				new Point (275, 395), new Point (295, 450)
			};

			Predicate<Point> predicate = FindPoints;

			// Find the first Point structure for which X times Y is greater than 100000. 
			Point first = Array.Find (points, predicate);

			Console.WriteLine ("PredicateExample: Points Found: X = {0}, Y = {1}", first.X, first.Y);
		}

		private bool FindPoints(Point obj) {
			return obj.X * obj.Y > 100000;
		}

		#endregion
	}
}

