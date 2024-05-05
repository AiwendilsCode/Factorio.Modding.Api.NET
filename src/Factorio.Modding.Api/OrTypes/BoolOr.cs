using OneOf;

namespace Factorio.Modding.Api.OrTypes
{
    public class BoolOr<T>
    {
        public OneOf<bool, T> Value
        {
            get
            {
                if (_value is null)
                {
                    if (_boolVal is not null)
                        return (bool)_boolVal;
                    else
                        throw new NullReferenceException("When generic value is null, bool value cannot be null.");
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
        private readonly bool? _boolVal;

        internal BoolOr(bool? boolVal, T? value)
        {
            _boolVal = boolVal;
            _value = value;
        }

        public static implicit operator BoolOr<T>(T value) => new(null, value);
    }
}
