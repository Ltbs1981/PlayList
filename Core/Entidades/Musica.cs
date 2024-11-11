using System.Runtime.CompilerServices;

namespace PlayList.Core.Entidades
{
    internal class Musica : Midia
    {
        public Musica(string nome, string artista, int duracao)
            : base(nome, artista, duracao) { }
        public override string ToString()
        {
            return $"Música: {Nome}\t Artista: {Artista}\tSegundos: {Duracao}";
        }
    }
}
