using System.Text.RegularExpressions;

namespace EstadosVisualesPersonalizados
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();

            GoToState(false);
        }

        private void entrada_TextChanged(object sender, TextChangedEventArgs e)
        {
            bool esValido = Regex.IsMatch(e.NewTextValue, @"^[2-9]\d{2}-\d{3}-\d{4}$");
            GoToState(esValido);
        }

        void GoToState (bool esValido)
        {
            string estadoVisual = esValido ? "Valido" : "Invalido";
            VisualStateManager.GoToState(stack, estadoVisual);
        }
    }

}
