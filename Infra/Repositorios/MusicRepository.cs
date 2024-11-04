using PlayList.Core.Entidades;
using PlayList.Core.Contratos.Repositorios;
using System.Collections.Generic;
using System.Linq;

namespace PlayList.Infra.Repositorios
{
    internal class MusicRepository : IMidiaRepository
    {
        private static List<Midia> midias = new List<Midia>();
        private static int id = 0;

        public void Add(Midia midia)
        {
            if (string.IsNullOrWhiteSpace(midia.Nome) || string.IsNullOrWhiteSpace(midia.Artista) || midia.Duracao <= 0)
            {
                Console.WriteLine("Dados inválidos! Verifique os valores inseridos.");
                return;
            }

            midia.Id = id++;
            midias.Add(midia);
            Console.WriteLine($"{midia.Nome} foi adicionado com sucesso!");
        }

        public List<Midia> GetAll()
        {
            return midias;
        }

        public void Update(Midia midia)
        {
            var midiaBanco = midias.FirstOrDefault(i => i.Id == midia.Id);
            if (midiaBanco != null && !string.IsNullOrWhiteSpace(midia.Nome))
            {
                midiaBanco.Nome = midia.Nome;
                Console.WriteLine("Nome atualizado com sucesso!");
            }
            else
            {
                Console.WriteLine("ID não encontrado ou nome inválido.");
            }
        }

        public void Delete(Midia midia)
        {
            if (midias.Remove(midia))
                Console.WriteLine("Mídia removida com sucesso!");
            else
                Console.WriteLine("ID não encontrado.");
        }
    }
}
