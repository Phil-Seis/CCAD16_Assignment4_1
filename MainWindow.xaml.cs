using System;
using System.Collections.Generic;
using System.Windows;

namespace CCAD16_Assignment4_1
{
    public partial class MainWindow : Window
    {
        private Dictionary<string, Person> persons;
        public MainWindow()
        {
            InitializeComponent();
            persons = MockData.CreateData();
            ContactData.ItemsSource = persons.Values;
        }

        private void SearchButtonClick(object sender, RoutedEventArgs e)
        {
  
            if (persons.TryGetValue(txtSearch.Text, out Person person))
            {
                MessageBox.Show(
                    $"\t**RECORD FOUND** \n\nName: {person.FullName}" + $"\nMobile Phone: {person.MobilePhone}" + $"\nWork Phone: {person.WorkPhone}" + $"\nAddress: {person.Address}");
            }

            else
            {
                MessageBox.Show($"Record for " + txtSearch.Text + " was not located.");
            }
        }
    }
}
