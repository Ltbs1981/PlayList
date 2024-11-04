using PlayList.Core.Entidades;

namespace PlayList.Core.Contratos.Servicos
{
    internal interface IMidiaService
    {
        void Add(Midia midia);
        List<Midia> GetAll();
        void Update(int id, string novoNome);
        void Delete(int id);

    }
}
