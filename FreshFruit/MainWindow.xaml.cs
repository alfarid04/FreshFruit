using FreshFruit.Controller;
using FreshFruit.Modal;
using System;
using System.Collections.Generic;
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

namespace FreshFruit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, BucketEventListener
    {
        Seller Alfa;
        public MainWindow()
        {
            InitializeComponent();
            Bucket keranjangBuah = new Bucket(4);
            BucketController bucketController = new BucketController(keranjangBuah, this);

            Alfa = new Seller("toni", bucketController);

            ListBoxBucket.ItemsSource = keranjangBuah.findAll();
        }

        public void onFailed(string message)
        {
            MessageBox.Show(message);
        }

        public void onSucceed(string message)
        {
            ListBoxBucket.Items.Refresh();
        }

        private void OnButtonAddAnggurClicked(object sender, RoutedEventArgs e)
        {
            Fruit anggur = new Fruit("Anggur");
            Alfa.addFruit(anggur);

            ListBoxBucket.Items.Refresh();
        }

        private void OnButtonAddAppleClicked(object sender, RoutedEventArgs e)
        {
            Fruit Apple = new Fruit("Apple");
            Alfa.addFruit(Apple);

            ListBoxBucket.Items.Refresh();
        }

        private void OnButtonAddBananaClicked(object sender, RoutedEventArgs e)
        {
            Fruit Banana = new Fruit("Banana");
            Alfa.addFruit(Banana);

            ListBoxBucket.Items.Refresh();
        }

        private void OnButtonAddOrangeClicked(object sender, RoutedEventArgs e)
        {
            Fruit orange = new Fruit("orange");
            Alfa.addFruit(orange);

            ListBoxBucket.Items.Refresh();
        }
    }
}
