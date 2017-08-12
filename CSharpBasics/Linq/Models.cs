using System;
using System.Collections.Generic;

namespace CSharpBasics.Linq.Models
{
	public class Item {

		public Item(string name, float cost){
			Name = name;
			Cost = cost;
		}
		public Item(string name, float cost, uint qty){
			Name = name;
			Cost = cost;
			Quantity = qty;
		}
		public int Id { get { return new Random(10).Next();}}
		public string Name { get; protected set; }
		public float Cost { get; protected set; }
		public uint Quantity { get; protected set; }

	}

	public class Fruit : Item {

		public Fruit(string name, float cost, uint qty ) : base (name, cost, qty) {

		}
	}

	public class Vegetable : Item {
		public Vegetable(string name, float cost, uint qty) : base (name, cost, qty) {

		}
	}

	public class Vendor {

		public Vendor(string name){
			Name = name;
			Id = new Random (10).Next();
			Items = new List<Item> ();
		}
		public int Id { get; private set; }
		public string Name { get; }
		public List<Item> Items { get; set; }
	}

	public class Outlet {

		public Outlet(string name, string city){
			Name = name;
			City = city;
			Vendors = new List<Vendor> ();
		}
		public string Name { get; private set; }
		public string City { get; private set; }
		public List<Vendor> Vendors { get; set; }
	}
}

