using OneOf;

namespace Factorio.Modding.Api.OrTypes
{
    internal class DoubleOr<T>
    {
        public OneOf<double, T> Value
        {
            get
            {
                if (_value is null)
                {
                    if (_doubleVal is not null)
                        return (double)_doubleVal;
                    else
                        throw new NullReferenceException("When generic value is null, int value cannot be null.");
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
        private readonly double? _doubleVal;

        internal DoubleOr(double? doubleVal, T? value)
        {
            _doubleVal = doubleVal;
            _value = value;
        }

        public static implicit operator DoubleOr<T>(T value) => new(null, value);
    }
}
