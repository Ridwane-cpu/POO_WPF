using System.Windows;
using System.Windows.Controls;

namespace ListeDeNoms
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int comteur = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        void OnEdtNomKeyDown(object sender, EventArgs e)
        {
            // Comment on ajoute un évènement en xaml?



        }

        void OnBtnAddNameClick(object sender, EventArgs e)
        {
            AddName(edtName.Text);
            AddNameText();

        }

        private void AddNameText()
        {
            if (comteur < 10)
            {
                var tbNom = new TextBlock();
                tbNom.Text = edtName.Text;
                tbNom.Margin = new Thickness(10, 1, 0, 0);
                gridNoms.RowDefinitions.Add(new RowDefinition());
                Grid.SetRow(tbNom, gridNoms.RowDefinitions.Count - 1);
                gridNoms.Children.Add(tbNom);
                comteur++;
            }
            else if (comteur == 10)
            {
                btnAddName.IsEnabled = false;
            }
        }

        // Avoir un message box qui montre le nom
        void AddName(string name)
        {
            MessageBox.Show(name);

        }
    }
}