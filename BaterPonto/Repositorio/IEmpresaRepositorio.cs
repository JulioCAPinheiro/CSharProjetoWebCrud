using BaterPonto.Models;

namespace BaterPonto.Repositorio
{
    public interface IEmpresaRepositorio
    {
        //Criamos uma Interface para que possamos ter um reuso mais facil paras as proxímas paginas que serão criados 
        EmpresModel ListPorId(int id);
        List<EmpresModel> BuscarTodos();
        EmpresModel Adicioar(EmpresModel Empresa);
        EmpresModel Atualizar(EmpresModel Empresa);

        bool Apagar(int id);
    }
}
