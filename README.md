# C# basics

Basics of the C# language with working examples built using monodevelop


## Delegates

Delegates are pointers to function used to implement events and callback methods. 

#### Anonymous methods
Anonymous method is a method with no  name just body

#### Built-In Delegates
1. Action -  Input 1 or more params of type T, return void 
2. Func - Input of type T, return of type Tr 
3. Predicate - Used to verify a criteria of method, returns bool 


## LINQ

Short for Language Integrated Query

1. Linq to Objects
2. Linq to Entity (ORM)
3. Linq to SQL (ORM)
4. Linq to Dataset
5. Linq to Xml


## LINQ – Querying & Lambda Operator

1. Restriction
2. Projection
3. Lambda => operator
4. Partition
5. Element At
6. Group By
7. Aggregation
8. Order By
9. Joins
10. Lazy vs Eager execution


## Expression Trees

Code in a tree-like data structure, where each node is an expression

Example: Func<int, int, int> function = (a,b) => a + b;

This consists of:
1. A declaration: Func<int, int, int> function
2. An equals operator: =
3.A lambda expression: (a,b) => a + b;

Basically, the following: (a,b) => a + b;  maps to  public int function(int a, int b) { return a + b; }


## EXAMPLE – Expression<Tdelegate>
	
Body: Retrieves body of the expression.
Parameters: Retrieve the parameters
NodeType: Gets  ExpressionType for node in the tree (45 different values)
Type: Gets the static type of the expression i.e in this case Func<int, int, int>.

IEnumerable<T> : returned for LINQ to OBJECTS
IQueryable<T>  : returned for LINQ TO SQL
	
