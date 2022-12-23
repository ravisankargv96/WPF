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

namespace AClassThatSupportsPropertyChangeNotificationAndControlChanges
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
            this.nameTextBox.Text = person.Name;
            this.ageTextBox.Text = person.Age.ToString();

            this.birthdayButton.Click += birthdayButton_Click;

            person.PropertyChanged += person_PropertyChanged;

            this.nameTextBox.TextChanged += nameTextBox_TextChanged;
            this.ageTextBox.TextChanged += ageTextBox_TextChanged;
        }

        void person_PropertyChanged(object sender, PropertyChangedEventArgs e) {

            switch (e.PropertyName) {
                case "Name":
                    this.nameTextBox.Text = person.Name;
                    break;

                case "Age":
                    this.ageTextBox.Text = person.Age.ToString();
                    break;
            }
        }

        void birthdayButton_Click(object sender, RoutedEventArgs e)
        {
            ++person.Age; // person_PropertyChanged will update ageTextBox

            MessageBox.Show(
                string.Format($"Happy Birthday, {person.Name}, age {person.Age}!"), "Birthday"
                );
        }

        void nameTextBox_TextChanged(object sender, TextChangedEventArgs e) { 
            person.Name = nameTextBox.Text;
        }

        void ageTextBox_TextChanged(object sender, TextChangedEventArgs e) {

            int age = 0;
            if(int.TryParse(ageTextBox.Text, out age))
            {
                person.Age = age;
            }
        }

    }
}
