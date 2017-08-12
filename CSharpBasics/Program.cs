using System;
using CSharpBasics.Delegates;
using CSharpBasics.Linq;

namespace CSharpBasics
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// Delegates
			Console.WriteLine("========= DELEGATE EXAMPLES =========\n\n");
			new DelegateExamples().Execute(DelegateExample.Basic);
			Console.WriteLine("\n");

			new DelegateExamples().Execute(DelegateExample.AnonymousMethodAndLambda);
			Console.WriteLine("\n");

			new DelegateExamples().Execute(DelegateExample.BuiltInFunc);
			Console.WriteLine("\n");

			new DelegateExamples().Execute(DelegateExample.BuiltInAction);
			Console.WriteLine("\n");

			new DelegateExamples().Execute(DelegateExample.BuiltInPredicate);
			Console.WriteLine("\n");

			new DelegateExamples().Execute(DelegateExample.ExpressionTree);

			Console.WriteLine("\n\n");

			// Linq
			Console.WriteLine("========= LINQ EXAMPLES =========\n\n");
			Console.WriteLine("\n\n");

			// HttpWebRequest and REST API
			Console.WriteLine("========= HTTP WEB EXAMPLES =========\n\n");
			new HttpRequestExample ().Execute ();
			Console.WriteLine("\n\n");

		}
	}
}
