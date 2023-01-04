using System.Collections.Generic;

namespace MoqExamples
{
    public class PersonRepository : IPersonRepository
    {
        public Person AddPerson(Person person, List<Person> people)
        {
            if (person.Name == null || person.Name == "" || person.Name == " ")
            {
                throw new EmptyPersonNameException();
            }

            people.Add(person);

            return person;
        }
    }
}
