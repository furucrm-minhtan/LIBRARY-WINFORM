using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Utils
{
    public interface Validation
    {
        bool validate();
        bool checkRequired();
        bool checkValidationRule();
    }
}
