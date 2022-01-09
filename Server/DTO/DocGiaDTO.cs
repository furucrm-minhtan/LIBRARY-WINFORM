using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.DTO
{
    public class DocGiaDTO
    {
        private string _maDocGia;
        private string _matKhau;
        private string _tenDocGia;
        private DateTime _ngaySinh;
        private string _gioiTinh;
        private string _danToc;
        private string _quocTich;
        private string _email;
        private string _sdtDocGia;
        private byte[] _anhDaiDien;
        private string _cMND;
        private string _noiCap;
        private string _ngheNghiep;
        private string _trinhDo;
        private string _truongHoc;
        private string _lopHoc;
        private string _maNguoiGiamHo;

        public DocGiaDTO(string maDocGia, string matKhau, string tenDocGia, DateTime ngaySinh, string gioiTinh, string danToc, string quocTich, string email, string sdtDocGia, byte[] anhDaiDien, string cMND, string noiCap, string ngheNghiep, string trinhDo, string truongHoc, string lopHoc, string maNguoiGiamHo)
        {
            _maDocGia = maDocGia;
            _matKhau = matKhau;
            _tenDocGia = tenDocGia;
            _ngaySinh = ngaySinh;
            _gioiTinh = gioiTinh;
            _danToc = danToc;
            _quocTich = quocTich;
            _email = email;
            _sdtDocGia = sdtDocGia;
            _anhDaiDien = anhDaiDien;
            _cMND = cMND;
            _noiCap = noiCap;
            _ngheNghiep = ngheNghiep;
            _trinhDo = trinhDo;
            _truongHoc = truongHoc;
            _lopHoc = lopHoc;
            _maNguoiGiamHo = maNguoiGiamHo;
        }

        public string MaDocGia { get => _maDocGia; set => _maDocGia = value; }
        public string MatKhau { get => _matKhau; set => _matKhau = value; }
        public string TenDocGia { get => _tenDocGia; set => _tenDocGia = value; }
        public DateTime NgaySinh { get => _ngaySinh; set => _ngaySinh = value; }
        public string GioiTinh { get => _gioiTinh; set => _gioiTinh = value; }
        public string DanToc { get => _danToc; set => _danToc = value; }
        public string QuocTich { get => _quocTich; set => _quocTich = value; }
        public string Email { get => _email; set => _email = value; }
        public string SdtDocGia { get => _sdtDocGia; set => _sdtDocGia = value; }
        public byte[] AnhDaiDien { get => _anhDaiDien; set => _anhDaiDien = value; }
        public string CMND { get => _cMND; set => _cMND = value; }
        public string NoiCap { get => _noiCap; set => _noiCap = value; }
        public string NgheNghiep { get => _ngheNghiep; set => _ngheNghiep = value; }
        public string TrinhDo { get => _trinhDo; set => _trinhDo = value; }
        public string TruongHoc { get => _truongHoc; set => _truongHoc = value; }
        public string LopHoc { get => _lopHoc; set => _lopHoc = value; }
        public string MaNguoiGiamHo { get => _maNguoiGiamHo; set => _maNguoiGiamHo = value; }
    }
}
