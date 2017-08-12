using System;

namespace CSharpBasics.Delegates
{
	/* Topic: Anaonymous Method & Lambda operator
	 * 
	 * () inline method with no method name
	 * 
	 * => token is called the lambda operator
	 * 
	 * 
	 */
	public class AnonymousMethodAndLambda
	{
		public void Execute() {

			Calculate calc = (int n1, int n2) => {
				return n1 + n2;
			};

			int num1 = 10, num2 = 20;
			int result = calc(num1, num2);
			Console.WriteLine ("AnonymousMethodAndLambda: {0} + {1} = {2}", num1, num2, result);
		}
	}
}

