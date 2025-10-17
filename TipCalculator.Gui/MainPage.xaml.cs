namespace TipCalculator.Gui
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void CalcularClicked(object sender, EventArgs e)
        {
            decimal importe = decimal.Parse(txtImporte.Text);
            decimal personas = decimal.Parse(txtPersonas.Text);
            decimal propina = decimal.Parse(txtPropina.Text);

            decimal propinaTotal = importe * propina / 100;
            decimal propinaPersona = propinaTotal / personas;
            decimal total = importe + propinaTotal;
            decimal totalPersona = total / personas;

            lblPropinaTotal.Text = propinaTotal.ToString("F2");
            lblPropinaPorPersona.Text = propinaPersona.ToString("F2");
            lblTotal.Text = total.ToString("F2");
            lblTotalPorPersona.Text = totalPersona.ToString("F2");
        }

        private void LimpiarClicked(object sender, EventArgs e)
        {
            txtImporte.Text = "";
            txtPersonas.Text = "";
            txtPropina.Text = "";
            lblPropinaTotal.Text = "0.00";
            lblPropinaPorPersona.Text = "0.00";
            lblTotal.Text = "0.00";
            lblTotalPorPersona.Text = "0.00";
        }
    }
}