namespace PersonWeb.Model
{
    public interface IServicePerson
    {
        bool EsValido(Person person);
        List<string> Errores { get; set; }
    }
}
