using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ListeDeNoms
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int comteurMargin = 0;
        int NAME_Top_Margin_Value = 1;
        int Name_Left_Margin_Value = 10;
        public MainWindow()
        {
            InitializeComponent();
        }

        void OnEdtNomKeyDown(object sender, EventArgs e)
        {
            // Comment on ajoute un évènement en xaml?
            if (e is KeyEventArgs keyEvent && keyEvent.Key == Key.Enter)
            {
                AddName(edtName.Text);
            }


        }

        void OnBtnAddNameClick(object sender, EventArgs e)
        {
            AddName(edtName.Text);
            AddNameText();

        }

        private void AddNameText()
        {
            if (comteurMargin < 10)
            {
                var tbNom = new TextBlock();
                tbNom.Text = edtName.Text;
                tbNom.Margin = new Thickness(Name_Left_Margin_Value, NAME_Top_Margin_Value, 0, 0);
                gridNoms.RowDefinitions.Add(new RowDefinition());
                Grid.SetRow(tbNom, gridNoms.RowDefinitions.Count - 1);
                gridNoms.Children.Add(tbNom);
                comteurMargin++;
            }
            else if (comteurMargin == 10)
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