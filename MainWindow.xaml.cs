using System.Windows;

namespace task7._01
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void customControl_Click(object sender, RoutedEventArgs e)
        {
            txtBlock.Text = "Ви щойно натиснули на кнопку";
        }
    }
}
