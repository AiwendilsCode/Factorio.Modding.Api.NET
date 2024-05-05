using System.Text;

namespace Factorio.Modding.Api.Common.Extensions
{
    public static class StringBuilderExtensions
    {
        public static void  AddIndentation(this StringBuilder sb, int count)
        {
            for (int i = 0; i < count; i++)
            {
                sb.Append('\t');
            }
        }
    }
}
