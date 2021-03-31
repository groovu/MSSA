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
using LibraryClass;

namespace LibraryWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Library lib = new Library("FDR Library");
        public MainWindow()
        {
            InitializeComponent();
            Title = lib.Name;
            Book b1 = new Book("test", 123, 1);
            lib.addBook(b1);
            refreshLibGrid();
            
        }
        private void refreshLibGrid()
        {
            LibDataGrid.IsReadOnly = false;
            LibDataGrid.ItemsSource = null;
            LibDataGrid.ItemsSource = lib.GetBooks();
            LibDataGrid.IsReadOnly = true;
            
        }

        private void addBookUserInput(object sender, RoutedEventArgs e)
        {
            string name = inputName.Text;
            int ISBN = int.Parse(inputISBN.Text);
            int count = int.Parse(inputCount.Text);

            Book newBook = new Book(name, ISBN, count);
            lib.addBook(newBook);
            refreshLibGrid();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
        //todo
        //bind label to variable
        //imagebox with url

    }
}
