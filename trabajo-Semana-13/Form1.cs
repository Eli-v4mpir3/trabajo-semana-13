namespace trabajo_Semana_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnCalcular.Click += btnCalcular_Click;
            btnLimpiar.Click += btnLimpiar_Click;
            btnDatosPrueba.Click += btnDatosPrueba_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
        private double[] LeerSueldos(TextBox[] cajas)
        {

            double[] sueldos = new double[cajas.Length];


            for (int i = 0; i < cajas.Length; i++)
            {
                sueldos[i] = double.Parse(cajas[i].Text);
            }


            return sueldos;
        }
        private double CalcularTotal(double[] datos)
        {
            // Acumulador para sumar los sueldos.
            double total = 0;

            // Recorremos el arreglo y sumamos cada sueldo.
            for (int i = 0; i < datos.Length; i++)
            {
                total = total + datos[i];
            }

            return total;
        }
        private void OrdenarBurbuja(double[] datos)
        {
            // Método burbuja ascendente: ordena de menor a mayor.
            for (int i = 0; i < datos.Length - 1; i++)
            {
                for (int j = 0; j < datos.Length - 1 - i; j++)
                {
                    // Si el elemento actual es mayor que el siguiente, se intercambian.
                    if (datos[j] > datos[j + 1])
                    {
                        double auxiliar = datos[j];
                        datos[j] = datos[j + 1];
                        datos[j + 1] = auxiliar;
                    }
                }
            }
        }
        private void MostrarArreglo(string nombreTurno, double[] datos)
        {
            // Construimos una línea de texto con los sueldos del turno.
            string linea = nombreTurno + ": ";

            // Agregamos cada sueldo a la línea.
            for (int i = 0; i < datos.Length; i++)
            {
                linea += $"S/ {datos[i]:F2} ";
            }

            // Mostramos la línea en el ListBox.
            lstResultados.Items.Add(linea);
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Limpiamos resultados anteriores.
                lstResultados.Items.Clear();

                // 1. Leemos los sueldos de cada turno.
                double[] manana = LeerSueldos(new TextBox[] { txbM1, txbM2, txbM3 });
                double[] tarde = LeerSueldos(new TextBox[] { txbT1, txbT2 });
                double[] noche = LeerSueldos(new TextBox[] { txbN1, txbN2 });

                // 2. Calculamos el total de cada turno.
                double totalManana = CalcularTotal(manana);
                double totalTarde = CalcularTotal(tarde);
                double totalNoche = CalcularTotal(noche);

                // 3. Mostramos los totales.
                lstResultados.Items.Add("=== TOTALES POR TURNO ===");
                lstResultados.Items.Add($"Mañana: S/ {totalManana:F2}");
                lstResultados.Items.Add($"Tarde: S/ {totalTarde:F2}");
                lstResultados.Items.Add($"Noche: S/ {totalNoche:F2}");

                // 4. Determinamos el turno con mayor gasto.
                string turnoMayor = "Mañana";
                double mayorGasto = totalManana;

                if (totalTarde > mayorGasto)
                {
                    mayorGasto = totalTarde;
                    turnoMayor = "Tarde";
                }

                if (totalNoche > mayorGasto)
                {
                    mayorGasto = totalNoche;
                    turnoMayor = "Noche";
                }

                lblTurnoMayor.Text =
                    $"Turno con mayor gasto: {turnoMayor} (S/ {mayorGasto:F2})";

                // 5. Ordenamos los sueldos de cada turno.
                OrdenarBurbuja(manana);
                OrdenarBurbuja(tarde);
                OrdenarBurbuja(noche);

                // 6. Mostramos los sueldos ordenados.
                lstResultados.Items.Add("");
                lstResultados.Items.Add("=== SUELDOS ORDENADOS DE MENOR A MAYOR ===");
                MostrarArreglo("Mañana", manana);
                MostrarArreglo("Tarde", tarde);
                MostrarArreglo("Noche", noche);
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Ingrese solo números válidos en los sueldos.",
                    "Dato no válido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiamos los TextBox.
            txbM1.Clear();
            txbM2.Clear();
            txbM3.Clear();
            txbT1.Clear();
            txbT2.Clear();
            txbN1.Clear();
            txbN2.Clear();

            // Limpiamos resultados.
            lstResultados.Items.Clear();

            // Reiniciamos el texto del Label.
            lblTurnoMayor.Text = "Turno con mayor gasto: -";

            // Enviamos el foco al primer TextBox.
            txbM1.Focus();
        }
        private void btnDatosPrueba_Click(object sender, EventArgs e)
        {
            txbM1.Text = "1200";
            txbM2.Text = "1500";
            txbM3.Text = "1800";

            txbT1.Text = "1300";
            txbT2.Text = "1600";

            txbN1.Text = "1700";
            txbN2.Text = "2000";
        }
    }
}

    