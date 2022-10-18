namespace BaterPonto.Models
{
    public class EmpresModel
    {

        //Aqui Criamos a nossa Entidade que será utiliza para termos base do nosso Crud
        public int Id { get; set; }

        public string Name { get; set; }

        public int CNPJ { get; set; }

        public string Email { get; set; }

        public int Celular { get; set; }

        public int InscriEstadual { get; set; }

    }
}
