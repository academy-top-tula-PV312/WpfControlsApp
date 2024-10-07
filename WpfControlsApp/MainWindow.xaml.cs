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

namespace WpfControlsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int count = 0;
        Brush backColor;

        public MainWindow()
        {
            InitializeComponent();
            
            Button myButton = new Button();
            myButton.Content = "My Button";
            myButton.FontSize = 30;
            stack.Children.Add(myButton);
        }

        private void rptBtn_Click(object sender, RoutedEventArgs e)
        {
            txtTablo.Text = (++count).ToString();
        }

        private void checkCpp_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Checked!");
        }

        private void checkCpp_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void checkCpp_Indeterminate(object sender, RoutedEventArgs e)
        {

        }

        private void btn_MouseEnter(object sender, MouseEventArgs e)
        {
            backColor = btn.Foreground;
            btn.Foreground = new SolidColorBrush(Colors.Red);
        }

        private void btn_MouseLeave(object sender, MouseEventArgs e)
        {
            btn.Foreground = backColor;
        }
    }
}