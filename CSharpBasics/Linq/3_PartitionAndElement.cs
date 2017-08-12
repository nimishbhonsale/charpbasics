using System;
using System.Linq;
using System.Collections.Generic;
using CSharpBasics.Linq.Models;

namespace CSharpBasics.Linq
{
	public class PartitionAndElement
	{
		public void LinqOperatorsPartitionAndElementExample() {
			var farmItems = new List<Item> {	
				new Fruit("Orange", 30, 13),
				new Fruit("Orange", 40, 14),
				new Fruit("Orange", 50, 15),
				new Fruit("Apple", 10, 11),
				new Fruit("Apple", 20, 12),
				new Vegetable("Tomato", 60, 16),
			}; 

			// Get First Item
			var firstItem = farmItems.First ();

			Console.WriteLine ("First item is:");
			var formattedItem = string.Format ("{0} {1} priced at {2}", firstItem.GetType ().Name, firstItem.Name, firstItem.Cost);
			Console.WriteLine (formattedItem);

			// Skip 2 items and take next 3 items
			var skipTakeItems = farmItems.Skip(2).Take(3);

			foreach (var item in skipTakeItems) {
				var itemFormat = string.Format ("{0} {1} priced at {2}", item.GetType ().Name, item.Name, item.Cost);
				Console.WriteLine (itemFormat);
			}

			// Get First Item if it exist or null if it does not
			var firstOrDefaultItem = new List<Item>().FirstOrDefault ();

			Console.WriteLine ("First item is: ");

			var result = firstOrDefaultItem == null 
				? "Item is null" 
				: string.Format ("{0} {1} priced at {2}", firstOrDefaultItem.GetType ().Name, firstOrDefaultItem.Name, firstOrDefaultItem.Cost);
			Console.WriteLine (result);

		}
	}
}

