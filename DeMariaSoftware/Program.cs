using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DeMariaSoftware.Data;
using DeMariaSoftware.Entities;
using DeMariaSoftware.Mappers;
using DeMariaSoftware.Models;
using DeMariaSoftware.Repositories;
using DeMariaSoftware.Services;
using DeMariaSoftware.Views;

namespace DeMariaSoftware
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var services = ConfigureServices();

            using var serviceProvider = services.BuildServiceProvider();

            // Aplica migrações e cria o banco de dados (caso o mesmo não exista)
            var context = serviceProvider.GetRequiredService<AppDbContext>();
            context.Database.Migrate();

            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(serviceProvider.GetRequiredService<FormHome>());
        }

        private static IServiceCollection ConfigureServices()
        {
            var services = new ServiceCollection();

            // Configuração do DbContext
            services.AddDbContext<AppDbContext>();

            // Mappers
            services.AddTransient<ICrudMapper<ClienteRequest, ClienteResponse, Cliente>, ClienteCrudMapper>();
            services.AddTransient<ICrudMapper<ProdutoRequest, ProdutoResponse, Produto>, ProdutoCrudMapper>();
            services.AddTransient<ICrudMapper<VendaRequest, VendaResponse, Venda>, VendaCrudMapper>();
            services.AddTransient<ICrudMapper<ItensVendaRequest, ItensVendaResponse, ItensVenda>, ItensVendaCrudMapper>();

            // Repositórios
            services.AddTransient<IClienteRepository, ClienteRepository>();
            services.AddTransient<IProdutoRepository, ProdutoRepository>();
            services.AddTransient<IVendaRepository, VendaRepository>();
            services.AddTransient<IItensVendaRepository, ItensVendaRepository>();

            // Serviços
            services.AddTransient<IClienteService, ClienteService>();
            services.AddTransient<IProdutoService, ProdutoService>();
            services.AddTransient<IVendaService, VendaService>();
            services.AddTransient<IItensVendaService, ItensVendaService>();
            services.AddTransient<IFormularioFactory, FormularioFactory>();

            // Formulários
            services.AddTransient<FormHome>();
            services.AddTransient<FormCliente>();
            services.AddTransient<FormProduto>();
            services.AddTransient<FormVenda>();

            return services;
        }
    }
}