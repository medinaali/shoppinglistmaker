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
using ClassAppBL;
using Entities;
using System.Data.SqlClient;

namespace DevApp
{
    /// <summary>
    /// Interaction logic for SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {
        public string Connection_String { get; private set; }
        public string Command { get; private set; }

        public SecondWindow()
        {
            InitializeComponent();
            InitializeProductCategory();
           
     
        }

        private void InitializeProductCategory()
        {
            List<string> lSate = new List<string>();
            lSate.Add("Please Select...");
            lSate.Add("Personal");
            lSate.Add("Gift");
            lSate.Add("Grocery");
            cbProductCategory.ItemsSource = lSate;
            cbProductCategory.SelectedValue = "Please Select...";
            List<Person> lPersonList = new List<Person>();
            Person lPerson = new Person();
           // lPersonList = lPerson.CreatePerson();
          //  DisplayGrid.DataContext = lPersonList;
          //  ProcessPersonBl lPersonBL = new ProcessPersonBl();
         //   DisplayGrid.DataContext = lPersonBL.GetAllPeople();
            DisplayGrid.DataContext = UpdateGrid();

        }

        private List<Person> UpdateGrid()
        {
            ProcessPersonBl lPersonBL = new ProcessPersonBl();
            List<Person> lPersonList = new List<Person>();
            lPersonList = lPersonBL.GetAllPeople();
            return lPersonList;
        } 

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Person lPerson = new Person()
            {
                FullName = TxtFullName.Text,
                ProductName = TxtProductName.Text,
                Notes = TxtNotes.Text,
                Purpose = TxtPurpose.Text,
                ProductCategory =  cbProductCategory.SelectedValue.ToString(),
                ProductPrice = TxtProductPrice.Text
            };
            ProcessPersonBl lProcessPersonBl = new ProcessPersonBl();
            lProcessPersonBl.ProcessInsertPerson(lPerson);
            ClearData();
          //  cbProductCategory.SelectedValue = "Please Select...";
            DisplayGrid.DataContext = UpdateGrid();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            ClearData();
 
        }
        private void EventSetter_OnHandler(object sender, MouseButtonEventArgs e)
        {
            DataGridRow row = sender as DataGridRow;
            if (row?.Item is Person)
            {
                Person lPerson = row.Item as Person;
                TxtFullName.Text = lPerson.FullName;
                TxtProductName.Text = lPerson.ProductName;
                TxtNotes.Text = lPerson.Notes;
                TxtPurpose.Text = lPerson.Purpose;
                cbProductCategory.SelectedValue = lPerson.ProductCategory.Length == 0 ? "Please Select..." : lPerson.ProductCategory.Trim(); 
                TxtProductPrice.Text = lPerson.ProductPrice;
            }
        }
        private void ClearData()
        {
            TxtProductName.Text = string.Empty;
            TxtFullName.Text = string.Empty;
            TxtNotes.Text = string.Empty;
            TxtPurpose.Text = string.Empty;
            cbProductCategory.SelectedValue = "Please Select...";
            TxtProductPrice.Text = string.Empty;
        }

        private void TxtFullName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtProductName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void DisplayGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnNewWindow2_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new Form1();
            newWindow.Show();
        }
    }
}
