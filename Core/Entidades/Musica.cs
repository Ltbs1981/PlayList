namespace PlayList.Core.Entidades
{
    internal class Musica
    {
        public Musica(string nome, string artista, int duracao)
        {
            Nome = nome;
            Artista = artista;
            Duracao = duracao;
        }

        public int Id { get; set; }
        public string  Nome { get; set; }
        public string  Artista { get; set; }
        public int Duracao { get; set; }

    }
}
