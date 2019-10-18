# Name: cssbs-hw09
### Author: Greg Stephens
### Date: 30 July, 2019

###### Read chapter 9, pages 201 – 219 in the C# Step by Step book.

##### 1. Declare an enum for military ranks, either officer or enlisted. Name it Ranks. What are the symbols, like Private, PFD, Corporal, or 1stLt, 2ndLt, Capt?
- variables of the enumeration


##### 2. Using the Ranks enum, assign a rank to yourself or a friend.
...

		namespace Enumeration_HW
		{
			enum rank { amn, a1c, sra, ssgt, tsgt, msgt, smsgt }
			class Program
			{
				rank greg = rank.ssgt;
				public void jrenlisted(rank sra)
				{
            rank ab;
            rank greg = rank.ssgt;
            Console.WriteLine((int)greg);
				}
				static void Main(string[] args)
				{
				}
			}
		}

...

##### 3. Determine the numeric index of particular ranks, using the Ranks enum.
...

		amn=0, a1c=1, sra=2, ssgt=3, tsgt=4, msgt=5, smsgt=6
...

##### 4. How do you select the type of an enum?
...

		enum rank : short { amn, a1c, sra, ssgt, tsgt, msgt, smsgt }
...

##### 5. Are structs stored on the stack or on the heap? What about enums?
structs are stored on the stack, enums on the heap

##### 6. Declare a struct named DOD with four branches.
...

		enum dod {army, airforce, marines, navy }
...

##### 7. Why can’t you create a default constructor for a struct?
The reason you can’t declare your own default constructor for a structure is that the compiler always generates one.
pg 217

##### 8. What is CIL? What does the CLR do to the CIL?
common intermediate language; its the instructions stored in assemblies that handle the set of instructions that is your code
the clr makes sure the cil instructions are converted into machine instructions that the computer can understand and execute
