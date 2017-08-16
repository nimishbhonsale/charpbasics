using System;
using CSharpBasics.Delegates;
using CSharpBasics.Linq;
using CSharpBasics.ExpressionTree;

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

			new RestrictionAndProjection ().LinqOperatorsRestrictProjectExample ();
			Console.WriteLine("\n\n");

			new LambdaSyntax ().LinqOperatorsLambdaSyntax ();
			Console.WriteLine("\n\n");

			new PartitionAndElement ().LinqOperatorsPartitionAndElementExample ();
			Console.WriteLine("\n\n");

			new GroupByAndAggregates ().LinqOperatorsAggregateGroupByExample ();
			Console.WriteLine("\n\n");

			new OrderBy ().LinqOperatorsOrderByExample ();
			Console.WriteLine("\n\n");

			new Joins ().LinqOperatorsJoinExample ();
			Console.WriteLine("\n\n");


			// Expression Trees
			Console.WriteLine("========= EXPRESSION TREES EXAMPLES =========\n\n");
			Console.WriteLine("\n\n");
			(new ExpressionTreesExample()).Execute();

			// HttpWebRequest and REST API
			Console.WriteLine("========= HTTP WEB EXAMPLES =========\n\n");
			new HttpRequestExample ().Execute ();
			Console.WriteLine("\n\n");

		}
	}
}