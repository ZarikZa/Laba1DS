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
    /// Логика взаимодействия для Clientts.xaml
    /// </summary>
    public partial class Clientts : Page
    {
        ClientsTableAdapter clientsTableAdapter = new ClientsTableAdapter();
        public Clientts()
        {
            InitializeComponent();
            datygridy.IsReadOnly = true;
            datygridy.ItemsSource = clientsTableAdapter.GetData();
        }
        private void DeleteBtm_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var id = (datygridy.SelectedItem as DataRowView).Row[0];
                clientsTableAdapter.DeleteQuery(Convert.ToInt32(id));
                datygridy.ItemsSource = clientsTableAdapter.GetData();
            }
            catch (Exception)
            {
                MessageBox.Show("Нельзя удалить, соrrи");
            }
        }

        private void AddBtm_Click(object sender, RoutedEventArgs e)
        {
            if (NameTbox.Text != "")
            {
                try
                {
                    clientsTableAdapter.InsertQuery(NameTbox.Text, SurnameTbox.Text, MiddleNameTbox.Text);
                    datygridy.ItemsSource = clientsTableAdapter.GetData();
                }
                catch (Exception)
                {
                    MessageBox.Show("Такое имя уже существует или же указан неверный ID");
                }
            }
        }

        private void datygridy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var cheged = (datygridy.SelectedItem as DataRowView);
            if(cheged != null)
            {
                NameTbox.Text = cheged.Row[1].ToString();
                SurnameTbox.Text = cheged.Row[2].ToString();
                MiddleNameTbox.Text = cheged.Row[3].ToString();
            }
        }

        private void EditBtm_Click(object sender, RoutedEventArgs e)
        {
            if (NameTbox.Text != "")
            {
                try
                {
                    var id = (datygridy.SelectedItem as DataRowView).Row[0];
                    clientsTableAdapter.UpdateQuery(NameTbox.Text, SurnameTbox.Text, MiddleNameTbox.Text, Convert.ToInt32(id));
                    datygridy.ItemsSource = clientsTableAdapter.GetData();
                }
                catch (Exception)
                {
                    MessageBox.Show("Такое имя уже существует");
                }
            }
        }
    }
}
