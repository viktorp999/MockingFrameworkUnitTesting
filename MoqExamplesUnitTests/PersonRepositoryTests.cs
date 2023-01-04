using NUnit.Framework;
using MoqExamples;
using System.Collections.Generic;

namespace MoqExamplesUnitTests
{
    [TestFixture]
    public class PersonRepositoryTests
    {
        private List<Person> _people;
        private IPersonRepository _repository;

        [SetUp]
        public void SetUp()
        {
            _people = new List<Person>();
            _repository = new PersonRepository();
        }

        [Test]
        public void AddPerson_WhenCalled_AddPersonToList()
        {
            Person person = new Person
            {
                Name = "Viktor"
            };

            var result = _repository.AddPerson(person, _people);

            Assert.AreEqual(result, person);
        }

        [Test]
        public void AddPerson_EmptyName_ThrowEmptyPersonNameException()
        {
            Person person = new Person
            {
                Name = null
            };

            Assert.Throws<EmptyPersonNameException>(() => _repository.AddPerson(person, _people));
        }
    }
}
