namespace QuanLyQuanCafe.DTO
{
    public class BanDTO
    {
        public int MaBan { get; set; }
        public string TenBan { get; set; }
        public string TrangThai { get; set; }

        public BanDTO() { }

        public BanDTO(int ma, string ten, string trangThai)
        {
            MaBan = ma;
            TenBan = ten;
            TrangThai = trangThai;
        }
    }
}