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
using PervayaLabaDataSet.Laba1DataSetTableAdapters;

namespace PervayaLabaDataSet
{
    /// <summary>
    /// Логика взаимодействия для Unitaz.xaml
    /// </summary>
    public partial class Unitaz : Page
    {
        UnitazsTableAdapter UnitazsTableAdapter = new UnitazsTableAdapter();
        public Unitaz()
        {
            InitializeComponent();
            datygridy.ItemsSource = UnitazsTableAdapter.GetData();
        }
    }
}
