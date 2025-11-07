using System.Collections.Generic; // Adiciona para List<T>
using AppHotel.Models;

namespace AppHotel
{
    public partial class App : Application
    {
        public List<Quarto> ListaQuartos { get; set; } = new List<Quarto>
        {
            new Quarto { Descricao = "Quarto Standard", PrecoDiaria = 150.00m, PrecoDiariaCrianca = 75.00m },
            new Quarto { Descricao = "Quarto Deluxe", PrecoDiaria = 250.00m, PrecoDiariaCrianca = 125.00m },
            new Quarto { Descricao = "Suíte Executiva", PrecoDiaria = 400.00m, PrecoDiariaCrianca = 200.00m }
        };

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);
            window.Title = "Hotel App";

            window.Width = 400;
            window.Height = 700;
            return window;
        }
    }
}
