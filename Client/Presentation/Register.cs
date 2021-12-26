using Client.DTO;
using Server.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Presentation
{
    public partial class Register : Form
    {
        private ReaderBUS bus;

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
                return;
            }

            try
            {
                if(bus.store(data))
                {
                    MessageBox.Show("Tạo Tài Khoản Thành Công");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            MessageBox.Show("Tạo Tài Khoản Thất Bại");
        }

        private void SignupChild_Click(object sender, EventArgs e)
        {
            ChildDTO data = getChildDataOnForm();

            try
            {
                if (bus.store(data))
                {
                    MessageBox.Show("Tạo Tài Khoản Thành Công");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            CMessageBox.Show("Tạo Tài Khoản Thất Bại");
        }

        private AdultDTO getAdultDataOnForm()
        {
            AdultDTO reader = new AdultDTO();
            reader.DisplayName = Display_Name.Text;
            reader.UserName = User_Name.Text;
            reader.Birth = Birth_Date.Text;
            reader.Email = Email.Text;
            reader.PhoneNumber = Phone.Text;
            reader.Sex = Sex.Text;
            reader.Job = Job.Text;
            reader.Id = CMND.Text;
            reader.IssuedPlace = Issued_Place.Text;
            reader.Nation = Nation.Text;
            reader.Nationality = Nationality.Text;
            reader.Degree = Degree.Text;
            reader.Type = "Adult";

            return reader;
        }

        private ChildDTO getChildDataOnForm()
        {
            ChildDTO reader = new ChildDTO();
            reader.DisplayName = Display_Name_Child.Text;
            reader.UserName = User_Name_Child.Text;
            reader.Birth = Birth_Date_Child.Text;
            reader.Email = Email_Child.Text;
            reader.Sex = Sex_Child.Text;
            reader.PhoneNumber = Phone_Child.Text;
            reader.School = School.Text;
            reader.Class = Class.Text;
            reader.Protector = Protector.SelectedValue.ToString();
            reader.Type = "Child";

            return reader;
        }

        private void UploadAvatar_Click(object sender, EventArgs e)
        {

        }
    }
}
