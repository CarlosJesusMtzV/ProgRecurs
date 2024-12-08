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
                MessageBox.Show("Por favor, ingrese un número entero positivo.");
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
                    MessageBox.Show("Opción no válida.");
                    break;
            }

            lblResultado.Text = $"Resultado: {resultado}";
        }

        // Métodos recursivos

        private int FactorialRecursivo(int n)
        {
            if (n == 0) return 1; // Condición de salida
            return n * FactorialRecursivo(n - 1); // Llamada recursiva
        }

        private int FibonacciRecursivo(int n)
        {
            if (n <= 1) return n; // Condición de salida
            return FibonacciRecursivo(n - 1) + FibonacciRecursivo(n - 2); // Llamada recursiva
        }

        private int SumaRecursiva(int n)
        {
            if (n == 0) return 0; // Condición de salida
            return n + SumaRecursiva(n - 1); // Llamada recursiva
        }
    }
}
