namespace DeMariaSoftware.Helpers
{
    public static class StringHelper
    {
        public static string DefaultValue(this string? value) => 
            string.IsNullOrEmpty(value) ? string.Empty : value.Trim();
    }
}
