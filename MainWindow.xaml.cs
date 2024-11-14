using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.TextFormatting;

namespace OnlineEducation
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private bool isTextHidden = false;
        private string originalText = string.Empty;

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void LoginTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

            if (string.IsNullOrEmpty(LoginTextBox.Text))
            {
                Login.Visibility = Visibility.Visible;
            }
            else
            {
                Login.Visibility = Visibility.Collapsed;
            }
        }

        private void TextBox_PasswordChanged(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrEmpty(PasswordBox.Text))
            {
                Password.Visibility = Visibility.Visible;
            }
            else
            {
                Password.Visibility = Visibility.Collapsed;
            }
        }
        //private void TextBox_PasswordChanged(object sender, TextChangedEventArgs e)
        //{
        //    TextBox tb = sender as TextBox;
        //    if (tb != null)
        //    {
        //        tb.Text = Regex.Replace(tb.Text, "[^0-9,.]", "●");
        //    }
        //}
        private void PasswordVisibility(object sender, RoutedEventArgs e)
        {
            if (isTextHidden)
            {
                PasswordBox.Text = originalText;
                isTextHidden = false;
            }
            else
            {
                originalText = PasswordBox.Text;
                PasswordBox.Text = new string('●', originalText.Length);
                isTextHidden = true;
            }
        }
        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTextBox.Text;
            string password = PasswordBox.Text;

            if (login == "admin" && password == "admin")
            {
                Window2 newWindow = new Window2();
                newWindow.Show();
                this.Close();
            }
            else
            {

                MessageBox.Show("Invalid login or password", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}