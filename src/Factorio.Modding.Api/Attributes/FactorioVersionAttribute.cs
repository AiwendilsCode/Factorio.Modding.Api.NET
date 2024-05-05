namespace Factorio.Modding.Api.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class FactorioVersionAttribute(string version) : Attribute
    {
        private string Version { get; } = version;
    }
}
