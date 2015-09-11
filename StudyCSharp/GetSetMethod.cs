using System;

namespace StudyCSharp
{
	abstract class Person
    {
        private string name;
        protected string thinkWay;
        private int age;

        public string Name
        {
            get {
                return name;
            }
            set {
                name = value;
            }
        }

        public abstract string ThinkWay {
            set; get;
        }

        public int Age
        {
            get {
                return age;
            }
            set {
                age = value;
            }
        }

        protected virtual void Test() {
            string abc = "1";
        }
    }

    class Girl: Person
    {
        public override string ThinkWay {
			get {
				return thinkWay;
			}
			set {
				thinkWay = value;
			}
		}

		protected override void Test() {

		}
    }

    class Boy: Person
    {
		public override string ThinkWay {
			get {
				return thinkWay;
			}
			set {
				thinkWay = value;
			}
		}
    }


	public class GetSetMethod
	{
		public GetSetMethod ()
		{
		}
	}
}

