using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace BreedingBeesProblem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ViewModel vm = new ViewModel();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = vm;
        }
        private void PathTextBox_onKeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                e.Handled = ((e.Key < Key.D0 || (e.Key > Key.D9 && e.Key < Key.NumPad0) || e.Key > Key.NumPad9) && (e.Key != Key.Back)
                      && (e.Key != Key.Delete) && (e.Key != Key.Left) && (e.Key != Key.Right) && (e.Key != Key.OemPeriod))
                      || (sender as TextBox).Text.Contains(".") && (e.Key == Key.OemPeriod);
            }
            catch
            {
                MessageBox.Show("check your input");
            }
        }
        private void CalculateBeeClick(object sender, RoutedEventArgs e)
        {
            vm.Calculate();
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            InfoWindow iw = new InfoWindow(vm)
            {
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                Owner = this
            };
            iw.Show();
        }
    }
}
