using System;
using System.Collections.Generic;
using System.Data;
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
using PervayaLabaDataSet.Laba1DataSetTableAdapters;
namespace PervayaLabaDataSet
{
    /// <summary>
    /// Логика взаимодействия для Orrders.xaml
    /// </summary>
    public partial class Orrders : Page
    {
        OrdersTableAdapter ordersTableAdapter = new OrdersTableAdapter();
        ClientsTableAdapter clientsTableAdapter = new ClientsTableAdapter();
        public Orrders()
        {
            InitializeComponent();
            datygridy.IsReadOnly = true;
            datygridy.ItemsSource = ordersTableAdapter.GetData();
            FiltrCbox.ItemsSource = clientsTableAdapter.GetData();
            FiltrCbox.DisplayMemberPath = "ClientName";
        }
        private void SearchBtm_Click(object sender, RoutedEventArgs e)
        {
            datygridy.ItemsSource = ordersTableAdapter.GetDataForOrders(Convert.ToInt32(SearchTbox.Text));
        }

        private void FiltrCbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var id = (int)(FiltrCbox.SelectedItem as DataRowView).Row[0];
            datygridy.ItemsSource = ordersTableAdapter.GetDataCtoto(id);
        }

        private void ClearBtm_Click(object sender, RoutedEventArgs e)
        {
            datygridy.ItemsSource = ordersTableAdapter.GetData();
        }
    }
}
