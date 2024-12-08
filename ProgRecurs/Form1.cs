namespace ProgRecurs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero;

            // Validar entrada
            if (!int.TryParse(txtNumero.Text, out numero) || numero < 0)
            {
                MessageBox.Show("Por favor, ingrese un n�mero entero positivo.");
                return;
            }

            string problema = comboBoxProblemas.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(problema))
            {
                MessageBox.Show("Seleccione un problema de la lista.");
                return;
            }

            int resultado = 0;

            switch (problema)
            {
                case "Factorial":
                    resultado = FactorialRecursivo(numero);
                    break;
                case "Fibonacci":
                    resultado = FibonacciRecursivo(numero);
                    break;
                case "Suma":
                    resultado = SumaRecursiva(numero);
                    break;
                default:
                    MessageBox.Show("Opci�n no v�lida.");
                    break;
            }

            lblResultado.Text = $"Resultado: {resultado}";
        }

        // M�todos recursivos

        private int FactorialRecursivo(int n)
        {
            if (n == 0) return 1; // Condici�n de salida
            return n * FactorialRecursivo(n - 1); // Llamada recursiva
        }

        private int FibonacciRecursivo(int n)
        {
            if (n <= 1) return n; // Condici�n de salida
            return FibonacciRecursivo(n - 1) + FibonacciRecursivo(n - 2); // Llamada recursiva
        }

        private int SumaRecursiva(int n)
        {
            if (n == 0) return 0; // Condici�n de salida
            return n + SumaRecursiva(n - 1); // Llamada recursiva
        }
    }
}
