namespace prueba1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var num1 = 10;
            var num2 = 20;
            int resultado = Suma (num1, num2)
        }

        private int Suma(int a, int b)
        { 
            int totalSuma = a + b;

            return totalSuma;
        }
    }
}
