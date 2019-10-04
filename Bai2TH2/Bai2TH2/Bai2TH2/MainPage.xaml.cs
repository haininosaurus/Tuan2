using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Bai2TH2
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            LoaiHoa l = new LoaiHoa();
            lsthoa.ItemsSource = l.Loaihoas;


        }
    }
    public class hoa
    {

        public string TenHoa { get; set; }
        public string Hinh { get; set; }
        public double Gia { get; set; }
        public string MoTa { get; set; }
    }
    public class LoaiHoa : List<hoa>
    {
        public string TenLoai { get; set; }
        private LoaiHoa(string tenloai)
        {
            TenLoai = tenloai;
        }
        public IList<LoaiHoa> Loaihoas { get; set; }
        public LoaiHoa()
        {
            List<LoaiHoa> l = new List<LoaiHoa>
            {
                new LoaiHoa("Hoa cuc")
                {
                    new hoa {TenHoa = "don xuan", Gia = 50000,
                    Hinh = "hoaCuc.png", MoTa = "hoa cuc cac mau: trang, vang, cam"},
                    new hoa{TenHoa = "hon nhien", Gia = 60000,
                    Hinh = "cuc.jpg", MoTa = "hoa cuc vang, cam"},
                    new hoa{TenHoa = "Tim thuy chung", Gia = 45000,
                    Hinh = "cucTim.png", MoTa = "Hoa cuc tim"}


                },
                new LoaiHoa("Hoa cuoi")
                {
                    new hoa {TenHoa = "day to hong", Gia = 250000,
                    Hinh = "hongdo.png", MoTa = "hoa hong do"},
                    new hoa{TenHoa = "cau thuy tinh", Gia = 220000,
                    Hinh = "cuc.jpg", MoTa = "hoa hong xanh"},
                    new hoa{TenHoa = "duyen tham", Gia = 260000,
                    Hinh = "cucTim.png", MoTa = "Hoa hong trang"}
                }
            };
            Loaihoas = l;
        }
    }
   


}
