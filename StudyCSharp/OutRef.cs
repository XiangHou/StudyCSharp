using System;

namespace StudyCSharp
{
	public class OutRef
	{
	    private int count;
	    //public int count {get; set;}

	    public int Count {
	        get {
	            return count;
	        }
	        set {
	            count = value;
	        }
	    }

	   


		public OutRef ()
		{
		}

		public void test() {
			
		    //Out(out count);

		    count = 1;
		    Ref(ref count);
		}

		private void Ref(ref int i) {
		    i++;
		}

		private void Out(out int i) {
		    i = 0;
		    i++;
		}
	}
}

