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
        private void SearchBtm_Click(object sender, RoutedEventArgs e)
        {
            datygridy.ItemsSource = clientsTableAdapter.GetDataBy3(SearchTbox.Text);
        }
    }
}
