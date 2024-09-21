using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            while (true)
            {
                Console.WriteLine("1. Bài tập 1: Tính toán hai số");
                Console.WriteLine("2. Bài tập 2: Tính chu vi và diện tích hình chữ nhật");
                Console.WriteLine("3. Bài tập 3: Tính chu vi và diện tích hình tròn");
                Console.WriteLine("4. Bài tập 4: Tính điểm trung bình cả năm");
                Console.WriteLine("5. Bài tập 5: Thông tin nhân viên");
                Console.WriteLine("6. Bài tập 6: Xem ngày");
                Console.WriteLine("7. Thoát");
                Console.Write("Chọn chức năng (1-7): ");
                int chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        TinhToanHaiSo();
                        break;
                    case 2:
                        HinhChuNhat();
                        break;
                    case 3:
                        HinhTron();
                        break;
                    case 4:
                        TinhDTB();
                        break;
                    case 5:
                        ThongTinNhanVien();
                        break;
                    case 6:
                        XemNgay();
                        break;
                    case 7:
                        return;
                    default:
                        Console.WriteLine("Chức năng không tồn tại.");
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }

        }

        private static void TinhToanHaiSo()
        {
            Console.Clear();
            Console.WriteLine("Nhập vào số nguyên a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào số nguyên b: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Tổng của a và b là: " + (a + b));
            Console.WriteLine("Hiệu của a và b là: " + (a - b));
            Console.WriteLine("Tích của a và b là: " + (a * b));
            Console.WriteLine("Thương của a và b là: " + (a / b));
            //Console.WriteLine("Phần dư của a và b là: " + (a % b));
            Console.WriteLine("Press Enter to go back...");
        }

        private static void HinhChuNhat()
        {
            Console.Clear();
            Console.WriteLine("Nhập vào chiều dài HCN: ");
            double cd = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào chiều rộng HCN: ");
            double cr = double.Parse(Console.ReadLine());

            double cv_hcn = (cd + cr) * 2;
            double s_hcn = cd * cr;

            Console.WriteLine("Chu vi của hình chữ nhật là: " + cv_hcn);
            Console.WriteLine("Diện tích của hình chữ nhật là: " + s_hcn);
            Console.WriteLine("Press Enter to go back...");
        }

        private static void HinhTron()
        {
            Console.Clear();
            Console.WriteLine("Nhập vào đường kính hình tròn: ");
            double d = double.Parse(Console.ReadLine());

            double r = d / 2;
            double cv_ht = 2 * Math.PI * r; // hoặc cv_ht = Math.PI * d;
            double s_ht = Math.PI * r * r;

            Console.WriteLine("Chu vi của hình tròn là: " + Math.Round(cv_ht,2));
            Console.WriteLine("Diện tích của hình tròn là: " + Math.Round(s_ht,2));
            Console.WriteLine("Press Enter to go back...");
        }

        private static void TinhDTB()
        {
            Console.Clear();
            Console.Write("Nhập họ tên HS: ");
            string hoten_hs = Console.ReadLine();
            Console.Write("Nhập lớp: ");
            string lop = Console.ReadLine();
            Console.WriteLine("Nhập điểm TB HK1:");
            double diem_hk1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập điểm TB HK2:");
            double diem_hk2 = double.Parse(Console.ReadLine());

            double diem_tb_ca_nam = (diem_hk1 + (diem_hk2 * 2)) / 3;

            Console.WriteLine("Họ tên HS: " + hoten_hs);
            Console.WriteLine("Lớp: " + lop);
            Console.WriteLine($"Điểm TB cả năm: {diem_tb_ca_nam:0.00}");
            Console.WriteLine("Press Enter to go back...");
        }

        private static void ThongTinNhanVien()
        {
            Console.Clear();
            Console.WriteLine("Nhập họ tên nhân viên: ");
            string hoten_nv = Console.ReadLine();
            Console.WriteLine("Nhập giới tính:");
            string gioitinh = Console.ReadLine();
            Console.WriteLine("Nhập ngày sinh:");
            string ngaysinh = Console.ReadLine();
            Console.WriteLine("Nhập hệ số lương:");
            double heso_luong = double.Parse(Console.ReadLine());
            Console.WriteLine("Lương cơ bản:");
            int luong_cb = int.Parse(Console.ReadLine());
            Console.WriteLine("Số năm làm việc:");
            int so_nam_lam = int.Parse(Console.ReadLine());

            double phucap = 0;
            if (so_nam_lam > 5)
            {
                phucap = 0.5 * luong_cb;
            }

            Console.WriteLine("Họ tên nhân viên: " + hoten_nv);
            Console.WriteLine("Giới tính: " + gioitinh);
            Console.WriteLine("Ngày sinh: " + ngaysinh);
            Console.WriteLine("Hệ số lương: " + heso_luong);
            Console.WriteLine($"Lương cơ bản: {luong_cb:N0}"); // Định dạng số có dấu phân cách hàng nghìn
            Console.WriteLine("Số năm làm việc: " + so_nam_lam);
            Console.WriteLine("Phụ cấp của nhân viên: " + phucap);
            Console.WriteLine("Press Enter to go back...");
        }

        // Hàm kiểm tra tính hợp lệ của ngày tháng năm
        private static bool IsValidDate(int ngay, int thang, int nam)
        {
            return DateTime.TryParse($"{ngay}/{thang}/{nam}", out _);
        }

        private static void XemNgay()
        {
            Console.Clear();
            // Nhập ngày, tháng, năm từ người dùng
            Console.Write("Nhập ngày = ");
            int ngay = int.Parse(Console.ReadLine());

            Console.Write("Nhập tháng = ");
            int thang = int.Parse(Console.ReadLine());

            Console.Write("Nhập năm = ");
            int nam = int.Parse(Console.ReadLine());

            // Kiểm tra xem ngày tháng năm có hợp lệ không
            if (IsValidDate(ngay, thang, nam))
            {
                DateTime ngayHienTai = new DateTime(nam, thang, ngay);
                DateTime ngayTruocdo = ngayHienTai.AddDays(-1);
                DateTime ngaySauDo = ngayHienTai.AddDays(1);

                Console.WriteLine($"Ngày hôm qua là: {ngayTruocdo.ToString("dd/MM/yyyy")}");
                Console.WriteLine($"Ngày hiện tại là: {ngayHienTai.ToString("dd/MM/yyyy")}");
                Console.WriteLine($"Ngày mai là: {ngaySauDo.ToString("dd/MM/yyyy")}");
            }
            else
            {
                Console.WriteLine("Ngày, tháng, năm không hợp lệ.");
            }
        }
    }
}
