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
    /// Логика взаимодействия для UnitazasTypes.xaml
    /// </summary>
    public partial class UnitazasTypes : Page
    {
        UnitazTypesTableAdapter UnitazTypesTableAdapter = new UnitazTypesTableAdapter();
        public UnitazasTypes()
        {
            InitializeComponent();
            datygridy.IsReadOnly = true;
            datygridy.ItemsSource = UnitazTypesTableAdapter.GetData();
        }

        private void DeleteBtm_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var id = (datygridy.SelectedItem as DataRowView).Row[0];
                UnitazTypesTableAdapter.DeleteQuery(Convert.ToInt32(id));
                datygridy.ItemsSource = UnitazTypesTableAdapter.GetData();
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
                    UnitazTypesTableAdapter.InsertQuery(Nazvanie.Text);
                    datygridy.ItemsSource = UnitazTypesTableAdapter.GetData();
                }
                catch (Exception)
                {
                    MessageBox.Show("Такое имя уже существует");
                }
            }
        }

        private void datygridy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var cheged = (datygridy.SelectedItem as DataRowView);
            if(cheged != null)
            {
                Nazvanie.Text = cheged.Row[1].ToString();
            }
        }

        private void EditBtm_Click(object sender, RoutedEventArgs e)
        {
            if (Nazvanie.Text != "")
            {
                try
                {
                    var id = (datygridy.SelectedItem as DataRowView).Row[0];
                    UnitazTypesTableAdapter.UpdateQuery(Nazvanie.Text, Convert.ToInt32(id));
                    datygridy.ItemsSource = UnitazTypesTableAdapter.GetData();
                    var asdas = Convert.ToDateTime(Nazvanie);
                }
                catch (Exception)
                {
                    MessageBox.Show("Такое имя уже существует");
                }
            }
        }
    }
}
