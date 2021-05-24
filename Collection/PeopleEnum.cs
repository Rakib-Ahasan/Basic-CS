using System;
using System.Collections;

namespace Collection
{
    public class PeopleEnum : IEnumerator
    {
        // When implement IEnumrable, you must also implement IEnumerator
        public Person[] people;

        

        //Enumerators are the positioned before the first element.
        // Until the first MoveNext() call
        private int position = -1;
        public PeopleEnum(Person[] list)
        {
            people = list;
        }
        public bool MoveNext()
        {
            position++;
            return (position < people.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Person Current
        {
            get
            {
                try
                {
                    return people[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
