# Name: cssbs-hw07
### Author: Greg Stephens
### Date: 22 July, 2019

#### Read chapter 7, pages 153 – 174 in the C# Step by Step book.
#### 1.2 Discussion Questions
#### Answer the discussion questions in writing.
##### 1. What is a class? According to the book, what does a class “arrange?”
a systematic arrangement of information and behavior into a meaningful entity

##### 2. What are the two purposes of encapsulation?
to combine methods and data within a class(support a classification)
to control the accessibility of methods and data; in other words, to control the use of the class
(direct the scope)

##### 3. How do you instantiate an instance of a class? How do you access that instance?
declaring the class desired "class circle"
you access it through the body of the class (the braces directly underneath)

##### 4. What is the default access of the fields and methods of a class? How do you change the default?
private; the class is shielded from the rest of the code until accessed by
changing private to public
##### 5. What is the syntax for writing a constructor?
a public method that doesnt return a value; give it the same name as its class
...

		class Circle
		{
			private int radius;
			public Circle() // default constructor
			{
				radius = 0;
			}
			public double Area()
			{
				return Math.PI * radius * radius;
			}
		}
...

##### 6. What is the difference between class fields and methods, and instance fields and methods? How do you
create class fields and methods?
there isnt?
class fields are just instance fields, they  can be set publicly and privately and they both
call methods of the class to use
class fields are instance fields, instance fields arent always class fields?

##### 7. How do you bring a static class in scope? Why would you want to bring a static class in scope?
static using statements, they're used to accomplish specific functions the system already knows how to use
examples are Math.Sqrt and Math.PI

##### 8. Can you think of a good reason to create an anonymous class? What is it?
to create a field of information (quite possibly a table) to pull queries from and use the information
in later methods

##### 9. What is polymorphism as this term is used in computer science? This is not in the book.
Polymorphism, in C#, is the ability of objects of different types to provide a unique interface for
different implementations of methods
Related to Overloaded statements? in the sense that the statements have different functions depending
on the methods calling it

##### 10. What is message passing as this term is used in computer science? This is not in the book.
Method calls.

It's called message passing to distinguish it from the imperative notion of "calling a function", and to
reinforce the idea that the receiving object decides what to do. On the call site, you just tell the
receiver the "message".

An example would be methods that are abstract in a class, and implemented in subclasses; or implementations
of an interface method. When you call e.g. GetEnumerator() through a variable of type IEnumerable, you don't
know at the call site what code should actually be executed.


##### 11. What was the first object-oriented programming language?
SIMULA 67


##### 12. Consider this quote by Alexander Stepanov:
I find OOP technically unsound. It attempts to decompose the world in terms of interfaces
that vary on a single type. To deal with the real problems you need multisorted algebras
— families of interfaces that span multiple types. I find OOP philosophically unsound. It
claims that everything is an object. Even if it is true it is not very interesting — saying that
everything is an object is saying nothing at all.

##### Who is Alexander Stephanov? What do you think about this quote?

russian computer programmer: the designer of C++
he was not into the idea of simplifying ideas and concepts for the sake of ease
