using System;
using System.Linq.Expressions;

namespace CSharpBasics.ExpressionTree
{
	public class ExpressionTreesExample
	{
		public void Execute ()
		{
			// Define the expression
			Expression<Func<int, int, int>> expression = (a,b) => a + b;

			// What is the expression
			Console.WriteLine("Param 1: {0}, Param 2: {1}", expression.Parameters[0], expression.Parameters[1]);
			BinaryExpression body = (BinaryExpression)expression.Body;
			ParameterExpression left = (ParameterExpression)body.Left;
			ParameterExpression right = (ParameterExpression)body.Right;
			Console.WriteLine(expression.Body);
			Console.WriteLine(" The left part of the expression: " +
				"{0}{4} The NodeType: {1}{4} The right part: {2}{4} The Type: {3}{4}",
				left.Name, body.NodeType, right.Name, body.Type, Environment.NewLine);

			// Compile expression
			int result = expression.Compile()(3, 5);
			Console.WriteLine(result);
		}
	}
}

