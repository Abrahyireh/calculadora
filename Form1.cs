namespace sumaRectaMultietcgrafi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            int Valor1 = Convert.ToInt32(txt_Valor1.Text);
            int Valor2 = Convert.ToInt32(txt_Valor2.Text);
            int Suma, Multiplicacion, Resta, Division;

            Suma = Valor1 + Valor2;
            Multiplicacion = Valor1 * Valor2;
            Resta = Valor1 - Valor2;
            Division = Valor1 / Valor2;

            string ResultadoSuma = $"{Suma}";
            txt_Suma.Text = ResultadoSuma.ToString();

            string ResultadoMultiplicacion = $"{Multiplicacion}";
            txt_Multiplicacion.Text = ResultadoMultiplicacion.ToString();

            string ResultadoResta = $"{Resta}";
            txt_Resta.Text = ResultadoResta.ToString();

            string ResultadoDivision = $"{Division}";
            txt_Division.Text = ResultadoDivision.ToString();



        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Suma.Clear();
            txt_Valor1.Clear();
            txt_Valor2.Clear();
            txt_Multiplicacion.Clear();
            txt_Resta.Clear();
            txt_Division.Clear();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}