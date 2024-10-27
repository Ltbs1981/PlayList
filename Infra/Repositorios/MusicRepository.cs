using PlayList.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayList.Infra.Repositorios
{
    internal class MusicRepository
    {
        private static List<Musica> musicas = new List<Musica>();
        private static int id = 0;

        public void Add(Musica musica)
        {
            musica.Id = id++;
            musicas.Add(musica);
        }
        public List<Musica> GetAll()
        {
            return musicas;
        }
        public void Update(Musica musica)
        {
            Musica banco = musicas.FirstOrDefault(i => i.Id == musica.Id);
        }
        public void Delete(Musica musica)
        {
            musicas.Remove(musica);
        }
    }
}