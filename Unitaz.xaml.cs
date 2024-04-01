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
    /// Логика взаимодействия для Unitaz.xaml
    /// </summary>
    public partial class Unitaz : Page
    {
        UnitazsTableAdapter unitazsTableAdapter = new UnitazsTableAdapter();
        public Unitaz()
        {
            InitializeComponent();
            datygridy.IsReadOnly = true;
            datygridy.ItemsSource = unitazsTableAdapter.GetData();
        }

        private void DeleteBtm_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var id = (datygridy.SelectedItem as DataRowView).Row[0];
                unitazsTableAdapter.DeleteQuery(Convert.ToInt32(id));
                datygridy.ItemsSource = unitazsTableAdapter.GetData();
            }
            catch (Exception)
            {
                MessageBox.Show("Нельзя удалить, соrrи");
            }
        }

        private void AddBtm_Click(object sender, RoutedEventArgs e)
        {
            if (Nazvanie.Text != "")
            {
                try 
                { 
                    unitazsTableAdapter.InsertQuery(Nazvanie.Text, Convert.ToInt32(TypeTbox.Text), Convert.ToDecimal(PriceTbox.Text));
                    datygridy.ItemsSource = unitazsTableAdapter.GetData();
                }
                catch
                {
                    MessageBox.Show("Такое имя уже существует или же указан неверный ID");
                }
            }
        }

        private void datygridy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var cheged = (datygridy.SelectedItem as DataRowView);
            if (cheged != null)
            {
                Nazvanie.Text = cheged.Row[1].ToString();
                TypeTbox.Text = cheged.Row[2].ToString();
                PriceTbox.Text = cheged.Row[3].ToString();
            }

        }

        private void EditBtm_Click(object sender, RoutedEventArgs e)
        {
            if (Nazvanie.Text != "")
            {
                try
                {
                    var id = (datygridy.SelectedItem as DataRowView).Row[0];
                    unitazsTableAdapter.UpdateQuery(Nazvanie.Text, Convert.ToInt32(TypeTbox.Text), Convert.ToInt32(PriceTbox.Text), Convert.ToInt32(id));
                    datygridy.ItemsSource = unitazsTableAdapter.GetData();
                }
                catch(Exception)
                {
                    MessageBox.Show("Такое имя уже существует");
                }
            }
        }
    }
}
