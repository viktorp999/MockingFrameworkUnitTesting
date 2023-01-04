using System.Collections.Generic;

namespace MoqExamples
{
    public interface IPersonRepository
    {
        Person AddPerson(Person person, List<Person> people);
    }
}
