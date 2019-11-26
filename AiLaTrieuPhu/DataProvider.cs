using AiLaTrieuPhu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiLaTrieuPhu.DataProvider
{
    public class DataProvider
    {
        private DataProvider()
        {
        }
        public static DataProvider getInstance { get { return NestedSelenium.instance; } }
        private class NestedSelenium
        {
            static NestedSelenium()
            {
            }
            internal static readonly DataProvider instance = new DataProvider();
        }

        public List<CauHoi> DanhSachCauHoi = new List<CauHoi>()
        {
            new CauHoi() {
                NoiDung = "Có một tàu điện đi về hướng nam. Gió hướng tây bắc. Vậy khói từ con tàu sẽ theo hướng nào?",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "Không hướng nào",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "Đông",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "Tây",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "Bắc",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Làm thế nào để không đụng phải ngón tay khi bạn đập búa vào một cái móng tay?",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "Cầm búa bằng cả 2 tay",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "Cầm búa bằng tay trái",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "Cầm búa bằng tay phải",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "Cầm búa bằng chân",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Nếu bạn nhìn thấy con chim đang đậu trên nhánh cây, làm sao để lấy nhánh cây mà không làm động con chim?",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "Đợi chim bay đi",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "Bắt chim bỏ ra ngoài",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "Ru chim ngủ rồi lấy",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "Cứ đến mà lấy",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Miệng rộng lớn nhưng không nói một từ, là con gì?",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "Con sông",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "Con cá voi ",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "Con khỉ đột",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "Con voi",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Có bao nhiêu chữ C trong câu sau: 'Cơm, canh, cá, tất cả em đều thích'?",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "5",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Loại nước giải khát nào chứa Canxi và Sắt?",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "Cafe",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "CoCa",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "Pepsi",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "Sinh tố",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Cái gì bạn không mượn mà trả?",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "Lời cảm ơn",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "Tiền",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "Tình",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "Không có thứ gì",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Vào lúc nửa đêm đồng hồ bất chợt gõ 13 tiếng, chuyện gì xảy ra?",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "Mang đồng hồ đi sửa",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "Chuyện xấu sẽ đến",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "Có ma",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "Ngày tận thế",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Cái gì luôn đi đến mà không bao giờ đến nơi?",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "Ngày mai",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "Cơn gió",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "Tình yêu",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "Không biết là cái gì",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Tìm điểm sai trong câu: 'Dưới ánh nắng sương long lanh triệu cành hồng khoe sắc thắm'?",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "Khoe sắc thắm",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "Ánh nắng sương",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "Triệu cành hồng",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "Sương long lanh",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Một anh thanh niên đánh 1 bà già hỏi anh ấy mất gì?",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "Mất dạy.",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "Mất tiền",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "Mất sức.",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "Mất trí",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Có 2 người cha và 2 người con cùng chia đều số tiền là 27 nghìn. Hỏi mỗi người được bao nhiều?",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "9",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "6,75",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "7",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "7.5",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Có 1 đàn chuột điếc đi ngang qua hố cống, hỏi có mấy con?",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "24",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "15",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "32",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "41",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Cái gì mà đi thì nằm, đứng cũng nằm, nhưng nằm lại đứng?",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "Bàn chân",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "Cái bàn",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "Cái ghế",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "Bàn tay",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Một kẻ giết người bị kết án tử hình. Hắn ta phải chọn một trong ba căn phòng: phòng thứ nhất lửa cháy dữ dội, phòng thứ hai đầy những kẻ ám sát đang giương súng, và phòng thứ ba đầy sư tử nhịn đói trong ba năm. Phòng nào an toàn nhất cho hắn?",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "Phòng thứ ba",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "Phòng thứ nhất",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "Phòng thứ hai",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "Không phòng nào",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Bố mẹ có 6 người con trai, mỗi người con trai có một đứa em gái. Vậy gia đình đó có mấy người?",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "9",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "8",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "10",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "11",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            },
            new CauHoi() {
                NoiDung = "Shi bai a diuuum Helloo",
                DanhSachDapAn = new List<DapAn>() {
                    new DapAn() {
                        NoiDung = "2",
                        IsTrue = true
                    },
                    new DapAn() {
                        NoiDung = "1",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "3",
                        IsTrue = false
                    },
                    new DapAn() {
                        NoiDung = "4",
                        IsTrue = false
                    },
                }
            }
            //// Tu bi Con ti niêu
        };
    }
}
