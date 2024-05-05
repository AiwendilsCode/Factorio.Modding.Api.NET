namespace Factorio.Modding.Api.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class | AttributeTargets.Field)]
    internal class InLuaAttribute(string name) : Attribute
    {
        public string Name { get; } = name;
    }
}
