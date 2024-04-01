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
        public Orrders()
        {
            InitializeComponent();
            datygridy.IsReadOnly = true;
            datygridy.ItemsSource = ordersTableAdapter.GetData();
        }
        private void DeleteBtm_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var id = (datygridy.SelectedItem as DataRowView).Row[0];
                ordersTableAdapter.DeleteQuery(Convert.ToInt32(id));
                datygridy.ItemsSource = ordersTableAdapter.GetData();
            }
            catch (Exception)
            {
                MessageBox.Show("Нельзя удалить, соrrи");
            }
        }

        private void AddBtm_Click(object sender, RoutedEventArgs e)
        {
            if (ID_ClientTbox.Text != "")
            {
                try
                {
                    ordersTableAdapter.InsertQuery(Convert.ToInt32(ID_ClientTbox.Text), Convert.ToInt32(ID_UnitazTbox.Text));
                    datygridy.ItemsSource = ordersTableAdapter.GetData();
                }
                catch (Exception)
                {
                    MessageBox.Show("Указан неверный ID");
                }
            }
        }

        private void datygridy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var cheged = (datygridy.SelectedItem as DataRowView);
            if(cheged != null)
            {
                ID_ClientTbox.Text = cheged.Row[1].ToString();
                ID_UnitazTbox.Text = cheged.Row[2].ToString();
            }
        }

        private void EditBtm_Click(object sender, RoutedEventArgs e)
        {
            if (ID_ClientTbox.Text != "")
            {
                try
                {
                    var id = (datygridy.SelectedItem as DataRowView).Row[0];
                    ordersTableAdapter.UpdateQuery(Convert.ToInt32(ID_ClientTbox.Text), Convert.ToInt32(ID_UnitazTbox.Text), Convert.ToInt32(id));
                    datygridy.ItemsSource = ordersTableAdapter.GetData();
                }
                catch (Exception)
                {
                    MessageBox.Show("Такое имя уже существует");
                }
            }
        }
    }
}
