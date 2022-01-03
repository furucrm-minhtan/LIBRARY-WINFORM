using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Client.Partials.Validation;

namespace Client.Utils
{
    public class Helpers : Server.Utils.Helpers
    {
        public class InputValidationSetting
        {
            public string fieldName { get; set; }
            public Dictionary<ErrorType, string> errorMessages { get; set; }
        }
    }
}
