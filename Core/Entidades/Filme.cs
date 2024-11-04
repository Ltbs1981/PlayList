namespace PlayList.Core.Entidades
{
    internal class Filme : Midia
    {
        public string Diretor { get; set; }
        public int DuracaoMinutos { get; set; }

        public Filme(string nome, string diretor, int duracaoMinutos) : base(nome, diretor, duracaoMinutos)
        {
            Diretor = diretor;
            DuracaoMinutos = duracaoMinutos;
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"Filme: {Nome}, Diretor: {Diretor}, Duração: {DuracaoMinutos} minutos");
        }
    }
}
