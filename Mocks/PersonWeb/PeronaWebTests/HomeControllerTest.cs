using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PersonWeb.Controllers;
using PersonWeb.Model;
using PersonWeb.Service;
using System.Collections.Generic;
using System.Linq;


namespace PeronaWebTests
{
    public class HomeController
    {

        private PersonService _servicePerson;
        [TestInitialize]
        public void Inicializar()
        {
            _servicePerson = new PersonService();
        }

        [TestMethod]
        public void createPersonValida() 
        {

            Person person = new Person();

            var mockServicePerson = new Mock<IServicePerson>();

            mockServicePerson.Setup(sp=> sp.EsValido(person)).Returns(false);
          
            mockServicePerson.SetupGet(x=>x.Errores).Returns(new List<string>() { "Hubo Errores"});

            PersonController controller = new PersonController(mockServicePerson.Object);

            var result = controller.CreatedPerson(person);

            Assert.IsNotNull(result);


        }
    }
}
