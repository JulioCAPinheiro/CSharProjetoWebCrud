using BaterPonto.Models;

namespace BaterPonto.Repositorio
{
    public interface IEmpresaRepositorio
    {
        EmpresModel ListPorId(int id);
        List<EmpresModel> BuscarTodos();
        EmpresModel Adicioar(EmpresModel Empresa);
        EmpresModel Atualizar(EmpresModel Empresa);

        bool Apagar(int id);
    }
}
