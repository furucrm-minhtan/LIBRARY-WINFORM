using Server.Core.Provider;
using Server.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.DAO
{
    public class BookDAO : DAO<BookDTO>
    {
        public static BookDAO instance = new BookDAO();
        public override string table => "books";

        public override bool delete(string key)
        {
            return Database.excute((SqlConnection con, SqlTransaction trans) =>
            {
                SqlCommand cm = new SqlCommand("DeleteBook", con);
                cm.Transaction = trans;
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.AddWithValue("@Id", key);

                cm.ExecuteNonQuery();
            });
        }

        public override List<BookDTO> getAll()
        {
            List<BookDTO> rs = new List<BookDTO>();

            Database.excuteQuery((SqlConnection con) =>
            {
                SqlCommand cm = new SqlCommand("GetBooks", con);
                cm.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cm.ExecuteReader();

                rs = BookDTO.readDatabaseData(reader);
            });

            return rs;
        }

        public List<BookDTO> getBooksWithName(string name)
        {
            List<BookDTO> rs = new List<BookDTO>();

            Database.excuteQuery((SqlConnection con) =>
            {
                SqlCommand cm = new SqlCommand("FindWithBookName", con);
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.AddWithValue("@Name", name);

                SqlDataReader reader = cm.ExecuteReader();

                rs = BookDTO.readDatabaseData(reader);
            });

            return rs;
        }

        public List<BookDTO> getBooksWithAuthor(string author)
        {
            List<BookDTO> rs = new List<BookDTO>();

            Database.excuteQuery((SqlConnection con) =>
            {
                SqlCommand cm = new SqlCommand("FindWithAuthorName", con);
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.AddWithValue("@Name", author);

                SqlDataReader reader = cm.ExecuteReader();

                rs = BookDTO.readDatabaseData(reader);
            });

            return rs;
        }

        public List<BookDTO> getBooksPublish(string publish)
        {
            List<BookDTO> rs = new List<BookDTO>();

            Database.excuteQuery((SqlConnection con) =>
            {
                SqlCommand cm = new SqlCommand("FindWithPublishDate", con);
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.AddWithValue("@Publish", publish);

                SqlDataReader reader = cm.ExecuteReader();

                rs = BookDTO.readDatabaseData(reader);
            });

            return rs;
        }

        public List<BookDTO> getBooksTag(int tag)
        {
            List<BookDTO> rs = new List<BookDTO>();

            Database.excuteQuery((SqlConnection con) =>
            {
                SqlCommand cm = new SqlCommand("FindWithBookTag", con);
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.AddWithValue("@@TagId", tag);

                SqlDataReader reader = cm.ExecuteReader();

                rs = BookDTO.readDatabaseData(reader);
            });

            return rs;
        }

        public override bool insert(BookDTO data)
        {
            return Database.excute((SqlConnection con, SqlTransaction trans) =>
            {
                SqlCommand cm = new SqlCommand("CreateBook");
                cm.Transaction = trans;
                cm.CommandType = CommandType.StoredProcedure;
                setParamsBook(cm, data);

                cm.ExecuteNonQuery();
            });
        }

        public override bool update(BookDTO data)
        {
            return Database.excute((SqlConnection con, SqlTransaction trans) =>
            {
                SqlCommand cm = new SqlCommand("UpdateBook");
                cm.Transaction = trans;
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.AddWithValue("@Id", data.Id);
                setParamsBook(cm, data);

                cm.ExecuteNonQuery();
            });
        }

        protected void setParamsBook(SqlCommand cm, BookDTO data)
        {
            foreach (var item in BookDTO.getMapping())
            {
                cm.Parameters.AddWithValue($"@{item.Value}", data.GetType().GetProperty(item.Key).GetValue(data));
            }
        }
    }
}
