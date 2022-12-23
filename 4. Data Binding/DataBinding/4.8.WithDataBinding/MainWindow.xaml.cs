using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WithDataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Person person = new Person("Tom", 9);
        public MainWindow()
        {
            InitializeComponent();

            //object -> UI
            grid.DataContext = person;
            
            this.birthdayButton.Click += birthdayButton_Click;

        }

        
        void birthdayButton_Click(object sender, RoutedEventArgs e)
        {
            // Data binding keeps person and the text boxes synchronized.
            ++person.Age; 

            MessageBox.Show(
                string.Format($"Happy Birthday, {person.Name}, age {person.Age}!"), "Birthday"
                );
        }


    }
}
