using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App4
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ObservableCollection<hoa> Hoas = new ObservableCollection<hoa>();
            Hoas.Add(new hoa
            {
                TenHoa = "Đón xuân",
                Gia = 50000,
                Hinh = "hoaCuc.png",
                MoTa = "hoa cúc màu trắng, vàng cam"
            });
            Hoas.Add(new hoa
            {
                TenHoa = "Hồn nhiên",
                Gia = 60000,
                Hinh = "cuc.jpg",
                MoTa = "hoa cúc màu trắng, vàng cam"
            });
            Hoas.Add(new hoa
            {
                TenHoa = "Tím thủy chung",
                Gia = 90000,
                Hinh = "cucTim.png",
                MoTa = "hoa cúc tím"
            });
            lsvHoa.ItemsSource = Hoas;

        }
        public class hoa
        {
            
            public string TenHoa { get; set; }
            public string Hinh { get; set; }
            public double Gia { get; set; }
            public string MoTa { get; set; }
        }


    }

}
