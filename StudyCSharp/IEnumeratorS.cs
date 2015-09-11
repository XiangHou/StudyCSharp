using System;
using System.Collections;

namespace StudyCSharp
{
	public class IEnumeratorS
	{
		public IEnumeratorS ()
		{
		}

		public void factExec() {
		    int[] array = new int[]{1, 2, 3, 4, 5};

		    IEnumerator e = array.GetEnumerator();
		    while(e.MoveNext()) {
		        Console.WriteLine(e.Current.ToString());
		    }
		}

		public IEnumerator interfaceTest() {
		    yield return 1;
		    yield return 2;
		    yield return 3;
		}
	}
}

