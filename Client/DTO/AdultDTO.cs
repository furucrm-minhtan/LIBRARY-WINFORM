using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using static Client.Partials.Validation;
using static Client.Utils.Helpers;

namespace Client.DTO
{
    public class AdultDTO : Server.DTO.AdultDTO
    {
        public static Dictionary<string, InputValidationSetting> fieldToDisplayForm = new Dictionary<string, InputValidationSetting>();

        public static Dictionary<string, ValidationOptions> getValidationForClient()
        {
            return new Dictionary<string, ValidationOptions>
            {
                {
                    fieldToDisplayForm["DisplayName"].fieldName,
                    new ValidationOptions {
                        IsRequired = true,
                        MaxLength = 20,
                        TypeControl = TypeControl.Text,
                        ErrorMessages = new Dictionary<ErrorType, string>
                        {
                            {
                                ErrorType.Require,
                                fieldToDisplayForm["DisplayName"].errorMessages[ErrorType.Require]
                            },
                            {
                                ErrorType.Length,
                                fieldToDisplayForm["DisplayName"].errorMessages[ErrorType.Length]
                            }
                        }
                    }
                },
                {
                    fieldToDisplayForm["Email"].fieldName,
                    new ValidationOptions {
                        IsRequired = true,
                        MaxLength = 100,
                        TypeControl = TypeControl.Text,
                        RegExString = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$",
                        ErrorMessages = new Dictionary<ErrorType, string>
                        {
                            {
                                ErrorType.Require,
                                fieldToDisplayForm["Email"].errorMessages[ErrorType.Require]
                            },
                            {
                                ErrorType.Length,
                                fieldToDisplayForm["Email"].errorMessages[ErrorType.Length]
                            },
                            {
                                ErrorType.Format,
                                fieldToDisplayForm["Email"].errorMessages[ErrorType.Format]
                            }
                        }
                    }
                },
                {
                    fieldToDisplayForm["PhoneNumber"].fieldName,
                    new ValidationOptions {
                        IsRequired = true,
                        MaxLength = 15,
                        RegExString = @"^[0-9]*$",
                        TypeControl = TypeControl.Text,
                        ErrorMessages = new Dictionary<ErrorType, string>
                        {
                            {
                                ErrorType.Require,
                                fieldToDisplayForm["PhoneNumber"].errorMessages[ErrorType.Require]
                            },
                            {
                                ErrorType.Length,
                                fieldToDisplayForm["PhoneNumber"].errorMessages[ErrorType.Length]
                            },
                            {
                                ErrorType.Format,
                                fieldToDisplayForm["PhoneNumber"].errorMessages[ErrorType.Format]
                            }
                        }
                    }
                },
                {
                    fieldToDisplayForm["Nation"].fieldName,
                    new ValidationOptions {
                        IsRequired = false,
                        MaxLength = 10,
                        TypeControl = TypeControl.Text,
                        ErrorMessages = new Dictionary<ErrorType, string>
                        {
                            {
                                ErrorType.Length,
                                fieldToDisplayForm["Nation"].errorMessages[ErrorType.Length]
                            }
                        }
                    }
                },
                {
                    fieldToDisplayForm["Nationality"].fieldName,
                    new ValidationOptions {
                        IsRequired = false,
                        MaxLength = 10,
                        TypeControl = TypeControl.Text,
                        ErrorMessages = new Dictionary<ErrorType, string>
                        {
                            {
                                ErrorType.Length,
                                fieldToDisplayForm["Nationality"].errorMessages[ErrorType.Length]
                            }
                        }
                    }
                },
                {
                    fieldToDisplayForm["Id"].fieldName,
                    new ValidationOptions {
                        IsRequired = false,
                        MaxLength = 20,
                        TypeControl = TypeControl.Text,
                        ErrorMessages = new Dictionary<ErrorType, string>
                        {
                            {
                                ErrorType.Length,
                                fieldToDisplayForm["Id"].errorMessages[ErrorType.Length]
                            }
                        }
                    }
                },
                {
                    fieldToDisplayForm["IssuedPlace"].fieldName,
                    new ValidationOptions {
                        IsRequired = false,
                        MaxLength = 10,
                        TypeControl = TypeControl.Text,
                        ErrorMessages = new Dictionary<ErrorType, string>
                        {
                            {
                                ErrorType.Length,
                                fieldToDisplayForm["IssuedPlace"].errorMessages[ErrorType.Length]
                            }
                        }
                    }
                },
                {
                    fieldToDisplayForm["Job"].fieldName,
                    new ValidationOptions {
                        IsRequired = false,
                        MaxLength = 10,
                        TypeControl = TypeControl.Text,
                        ErrorMessages = new Dictionary<ErrorType, string>
                        {
                            {
                                ErrorType.Length,
                                fieldToDisplayForm["Job"].errorMessages[ErrorType.Length]
                            }
                        }
                    }
                },
                {
                    fieldToDisplayForm["Degree"].fieldName,
                    new ValidationOptions {
                        IsRequired = false,
                        MaxLength = 10,
                        TypeControl = TypeControl.Text,
                        ErrorMessages = new Dictionary<ErrorType, string>
                        {
                            {
                                ErrorType.Length,
                                fieldToDisplayForm["Degree"].errorMessages[ErrorType.Length]
                            }
                        }
                    }
                }
            };
        }
    }
}
