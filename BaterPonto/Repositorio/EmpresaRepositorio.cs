using BaterPonto.DB;
using BaterPonto.Models;

namespace BaterPonto.Repositorio
{
    //Dentro da pasta EmpresaRepositorio criamos chamos os metodos criados na Função IEmpresaRepositorio gerando uma dependencia
    //E implementando as suas regras
    public class EmpresaRepositorio : IEmpresaRepositorio
    {
        private readonly BancoContext _bancoContext;

        public EmpresaRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public EmpresModel ListPorId(int id)
        {
            return _bancoContext.Empresa.FirstOrDefault(x => x.Id == id);
        }
        public List<EmpresModel> BuscarTodos()
        {
            return _bancoContext.Empresa.ToList();
        }
        public EmpresModel Adicioar(EmpresModel Empresa)
        {
            _bancoContext.Empresa.Add(Empresa);
            _bancoContext.SaveChanges();
            return Empresa;
        }

        public EmpresModel Atualizar(EmpresModel Empresa)
        {
            EmpresModel EmpresaDb = ListPorId(Empresa.Id);
            if (EmpresaDb == null) throw new System.Exception("Houve um erro na atualização");

            EmpresaDb.Name = Empresa.Name;
            EmpresaDb.CNPJ = Empresa.CNPJ;
            EmpresaDb.Email = Empresa.Email;
            EmpresaDb.Celular = Empresa.Celular;
            EmpresaDb.InscriEstadual = Empresa.InscriEstadual;

            _bancoContext.Empresa.Update(EmpresaDb);
            _bancoContext.SaveChanges();

            return EmpresaDb;
        }

        public bool Apagar(int Id)
        {
            EmpresModel EmpresaDb = ListPorId(Id);
            if (EmpresaDb == null) throw new System.Exception("Houve um erro na deleção da empresa");

            _bancoContext.Empresa.Remove(EmpresaDb);
            _bancoContext.SaveChanges();

            return true;
        }
    }
}
