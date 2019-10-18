# Name: cssbs-hw11
### Author: Greg Stephens
### Date: 5 Aug, 2019

###### Read chapter 11, pages 243 – 254 in the C# Step by Step book.
##### 1. How do you define a method that takes an arbitrary number of arguments?

Using a params array, you can pass a variable number of arguments to a method. You indicate a params
array by using the params keyword as an array parameter modifi er when you define the method parameters.

    class Util
    {
      public static int Min(params int[] paramList)
        {
          // method code
        }
    }

##### 2. How do you call a method that takes an arbitrary number of arguments?
the params keyword

to create a method that accepts an arbritrary number of values, you can simply write this:

      int meth = Method(first, second);

      int array = Class.Array(first, second, third);

##### 3. Why can’t you use an array to pass an arbitrary number of arguments to a method?
- an array is a static object, it has a fixed size

##### 4. How many parameters can a method have?
There is no general consensus and it depends on who you ask.

In general the moment readability suffers, there are too many

https://stackoverflow.com/questions/12431932/how-many-parameters-in-c-sharp-method-are-acceptable

##### 5. Do parameter arguments have to have the same type?
no but only if the method type is an object

https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/params


##### 6. What is the difference between a method that takes a parameter argument and one that takes optional arguments?
Generally, you use parameter arrays for methods that can take any number of parameters (including none), whereas you use optional parameters only where it is not convenient to force a caller to provide
an argument for every parameter.

- pg 263

##### 7. How do you define a method that takes different (and arbitrary) types of arguments?
use type object on your method
