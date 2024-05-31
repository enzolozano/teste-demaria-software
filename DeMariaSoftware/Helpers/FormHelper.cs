namespace DeMariaSoftware.Helpers
{
    public static class FormHelper
    {
        public static bool IsFormOpen<T>() where T : Form =>
            Application.OpenForms
                .OfType<T>()
                .Any();

        public static void FocusForm<T>() where T : Form =>
            Application.OpenForms
                .OfType<T>()
                .FirstOrDefault()?
                .Activate();
    }
}