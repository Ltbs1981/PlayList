using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayList.Core.Entidades
{
    internal abstract class Midia
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Artista { get; set; }
        public int Duracao { get; set; }

        public Midia(string nome, string artista, int duracao)
        {
            Nome = nome;
            Artista = artista;
            Duracao = duracao;
        }

        public abstract void ExibirDetalhes();

    }
}
