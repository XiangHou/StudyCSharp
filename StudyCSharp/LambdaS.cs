using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace StudyCSharp
{
	public class LambdaS
	{
	    delegate int del(int i);

	    List<Person> team = new List<Person>();
		public LambdaS ()
		{
		    Person p1 = new Boy();
		    p1.Name = "Core";
		    p1.Age = 29;
		    Person p2 = new Girl();
		    p2.Name = "Island Mouse";
		    p2.Age = 30;
		    Person p3 = new Girl();
		    p3.Name = "Kangeroo";
		    p3.Age = 32;

		    team.Add(p1);
		    team.Add(p2);
		    team.Add(p3);
		}

		public void delegateWay() {
		    IEnumerable<Person> result = team.Where(
		        delegate(Person p) {
		        	return p.Age >= 30;
		        }
		    );

		    foreach (Person p in result) {
		        Console.WriteLine(p.Name);
		    }
		}

		public void lambdaWay() {
		    IEnumerable<Person> result = team.Where(
		        Person => Person.Age <= 30
		    );

			foreach (Person p in result) {
		        Console.WriteLine(p.Name);
		    }
		}
	}
}

