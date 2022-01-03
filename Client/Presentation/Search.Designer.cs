
namespace Client.Presentation
{
    partial class Search
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.TextBox();
            this.ListBookSearchName = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.TextBox();
            this.ListBookSearchAuthor = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.PublishDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.ListBookSearchPublishDate = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Tag = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ListBookSearchTag = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListBookSearchName)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListBookSearchAuthor)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListBookSearchPublishDate)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListBookSearchTag)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 447);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Name);
            this.tabPage1.Controls.Add(this.ListBookSearchName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(793, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tìm Theo Tên Sách";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên Sách";
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(194, 18);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(401, 20);
            this.Name.TabIndex = 1;
            // 
            // ListBookSearchName
            // 
            this.ListBookSearchName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListBookSearchName.Location = new System.Drawing.Point(6, 60);
            this.ListBookSearchName.Name = "ListBookSearchName";
            this.ListBookSearchName.Size = new System.Drawing.Size(778, 355);
            this.ListBookSearchName.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.Author);
            this.tabPage2.Controls.Add(this.ListBookSearchAuthor);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(793, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tìm Theo Tên Tác Giả";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên Tác Giả";
            // 
            // Author
            // 
            this.Author.Location = new System.Drawing.Point(197, 12);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(401, 20);
            this.Author.TabIndex = 4;
            // 
            // ListBookSearchAuthor
            // 
            this.ListBookSearchAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListBookSearchAuthor.Location = new System.Drawing.Point(6, 59);
            this.ListBookSearchAuthor.Name = "ListBookSearchAuthor";
            this.ListBookSearchAuthor.Size = new System.Drawing.Size(781, 356);
            this.ListBookSearchAuthor.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.PublishDate);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.ListBookSearchPublishDate);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(793, 421);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tìm Theo Ngày Xuất Bản";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // PublishDate
            // 
            this.PublishDate.Location = new System.Drawing.Point(286, 15);
            this.PublishDate.Name = "PublishDate";
            this.PublishDate.Size = new System.Drawing.Size(200, 20);
            this.PublishDate.TabIndex = 9;
            this.PublishDate.ValueChanged += new System.EventHandler(this.PublishDate_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ngày Xuất Bản";
            // 
            // ListBookSearchPublishDate
            // 
            this.ListBookSearchPublishDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListBookSearchPublishDate.Location = new System.Drawing.Point(6, 59);
            this.ListBookSearchPublishDate.Name = "ListBookSearchPublishDate";
            this.ListBookSearchPublishDate.Size = new System.Drawing.Size(781, 359);
            this.ListBookSearchPublishDate.TabIndex = 6;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.Tag);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.ListBookSearchTag);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(793, 421);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Tìm Theo Thể Loại";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Tag
            // 
            this.Tag.FormattingEnabled = true;
            this.Tag.Location = new System.Drawing.Point(286, 16);
            this.Tag.Name = "Tag";
            this.Tag.Size = new System.Drawing.Size(224, 21);
            this.Tag.TabIndex = 12;
            this.Tag.SelectedValueChanged += new System.EventHandler(this.Tag_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Thể Loại";
            // 
            // ListBookSearchTag
            // 
            this.ListBookSearchTag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListBookSearchTag.Location = new System.Drawing.Point(6, 57);
            this.ListBookSearchTag.Name = "ListBookSearchTag";
            this.ListBookSearchTag.Size = new System.Drawing.Size(781, 358);
            this.ListBookSearchTag.TabIndex = 10;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            //this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListBookSearchName)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListBookSearchAuthor)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListBookSearchPublishDate)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListBookSearchTag)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView ListBookSearchName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Author;
        private System.Windows.Forms.DataGridView ListBookSearchAuthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView ListBookSearchPublishDate;
        private System.Windows.Forms.DateTimePicker PublishDate;
        private System.Windows.Forms.ComboBox Tag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView ListBookSearchTag;
    }
}