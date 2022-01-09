using Server.DAO;
using Server.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.BUS
{
    public class DocGiaBUS
    {
        static public DocGiaDTO DangNhap(string maDocGia, string matKhau)
        {
            return DocGiaDAO.DangNhap(maDocGia, matKhau);
        }
    }
}
