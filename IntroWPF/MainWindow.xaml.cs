using System.Windows;

namespace IntroWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool _isOn = false;
        public MainWindow()
        {
            InitializeComponent();

            tbIntro.Text = "Salut le monde!";
            tbIntro.FontSize = 120;

            // Ensuite ajouter un bouton pour changer le texte (de type toggle)
        }

        private void OnOnOff_Click(object sender, RoutedEventArgs e)
        {

            //if (_isOn)
            //{
            //    tbIntro.Text = "Salut le monde!";
            //}
            //else 
            //{
            //    tbIntro.Text = "Hello words";
            //}

            //predicat ternerre
            tbIntro.Text = _isOn ? "Salut le monde!" : "Hello words";
            _isOn = !_isOn;
        }
    }
}