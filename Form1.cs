namespace prueba1
{ /*
    TAREA
     realizar las operaciones matematicas, resta, multi, y division
    crear otra clase en la que realicen las sentencias de control que 
    hagan uso de los operadores relacionales y logicos
   
   */
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
            Operaciones op = new Operaciones();
            int resultado = op.Suma(num1, num2);  op.Resta(num1, num2); op.Division(num1, num2);
        }

    }
    class Operaciones
    {
        public int Suma(int a, int b)
        {
            int totalSuma = a + b;
            Console.WriteLine(totalSuma);

            return totalSuma;
        }
        public int Resta(int a, int b)
        {
            int totalResta = a + b;
            Console.WriteLine(totalResta);
            return totalResta;
        }
        public float Division (float a, float b)
        {
            float totalDiv = a / b;
            Console.WriteLine(totalDiv);
            return totalDiv;
        }
        public int multiplicacion (int a, int b)
        {
            int totalMulti = a * b;
            Console.WriteLine(totalMulti);
            return totalMulti;
        }
    }
}
