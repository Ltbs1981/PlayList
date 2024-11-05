using Microsoft.Extensions.DependencyInjection;
using PlayList.Core.Contratos.Repositorios;
using PlayList.Core.Contratos.Servicos;
using PlayList.Infra.Repositorios;
using PlayList.Servico;
using PlayList.Web.Controller;

namespace PlayList
{
    internal class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddScoped<IMidiaRepository, MidiaRepository>();
            services.AddScoped<IMidiaService, MidiaService>();


            services.AddScoped<MidiaController>();
        }
    }
}
