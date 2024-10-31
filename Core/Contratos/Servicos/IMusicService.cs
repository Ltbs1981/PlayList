using PlayList.Core.Entidades;

namespace PlayList.Core.Contratos.Servicos
{    internal interface IMusicService
    {
        void Add(Musica musica);
        List<Musica> GetAll();
        void Update(int id, string novoNome);
        void Delete(Musica musica);

    }
}
