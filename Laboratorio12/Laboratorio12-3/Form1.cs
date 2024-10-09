namespace Laboratorio12_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSemiperimetro_Click(object sender, EventArgs e)
        {
            double ladoA = double.Parse(txtLadoA.Text);
            double ladoB = double.Parse(txtLadoB.Text);
            double ladoC = double.Parse(txtLadoC.Text);

            double semiperimetro = (ladoA + ladoB + ladoC) / 2;

            txtSemiperimetro.Text = semiperimetro.ToString();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            double ladoA = double.Parse(txtLadoA.Text);
            double ladoB = double.Parse(txtLadoB.Text);
            double ladoC = double.Parse(txtLadoC.Text);

            double semiperimetro = (ladoA + ladoB + ladoC) / 2;

            double area = Math.Sqrt(semiperimetro * (semiperimetro - ladoA) * (semiperimetro - ladoB) * (semiperimetro - ladoC));

            txtArea.Text = area.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtLadoA.Text = "";
            txtLadoB.Text = "";
            txtLadoC.Text = "";
            txtSemiperimetro.Text = "";
            txtArea.Text = "";
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
