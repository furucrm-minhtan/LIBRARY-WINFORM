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
            System.Windows.Controls.TextBox txtBox = (System.Windows.Controls.TextBox)Sender;

            switch (txtBox.Name)
            {
                case "Name":
                    ListBookSearchName.DataSource = SearchBus.getBooksWithName(txtBox.Text);
                    break;
                case "Author":
                    ListBookSearchName.DataSource = SearchBus.getBooksWithAuthor(txtBox.Text);
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
            Tag.DataSource = Helpers.createOptionsForCombobox(new List<Object>(TagBus.getAllTag()), "Id", "Name", true);
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
    }
}
