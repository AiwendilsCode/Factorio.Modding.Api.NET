namespace Factorio.Modding.Api.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class ApiVersionAttribute(int version) : Attribute
    {
        public int Version { get; } = version;
    }
}
