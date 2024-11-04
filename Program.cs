﻿using Microsoft.Extensions.DependencyInjection;
using PlayList;
using PlayList.Core.Entidades;
using PlayList.Web.Controller;
using System;

namespace PlayList
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            
            var serviceCollection = new ServiceCollection();
            var startup = new Startup();
            startup.ConfigureServices(serviceCollection);

            var serviceProvider = serviceCollection.BuildServiceProvider();


            var musicController = serviceProvider.GetRequiredService<MusicController>();

            
            musicController.Criar("Dead Lion", "Imagine Dragons", 288);
            musicController.Criar("The Unforgivem", "Metalica", 302);
            musicController.Ler();

            musicController.Editar(0, "Believe");
            musicController.Ler();

            musicController.Delete(1);
            musicController.Ler();

            var filmeController= serviceProvider.GetRequiredService<MusicController>();

            filmeController.Criar("O Poderoso Chefão", "Francis Ford Coppola", 175);
            filmeController.Ler();

            
            //var filme = new Filme("O Poderoso Chefão", "Francis Ford Coppola", 175);
            //filme.ExibirInformacoes();

        }
    }
}
