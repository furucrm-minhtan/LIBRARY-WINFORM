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

            try
            {
                if(bus.store(data))
                {
                    Console.WriteLine("Tạo Tài Khoản Thành Công");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Tạo Tài Khoản Thất Bại");
        }

        private AdultDTO getAdultDataOnForm()
        {
            AdultDTO reader = new AdultDTO();
            reader.DisplayName = Name.Text;
            reader.UserName = User_Name.Text;
            reader.Birth = Birth_Date.Text;
            reader.Email = Email.Text;
            reader.PhoneNumber = Phone.Text;
            reader.Job = Job.Text;
            reader.Id = CMND.Text;
            reader.IssuedPlace = Issued_Place.Text;
            reader.Nation = Nation.Text;
            reader.Nationality = Nationality.Text;

            return reader;
        }
    }
}
