namespace sumaRectaMultietcgrafi
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
            txt_Valor1 = new TextBox();
            txt_Valor2 = new TextBox();
            txt_Suma = new TextBox();
            txt_Multiplicacion = new TextBox();
            txt_Resta = new TextBox();
            txt_Division = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btn_Calcular = new Button();
            btn_Limpiar = new Button();
            btn_Salir = new Button();
            SuspendLayout();
            // 
            // txt_Valor1
            // 
            txt_Valor1.Location = new Point(162, 109);
            txt_Valor1.Name = "txt_Valor1";
            txt_Valor1.Size = new Size(100, 23);
            txt_Valor1.TabIndex = 0;
            // 
            // txt_Valor2
            // 
            txt_Valor2.Location = new Point(293, 109);
            txt_Valor2.Name = "txt_Valor2";
            txt_Valor2.Size = new Size(100, 23);
            txt_Valor2.TabIndex = 1;
            // 
            // txt_Suma
            // 
            txt_Suma.Location = new Point(34, 270);
            txt_Suma.Name = "txt_Suma";
            txt_Suma.Size = new Size(100, 23);
            txt_Suma.TabIndex = 2;
            // 
            // txt_Multiplicacion
            // 
            txt_Multiplicacion.Location = new Point(162, 270);
            txt_Multiplicacion.Name = "txt_Multiplicacion";
            txt_Multiplicacion.Size = new Size(100, 23);
            txt_Multiplicacion.TabIndex = 3;
            // 
            // txt_Resta
            // 
            txt_Resta.Location = new Point(293, 270);
            txt_Resta.Name = "txt_Resta";
            txt_Resta.Size = new Size(100, 23);
            txt_Resta.TabIndex = 4;
            // 
            // txt_Division
            // 
            txt_Division.Location = new Point(418, 270);
            txt_Division.Name = "txt_Division";
            txt_Division.Size = new Size(100, 23);
            txt_Division.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(188, 77);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 6;
            label1.Text = "Valor1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(317, 77);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 7;
            label2.Text = "Valor2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 308);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 8;
            label3.Text = "Suma";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(179, 308);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 9;
            label4.Text = "Multiplicacion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(334, 308);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 10;
            label5.Text = "Resta";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(448, 308);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 11;
            label6.Text = "Division";
            // 
            // btn_Calcular
            // 
            btn_Calcular.Location = new Point(59, 398);
            btn_Calcular.Name = "btn_Calcular";
            btn_Calcular.Size = new Size(75, 23);
            btn_Calcular.TabIndex = 12;
            btn_Calcular.Text = "Calcular";
            btn_Calcular.UseVisualStyleBackColor = true;
            btn_Calcular.Click += btn_Calcular_Click;
            // 
            // btn_Limpiar
            // 
            btn_Limpiar.Location = new Point(240, 398);
            btn_Limpiar.Name = "btn_Limpiar";
            btn_Limpiar.Size = new Size(75, 23);
            btn_Limpiar.TabIndex = 13;
            btn_Limpiar.Text = "Limpiar";
            btn_Limpiar.UseVisualStyleBackColor = true;
            btn_Limpiar.Click += btn_Limpiar_Click;
            // 
            // btn_Salir
            // 
            btn_Salir.BackColor = Color.Red;
            btn_Salir.ForeColor = SystemColors.ButtonHighlight;
            btn_Salir.Location = new Point(418, 398);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(75, 23);
            btn_Salir.TabIndex = 14;
            btn_Salir.Text = "X";
            btn_Salir.UseVisualStyleBackColor = false;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 450);
            Controls.Add(btn_Salir);
            Controls.Add(btn_Limpiar);
            Controls.Add(btn_Calcular);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_Division);
            Controls.Add(txt_Resta);
            Controls.Add(txt_Multiplicacion);
            Controls.Add(txt_Suma);
            Controls.Add(txt_Valor2);
            Controls.Add(txt_Valor1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Valor1;
        private TextBox txt_Valor2;
        private TextBox txt_Suma;
        private TextBox txt_Multiplicacion;
        private TextBox txt_Resta;
        private TextBox txt_Division;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btn_Calcular;
        private Button btn_Limpiar;
        private Button btn_Salir;
    }
}