using System;
using System.Linq;
using System.Collections.Generic;
using CSharpBasics.Linq.Models;

namespace CSharpBasics.Linq
{
	public class GroupByAndAggregates
	{
		public void LinqOperatorsAggregateGroupByExample() {
			var farmItems = new List<Item> {	
				new Fruit("Orange", 30, 13),
				new Fruit("Orange", 40, 14),
				new Fruit("Orange", 50, 15),
				new Fruit("Apple", 10, 11),
				new Fruit("Apple", 20, 12),
				new Vegetable("Tomato", 60, 16),
			}; 

			var groupAggregateQuery = 
				from item in farmItems
				group item by item.Name into g
				select new { Produce = g.Key, Occurances = g.Count () };


			Console.WriteLine ("Items with their occurances is:");

			foreach (var item in groupAggregateQuery) {
				var formattedItem = string.Format ("Item: {0} - occurance: {1}", item.Produce, item.Occurances);
				Console.WriteLine (formattedItem);
			}


			var maxValue = farmItems.Max (x => x.Cost);
			var itemWithMax = farmItems.Where (x => x.Cost == maxValue).FirstOrDefault();

			Console.WriteLine ("Max cost for item {0} is : {1}", itemWithMax.Name, itemWithMax.Cost);
		}
	}
}

