using System;
using System.Collections.Generic;

namespace StudyCSharp
{
	class Entry
	{
	    public static void GenericTest() {
//	        Generic<int> generic = new Generic<int>();
//	        int[] array = {1, 9, 6, 0, 3, 4};
//	        generic.bubbleSort(array);
//	        foreach (int i in array) {
//	            Console.WriteLine("{0}", i);
//	        }

            Book[] bookArray = new Book[3];
            Book book1 = new Book(123, "Hello World");
            Book book2 = new Book(234, "Hi");
            Book book3 = new Book(1, "Core");

            bookArray[0] = book1;
            bookArray[1] = book2;
            bookArray[2] = book3;

            Generic genericSort = new Generic();
            genericSort.bubbleSortG(bookArray);
            //genericSort.bubbleSortG<Book>(bookArray);  it is same to line above

            foreach (Book book in bookArray) {
                Console.Write("Id: {0}", book.Id);
                Console.WriteLine("    Title: {0}", book.Title);
            }
	    }


	    public static void OutRefTest() {
	        OutRef outRef = new OutRef();
	        outRef.test();
	        Console.WriteLine("{0}", outRef.Count);
	    }

	    public static void IEnumeratorTest() {
	        IEnumeratorS e = new IEnumeratorS();
	        //e.factExec();
	        e.interfaceTest();
	    }

	    public static void LambdaTest() {
	        LambdaS lambda = new LambdaS();
	        //lambda.delegateWay();
	        lambda.lambdaWay();
	    }

		public static void Main (string[] args)
		{
		    //GenericTest();
			//OutRefTest();
			//IEnumeratorTest();
			LambdaTest();
		}
	}
}
