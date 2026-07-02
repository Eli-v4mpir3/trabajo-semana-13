namespace trabajo_Semana_13
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            txbM3 = new TextBox();
            txbM2 = new TextBox();
            txbM1 = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            txbT2 = new TextBox();
            txbT1 = new TextBox();
            label12 = new Label();
            label14 = new Label();
            label6 = new Label();
            label7 = new Label();
            groupBox3 = new GroupBox();
            txbN2 = new TextBox();
            txbN1 = new TextBox();
            label15 = new Label();
            label8 = new Label();
            label9 = new Label();
            label17 = new Label();
            lblTurnoMayor = new Label();
            label5 = new Label();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnDatosPrueba = new Button();
            lstResultados = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 13);
            label1.Name = "label1";
            label1.Size = new Size(303, 25);
            label1.TabIndex = 0;
            label1.Text = "Ejercicio 1. Planilla por turnos ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 38);
            label2.Name = "label2";
            label2.Size = new Size(722, 40);
            label2.TabIndex = 1;
            label2.Text = "Ingrese los sueldos de los trabajadores por turno. El programa calcula el gasto total, identifica el turno más \r\ncostoso y ordena los sueldos de menor a mayor usando burbuja.";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txbM3);
            groupBox1.Controls.Add(txbM2);
            groupBox1.Controls.Add(txbM1);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(17, 102);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(237, 155);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Turno Mañana";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txbM3
            // 
            txbM3.Location = new Point(106, 110);
            txbM3.Name = "txbM3";
            txbM3.Size = new Size(125, 27);
            txbM3.TabIndex = 10;
            // 
            // txbM2
            // 
            txbM2.Location = new Point(106, 71);
            txbM2.Name = "txbM2";
            txbM2.Size = new Size(125, 27);
            txbM2.TabIndex = 9;
            // 
            // txbM1
            // 
            txbM1.Location = new Point(106, 35);
            txbM1.Name = "txbM1";
            txbM1.Size = new Size(125, 27);
            txbM1.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9F);
            label11.Location = new Point(7, 116);
            label11.Name = "label11";
            label11.Size = new Size(92, 18);
            label11.TabIndex = 8;
            label11.Text = "Sueldo 3: S/.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9F);
            label10.Location = new Point(6, 78);
            label10.Name = "label10";
            label10.Size = new Size(92, 18);
            label10.TabIndex = 7;
            label10.Text = "Sueldo 2: S/.";
            label10.Click += label10_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F);
            label4.Location = new Point(6, 119);
            label4.Name = "label4";
            label4.Size = new Size(0, 18);
            label4.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F);
            label3.Location = new Point(6, 39);
            label3.Name = "label3";
            label3.Size = new Size(92, 18);
            label3.TabIndex = 4;
            label3.Text = "Sueldo 1: S/.";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txbT2);
            groupBox2.Controls.Add(txbT1);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(260, 102);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(237, 155);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Turno Tarde";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // txbT2
            // 
            txbT2.Location = new Point(105, 78);
            txbT2.Name = "txbT2";
            txbT2.Size = new Size(125, 27);
            txbT2.TabIndex = 11;
            // 
            // txbT1
            // 
            txbT1.Location = new Point(106, 35);
            txbT1.Name = "txbT1";
            txbT1.Size = new Size(125, 27);
            txbT1.TabIndex = 13;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 9F);
            label12.Location = new Point(12, 78);
            label12.Name = "label12";
            label12.Size = new Size(92, 18);
            label12.TabIndex = 11;
            label12.Text = "Sueldo 2: S/.";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 9F);
            label14.Location = new Point(12, 39);
            label14.Name = "label14";
            label14.Size = new Size(92, 18);
            label14.TabIndex = 9;
            label14.Text = "Sueldo 1: S/.";
            label14.Click += label14_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F);
            label6.Location = new Point(6, 78);
            label6.Name = "label6";
            label6.Size = new Size(0, 18);
            label6.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F);
            label7.Location = new Point(6, 39);
            label7.Name = "label7";
            label7.Size = new Size(0, 18);
            label7.TabIndex = 7;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txbN2);
            groupBox3.Controls.Add(txbN1);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label17);
            groupBox3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(502, 102);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(237, 155);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Turno Noche";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // txbN2
            // 
            txbN2.Location = new Point(106, 78);
            txbN2.Name = "txbN2";
            txbN2.Size = new Size(125, 27);
            txbN2.TabIndex = 15;
            // 
            // txbN1
            // 
            txbN1.Location = new Point(106, 35);
            txbN1.Name = "txbN1";
            txbN1.Size = new Size(125, 27);
            txbN1.TabIndex = 12;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 9F);
            label15.Location = new Point(12, 78);
            label15.Name = "label15";
            label15.Size = new Size(92, 18);
            label15.TabIndex = 14;
            label15.Text = "Sueldo 2: S/.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9F);
            label8.Location = new Point(6, 78);
            label8.Name = "label8";
            label8.Size = new Size(0, 18);
            label8.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9F);
            label9.Location = new Point(6, 39);
            label9.Name = "label9";
            label9.Size = new Size(0, 18);
            label9.TabIndex = 9;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 9F);
            label17.Location = new Point(12, 39);
            label17.Name = "label17";
            label17.Size = new Size(92, 18);
            label17.TabIndex = 12;
            label17.Text = "Sueldo 1: S/.";
            // 
            // lblTurnoMayor
            // 
            lblTurnoMayor.AutoSize = true;
            lblTurnoMayor.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTurnoMayor.Location = new Point(506, 292);
            lblTurnoMayor.Name = "lblTurnoMayor";
            lblTurnoMayor.Size = new Size(234, 20);
            lblTurnoMayor.TabIndex = 4;
            lblTurnoMayor.Text = "Turno Con Mayor Gasto : -";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(24, 350);
            label5.Name = "label5";
            label5.Size = new Size(84, 18);
            label5.TabIndex = 5;
            label5.Text = "Resultado";
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(9, 285);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(204, 35);
            btnCalcular.TabIndex = 11;
            btnCalcular.Text = "Calcular y Ordenar";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(220, 285);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(101, 35);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnDatosPrueba
            // 
            btnDatosPrueba.BackColor = SystemColors.ActiveCaption;
            btnDatosPrueba.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDatosPrueba.Location = new Point(332, 285);
            btnDatosPrueba.Name = "btnDatosPrueba";
            btnDatosPrueba.Size = new Size(162, 35);
            btnDatosPrueba.TabIndex = 13;
            btnDatosPrueba.Text = "Datos de Prueba";
            btnDatosPrueba.UseVisualStyleBackColor = false;
            // 
            // lstResultados
            // 
            lstResultados.FormattingEnabled = true;
            lstResultados.Location = new Point(23, 377);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(716, 204);
            lstResultados.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 759);
            Controls.Add(lstResultados);
            Controls.Add(btnDatosPrueba);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(label5);
            Controls.Add(lblTurnoMayor);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Ejercicio 1. Planilla por turnos ";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label11;
        private Label label10;
        private Label label15;
        private Label label17;
        private Label lblTurnoMayor;
        private Label label12;
        private Label label14;
        private Label label5;

        private TextBox txbM1;
        private TextBox txbM2;
        private TextBox txbM3;
        private TextBox txbT1;
        private TextBox txbT2;
        private TextBox txbN1;
        private TextBox txbN2;

        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnDatosPrueba;
        private ListBox lstResultados;
    }
}


        

