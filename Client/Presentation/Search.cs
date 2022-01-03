using Server.BUS;
using Server.DTO;
using Server.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Client.Presentation
{
    public partial class Search : Form
    {
        protected SearchBookBUS SearchBus;
        protected TagBUS TagBus;

        public Search()
        {
            InitializeComponent();
        }

        private void TextChanged(object Sender, EventArgs e)
        {
            System.Windows.Forms.TextBox txtBox = (System.Windows.Forms.TextBox)Sender;

            switch (txtBox.Name)
            {
                case "Name":
                    ListBookSearchName.DataSource = SearchBus.getBooksWithName(txtBox.Text);
                    break;
                case "Author":
                    ListBookSearchAuthor.DataSource = SearchBus.getBooksWithAuthor(txtBox.Text);
                    break;
            }
        }

        private void Search_Load(object sender, EventArgs e)
        {
            this.SearchBus = new SearchBookBUS();
            this.TagBus = new TagBUS();
            Name.TextChanged += new EventHandler(TextChanged);
            Author.TextChanged += new EventHandler(TextChanged);
            Tag.DisplayMember = "label";
            Tag.ValueMember = "value";
            Tag.DataSource = Helpers.createOptionsForCombobox(new List<Object>(TagBus.getAllTag()), "Name", "Id", true);
            PublishDate.CustomFormat = "dd/MM/yyyy";
            PublishDate.Format = DateTimePickerFormat.Custom; 
            loadDefaultListBook();
        }

        private void PublishDate_ValueChanged(object sender, EventArgs e)
        {
            ListBookSearchPublishDate.DataSource = SearchBus.getBooksWithPublish(PublishDate.Value.ToString("yyyy-MM-dd"));
        }

        private void Tag_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Tag.SelectedValue != null && !String.IsNullOrEmpty(Tag.SelectedValue?.ToString()))
            {
                ListBookSearchTag.DataSource = SearchBus.getBooksWithTag(int.Parse(Tag.SelectedValue.ToString()));
            }
        }

        private void loadDefaultListBook()
        {
            List<BookDTO> books = SearchBus.getAllBook();
            ListBookSearchName.DataSource = books;
            ListBookSearchAuthor.DataSource = books;
            ListBookSearchPublishDate.DataSource = books;
            ListBookSearchTag.DataSource = books;
        }
    }
}
