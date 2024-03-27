using sesion5.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace sesion5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        useEntities db=new useEntities();
        public MainWindow()
        {
            InitializeComponent();
            db.Medications.Load();
            dg.ItemsSource= db.Medications.Local.ToBindingList();

            db.Warehouses.Load();
            dh.ItemsSource = db.Warehouses.Local.ToBindingList();
           
            db.Warehouses.Load();
            spis.ItemsSource = db.Disposals.Local.ToBindingList();
        }

        private void dg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            db.SaveChanges();
        }

        private void dh_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            db.SaveChanges();
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Успешно");
            db.SaveChanges();
        }

        private void spitat_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Успешне списание");
            db.SaveChanges();

        }

        private void spis_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            db.SaveChanges();
        }
    }
}
