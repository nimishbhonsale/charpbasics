using System;
using System.Linq;
using System.Collections.Generic;
using CSharpBasics.Linq.Models;

namespace CSharpBasics.Linq
{
	public class RestrictionAndProjection
	{
		/// <summary>
		/// Basic operators: select, where using Query syntax
		/// </summary>
		public void LinqOperatorsRestrictProjectExample() {

			// Get all the items which have item price less than 35

			var items = new List<Item> {	
				new Fruit("Apple", 40, 10),
				new Fruit("Orange", 10, 10),
				new Vegetable("Tomato", 50, 10),
				new Vegetable("Potato", 30, 10),
			}; 

			IEnumerable<Item> queryWithItemsLessThan35 = 
				from item in items
				where item.Cost < 35
				select item;

			Console.WriteLine ("Item with price less than 35 are:");
			foreach (var item in queryWithItemsLessThan35) {
				var formattedItem = string.Format ("{0} {1} priced at {2}", item.GetType ().Name, item.Name, item.Cost);
				Console.WriteLine (formattedItem);
			}
		}
	}
}

