using System;

namespace CSharpBasics.Delegates.Models
{
	public class Adder
	{

		public static int Add (int x, int y){
			return x + y;
		}
	}

	public class Subracter
	{

		public static int Subtract (int x, int y){
			return x - y;
		}
	}

	public class Multiplier
	{

		public static int Multiply (int x, int y){
			return x * y;
		}
	}

	public class Divider
	{

		public static int Divide (int x, int y){
			return x / y;
		}
	}

	public class Modulus
	{
		public static int Mod (int x, int y){
			return x % y;
		}
	}


	public enum Operator {
		Add,
		Subtract,
		Multiply,
		Divide,
		Modulus
	}

	public class Point {

		public int X { get; private set; }
		public int Y { get; private set; }

		public Point(int x, int y) {
			X = x;
			Y = y;
		}
	}
}

