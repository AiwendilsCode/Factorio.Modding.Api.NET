using OneOf;

namespace Factorio.Modding.Api.OrTypes
{
    public class StringOr<T>
    {
        public OneOf<string, T> Value
        {
            get
            {
                if (_value is null)
                {
                    if (_stringVal is not null)
                        return _stringVal;
                    else
                        throw new NullReferenceException("When generic value is null, string value cannot be null.");
                }

                return _value;
            }
            set
            {
                if (value is not T tValue)
                    throw new ArgumentException($"Only values of type {typeof(T).Name} are allowed.");

                _value = tValue;
            }
        }

        private T? _value;
        private readonly string? _stringVal;

        internal StringOr(string? stringVal, T? value)
        {
            _value = value;
            _stringVal = stringVal;
        }

        public static implicit operator StringOr<T>(T value) => new(null, value);
    }
}
