namespace PlayList.Core.Entidades
{
    internal class Musica : Midia
    {
        public Musica(string nome, string artista, int duracao)
            : base(nome, artista, duracao) { }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"Musica: {Nome}, Artista: {Artista}, Duração: {Duracao} min");
        }
    }
}
