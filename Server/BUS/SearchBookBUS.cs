using Server.DAO;
using Server.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.BUS
{
    public class SearchBookBUS
    {
        public List<BookDTO> getBooks(string typeSearch, BookDTO data)
        {
            List<BookDTO> books = new List<BookDTO>();

            switch (typeSearch)
            {
                case "name":
                    books = getBooksWithName(data.Name);
                    break;
                case "author":
                    books = getBooksWithAuthor(data.Author);
                    break;
                case "publish":
                    books = getBooksWithPublish(data.Publish);
                    break;
                case "tag":
                    books = getBooksWithTag(data.Tag);
                    break;
                default:
                    break;
            }

            return books;
        }

        public List<BookDTO> getBooksWithName(string name)
        {
            return BookDAO.instance.getBooksWithName(name);
        }

        public List<BookDTO> getBooksWithAuthor(string author)
        {
            return BookDAO.instance.getBooksWithAuthor(author);
        }

        public List<BookDTO> getBooksWithPublish(string publish)
        {
            return BookDAO.instance.getBooksPublish(publish);
        }

        public List<BookDTO> getBooksWithTag(string tag)
        {
            return BookDAO.instance.getBooksTag(tag);
        }
    }
}
