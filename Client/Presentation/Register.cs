using Client.DTO;
using Server.BUS;
using Server.Utils;
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
            AdultDTO data = getAdultDataOnForm();
            if (!data.validate())
            {
                MessageBox.Show("Xin nhập thông tin được yêu cầu");
                return;
            }

            try
            {
                Avatar.Image.Dispose();
                Utils.copyFile(filePath, data.Avatar);
                if (bus.store(data))
                {
                    MessageBox.Show("Tạo Tài Khoản Thành Công");
                }
                Utils.removeFile(data.Avatar);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Tạo Tài Khoản Thất Bại");
            }
        }

        private void SignupChild_Click(object sender, EventArgs e)
        {
            ChildDTO data = getChildDataOnForm();

            try
            {
                Avatar.Image.Dispose();
                Utils.copyFile(filePath, data.Avatar);
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
            reader.Avatar = Utils.generateDestinationPathImage(DateTime.Today.ToString("yyyyMMddHHmmss"), Path.GetExtension(filePath));
            reader.Password = Utils.hashPassword(Utils.getRandomString(10));

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
            reader.Avatar = Utils.generateDestinationPathImage(DateTime.Today.ToString("yyyyMMddHHmmss"), Path.GetExtension(filePath));
            reader.Password = Utils.hashPassword(Utils.getRandomString(10));

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

        private void Register_Load(object sender, EventArgs e)
        {
            Birth_Date.CustomFormat = "dd/MM/yyyy";
            Birth_Date.Format = DateTimePickerFormat.Custom;
            Birth_Date_Child.CustomFormat = "dd/MM/yyyy";
            Birth_Date_Child.Format = DateTimePickerFormat.Custom;
        }
    }
}
