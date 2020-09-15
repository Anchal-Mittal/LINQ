# LINQ
Learning LINQ

LINQ stands for Language Integrated Query.

Ways to write LINQ query:
There are three ways to write LINQ query.
1. Query Syntax
2. Method Syntax
3. Mixed Syntax

What is IEnumerable?
 1. IEnumerable is an interface. 
 2. IEnumerable is available in System.Collection namespace
 3. All the collections in c# implements this interface. It is type of Iteration Design Pattern.
 4. Because of this interface we can iterate on a collection.
 5. It contains only one method name as GetEnumerator which of IEnumerator type.
 6. IEnumerable also has a child for generic classes IEnumerable<T>. Hence IEnumerable is a parent class of IEnumerable<T>
 7. IEnumerable and IEnumerable<T> should be used for in memory data objects. 
 
 What is IEnumerator?
 1. IEnumerator is also an interface.
 2. IEnumerator contains three methods:
  a. Current-: Get the element at the current position of the collection.
  b. MoveNext-: Advances the enumerator to the next element of the collection.It is boolean type. It the enumerator reach at the end it returns false otherwise true.
  c. Reset-: Sets the enumerator to its initial position, which is before the first element in the collection.
  
  What is IQueryable?
  1. IQueryable is also an interface.
  2. IQueryable is a child class of IEnumerable.It means we can assigned IQuerable refrence to IEnumerable type variable.
  3. IQueryable interface contains:
   1.1 Expression
   1.2 Type
   1.3 IQueryProvider: IQueryable contains a property of type IQueryProvider which is used in LinqProviders.
  4. It is the best choice for other data providers (linq to entities etc...)
  
  What is IQueryProvider?
  1. IQueryProvider is also an interface.
  2. It is used to create and execute the query.
   
  
  
