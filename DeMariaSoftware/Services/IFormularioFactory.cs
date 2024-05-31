namespace DeMariaSoftware.Services
{
    public interface IFormularioFactory
    {
        void AbrirTela<TForm>() where TForm : Form;
    }
}