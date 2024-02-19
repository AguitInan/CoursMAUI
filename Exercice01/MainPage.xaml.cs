using Microsoft.Maui.Controls;
using System;

namespace Exercice01
{
    public partial class MainPage : ContentPage
    {
        private int mysteryNumber;
        private Random random = new Random();

        public MainPage()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            mysteryNumber = random.Next(1, 101);
        }

        private void OnCheckNumberClicked(object sender, EventArgs e)
        {
            if (int.TryParse(entryNumber.Text, out int userNumber))
            {
                if (userNumber == mysteryNumber)
                {
                    lblResult.Text = "Bravo ! Vous avez trouvé le nombre mystère.";
                    lblResult.TextColor = Colors.Green;
                    btnRestart.IsVisible = true;
                }
                else if (userNumber < mysteryNumber)
                {
                    lblResult.Text = "Le nombre mystère est plus grand.";
                    lblResult.TextColor = Colors.Orange;
                }
                else
                {
                    lblResult.Text = "Le nombre mystère est plus petit.";
                    lblResult.TextColor = Colors.Orange;
                }
                lblResult.IsVisible = true;
            }
            else
            {
                lblResult.Text = "Veuillez entrer un nombre valide.";
                lblResult.TextColor = Colors.Red;
                lblResult.IsVisible = true;
            }

            entryNumber.Text = string.Empty;
        }

    }
}
