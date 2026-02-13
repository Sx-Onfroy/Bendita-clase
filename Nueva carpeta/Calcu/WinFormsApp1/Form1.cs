namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

            private void btnSumar_Click(object sender, EventArgs e)
        {
            double numero1;
            double numero2;

            if (double.TryParse(txtNumero1.Text, out numero1) &&
                double.TryParse(txtNumero2.Text, out numero2))
            {
                double suma = numero1 + numero2;
                lblResultado.Text = "Resultado: " + suma.ToString();
            }
            else
            {
                MessageBox.Show("Por favor ingresa solo números válidos.");
            }
        }

    }
}

