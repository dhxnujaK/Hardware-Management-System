using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hardware_Management_System
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Tile_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string username = usernametextbox.Text;
            string password = passwordtextbox.Password;

            if (username == "admin" && password == "admin")
            {
                MessageBox.Show("Login Successful");
                this.Hide();
                //Dashboard dashboard = new Dashboard();
                //dashboard.Show();
                MainScreen mainScreen = new MainScreen();
                mainScreen.Show();
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }
    }
}