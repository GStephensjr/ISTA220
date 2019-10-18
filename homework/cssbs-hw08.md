# Name: cssbs-hw08
## Author: Greg Stephens
### Date 23 July, 2019

#### Read chapter 8, pages 77 – 199 in the C# Step by Step book.

##### 1. What is the difference between deep copy and shallow copy?
shallow copies only uses the clone method to copy references and values.
deep copies clone the object itself as well.

##### 2. What is the value of a reference after you declare and initialize it?
its initialized to the value you set
- use a value type keyword

##### 3. How do you declare a value type?
pg 183 you allocate a block of memory big enough to hold the value type
- use the new keyword

##### 4. How do you declare a reference type?
pg 183 you allocate a block of memory to hold an address(reference) to the memory block containing the
declared reference type (objects)

##### 5. Does C# allow you to assign NULL to a value type?
yes

##### 6. Can you assign a nullable value type to a non-nullable variable of the same type? Why or why not?
no. the non nullable type cant accept the nullable type because the nullable value type might contain
null as a value, which the non nullable cannot accept

##### 7. What is the difference between the stack and the heap?
the heap contains the locations for references. when references are called they are assigned to the stack
as a value
- stack is for executable code
- heap is for objects and items whose lifespan is indeterminate

##### 8. What does it mean when we say that all classes are specialized types?
a class is a kind of reference type when declared as a variable
the stack is used for static memory allocation, the heap for dynamic.
stack contains variables, heap contains objects
pg 197

##### 9. What does ref do?
when using ref as a prefix, any actions performed on the parameter are also performed on the original
argument, the parameter and argument both reference the same data.

##### 10. What does out do?
it has the method itself initialize the parameter
it passes the argument to a method by reference instead of by the value
- prefix a parameter with the out keyword  to turn the parameter into an alias for the argument
- when passing an out parameter to a method, the method has to assign a value before it returns
##### 11. Describe boxing and unboxing in your own words.
boxing converts a value type into an object and stores it on the heap
unboxing takes the stored value and converts it into a specified value type, assigning
it to a new variable

##### 12. What does cast do?
casting data tells the compiler to treat it as a specified value type
