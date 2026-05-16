namespace QuanLyQuanCafe.DTO
{
    public class TaiKhoanDTO
    {
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string ChucVu { get; set; }

        public TaiKhoanDTO() { }

        public TaiKhoanDTO(string tenDN, string matKhau, string chucVu)
        {
            this.TenDangNhap = tenDN;
            this.MatKhau = matKhau;
            this.ChucVu = chucVu;
        }
    }
}