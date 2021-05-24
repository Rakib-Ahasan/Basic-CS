using System.Collections;

namespace Collection
{
    public class People : IEnumerable
    {
        //Collection of the Preson objects.This class
        // Emplements IEnumerable so that it can be used
        // With for Each syntax

        private Person[] people;

        public People(Person[] pArray)
        {
            people=new Person[pArray.Length];
            for (int i = 0; i < pArray.Length; i++)
            {
                people[i] = pArray[i];
            }
        }

        //Emplementation for the GetEnumerator method
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator) GetEnumerator();
        }

        public PeopleEnum GetEnumerator()
        {
            return new PeopleEnum(people);
        }
    }
}
