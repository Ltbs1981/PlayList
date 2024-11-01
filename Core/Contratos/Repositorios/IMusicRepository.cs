﻿using PlayList.Core.Entidades;

namespace PlayList.Core.Contratos.Repositorios
{
    internal interface IMusicRepository
    {
        void Add(Musica musica);
        List<Musica> GetAll();
        void Update(Musica musica);
        void Delete(Musica musica);
    }
}
