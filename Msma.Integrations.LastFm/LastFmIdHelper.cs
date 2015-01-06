using System;
using System.Linq;

namespace Msma.Integrations.LastFm
{
    public class LastFmIdHelper
    {
        public static string ConvertNameToId(string name)
        {
            return name.Replace(' ', '+');
        }

        public static string ConvertIdToName(string id)
        {
            return id.Replace('+', ' ');
        }

        public static string ConvertNamesToId(string artistName, string workName)
        {
            return ConvertNameToId(artistName) + "|" + ConvertNameToId(workName);
        }

        public static Tuple<string, string> ConvertIdToNames(string id)
        {
            string[] identificationParameters = id.Split('|');
            if (!identificationParameters.Any() || identificationParameters.Length != 2)
                return null;

            var artistName = identificationParameters[0];
            var workName = identificationParameters[1];

            return new Tuple<string, string>(ConvertIdToName(artistName), ConvertIdToName(workName));
        }
    }
}
