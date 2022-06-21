using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonWeb.Model;
using PersonWeb.Service;
using System.Linq;

namespace PeronaWebTests
{
    [TestClass]
    public class ServicePersonTest
    {
        private PersonService _servicePerson;
        [TestInitialize]
        public void Inicializar()
        {
            _servicePerson = new PersonService();
        }
        [TestMethod]
        public void PersonWithNameEmpty()
        {
           var person = new Person("",200,"christianccm@gmail.com","88074243","Cariari");

           var result = _servicePerson.EsValido(person);

            Assert.IsFalse(result);
            Assert.IsTrue(_servicePerson.Errores.Any());
        }
        [TestMethod]
        public void PersonWithAgeUnderO()
        {

            var person = new Person("Christian", -1, "", "", "");

            var result = _servicePerson.EsValido(person);

            Assert.IsFalse(result);
            Assert.IsTrue(_servicePerson.Errores.Any());
        }

        [TestMethod]
        public void PersonWithAgeGreater100()
        {

            var person = new Person("Christian", 1008, "", "", "");

            var result = _servicePerson.EsValido(person);

            Assert.IsFalse(result);
            Assert.IsTrue(_servicePerson.Errores.Any());
        }

        [TestMethod]
        public void PersonValid()
        {

            var person = new Person("Christian", 78, "christianccm@gmail.com", "88074243", "Cariari");

            var result = _servicePerson.EsValido(person);

            Assert.IsTrue(result);
            Assert.IsFalse(_servicePerson.Errores.Any());
        }
    }
}