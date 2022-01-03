
namespace Client.Presentation
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserName = new System.Windows.Forms.TabControl();
            this.AdultRegister = new System.Windows.Forms.TabPage();
            this.Degree = new System.Windows.Forms.TextBox();
            this.Degree_Label = new System.Windows.Forms.Label();
            this.Birth_Date = new System.Windows.Forms.DateTimePicker();
            this.SignupAdult = new System.Windows.Forms.Button();
            this.UploadAvatar = new System.Windows.Forms.Button();
            this.Avatar = new System.Windows.Forms.PictureBox();
            this.Issued_Place = new System.Windows.Forms.TextBox();
            this.Issued_Place_Label = new System.Windows.Forms.Label();
            this.Job = new System.Windows.Forms.TextBox();
            this.Job_Label = new System.Windows.Forms.Label();
            this.Sex = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.CMND = new System.Windows.Forms.TextBox();
            this.Id_Label = new System.Windows.Forms.Label();
            this.Nationality = new System.Windows.Forms.TextBox();
            this.Nationality_Label = new System.Windows.Forms.Label();
            this.Nation = new System.Windows.Forms.TextBox();
            this.Nation_Label = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.TextBox();
            this.Phone_Label = new System.Windows.Forms.Label();
            this.Sex_Label = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.Email_Label = new System.Windows.Forms.Label();
            this.Birth_Date_Label = new System.Windows.Forms.Label();
            this.User_Name = new System.Windows.Forms.TextBox();
            this.User_Name_Label = new System.Windows.Forms.Label();
            this.Display_Name = new System.Windows.Forms.TextBox();
            this.Display_Name_Label = new System.Windows.Forms.Label();
            this.ChildRegister = new System.Windows.Forms.TabPage();
            this.Birth_Date_Child = new System.Windows.Forms.DateTimePicker();
            this.SignupChild = new System.Windows.Forms.Button();
            this.Protector = new System.Windows.Forms.ComboBox();
            this.UploadAvatarChild = new System.Windows.Forms.Button();
            this.Child_Avatar = new System.Windows.Forms.PictureBox();
            this.Class = new System.Windows.Forms.TextBox();
            this.Class_Label = new System.Windows.Forms.Label();
            this.Protector_Label = new System.Windows.Forms.Label();
            this.Sex_Child = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.School = new System.Windows.Forms.TextBox();
            this.School_Label = new System.Windows.Forms.Label();
            this.Phone_Child = new System.Windows.Forms.TextBox();
            this.Phone_Child_Label = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.Email_Child = new System.Windows.Forms.TextBox();
            this.Email_Child_Label = new System.Windows.Forms.Label();
            this.Birth_Date_Child_Label = new System.Windows.Forms.Label();
            this.User_Name_Child = new System.Windows.Forms.TextBox();
            this.User_Name_Child_Label = new System.Windows.Forms.Label();
            this.Display_Name_Child = new System.Windows.Forms.TextBox();
            this.Display_Name_Child_Label = new System.Windows.Forms.Label();
            this.RegisterAdultValidation = new Client.Partials.Validation();
            this.RegisterChildValidation = new Client.Partials.Validation();
            this.UserName.SuspendLayout();
            this.AdultRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).BeginInit();
            this.Sex.SuspendLayout();
            this.ChildRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Child_Avatar)).BeginInit();
            this.Sex_Child.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.Controls.Add(this.AdultRegister);
            this.UserName.Controls.Add(this.ChildRegister);
            this.UserName.Location = new System.Drawing.Point(0, 0);
            this.UserName.Name = "UserName";
            this.UserName.SelectedIndex = 0;
            this.UserName.Size = new System.Drawing.Size(800, 450);
            this.UserName.TabIndex = 0;
            // 
            // AdultRegister
            // 
            this.AdultRegister.Controls.Add(this.Degree);
            this.AdultRegister.Controls.Add(this.Degree_Label);
            this.AdultRegister.Controls.Add(this.Birth_Date);
            this.AdultRegister.Controls.Add(this.SignupAdult);
            this.AdultRegister.Controls.Add(this.UploadAvatar);
            this.AdultRegister.Controls.Add(this.Avatar);
            this.AdultRegister.Controls.Add(this.Issued_Place);
            this.AdultRegister.Controls.Add(this.Issued_Place_Label);
            this.AdultRegister.Controls.Add(this.Job);
            this.AdultRegister.Controls.Add(this.Job_Label);
            this.AdultRegister.Controls.Add(this.Sex);
            this.AdultRegister.Controls.Add(this.CMND);
            this.AdultRegister.Controls.Add(this.Id_Label);
            this.AdultRegister.Controls.Add(this.Nationality);
            this.AdultRegister.Controls.Add(this.Nationality_Label);
            this.AdultRegister.Controls.Add(this.Nation);
            this.AdultRegister.Controls.Add(this.Nation_Label);
            this.AdultRegister.Controls.Add(this.Phone);
            this.AdultRegister.Controls.Add(this.Phone_Label);
            this.AdultRegister.Controls.Add(this.Sex_Label);
            this.AdultRegister.Controls.Add(this.Email);
            this.AdultRegister.Controls.Add(this.Email_Label);
            this.AdultRegister.Controls.Add(this.Birth_Date_Label);
            this.AdultRegister.Controls.Add(this.User_Name);
            this.AdultRegister.Controls.Add(this.User_Name_Label);
            this.AdultRegister.Controls.Add(this.Display_Name);
            this.AdultRegister.Controls.Add(this.Display_Name_Label);
            this.AdultRegister.Location = new System.Drawing.Point(4, 22);
            this.AdultRegister.Name = "AdultRegister";
            this.AdultRegister.Padding = new System.Windows.Forms.Padding(3);
            this.AdultRegister.Size = new System.Drawing.Size(792, 424);
            this.AdultRegister.TabIndex = 0;
            this.AdultRegister.Text = "Đăng Ký Người Lớn";
            this.AdultRegister.UseVisualStyleBackColor = true;
            // 
            // Degree
            // 
            this.Degree.Location = new System.Drawing.Point(482, 290);
            this.Degree.Name = "Degree";
            this.Degree.Size = new System.Drawing.Size(232, 20);
            this.Degree.TabIndex = 56;
            // 
            // Degree_Label
            // 
            this.Degree_Label.AutoSize = true;
            this.Degree_Label.Location = new System.Drawing.Point(419, 293);
            this.Degree_Label.Name = "Degree_Label";
            this.Degree_Label.Size = new System.Drawing.Size(54, 13);
            this.Degree_Label.TabIndex = 57;
            this.Degree_Label.Text = "Bằng Cấp";
            // 
            // Birth_Date
            // 
            this.Birth_Date.Location = new System.Drawing.Point(98, 97);
            this.Birth_Date.Name = "Birth_Date";
            this.Birth_Date.Size = new System.Drawing.Size(233, 20);
            this.Birth_Date.TabIndex = 55;
            // 
            // SignupAdult
            // 
            this.SignupAdult.Location = new System.Drawing.Point(224, 336);
            this.SignupAdult.Name = "SignupAdult";
            this.SignupAdult.Size = new System.Drawing.Size(313, 33);
            this.SignupAdult.TabIndex = 1;
            this.SignupAdult.Text = "Đăng Ký";
            this.SignupAdult.UseVisualStyleBackColor = true;
            this.SignupAdult.Click += new System.EventHandler(this.SignupAdult_Click);
            // 
            // UploadAvatar
            // 
            this.UploadAvatar.Location = new System.Drawing.Point(588, 6);
            this.UploadAvatar.Name = "UploadAvatar";
            this.UploadAvatar.Size = new System.Drawing.Size(75, 23);
            this.UploadAvatar.TabIndex = 27;
            this.UploadAvatar.Text = "Upload Ảnh";
            this.UploadAvatar.UseVisualStyleBackColor = true;
            this.UploadAvatar.Click += new System.EventHandler(this.UploadAvatar_Click);
            // 
            // Avatar
            // 
            this.Avatar.Location = new System.Drawing.Point(482, 6);
            this.Avatar.Name = "Avatar";
            this.Avatar.Size = new System.Drawing.Size(100, 107);
            this.Avatar.TabIndex = 26;
            this.Avatar.TabStop = false;
            // 
            // Issued_Place
            // 
            this.Issued_Place.Location = new System.Drawing.Point(482, 173);
            this.Issued_Place.Name = "Issued_Place";
            this.Issued_Place.Size = new System.Drawing.Size(232, 20);
            this.Issued_Place.TabIndex = 24;
            // 
            // Issued_Place_Label
            // 
            this.Issued_Place_Label.AutoSize = true;
            this.Issued_Place_Label.Location = new System.Drawing.Point(396, 176);
            this.Issued_Place_Label.Name = "Issued_Place_Label";
            this.Issued_Place_Label.Size = new System.Drawing.Size(80, 13);
            this.Issued_Place_Label.TabIndex = 25;
            this.Issued_Place_Label.Text = "Nơi Cấp CMND";
            // 
            // Job
            // 
            this.Job.Location = new System.Drawing.Point(98, 210);
            this.Job.Name = "Job";
            this.Job.Size = new System.Drawing.Size(232, 20);
            this.Job.TabIndex = 22;
            // 
            // Job_Label
            // 
            this.Job_Label.AutoSize = true;
            this.Job_Label.Location = new System.Drawing.Point(22, 213);
            this.Job_Label.Name = "Job_Label";
            this.Job_Label.Size = new System.Drawing.Size(70, 13);
            this.Job_Label.TabIndex = 23;
            this.Job_Label.Text = "Nghề Nghiệp";
            // 
            // Sex
            // 
            this.Sex.Controls.Add(this.radioButton2);
            this.Sex.Controls.Add(this.radioButton1);
            this.Sex.Location = new System.Drawing.Point(98, 236);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(200, 55);
            this.Sex.TabIndex = 21;
            this.Sex.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(59, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(39, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Nữ";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nam";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // CMND
            // 
            this.CMND.Location = new System.Drawing.Point(482, 133);
            this.CMND.Name = "CMND";
            this.CMND.Size = new System.Drawing.Size(232, 20);
            this.CMND.TabIndex = 19;
            // 
            // Id_Label
            // 
            this.Id_Label.AutoSize = true;
            this.Id_Label.Location = new System.Drawing.Point(437, 136);
            this.Id_Label.Name = "Id_Label";
            this.Id_Label.Size = new System.Drawing.Size(39, 13);
            this.Id_Label.TabIndex = 20;
            this.Id_Label.Text = "CMND";
            // 
            // Nationality
            // 
            this.Nationality.Location = new System.Drawing.Point(482, 253);
            this.Nationality.Name = "Nationality";
            this.Nationality.Size = new System.Drawing.Size(232, 20);
            this.Nationality.TabIndex = 17;
            // 
            // Nationality_Label
            // 
            this.Nationality_Label.AutoSize = true;
            this.Nationality_Label.Location = new System.Drawing.Point(419, 256);
            this.Nationality_Label.Name = "Nationality_Label";
            this.Nationality_Label.Size = new System.Drawing.Size(57, 13);
            this.Nationality_Label.TabIndex = 18;
            this.Nationality_Label.Text = "Quốc Tịch";
            // 
            // Nation
            // 
            this.Nation.Location = new System.Drawing.Point(482, 213);
            this.Nation.Name = "Nation";
            this.Nation.Size = new System.Drawing.Size(232, 20);
            this.Nation.TabIndex = 15;
            // 
            // Nation_Label
            // 
            this.Nation_Label.AutoSize = true;
            this.Nation_Label.Location = new System.Drawing.Point(427, 216);
            this.Nation_Label.Name = "Nation_Label";
            this.Nation_Label.Size = new System.Drawing.Size(49, 13);
            this.Nation_Label.TabIndex = 16;
            this.Nation_Label.Text = "Dân Tộc";
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(98, 173);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(232, 20);
            this.Phone.TabIndex = 13;
            // 
            // Phone_Label
            // 
            this.Phone_Label.AutoSize = true;
            this.Phone_Label.Location = new System.Drawing.Point(17, 176);
            this.Phone_Label.Name = "Phone_Label";
            this.Phone_Label.Size = new System.Drawing.Size(75, 13);
            this.Phone_Label.TabIndex = 14;
            this.Phone_Label.Text = "Số Điện Thoại";
            // 
            // Sex_Label
            // 
            this.Sex_Label.AutoSize = true;
            this.Sex_Label.Location = new System.Drawing.Point(41, 257);
            this.Sex_Label.Name = "Sex_Label";
            this.Sex_Label.Size = new System.Drawing.Size(51, 13);
            this.Sex_Label.TabIndex = 10;
            this.Sex_Label.Text = "Giới Tính";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(98, 137);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(232, 20);
            this.Email.TabIndex = 7;
            // 
            // Email_Label
            // 
            this.Email_Label.AutoSize = true;
            this.Email_Label.Location = new System.Drawing.Point(60, 140);
            this.Email_Label.Name = "Email_Label";
            this.Email_Label.Size = new System.Drawing.Size(32, 13);
            this.Email_Label.TabIndex = 8;
            this.Email_Label.Text = "Email";
            // 
            // Birth_Date_Label
            // 
            this.Birth_Date_Label.AutoSize = true;
            this.Birth_Date_Label.Location = new System.Drawing.Point(36, 97);
            this.Birth_Date_Label.Name = "Birth_Date_Label";
            this.Birth_Date_Label.Size = new System.Drawing.Size(56, 13);
            this.Birth_Date_Label.TabIndex = 6;
            this.Birth_Date_Label.Text = "Ngày Sinh";
            // 
            // User_Name
            // 
            this.User_Name.Location = new System.Drawing.Point(98, 57);
            this.User_Name.Name = "User_Name";
            this.User_Name.Size = new System.Drawing.Size(232, 20);
            this.User_Name.TabIndex = 3;
            // 
            // User_Name_Label
            // 
            this.User_Name_Label.AutoSize = true;
            this.User_Name_Label.Location = new System.Drawing.Point(8, 60);
            this.User_Name_Label.Name = "User_Name_Label";
            this.User_Name_Label.Size = new System.Drawing.Size(84, 13);
            this.User_Name_Label.TabIndex = 4;
            this.User_Name_Label.Text = "Tên Đăng Nhập";
            // 
            // Display_Name
            // 
            this.Display_Name.Location = new System.Drawing.Point(98, 16);
            this.Display_Name.Name = "Display_Name";
            this.Display_Name.Size = new System.Drawing.Size(232, 20);
            this.Display_Name.TabIndex = 1;
            // 
            // Display_Name_Label
            // 
            this.Display_Name_Label.AutoSize = true;
            this.Display_Name_Label.Location = new System.Drawing.Point(8, 19);
            this.Display_Name_Label.Name = "Display_Name_Label";
            this.Display_Name_Label.Size = new System.Drawing.Size(84, 13);
            this.Display_Name_Label.TabIndex = 2;
            this.Display_Name_Label.Text = "Tên Người dùng";
            // 
            // ChildRegister
            // 
            this.ChildRegister.Controls.Add(this.Birth_Date_Child);
            this.ChildRegister.Controls.Add(this.SignupChild);
            this.ChildRegister.Controls.Add(this.Protector);
            this.ChildRegister.Controls.Add(this.UploadAvatarChild);
            this.ChildRegister.Controls.Add(this.Child_Avatar);
            this.ChildRegister.Controls.Add(this.Class);
            this.ChildRegister.Controls.Add(this.Class_Label);
            this.ChildRegister.Controls.Add(this.Protector_Label);
            this.ChildRegister.Controls.Add(this.Sex_Child);
            this.ChildRegister.Controls.Add(this.School);
            this.ChildRegister.Controls.Add(this.School_Label);
            this.ChildRegister.Controls.Add(this.Phone_Child);
            this.ChildRegister.Controls.Add(this.Phone_Child_Label);
            this.ChildRegister.Controls.Add(this.label18);
            this.ChildRegister.Controls.Add(this.Email_Child);
            this.ChildRegister.Controls.Add(this.Email_Child_Label);
            this.ChildRegister.Controls.Add(this.Birth_Date_Child_Label);
            this.ChildRegister.Controls.Add(this.User_Name_Child);
            this.ChildRegister.Controls.Add(this.User_Name_Child_Label);
            this.ChildRegister.Controls.Add(this.Display_Name_Child);
            this.ChildRegister.Controls.Add(this.Display_Name_Child_Label);
            this.ChildRegister.Location = new System.Drawing.Point(4, 22);
            this.ChildRegister.Name = "ChildRegister";
            this.ChildRegister.Padding = new System.Windows.Forms.Padding(3);
            this.ChildRegister.Size = new System.Drawing.Size(792, 424);
            this.ChildRegister.TabIndex = 1;
            this.ChildRegister.Text = "Đăng Ký Cho Trẻ Em";
            this.ChildRegister.UseVisualStyleBackColor = true;
            // 
            // Birth_Date_Child
            // 
            this.Birth_Date_Child.Location = new System.Drawing.Point(114, 101);
            this.Birth_Date_Child.Name = "Birth_Date_Child";
            this.Birth_Date_Child.Size = new System.Drawing.Size(233, 20);
            this.Birth_Date_Child.TabIndex = 54;
            // 
            // SignupChild
            // 
            this.SignupChild.Location = new System.Drawing.Point(227, 314);
            this.SignupChild.Name = "SignupChild";
            this.SignupChild.Size = new System.Drawing.Size(345, 32);
            this.SignupChild.TabIndex = 53;
            this.SignupChild.Text = "Đăng Ký ";
            this.SignupChild.UseVisualStyleBackColor = true;
            this.SignupChild.Click += new System.EventHandler(this.SignupChild_Click);
            // 
            // Protector
            // 
            this.Protector.FormattingEnabled = true;
            this.Protector.Location = new System.Drawing.Point(114, 213);
            this.Protector.Name = "Protector";
            this.Protector.Size = new System.Drawing.Size(233, 21);
            this.Protector.TabIndex = 52;
            // 
            // UploadAvatarChild
            // 
            this.UploadAvatarChild.Location = new System.Drawing.Point(605, 10);
            this.UploadAvatarChild.Name = "UploadAvatarChild";
            this.UploadAvatarChild.Size = new System.Drawing.Size(75, 23);
            this.UploadAvatarChild.TabIndex = 51;
            this.UploadAvatarChild.Text = "Upload Ảnh";
            this.UploadAvatarChild.UseVisualStyleBackColor = true;
            this.UploadAvatarChild.Click += new System.EventHandler(this.UploadAvatar_Click);
            // 
            // Child_Avatar
            // 
            this.Child_Avatar.Location = new System.Drawing.Point(499, 10);
            this.Child_Avatar.Name = "Child_Avatar";
            this.Child_Avatar.Size = new System.Drawing.Size(100, 107);
            this.Child_Avatar.TabIndex = 50;
            this.Child_Avatar.TabStop = false;
            // 
            // Class
            // 
            this.Class.Location = new System.Drawing.Point(499, 177);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(232, 20);
            this.Class.TabIndex = 48;
            // 
            // Class_Label
            // 
            this.Class_Label.AutoSize = true;
            this.Class_Label.Location = new System.Drawing.Point(444, 180);
            this.Class_Label.Name = "Class_Label";
            this.Class_Label.Size = new System.Drawing.Size(48, 13);
            this.Class_Label.TabIndex = 49;
            this.Class_Label.Text = "Lớp Học";
            // 
            // Protector_Label
            // 
            this.Protector_Label.AutoSize = true;
            this.Protector_Label.Location = new System.Drawing.Point(34, 217);
            this.Protector_Label.Name = "Protector_Label";
            this.Protector_Label.Size = new System.Drawing.Size(74, 13);
            this.Protector_Label.TabIndex = 47;
            this.Protector_Label.Text = "Người Bảo Hộ";
            // 
            // Sex_Child
            // 
            this.Sex_Child.Controls.Add(this.radioButton3);
            this.Sex_Child.Controls.Add(this.radioButton4);
            this.Sex_Child.Location = new System.Drawing.Point(115, 240);
            this.Sex_Child.Name = "Sex_Child";
            this.Sex_Child.Size = new System.Drawing.Size(200, 55);
            this.Sex_Child.TabIndex = 45;
            this.Sex_Child.TabStop = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(59, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(39, 17);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.Text = "Nữ";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 19);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(47, 17);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Nam";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // School
            // 
            this.School.Location = new System.Drawing.Point(499, 137);
            this.School.Name = "School";
            this.School.Size = new System.Drawing.Size(232, 20);
            this.School.TabIndex = 43;
            // 
            // School_Label
            // 
            this.School_Label.AutoSize = true;
            this.School_Label.Location = new System.Drawing.Point(429, 141);
            this.School_Label.Name = "School_Label";
            this.School_Label.Size = new System.Drawing.Size(64, 13);
            this.School_Label.TabIndex = 44;
            this.School_Label.Text = "Trường Học";
            // 
            // Phone_Child
            // 
            this.Phone_Child.Location = new System.Drawing.Point(115, 177);
            this.Phone_Child.Name = "Phone_Child";
            this.Phone_Child.Size = new System.Drawing.Size(232, 20);
            this.Phone_Child.TabIndex = 37;
            // 
            // Phone_Child_Label
            // 
            this.Phone_Child_Label.AutoSize = true;
            this.Phone_Child_Label.Location = new System.Drawing.Point(34, 180);
            this.Phone_Child_Label.Name = "Phone_Child_Label";
            this.Phone_Child_Label.Size = new System.Drawing.Size(75, 13);
            this.Phone_Child_Label.TabIndex = 38;
            this.Phone_Child_Label.Text = "Số Điện Thoại";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(58, 261);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 13);
            this.label18.TabIndex = 36;
            this.label18.Text = "Giới Tính";
            // 
            // Email_Child
            // 
            this.Email_Child.Location = new System.Drawing.Point(115, 141);
            this.Email_Child.Name = "Email_Child";
            this.Email_Child.Size = new System.Drawing.Size(232, 20);
            this.Email_Child.TabIndex = 34;
            // 
            // Email_Child_Label
            // 
            this.Email_Child_Label.AutoSize = true;
            this.Email_Child_Label.Location = new System.Drawing.Point(77, 144);
            this.Email_Child_Label.Name = "Email_Child_Label";
            this.Email_Child_Label.Size = new System.Drawing.Size(32, 13);
            this.Email_Child_Label.TabIndex = 35;
            this.Email_Child_Label.Text = "Email";
            // 
            // Birth_Date_Child_Label
            // 
            this.Birth_Date_Child_Label.AutoSize = true;
            this.Birth_Date_Child_Label.Location = new System.Drawing.Point(53, 101);
            this.Birth_Date_Child_Label.Name = "Birth_Date_Child_Label";
            this.Birth_Date_Child_Label.Size = new System.Drawing.Size(56, 13);
            this.Birth_Date_Child_Label.TabIndex = 33;
            this.Birth_Date_Child_Label.Text = "Ngày Sinh";
            // 
            // User_Name_Child
            // 
            this.User_Name_Child.Location = new System.Drawing.Point(115, 61);
            this.User_Name_Child.Name = "User_Name_Child";
            this.User_Name_Child.Size = new System.Drawing.Size(232, 20);
            this.User_Name_Child.TabIndex = 30;
            // 
            // User_Name_Child_Label
            // 
            this.User_Name_Child_Label.AutoSize = true;
            this.User_Name_Child_Label.Location = new System.Drawing.Point(25, 64);
            this.User_Name_Child_Label.Name = "User_Name_Child_Label";
            this.User_Name_Child_Label.Size = new System.Drawing.Size(84, 13);
            this.User_Name_Child_Label.TabIndex = 31;
            this.User_Name_Child_Label.Text = "Tên Đăng Nhập";
            // 
            // Display_Name_Child
            // 
            this.Display_Name_Child.Location = new System.Drawing.Point(115, 20);
            this.Display_Name_Child.Name = "Display_Name_Child";
            this.Display_Name_Child.Size = new System.Drawing.Size(232, 20);
            this.Display_Name_Child.TabIndex = 28;
            // 
            // Display_Name_Child_Label
            // 
            this.Display_Name_Child_Label.AutoSize = true;
            this.Display_Name_Child_Label.Location = new System.Drawing.Point(25, 23);
            this.Display_Name_Child_Label.Name = "Display_Name_Child_Label";
            this.Display_Name_Child_Label.Size = new System.Drawing.Size(84, 13);
            this.Display_Name_Child_Label.TabIndex = 29;
            this.Display_Name_Child_Label.Text = "Tên Người dùng";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 398);
            this.Controls.Add(this.UserName);
            this.Name = "Register";
            this.Text = "Đăng Ký Đọc Giả";
            this.Load += new System.EventHandler(this.Register_Load);
            this.UserName.ResumeLayout(false);
            this.AdultRegister.ResumeLayout(false);
            this.AdultRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).EndInit();
            this.Sex.ResumeLayout(false);
            this.Sex.PerformLayout();
            this.ChildRegister.ResumeLayout(false);
            this.ChildRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Child_Avatar)).EndInit();
            this.Sex_Child.ResumeLayout(false);
            this.Sex_Child.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl UserName;
        private System.Windows.Forms.TabPage AdultRegister;
        private System.Windows.Forms.TabPage ChildRegister;
        private System.Windows.Forms.TextBox Display_Name;
        private System.Windows.Forms.Label Display_Name_Label;
        private System.Windows.Forms.Label Birth_Date_Label;
        private System.Windows.Forms.TextBox User_Name;
        private System.Windows.Forms.Label User_Name_Label;
        private System.Windows.Forms.TextBox Nationality;
        private System.Windows.Forms.Label Nationality_Label;
        private System.Windows.Forms.TextBox Nation;
        private System.Windows.Forms.Label Nation_Label;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.Label Phone_Label;
        private System.Windows.Forms.Label Sex_Label;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label Email_Label;
        private System.Windows.Forms.GroupBox Sex;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox Job;
        private System.Windows.Forms.Label Job_Label;
        private System.Windows.Forms.TextBox CMND;
        private System.Windows.Forms.Label Id_Label;
        private System.Windows.Forms.TextBox Issued_Place;
        private System.Windows.Forms.Label Issued_Place_Label;
        private System.Windows.Forms.Button UploadAvatar;
        private System.Windows.Forms.PictureBox Avatar;
        private System.Windows.Forms.ComboBox Protector;
        private System.Windows.Forms.Button UploadAvatarChild;
        private System.Windows.Forms.PictureBox Child_Avatar;
        private System.Windows.Forms.TextBox Class;
        private System.Windows.Forms.Label Class_Label;
        private System.Windows.Forms.Label Protector_Label;
        private System.Windows.Forms.GroupBox Sex_Child;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.TextBox School;
        private System.Windows.Forms.Label School_Label;
        private System.Windows.Forms.TextBox Phone_Child;
        private System.Windows.Forms.Label Phone_Child_Label;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox Email_Child;
        private System.Windows.Forms.Label Email_Child_Label;
        private System.Windows.Forms.Label Birth_Date_Child_Label;
        private System.Windows.Forms.TextBox User_Name_Child;
        private System.Windows.Forms.Label User_Name_Child_Label;
        private System.Windows.Forms.TextBox Display_Name_Child;
        private System.Windows.Forms.Label Display_Name_Child_Label;
        private System.Windows.Forms.Button SignupAdult;
        private System.Windows.Forms.Button SignupChild;
        private System.Windows.Forms.DateTimePicker Birth_Date;
        private System.Windows.Forms.DateTimePicker Birth_Date_Child;
        private System.Windows.Forms.TextBox Degree;
        private System.Windows.Forms.Label Degree_Label;
        private Partials.Validation RegisterAdultValidation;
        private Partials.Validation RegisterChildValidation;
    }
}

