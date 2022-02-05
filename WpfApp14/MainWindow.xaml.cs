using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                NameofGood = " Помидоры ",
                PriceGood = 250,
                CodeofGood = 1,
                CategoryofGood = CategoryofGoods.Food
            });
            products.Add(new Product()
            {
                NameofGood = " Огурцы ",
                PriceGood = 135,
                CodeofGood = 1,
                CategoryofGood = CategoryofGoods.Food
            });
            products.Add(new Product()
            {
                NameofGood = " Пылесос Dyson ",
                PriceGood = 29990,
                CodeofGood = 2,
                CategoryofGood = CategoryofGoods.Appliance
            });
            ListBox.ItemsSource = products;
        }
    }
}
