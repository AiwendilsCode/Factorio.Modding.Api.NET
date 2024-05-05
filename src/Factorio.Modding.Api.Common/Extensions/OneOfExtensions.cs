using OneOf;

namespace Factorio.Modding.Api.Common.Extensions
{
    public static class OneOfExtensions
    {
        public static T GetAs<T>(this IOneOf oneOf)
        {
            if (oneOf.Value is T result)
            {
                return result;
            }
            else
            {
                throw new InvalidCastException($"Specified OneOf object does not hold {typeof(T).Name} data type. It holds {oneOf.Value.GetType().Name} instead.");
            }
        }
    }
}
