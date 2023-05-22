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
using System.Windows.Shapes;

namespace Sport
{
    /// <summary>
    /// Логика взаимодействия для MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        user08Entities Context;
        public MainMenu()
        {
            InitializeComponent();
            Context = new user08Entities();
            ProductDataGrid.ItemsSource = Context.Product.ToList();
        }

        private void ShowOrderBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SearchProductTxb_SelectionChanged(object sender, RoutedEventArgs e)
        {
            List<Product> ProductListSearch = Context.Product.Where(x => x.NameProduct.ToLower().Contains(SearchProductTxb.Text.ToLower())).ToList();
            if (ProductListSearch.Count == 0)
            {
                MessageBox.Show("Поиск не дал результатов", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                ProductDataGrid.ItemsSource = ProductListSearch;
            }
        }
    }
}
