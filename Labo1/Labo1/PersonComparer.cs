using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo1
{
    public class PersonComparer : IEqualityComparer<Person>
    {
        public Boolean Equals(Person person1, Person person2)
        {

            if (person1==person2 || (person1.Name.Equals(person2.Name) && person1.Age == person2.Age))
                return true;
            else
                return false;
        }
        public int GetHashCode(Person person)
        {
            return person.Name.GetHashCode() ^ person.Age;
        }
    }
}
