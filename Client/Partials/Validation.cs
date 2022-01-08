using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Partials
{
    public partial class Validation : Component
    {
        private Dictionary<string, ValidationOptions> _FieldsDefine = new Dictionary<string, ValidationOptions>();
        private ErrorProvider errorProvider = new ErrorProvider();

        private List<Control> _ControlValidationList = new List<Control>();
        public void AddControl(Control control, Dictionary<string, ValidationOptions> option = null)
        {
            _ControlValidationList.Add(control);
            control.Validating += Validating;
            if (option != null)
            {
                _FieldsDefine.Add(option.Keys.First(), option.Values.First());
            }
        }

        public void AddControls(List<Control> controls, Dictionary<string, ValidationOptions> options)
        {
            foreach (var control in controls)
            {
                AddControl(control);
            }
            _FieldsDefine = options;
        }

        private void Validating(object sender, CancelEventArgs e)
        {
            Control control = (Control)sender;
            ValidationOptions options = _FieldsDefine[control.Name];
            if (options.TypeControl == TypeControl.Text)
            {
                if (options.IsRequired && control.Text.Length == 0)
                {
                    errorProvider.SetError(control, options.ErrorMessages[ErrorType.Require]);
                    control.BackColor = Color.Red;
                    control.ForeColor = Color.White;
                    return;
                }

                if (control.Text.Length > options.MaxLength)
                {
                    errorProvider.SetError(control, options.ErrorMessages[ErrorType.Length]);
                    control.BackColor = Color.Red;
                    control.ForeColor = Color.White;
                    return;
                }

                if (options.RegExString != null)
                {
                    Regex rx = new Regex(options.RegExString);
                    MatchCollection matches = rx.Matches(control.Text);

                    if (matches.Count <= 0)
                    {
                        errorProvider.SetError(control, options.ErrorMessages[ErrorType.Format]);
                        control.BackColor = Color.Red;
                        control.ForeColor = Color.White;
                        return;
                    }
                }
                control.BackColor = Color.White;
                control.ForeColor = Color.Black;
                errorProvider.SetError(control, "");
            }
            else if (options.TypeControl == TypeControl.Combobox)
            {
                var combobox = (ComboBox)control;
                if (options.IsRequired && combobox.SelectedValue.ToString() == "")
                {
                    errorProvider.SetError(control, options.ErrorMessages[ErrorType.Require]);
                    control.BackColor = Color.Red;
                    control.ForeColor = Color.White;
                    return;
                }

                control.BackColor = Color.White;
                control.ForeColor = Color.Black;
                errorProvider.SetError(control, "");
            }
        }

        public bool hasError()
        {
            foreach (var control in _ControlValidationList)
            {
                if (!string.IsNullOrEmpty(errorProvider.GetError(control)))
                {
                    return true;
                }
            }
            return false;
        }

        public enum TypeControl
        {
            Text,
            Combobox
        }

        public enum ErrorType
        {
            Require,
            Length,
            Format
        }

        public class ValidationOptions
        {
            public Dictionary<ErrorType, string> ErrorMessages { get; set; }
            public string RegExString { get; set; }
            public bool IsRequired { get; set; }
            public int MaxLength { get; set; } = 0;

            public TypeControl TypeControl { get; set; }
        }
    }
}
