using System;
using System.Linq;
using System.Collections.Generic;
using CSharpBasics.Linq.Models;

namespace CSharpBasics.Linq
{
	public class LambdaSyntax
	{
		/// <summary>
		/// Basic operators: select, where using Lambda syntax
		/// </summary>
		public void LinqOperatorsLambdaSyntax() {

			// Problem: Get all the items which have item price less than 35
			IEnumerable<Item> items = new List<Item> {	
				new Fruit("Apple", 40, 10),
				new Fruit("Orange", 10, 10),
				new Vegetable("Tomato", 50, 10),
				new Vegetable("Potato", 30, 10),
			}; 

			var queryWithItemsLessThan35 = items.Where (x => x.Cost < 35);

			Console.WriteLine ("Item with price less than 35 are:");
			foreach (var item in queryWithItemsLessThan35) {
				var formattedItem = string.Format ("{0} {1} priced at {2}", item.GetType ().Name, item.Name, item.Cost);
				Console.WriteLine (formattedItem);
			}
		}
	}
}

