using System.Windows;
using System.Windows.Controls;

namespace ChiffreSecret
{
    public partial class MainWindow : Window
    {
        private const int BUTTON_Width = 39;
        int NumberOfAttempts;
        int NumberToFind;
        int numberRandom = Random.Shared.Next(0, 20);
        int valueBtn = 0;
        public MainWindow()
        {
            InitializeComponent();
            PrepareButtons();
            // Va voir le menu!
        }

        private void PrepareButtons()
        {
            // Ici tu vas préparer tes boutons.
            for (int i = 0; i <= 20; i++)
            {
                Button button = new Button();
                button.Margin = new Thickness((i - 1) * BUTTON_Width, 0, 0, 0);
                button.Content = i;
                GridButtons.Children.Add(button);
                button.Width = BUTTON_Width;
                button.HorizontalAlignment = HorizontalAlignment.Left;
                button.Click += OnBtnNumberClick;
            }
        }

        void OnBtnNumberClick(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                valueBtn = int.Parse(button.Content.ToString());

                if (valueBtn == numberRandom)
                {
                    MessageBox.Show($" Vous avez gangner, le chiffre etait bien {button.Content.ToString()}");
                }
                else if (valueBtn < numberRandom)
                {
                    tbHint.Text = "↑";
                }
                else if (valueBtn > numberRandom)
                {
                    tbHint.Text = "↓";
                }
            }


        }
        void OnMenuNewGameClick(object sender, RoutedEventArgs e)
        {
            valueBtn = 0;
            numberRandom = Random.Shared.Next(0, 20);
            tbHint.Text = "?";

        }
    }
}