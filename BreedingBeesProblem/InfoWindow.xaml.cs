using System.Windows;

namespace BreedingBeesProblem
{
    /// <summary>
    /// Interaction logic for InfoWindow.xaml
    /// </summary>
    public partial class InfoWindow : Window
    {
        ViewModel vm;
        public InfoWindow(ViewModel vm)
        {
            InitializeComponent();
            this.vm = vm;
            DataContext = vm;
        }
    }
}
