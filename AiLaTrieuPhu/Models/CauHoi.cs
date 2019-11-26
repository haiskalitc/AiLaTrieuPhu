using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiLaTrieuPhu.Models
{
    public class CauHoi
    {
        public string NoiDung { get; set; }
        public List<DapAn> DanhSachDapAn { get; set; }
    }
}
