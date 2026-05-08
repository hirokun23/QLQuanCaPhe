using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data;

namespace QuanLyQuanCafe
{
    public static class AppState
    {
        // trạng thái bàn
        public static Dictionary<int, string> BanTrangThai
            = new Dictionary<int, string>();

        // bill theo bàn
        public static Dictionary<int, DataTable> BillTheoBan
            = new Dictionary<int, DataTable>();
    }
}
