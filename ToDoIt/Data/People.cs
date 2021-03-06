using System;
using ToDoIt.Model;

namespace ToDoIt.Data
{
    public class People

    {

        private static Person[] personList = new Person[0];

        public int Size()
        {
            return personList.Length;
        }
        public Person[] FindAll()
        {
            return personList;
        }
        public Person FindById(int ID)
        {
            //personList är en kö av person
            foreach (Person aPersonInTheArray in personList)  //för varje person i kön
            {
                if (aPersonInTheArray.PersonID == ID) //om personen har id= personID , returnera personen
                {
                    return aPersonInTheArray;
                }

            }
            return null;
        }
        public Person NewPerson(string firstName, string lastName)
        {
            Person person = new Person(PersonSequencer.nextPersonID(), firstName, lastName);

            Array.Resize(ref personList, personList.Length + 1);
            personList[personList.Length - 1] = person;

            return person;
        }
        

        public void ClearPersons()
        {
            personList = new Person[0];
        }

    

        public void RemoveObject(Person person)
        {
            int index = 0;

            for (int i = 0; i < personList.Length; i++)
            {
                if (personList[i].Equals(person))
                {
                    index = i;
                    break;
                }
            }

            for (int i = index; i < personList.Length - 1; i++)
            {
                personList[i] = personList[i + 1];
            }

            Array.Resize(ref personList, personList.Length - 1);

        }
    }
}

