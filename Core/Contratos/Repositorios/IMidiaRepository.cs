using PlayList.Core.Entidades;

namespace PlayList.Core.Contratos.Repositorios
{
    internal interface IMidiaRepository
    {
        void Add(Midia midia);
        List<Midia> GetAll();
        void Update(Midia midia);
        void Delete(Midia midia);
    }
}
