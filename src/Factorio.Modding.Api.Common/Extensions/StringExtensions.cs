namespace Factorio.Modding.Api.Common.Extensions
{
    public static class StringExtensions
    {
        public static bool IsNumeric(this string str)
        {
            int startIndex = 0;

            if (str.StartsWith('-') || str.StartsWith('+'))
                startIndex++;

            int countOfDecimalDelims = 0;
            int countOfExponents = 0;

            for (int i = startIndex; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                    continue;

                if (str[i] == '.' || str[i] == ',')
                {
                    countOfDecimalDelims++;

                    if (countOfExponents == 0 && countOfDecimalDelims > 1)
                        return false;

                    if (countOfExponents == 1 && countOfDecimalDelims > 2)
                        return false;

                    continue;
                }

                if (str[i] == 'e')
                {
                    countOfExponents++;

                    if (countOfExponents > 1)
                        return false;
                    continue;
                }

                return false;
            }

            return true;
        }
    }
}
