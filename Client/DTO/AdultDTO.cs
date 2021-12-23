using Client.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Client.DTO
{
    public class AdultDTO : Server.DTO.AdultDTO, Validation
    {
        List<string> requiredFields;
        Dictionary<string, ValidationRule> validationRule = new Dictionary<string, ValidationRule>()
        {
            { "DisplayName", new ValidationRule { length = 255 } },
            { "UserName", new ValidationRule { length = 50 } },
            { "Email", new ValidationRule { length = 100, regex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$" } },
            { "PhoneNumber", new ValidationRule { length = 100 } },
            { "Nation", new ValidationRule { length = 10 } },
            { "Nationality", new ValidationRule { length = 100 } },
            { "Id", new ValidationRule { length = 15 } },
            { "IssuedPlace", new ValidationRule { length = 20 } },
            { "Job", new ValidationRule { length = 20 } },
            { "Degree", new ValidationRule { length = 10 } }
        };
        
        public bool validate()
        {
            throw new NotImplementedException();
        }

        public bool checkRequired()
        {
            foreach (string field in requiredFields)
            {
                if (String.IsNullOrEmpty(this.GetType().GetProperty(field).GetValue(this).ToString())) return false;
            }

            return true;
        }

        public bool checkValidationRule()
        {
            foreach (var rule in validationRule)
            {
                string value = this.GetType().GetProperty(rule.Key).GetValue(this).ToString();
                if (value.Length > rule.Value.length) return false;
                if (!String.IsNullOrEmpty(rule.Value.regex))
                {
                    Regex regex = new Regex(rule.Value.regex);
                    Match match = regex.Match(value);
                    if (!match.Success) return false; 
                }
            }

            return true;
        }
    }
}
