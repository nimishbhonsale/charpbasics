using System;
using CSharpBasics.Delegates.Models;

namespace CSharpBasics.Delegates
{
	/* Topic: Delegates
	 * 
	 * What is a delegate?
	 * Delegates are pointers to function used to implement events and callback methods.
	 * 
	 * 
	 * 
	 */

	public delegate int Calculate(int x, int y);

	public class Calculator {

		public void Execute() {
			int num1 = 100, num2 = 10;
			ExecuteCalc (num1, num2, Operator.Add);
			ExecuteCalc (num1, num2, Operator.Subtract);
			ExecuteCalc (num1, num2, Operator.Multiply);
			ExecuteCalc (num1, num2, Operator.Divide);
			ExecuteCalc (num1, num2, Operator.Modulus);
		}

		private void ExecuteCalc(int num1, int num2, Operator op){
			var result = new Calculator ().CalculateResult (num1, num2, op);
			Console.WriteLine ("Basic Delegate: {0} {2} {1} = {3}", num1, num2, op.ToString (), result);
		}

		private int CalculateResult(int x, int y, Operator oper) {

			Calculate calc = null;
			int result = 0;
			switch (oper) {

			case Operator.Add:
				calc = Adder.Add;
				break;

			case Operator.Subtract:
				calc = Subracter.Subtract;
				break;

			case Operator.Multiply:
				calc = Multiplier.Multiply;
				break;

			case Operator.Divide:
				calc = Divider.Divide;
				break;

			case Operator.Modulus:
				calc = Modulus.Mod;
				break;

			default:
				break;
			}

			if(calc != null)
				result = calc (x, y);
			return result;
		}
	}
}

