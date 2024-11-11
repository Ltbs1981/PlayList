using PlayList.Core.Entidades;
using PlayList.Core.Contratos.Repositorios;
using PlayList.Core.Contratos.Servicos;
using System;
using System.Linq;
using System.Collections.Generic;
using PlayList.Infra.Repositorios;

namespace PlayList.Servico
{
    internal class MidiaService : IMidiaService
    {
        private static IMidiaRepository _musicRepository = new MidiaRepository();

        public void Add(Midia midia)
        {
            _musicRepository.Add(midia);
        }

        public List<Midia> GetAll()
        {
            return _musicRepository.GetAll();
        }

        public void Update(int id, string novoNome)
        {
            var midia = _musicRepository.GetAll().FirstOrDefault(x => x.Id == id);
            if (midia != null && !string.IsNullOrWhiteSpace(novoNome))
            {
                midia.Nome = novoNome;
                _musicRepository.Update(midia);
            }
            else
            {
                Console.WriteLine("ID não encontrado ou nome inválido.");
            }
        }

        public void Delete(int id)
        {
            var midia = _musicRepository.GetAll().FirstOrDefault(x => x.Id == id);
            if (midia != null)
            {
                _musicRepository.Delete(midia);
            }
            else
            {
                Console.WriteLine("ID não encontrado.");
            }
        }
    }
}
