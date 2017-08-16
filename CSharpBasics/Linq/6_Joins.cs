using System;
using System.Linq;
using System.Collections.Generic;
using CSharpBasics.Linq.Models;

namespace CSharpBasics.Linq
{
	public class Joins
	{
		/// <summary>
		/// Cross join
		/// </summary>
		public void LinqOperatorsJoinExample() {
			var farmer1Items = new List<Item> {	
				new Fruit("Apple", 40, 10),
				new Fruit("Orange", 10, 20),
				new Vegetable("Tomato", 50, 10),
				new Vegetable("Potato", 25, 18),
				new Vegetable("Potato", 55, 19),
			}; 

			var farmer2Items = new List<Item> {	
				new Fruit("Apple", 35, 11),
				new Fruit("Apple", 45, 12),
				new Fruit("Pineapple", 10, 20),
				new Vegetable("Brinjal", 20, 10),
				new Vegetable("Potato", 30, 20),
			}; 

			// Get the names of the items less than 35 which farmer 1 and farmer 2 both have produced.
			var queryWithItemsLessThan35 = 
				from f1 in farmer1Items 
				join f2 in farmer2Items on f1.Name equals f2.Name
					where f1.Cost < 35 && f2.Cost < 35
				select new {Produce = f1.Name};

			Console.WriteLine ("Items less than 35 which farmer 1 and farmer 2 both have produced:");

			foreach (var item in queryWithItemsLessThan35) {
				Console.WriteLine (item.Produce);
			}

			/*
			// Get the items which farmer 1 and farmer 2 both have produced.
			var queryWithItemsFromFarm2 = 
				from f1 in farmer1Items 
				join f2 in farmer2Items on f1.Name equals f2.Name
				select new {Produce = string.Format("{0} {1}",f1.Name,f1.Quantity), Item = f2};

			var queryWithItemsFromFarm1 = 
				from f1 in farmer1Items 
				join f2 in farmer2Items on f1.Name equals f2.Name
				select new {Produce = string.Format("{0} {1}",f2.Name,f2.Quantity) , Item = f1};


			Console.WriteLine ("Items farmer 2 has produced with farm 1:");

			foreach (var item in queryWithItemsFromFarm2) {
				var formattedItem = string.Format ("{0} {1} priced at {2}", item.Produce, item.Item.Name , item.Item.Cost);
				Console.WriteLine (formattedItem);
			}

			Console.WriteLine ("Items farmer 1 has produced with farm 2:");

			foreach (var item in queryWithItemsFromFarm1) {
				var formattedItem = string.Format ("{0} {1} priced at {2}", item.Produce, item.Item.Name , item.Item.Cost);
				Console.WriteLine (formattedItem);
			}
			*/
		}
	}
}

