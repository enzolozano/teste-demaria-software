using Microsoft.Extensions.DependencyInjection;

namespace DeMariaSoftware.Services
{
    public class FormularioFactory : IFormularioFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public FormularioFactory(IServiceProvider serviceProvider) =>
            _serviceProvider = serviceProvider;

        public void AbrirTela<TForm>() where TForm : Form
        {
            var form = _serviceProvider.GetRequiredService<TForm>();
            form.Show();
        }
    }
}