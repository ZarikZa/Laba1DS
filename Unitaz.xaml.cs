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
        UnitazTypesTableAdapter unitazTypesTableAdapter = new UnitazTypesTableAdapter();
        public Unitaz()
        {
            InitializeComponent();
            datygridy.IsReadOnly = true;
            datygridy.ItemsSource = unitazsTableAdapter.GetData();
            FiltrCbox.ItemsSource = unitazTypesTableAdapter.GetData();
            FiltrCbox.DisplayMemberPath = "UnitazType";
        }

        private void SearchBtm_Click(object sender, RoutedEventArgs e)
        {
            datygridy.ItemsSource = unitazsTableAdapter.GetDataForUnitaz(SearchTbox.Text);
        }

        private void FiltrCbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var id = (int)(FiltrCbox.SelectedItem  as DataRowView).Row[0];
            datygridy.ItemsSource = unitazsTableAdapter.GetDataBy3(id);
        }

        private void ClearBtm_Click(object sender, RoutedEventArgs e)
        {
            datygridy.ItemsSource = unitazsTableAdapter.GetData();
        }
    }
}
