using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Client.Utils
{
    public class CustomLabel
    {
        public static Dictionary<string, string> messages = new Dictionary<string, string>
        {
            {
                "require",
                "{fieldName} Is Required"
            },
            {
                "length",
                "{fieldName} max length {length}"
            },
            {
                "format",
                "format {fieldName} is invalid"
            }
        };

        public static string format(string messageName, Dictionary<string, string> parameters)
        {
            if (!messages.ContainsKey(messageName)) return "";
            return Regex.Replace(messages[messageName], @"\{(.+?)\}", m => parameters[m.Groups[1].Value]);
        }
    }
}
