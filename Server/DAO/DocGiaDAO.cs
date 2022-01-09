using Server.Core.Provider;
using Server.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server.DAO
{
    public class DocGiaDAO
    {
        static public DocGiaDTO DangNhap(string maDocGia, string matKhau)
        {
            DataConnection dataConnection = new DataConnection();
            DocGiaDTO result = null;
            try
            {
                dataConnection.Connect();
                DataTable dt = dataConnection.Select(
                    CommandType.StoredProcedure,
                    "usp_dangnhap",
                    new SqlParameter { ParameterName = "@username", Value = maDocGia },
                    new SqlParameter { ParameterName = "@pass", Value = matKhau });
                if (dt != null)
                {
                    foreach (DataRow r in dt.Rows)
                    {
                        result = new DocGiaDTO(
                            r["MaDocGia"].ToString(),
                            r["MatKhau"].ToString(),
                            r["TenDocGia"].ToString(),
                            DateTime.Parse(r["NgaySinh"].ToString()),
                            r["GioiTinh"].ToString(),
                            r["DanToc"].ToString(),
                            r["QuocTich"].ToString(),
                            r["Email"].ToString(),
                            r["SDTDocGia"].ToString(),
                            Encoding.ASCII.GetBytes(r["AnhDaiDien"].ToString()),
                            r["CMND"].ToString(),
                            r["NoiCap"].ToString(),
                            r["NgheNghiep"].ToString(),
                            r["TrinhDo"].ToString(),
                            r["TruongHoc"].ToString(),
                            r["LopHoc"].ToString(),
                            r["MaNguoiGiamHo"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dataConnection.Disconnect();
            }
            return result;
        }
    }
}
