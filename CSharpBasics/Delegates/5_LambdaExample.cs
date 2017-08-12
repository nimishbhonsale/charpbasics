using System;

namespace CSharpBasics
{

	/* Topic: Lambda operator
	 * 
	 * => token is called the lambda operator
	 * 
	 * 
	 */

	public class LambdaExample
	{
		public void Execute(){
			string message = string.Empty;

			(string name, int age) => {
				message = string.Format("Name is: {0} and age is : {1}",name,age);
			};
			Console.WriteLine("Print message: {0}",message);
		}
	}
}

