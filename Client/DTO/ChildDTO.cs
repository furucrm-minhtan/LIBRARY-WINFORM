using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Client.Partials.Validation;
using static Client.Utils.Helpers;

namespace Client.DTO
{
    public class ChildDTO : Server.DTO.ChildDTO
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
                    fieldToDisplayForm["School"].fieldName,
                    new ValidationOptions {
                        IsRequired = false,
                        MaxLength = 30,
                        TypeControl = TypeControl.Text,
                        ErrorMessages = new Dictionary<ErrorType, string>
                        {
                            {
                                ErrorType.Length,
                                fieldToDisplayForm["School"].errorMessages[ErrorType.Length]
                            }
                        }
                    }
                },
                {
                    fieldToDisplayForm["Class"].fieldName,
                    new ValidationOptions {
                        IsRequired = false,
                        MaxLength = 5,
                        TypeControl = TypeControl.Text,
                        ErrorMessages = new Dictionary<ErrorType, string>
                        {
                            {
                                ErrorType.Length,
                                fieldToDisplayForm["Class"].errorMessages[ErrorType.Length]
                            }
                        }
                    }
                }
            };
        }
    }
}
