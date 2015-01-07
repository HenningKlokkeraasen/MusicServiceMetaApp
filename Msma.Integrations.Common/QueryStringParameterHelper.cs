using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Msma.Integrations.Common
{
    public class QueryStringParameterHelper
    {
        public static string FlattenQueryStringParameters(IEnumerable<KeyValuePair<string, string>> parameters, bool startWithQuestionMark = false)
        {
            if (parameters == null || !parameters.Any())
                return string.Empty;

            var sb = new StringBuilder();
            var isFirst = true;
            foreach (var param in parameters)
            {
                var separator = isFirst && startWithQuestionMark
                    ? '?'
                    : '&';
                sb.Append(separator + param.Key + '=' + param.Value);
                isFirst = false;
            }
            return sb.ToString();
        }
    }
}
