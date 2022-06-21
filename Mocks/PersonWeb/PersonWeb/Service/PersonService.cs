using PersonWeb.Model;
using System.Collections.Generic;
namespace PersonWeb.Service

{
    public class PersonService: IServicePerson
    {
        public List<string>?Errores { get; set; }

        public bool EsValido(Model.Person person)
        {
            Errores = new List<string>();

            if (string.IsNullOrWhiteSpace(person.getName()))
            {
                Errores.Add("El nombre de la persona es un valor requerido");
            }
            if (person.getAge() > 100)
            {
              //  Errores.Add("La edad de la persona debe ser menor a 100");  
            }
            if (person.getAge() < 0)
            {
                Errores.Add("La edad de la persona debe ser mayor a cero");
   
            }

            return !Errores.Any();
        }
    }
}
