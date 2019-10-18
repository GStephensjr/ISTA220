# Name: cssbs-hw12
### Author: Greg Stephens
### Date: 7 Aug, 2019

##### 1. How does inheritance promote the principle of don’t repeat yourself (DRY)?
instead of creating many classes that share similarities, you can create a single class with all of those attributes
and derive more unique classes from it

##### 2. What is the syntax of a derived class that inherits from a base class?
    class DerivedClass : BaseClass
      {
        ...
      }

##### 3. Do all user defined types (classes and structs) inherit from some base class? If so, what is it?
- structs all implicitly derive from a base class called System.ValueType
- classes all implicitly derive from System.Object

##### 4. What happens if you do not have a default constructor in a base class when creating a derived class?
results in a compile time error
pgs 270 - 271

##### 5. Can you assign a variable of a derived class to another variable of its base class? Why or why not?
yes because the derived class can access its base class

##### 6. Can you assign a variable of a derived class to another variable of of a derived class of its base class? Why or why not?
generally no

##### 7. Can you assign a variable of a base class to another variable of a derived class? Why or why not?
no, for the most part you  cant assign down

##### 8. Under what circumstances would you want to use the new keyword when defining a method in a derived class?
when you're sure you want the method in the derived class to share the same signature as a method in the base class.
the new keyword shuts off the warning that appears when you compile the code.

##### 9. What is a virtual method? Why would you want to define a virtual method?
method that is intended to be overridden is called a virtual method

Overriding a method is a mechanism for providing different implementations of the same method—the methods are all related because they are intended to perform the same task, but in a class-specific manner

##### 10. What does override do? Why does it do it?
Overriding a method is a mechanism for providing different implementations of the same method—the methods are all related because they are intended to perform the same task, but in a class-specific manner

##### 11. How do you define an extension type?
    static class Util
      {
        public static int Negate(this int i)
          {
            return -i;
          }
      }

it is the **this** keyword prefixing the parameter to Negate that identifies it as an extension method, and the fact that the parameter that this prefixes is an int means that youare extending the int type.

##### 12. Why do you define an extension type?
when you want to extend a type with additional static methods
