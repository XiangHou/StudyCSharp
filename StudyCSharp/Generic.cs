using System;
using System.Collections.Generic;

namespace StudyCSharp
{
    public interface IComparable
    {
        int CompareTo(object obj);
    }

    public class Book: IComparable

    {
        private int id;
        private string title;

        public Book(int id, string title) {
            this.id = id;
            this.title = title;
        }

        public int Id {
            get {
                return id;
            }
            set {
                id = value;
            }
        }

        public string Title {
            get {
                return title;
            }
            set {
                title = value;
            }
        }

        public int CompareTo(object obj) {
            Book book = (Book) obj;
            return this.Id.CompareTo(book.Id);
        }
    }

	public class Generic
	{
		public Generic() {
		}

		public void bubbleSort(int[] array) {
		    int length = array.Length;

		    for (int i = 0; i < length - 1; i++) {
		        for (int j = length - 1; j >= 1; j--) {
		            if (array[j] < array[j-1]) {
		                int temp = array[j];
		                array[j] = array[j - 1];
		                array[j - 1] = temp;
		            }
		        }
		    }
		}

		public void bubbleSortG<T> (T[] array) where T: IComparable {
			int length = array.Length;
	
		    for (int i = 0; i < length - 1; i++) {
		        for (int j = length - 1; j >= 1; j--) {
					if (array[j].CompareTo(array[j - 1]) < 0) {
		                T temp = array[j];
		                array[j] = array[j - 1];
		                array[j - 1] = temp;
		            }
		        }
		    }
		}

	}


}

