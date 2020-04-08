using System;
using System.Windows;
using CryptLibraryING;

namespace AistWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btReg_Click(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            Close();
        }

        private void btEnter_Click(object sender, RoutedEventArgs e)
        {
            string Login = tbLogin.Text;
            string Password = tbPassword.Text;
            Table_Class tableClass = new Table_Class($"SELECT\r\n  Sotrudniki.ID_Sotrudnika\r\n ,Dolgnost.Dostup\r\nFROM dbo.Sotrudniki\r\nINNER JOIN dbo.Dolgnost\r\n  ON Sotrudniki.Dolgnost_ID = Dolgnost.ID_Dolgnost\r\n  WHERE Sotrudnika_Login = {Login} AND Sotrudnika_Password = {Password}");
            if (tableClass.table.Rows[0][0] != DBNull.Value)
            {
                App.intID = tableClass.table.Rows[0][0].ToString();

            }
            else
            {
                MessageBox.Show("Не правильно введен логин или пароль!!!", "ИНЖПРОМТОРГ", MessageBoxButton.OK,
                    MessageBoxImage.Warning);
                tbPassword.Text = "";
            }
        }
    }
}
