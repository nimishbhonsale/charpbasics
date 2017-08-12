using System;
using System.Linq;
using System.Collections.Generic;
using CSharpBasics.Linq.Models;

namespace CSharpBasics.Linq
{
	public class OrderBy
	{
		public void LinqOperatorsOrderByExample() {
			var farmItems = new List<Item> {	
				new Fruit("Orange", 40, 14),
				new Fruit("Orange", 30, 13),
				new Fruit("Orange", 50, 15),
				new Fruit("Apple", 20, 11),
				new Fruit("Apple", 10, 12),
				new Vegetable("Tomato", 60, 16),
			}; 

			var orderByQuery = 
				from item in farmItems
				orderby item.Name,item.Quantity
			select item;


			Console.WriteLine ("Items ordered is:");

			foreach (Item item in orderByQuery) {
				var formattedItem = string.Format ("Type: {0} Name: {1} Count: {2}", item.GetType().Name, item.Name, item.Quantity);
				Console.WriteLine (formattedItem);
			}
		}
	}
}

