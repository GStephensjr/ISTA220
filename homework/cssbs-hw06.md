# Name: cssbs-hw06

## Author: Greg Stephens

## Date: 17 July, 2019

##### 1. What is an exception?

a response to an unforeseen circumstance that arises while a program is running, such as an attempt to divide by zero

##### 2. What happens in a try block if the program executes without errors?

if none of the statements generates an exception, they all run, one after the other, to completion.

##### 3. How does the catch mechanism work for unhandled exceptions?

if the catch mechanism cant match the unhandled exeption, it moves to the next handler to try and match


##### 4. What happens in a program if an exception block fails to handle an particular error?

If, after cascading back through the list of calling methods, the runtime is unable to find a matching catch handler, the program will terminate with an unhandled exception.

##### 5. What is the parent class for all exceptions? How does this work?

system.exceptions class
there are different exceptions classes, like the systemexceptions and applicationexceptions.
these classes have libraries of catch expressions to catch the exceptions thrown.

##### 6. How do you determine the type of an error?

Format exception can help you figure out the cause
also debugging. pg. 135

##### 7. What is the purpose of integer checking?

to make sure that the integer is the proper size to avoid silent overflows

##### 8. What does the finally block do?

the finally block will always be run, even if an exception occurs.
