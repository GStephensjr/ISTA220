# Name: cssbs-hw10
### Author: Greg Stephens
### Date: 31 July, 2019


###### Read chapter 10, pages 221 – 242 in the C# Step by Step book.
###### Answer the discussion questions in writing.

You can think of an array as a simple collection of data, ordered by an index

##### 1. What does an array look like in memory?
an array looks likes an unordered sequence of items living in a contiguous block of memory.
it must be accessed via an index.

##### 2. Where is memory allocated to hold an array, on the stack or on the heap?
on the heap

##### 3. Where is memory allocated to hold an array reference, on the stack or on the heap?
on the stack

##### 4. Can an array hold values of different types? This is a trick question, the answer is, “It depends.”
you can add any item to the array but it must be in a cast to be used properly

https://stackoverflow.com/questions/6482331/how-to-add-different-types-of-objects-in-a-single-array-in-c

##### 5. Describe the syntax of the condition or a for each loop.

...

    public void ProcessData(int[] data)
    {
      foreach (int i in data)
      {
        ...
      }
    }

...

##### 6. How do you make a deep copy of a array?
to copy the values is to use the System.Array static method named Copy. As with
CopyTo, you must initialize the target array before calling Copy:

...

    int[] pins = { 9, 3, 7, 2 };
    int[] copy = new int[pins.Length];
    Array.Copy(pins, copy, copy.Length);

...

##### 7. What is the difference between a multi-dimensional array and an array of arrays?
multi-dimensional arrays have a nicer syntax. jagged arrays consume less memory, are faster and are more effective

##### 8. How do you “flatten” a multidimensional array? In other words, take something that looks like a matrix

...

    (
    1 2 3
    4 5 6
    7 8 9
    )

...

 ##### and turn it into an array

 ...

    [1, 2, 3, 4, 5, 6, 7, 8, 9]

...

 ##### ?
