using System.Text;

namespace Factorio.Modding.Api.Common.NamingConventions
{
    public static class NamingConventionConverter
    {
        public static string ConvertToUpperCamelCase(this string input)
        {
            input = ReplaceNonAlphaNumericChars(input);

            if (IsLowerCamelCase(input)) return MakeFirstLetterCapital(input);
            else if (IsUpperCamelCase(input)) return input;
            else if (IsLowerSnakeCase(input)) return ConvertLowerSnakeToUpperCamel(input);
            else if (IsUpperSnakeCase(input)) return MakeFirstLetterCapital(input).Replace("_", "");
            else if (IsKebabCase(input)) return ConvertKebabCaseToUpperCamelCase(input);
            else throw new ArgumentException($"Unrecognized naming convention of input string: {input}");
        }

        public static string ConvertToLowerCamelCase(this string input)
        {
            input = ReplaceNonAlphaNumericChars(input);

            if (IsLowerCamelCase(input)) return input;
            else if (IsUpperCamelCase(input)) return MakeFirstLetterLower(input);
            else if (IsLowerSnakeCase(input)) return MakeFirstLetterLower(ConvertLowerSnakeToUpperCamel(input));
            else if (IsUpperSnakeCase(input)) return MakeFirstLetterLower(input).Replace("_", "");
            else if (IsKebabCase(input)) return MakeFirstLetterLower(ConvertKebabCaseToUpperCamelCase(input));
            else throw new ArgumentException($"Unrecognized naming convention of input string: {input}");
        }

        private static string ReplaceNonAlphaNumericChars(string input)
        {
            char replacingChar = '_';

            if (input.Contains('-'))
                replacingChar = '-';

            StringBuilder replacedBuilder = new();

            foreach (char c in input)
            {
                if (char.IsAsciiLetterOrDigit(c))
                    replacedBuilder.Append(c);
                else
                    replacedBuilder.Append(replacingChar);
            }

            return replacedBuilder.ToString();
        }

        private static string ConvertKebabCaseToUpperCamelCase(string input)
        {
            if (input.Length == 0)
                return input;

            StringBuilder caseBuilder = new();

            caseBuilder.Append(char.ToUpper(input[0]));

            for (int i = 1; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    caseBuilder.Append(input[i]);
                    continue;
                }

                if (input[i] == '-')
                {
                    if (i == input.Length - 1)
                        break;

                    caseBuilder.Append(char.ToUpper(input[++i]));
                }
                else
                {
                    caseBuilder.Append(input[i]);
                }
            }

            return caseBuilder.ToString();
        }

        private static string MakeFirstLetterCapital(string input)
        {
            if (input.Length > 1)
            {
                return char.ToUpper(input[0]) + input[1..];
            }
            else
                return input.ToUpper();
        }

        private static string MakeFirstLetterLower(string input)
        {
            if (input.Length > 1)
            {
                return char.ToLower(input[0]) + input[1..];
            }
            else
                return input.ToLower();
        }

        private static string ConvertLowerSnakeToUpperCamel(string input)
        {
            StringBuilder output = new();

            char lastChar = '_';
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    output.Append(c);
                    continue;
                }

                if (lastChar == '_')
                {
                    output.Append(char.ToUpper(c));
                    lastChar = c;
                }
                else
                {
                    if (c != '_')
                        output.Append(c);
                    lastChar = c;
                }
            }

            return output.ToString();
        }

        private static bool IsUpperCamelCase(string input)
        {
            if (input.Length == 0) return false;

            return !input.Contains('_') && !input.Contains('-') && char.IsUpper(input[0]);
        }

        private static bool IsLowerCamelCase(string input)
        {
            if (input.Length == 0) return false;

            return !input.Contains('_') && !input.Contains('-') && !char.IsUpper(input[0]);
        }

        private static bool IsKebabCase(string input)
        {
            if (!input.Contains('-'))
                return false;

            foreach (var c in input)
            {
                if (char.IsDigit(c))
                    continue;

                if (c != '-' && !char.IsLower(c))
                    return false;
            }

            return true;
        }

        private static bool IsUpperSnakeCase(string input)
        {
            if (input.Length == 0) return false;

            return input.Contains('_') && char.IsUpper(input[0]);
        }

        private static bool IsLowerSnakeCase(string input)
        {
            if (input.Length == 0) return false;

            return input.Contains('_') && !char.IsUpper(input[0]);
        }
    }
}
