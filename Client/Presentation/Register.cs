using Client.DTO;
using Client.Utils;
using Server.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Client.Partials.Validation;
using static Client.Utils.Helpers;

namespace Client.Presentation
{
    public partial class Register : Form
    {
        private ReaderBUS bus;
        private string filePath;

        public Register()
        {
            InitializeComponent();
            this.bus = new ReaderBUS();
        }

        private void SignupAdult_Click(object sender, EventArgs e)
        {
            ValidateChildren();
            if (RegisterAdultValidation.hasError())
            {
                MessageBox.Show("Xin nhập thông tin được yêu cầu");
                return;
            }
            AdultDTO data = getAdultDataOnForm();

            try
            {
                if(!String.IsNullOrEmpty(filePath))
                {
                    Avatar.Image.Dispose();
                    Helpers.copyFile(filePath, data.Avatar);
                }
                if(bus.checkUserExist(data))
                {
                    MessageBox.Show("Tên Tài Khoản Đã Tồn Tại");
                    return;
                }
                if (bus.store(data))
                {
                    MessageBox.Show("Tạo Tài Khoản Thành Công");
                }
                Helpers.removeFile(data.Avatar);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Tạo Tài Khoản Thất Bại");
            }
        }

        private void SignupChild_Click(object sender, EventArgs e)
        {
            ValidateChildren();

            if (RegisterChildValidation.hasError())
            {
                MessageBox.Show("Xin nhập thông tin được yêu cầu");
                return;
            }
            ChildDTO data = getChildDataOnForm();

            try
            {
                if (!String.IsNullOrEmpty(filePath))
                {
                    Child_Avatar.Image.Dispose();
                    Helpers.copyFile(filePath, data.Avatar);
                }
                
                if (bus.checkUserExist(data))
                {
                    MessageBox.Show("Tên Tài Khoản Đã Tồn Tại");
                    return;
                }
                if (bus.store(data))
                {
                    MessageBox.Show("Tạo Tài Khoản Thành Công");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Tạo Tài Khoản Thất Bại");
            }
        }

        private AdultDTO getAdultDataOnForm()
        {
            AdultDTO reader = new AdultDTO();
            reader.DisplayName = Display_Name.Text;
            reader.UserName = User_Name.Text;
            reader.Birth = Birth_Date.Value.Date.ToString("yyyy-MM-dd");
            reader.Email = Email.Text;
            reader.PhoneNumber = Phone.Text;
            reader.Sex = Sex.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Text;
            reader.Job = Job.Text;
            reader.Id = CMND.Text;
            reader.IssuedPlace = Issued_Place.Text;
            reader.Nation = Nation.Text;
            reader.Nationality = Nationality.Text;
            reader.Degree = Degree.Text;
            reader.Type = "Adult";
            reader.Avatar = Helpers.generateDestinationPathImage(Helpers.getUnixTime().ToString(), Path.GetExtension(filePath));

            return reader;
        }

        private ChildDTO getChildDataOnForm()
        {
            ChildDTO reader = new ChildDTO();
            reader.DisplayName = Display_Name_Child.Text;
            reader.UserName = User_Name_Child.Text;
            reader.Birth = Birth_Date_Child.Value.Date.ToString("yyyy-MM-dd"); ;
            reader.Email = Email_Child.Text;
            reader.Sex = Sex.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Text;
            reader.PhoneNumber = Phone_Child.Text;
            reader.School = School.Text;
            reader.Class = Class.Text;
            reader.Protector = Protector.SelectedValue.ToString();
            reader.Type = "Child";
            reader.Avatar = Helpers.generateDestinationPathImage(Helpers.getUnixTime().ToString(), Path.GetExtension(filePath));

            return reader;
        }

        private void UploadAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (openFileDialog.ShowDialog().Equals(DialogResult.OK))
            {
                filePath = openFileDialog.FileName;
                Avatar.Image = new Bitmap(filePath);
            }
        }

        private void UploadAvatarChild_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (openFileDialog.ShowDialog().Equals(DialogResult.OK))
            {
                filePath = openFileDialog.FileName;
                Child_Avatar.Image = new Bitmap(filePath);
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            Birth_Date.CustomFormat = "dd/MM/yyyy";
            Birth_Date.Format = DateTimePickerFormat.Custom;
            Birth_Date_Child.CustomFormat = "dd/MM/yyyy";
            Birth_Date_Child.Format = DateTimePickerFormat.Custom;
            Protector.DisplayMember = "label";
            Protector.ValueMember = "value";
            Protector.DataSource = Helpers.createOptionsForCombobox(new List<Object>(bus.getAdultReader()), "UserName", "MADG", true);
            setValidationForm();
        }

        private void setValidationForm()
        {
            AdultDTO.fieldToDisplayForm = getValidationInputSettingForAdult();
            Dictionary<string, ValidationOptions> adultValidationOptions = AdultDTO.getValidationForClient();
            List<Control> adultControls = new List<Control>()
            {
                Display_Name,
                User_Name,
                Phone,
                Email,
                Job,
                Nation,
                Nationality,
                CMND,
                Issued_Place,
                Degree
            };
            RegisterAdultValidation.AddControls(adultControls, adultValidationOptions);

            ChildDTO.fieldToDisplayForm = getValidationInputSettingForChild();
            Dictionary<string, ValidationOptions> childValidationOptions = ChildDTO.getValidationForClient();
            List<Control> childControls = new List<Control>()
            {
                Display_Name_Child,
                User_Name_Child,
                Phone_Child,
                Email_Child,
                School,
                Class
            };
            RegisterChildValidation.AddControls(childControls, childValidationOptions);
        }

        private Dictionary<string, InputValidationSetting> getValidationInputSettingForAdult()
        {
            return new Dictionary<string, InputValidationSetting>
            {
                {
                    "DisplayName",
                    new InputValidationSetting
                    {
                        fieldName = "Display_Name",
                        errorMessages = new Dictionary<ErrorType, string>
                        {
                            {
                                ErrorType.Require,
                                CustomLabel.format(
                                    "require",
                                    new Dictionary<string, string>
                                    {
                                        {
                                            "fieldName",
                                            Display_Name_Label.Text
                                        }
                                    }
                                )
                            },
                             {
                                ErrorType.Length,
                                CustomLabel.format(
                                    "length",
                                    new Dictionary<string, string>
                                    {
                                        {
                                            "fieldName",
                                            Display_Name_Label.Text
                                        },
                                        {
                                            "length",
                                            "255"
                                        }
                                    }
                                )
                            }
                        }
                    }
                },
                {
                    "UserName",
                    new InputValidationSetting
                    {
                        fieldName = "User_Name",
                        errorMessages = new Dictionary<ErrorType, string>
                        {
                            {
                                ErrorType.Require,
                                CustomLabel.format(
                                    "require",
                                    new Dictionary<string, string>
                                    {
                                        {
                                            "fieldName",
                                            User_Name_Label.Text
                                        }
                                    }
                                )
                            },
                             {
                                ErrorType.Length,
                                CustomLabel.format(
                                    "length",
                                    new Dictionary<string, string>
                                    {
                                        {
                                            "fieldName",
                                            User_Name_Label.Text
                                        },
                                        {
                                            "length",
                                            "50"
                                        }
                                    }
                                )
                            }
                        }
                    }
                },
                {
                    "Email",
                    new InputValidationSetting
                    {
                        fieldName = "Email",
                        errorMessages = new Dictionary<ErrorType, string>
                        {
                            {
                                ErrorType.Require,
                                CustomLabel.format(
                                    "require",
                                    new Dictionary<string, string>
                                    {
                                        {
                                            "fieldName",
                                            Email_Label.Text
                                        }
                                    }
                                )
                            },
                            {
                                ErrorType.Length,
                                CustomLabel.format(
                                    "length",
                                    new Dictionary<string, string>
                                    {
                                        {
                                            "fieldName",
                                            Email_Label.Text
                                        },
                                        {
                                            "length",
                                            "10"
                                        }
                                    }
                                )
                            },
                            {
                                ErrorType.Format,
                                CustomLabel.format(
                                    "format",
                                    new Dictionary<string, string>
                                    {
                                        {
                                            "fieldName",
                                            Email_Label.Text
                                        }
                                    }
                                )
                            }
                        }
                    }
                },
                {
                    "PhoneNumber",
                    new InputValidationSetting
                    {
                        fieldName = "Phone",
                        errorMessages = new Dictionary<ErrorType, string>
                        {
                            {
                                ErrorType.Require,
                                CustomLabel.format(
                                    "require",
                                    new Dictionary<string, string>
                                    {
                                        {
                                            "fieldName",
                                            Phone_Label.Text
                                        }
                                    }
                                )
                            },
                            {
                                ErrorType.Format,
                                CustomLabel.format(
                                    "format",
                                    new Dictionary<string, string>
                                    {
                                        {
                                            "fieldName",
                                            Phone_Label.Text
                                        }
                                    }
                                )
                            },
                            {
                                ErrorType.Length,
                                CustomLabel.format(
                                    "length",
                                    new Dictionary<string, string>
                                    {
                                        {
                                            "fieldName",
                                            Phone_Label.Text
                                        },
                                        {
                                            "length",
                                            "11"
                                        }
                                    }
                                )
                            }
                        },
                    }
                },
                {
                    "Job",
                    new InputValidationSetting
                    {
                        fieldName = "Job",
                        errorMessages = new Dictionary<ErrorType, string>
                        {
                            {
                                ErrorType.Length,
                                CustomLabel.format(
                                    "length",
                                    new Dictionary<string, string>
                                    {
                                        {
                                            "fieldName",
                                            Job_Label.Text
                                        },
                                        {
                                            "length",
                                            "11"
                                        }
                                    }
                                )
                            }
                        },
                    }
                },
                {
                    "Nation",
                    new InputValidationSetting
                    {
                        fieldName = "Nation",
                        errorMessages = new Dictionary<ErrorType, string>
                        {
                            {
                                ErrorType.Length,
                                CustomLabel.format(
                                    "length",
                                    new Dictionary<string, string>
                                    {
                                        {
                                            "fieldName",
                                            Nation_Label.Text
                                        },
                                        {
                                            "length",
                                            "10"
                                        }
                                    }
                                )
                            }
                        },
                    }
                },
                {
                    "Nationality",
                    new InputValidationSetting
                    {
                        fieldName = "Nationality",
                        errorMessages = new Dictionary<ErrorType, string>
                        {
                            {
                                ErrorType.Length,
                                CustomLabel.format(
                                    "length",
                                    new Dictionary<string, string>
                                    {
                                        {
                                            "fieldName",
                                            Nationality_Label.Text
                                        },
                                        {
                                            "length",
                                            "100"
                                        }
                                    }
                                )
                            }
                        },
                    }
                },
                {
                    "Id",
                    new InputValidationSetting
                    {
                        fieldName = "CMND",
                        errorMessages = new Dictionary<ErrorType, string>
                        {
                            {
                                ErrorType.Length,
                                CustomLabel.format(
                                    "length",
                                    new Dictionary<string, string>
                                    {
                                        {
                                            "fieldName",
                                            Id_Label.Text
                                        },
                                        {
                                            "length",
                                            "10"
                                        }
                                    }
                                )
                            }
                        },
                    }
                },
                {
                    "IssuedPlace",
                    new InputValidationSetting
                    {
                        fieldName = "Issued_Place",
                        errorMessages = new Dictionary<ErrorType, string>
                        {
                            {
                                ErrorType.Length,
                                CustomLabel.format(
                                    "length",
                                    new Dictionary<string, string>
                                    {
                                        {
                                            "fieldName",
                                            Issued_Place_Label.Text
                                        },
                                        {
                                            "length",
                                            "20"
                                        }
                                    }
                                )
                            }
                        },
                    }
                },
                {
                    "Degree",
                    new InputValidationSetting
                    {
                        fieldName = "Degree",
                        errorMessages = new Dictionary<ErrorType, string>
                        {
                            {
                                ErrorType.Length,
                                CustomLabel.format(
                                    "length",
                                    new Dictionary<string, string>
                                    {
                                        {
                                            "fieldName",
                                            Degree_Label.Text
                                        },
                                        {
                                            "length",
                                            "10"
                                        }
                                    }
                                )
                            }
                        },
                    }
                }
            };
        }
        private Dictionary<string, InputValidationSetting> getValidationInputSettingForChild()
        {
            return new Dictionary<string, InputValidationSetting>
            {
                {
                    "DisplayName",
                    new InputValidationSetting
                    {
                        fieldName = "Display_Name_Child",
                        errorMessages = new Dictionary<ErrorType, string>
                        {
                            {
                                ErrorType.Require,
                                CustomLabel.format(
                                    "require",
                                    new Dictionary<string, string>
                                    {
                                        {
                                            "fieldName",
                                            Display_Name_Child_Label.Text
                                        }
                                    }
                                )
                            },
                             {
                                ErrorType.Length,
                                CustomLabel.format(
                                    "length",
                                    new Dictionary<string, string>
                                    {
                                        {
                                            "fieldName",
                                            Display_Name_Child_Label.Text
                                        },
                                        {
                                            "length",
                                            "255"
                                        }
                                    }
                                )
                            }
                        }
                    }
                },
                {
                    "UserName",
                    new InputValidationSetting
                    {
                        fieldName = "User_Name_Child",
                        errorMessages = new Dictionary<ErrorType, string>
                        {
                            {
                                ErrorType.Require,
                                CustomLabel.format(
                                    "require",
                                    new Dictionary<string, string>
                                    {
                                        {
                                            "fieldName",
                                            User_Name_Child_Label.Text
                                        }
                                    }
                                )
                            },
                             {
                                ErrorType.Length,
                                CustomLabel.format(
                                    "length",
                                    new Dictionary<string, string>
                                    {
                                        {
                                            "fieldName",
                                            User_Name_Child_Label.Text
                                        },
                                        {
                                            "length",
                                            "50"
                                        }
                                    }
                                )
                            }
                        }
                    }
                },
                {
                    "Email",
                    new InputValidationSetting
                    {
                        fieldName = "Email_Child",
                        errorMessages = new Dictionary<ErrorType, string>
                        {
                            {
                                ErrorType.Require,
                                CustomLabel.format(
                                    "require",
                                    new Dictionary<string, string>
                                    {
                                        {
                                            "fieldName",
                                            Email_Child_Label.Text
                                        }
                                    }
                                )
                            },
                            {
                                ErrorType.Length,
                                CustomLabel.format(
                                    "length",
                                    new Dictionary<string, string>
                                    {
                                        {
                                            "fieldName",
                                            Email_Child_Label.Text
                                        },
                                        {
                                            "length",
                                            "10"
                                        }
                                    }
                                )
                            },
                            {
                                ErrorType.Format,
                                CustomLabel.format(
                                    "format",
                                    new Dictionary<string, string>
                                    {
                                        {
                                            "fieldName",
                                            Email_Child_Label.Text
                                        }
                                    }
                                )
                            }
                        }
                    }
                },
                {
                    "PhoneNumber",
                    new InputValidationSetting
                    {
                        fieldName = "Phone_Child",
                        errorMessages = new Dictionary<ErrorType, string>
                        {
                            {
                                ErrorType.Require,
                                CustomLabel.format(
                                    "require",
                                    new Dictionary<string, string>
                                    {
                                        {
                                            "fieldName",
                                            Phone_Child_Label.Text
                                        }
                                    }
                                )
                            },
                            {
                                ErrorType.Length,
                                CustomLabel.format(
                                    "length",
                                    new Dictionary<string, string>
                                    {
                                        {
                                            "fieldName",
                                            Phone_Child_Label.Text
                                        },
                                        {
                                            "length",
                                            "11"
                                        }
                                    }
                                )
                            }
                        },
                    }
                },
                {
                    "School",
                    new InputValidationSetting
                    {
                        fieldName = "School",
                        errorMessages = new Dictionary<ErrorType, string>
                        {
                            {
                                ErrorType.Length,
                                CustomLabel.format(
                                    "length",
                                    new Dictionary<string, string>
                                    {
                                        {
                                            "fieldName",
                                            School_Label.Text
                                        },
                                        {
                                            "length",
                                            "50"
                                        }
                                    }
                                )
                            }
                        },
                    }
                },
                {
                    "Class",
                    new InputValidationSetting
                    {
                        fieldName = "Class",
                        errorMessages = new Dictionary<ErrorType, string>
                        {
                            {
                                ErrorType.Length,
                                CustomLabel.format(
                                    "length",
                                    new Dictionary<string, string>
                                    {
                                        {
                                            "fieldName",
                                            Issued_Place_Label.Text
                                        },
                                        {
                                            "length",
                                            "10"
                                        }
                                    }
                                )
                            }
                        },
                    }
                }
            };
        }
    }
}
