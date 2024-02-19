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

    }
}
