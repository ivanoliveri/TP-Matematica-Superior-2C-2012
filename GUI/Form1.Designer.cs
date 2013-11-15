namespace GUI
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddOrdenedPair = new System.Windows.Forms.Button();
            this.txtYValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtXValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteAllOrdenedPairs = new System.Windows.Forms.Button();
            this.btnDeleteSelectedOrdenedPair = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBackwardInterpolatingPolynomial = new System.Windows.Forms.TextBox();
            this.txtForwardInterpolatingPolynomial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalculatePolynomial = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtXValueToEvaluate = new System.Windows.Forms.TextBox();
            this.txtInterpolationInterval = new System.Windows.Forms.TextBox();
            this.txtResultOfEvaluation = new System.Windows.Forms.TextBox();
            this.btnEvaluatePolynomial = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPolynomialDegree = new System.Windows.Forms.TextBox();
            this.txtOrdenedPairsCount = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddOrdenedPair);
            this.groupBox1.Controls.Add(this.txtYValue);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtXValue);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso de Pares Ordenados";
            // 
            // btnAddOrdenedPair
            // 
            this.btnAddOrdenedPair.Location = new System.Drawing.Point(7, 55);
            this.btnAddOrdenedPair.Name = "btnAddOrdenedPair";
            this.btnAddOrdenedPair.Size = new System.Drawing.Size(494, 31);
            this.btnAddOrdenedPair.TabIndex = 4;
            this.btnAddOrdenedPair.Text = "Agregar";
            this.btnAddOrdenedPair.UseVisualStyleBackColor = true;
            this.btnAddOrdenedPair.Click += new System.EventHandler(this.btnAddOrdenedPair_Click);
            // 
            // txtYValue
            // 
            this.txtYValue.Location = new System.Drawing.Point(336, 27);
            this.txtYValue.Name = "txtYValue";
            this.txtYValue.Size = new System.Drawing.Size(165, 20);
            this.txtYValue.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor de Y :";
            // 
            // txtXValue
            // 
            this.txtXValue.Location = new System.Drawing.Point(75, 28);
            this.txtXValue.Name = "txtXValue";
            this.txtXValue.Size = new System.Drawing.Size(165, 20);
            this.txtXValue.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor de X :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeleteAllOrdenedPairs);
            this.groupBox2.Controls.Add(this.btnDeleteSelectedOrdenedPair);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(509, 210);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Valores Ingresados";
            // 
            // btnDeleteAllOrdenedPairs
            // 
            this.btnDeleteAllOrdenedPairs.Location = new System.Drawing.Point(9, 174);
            this.btnDeleteAllOrdenedPairs.Name = "btnDeleteAllOrdenedPairs";
            this.btnDeleteAllOrdenedPairs.Size = new System.Drawing.Size(492, 31);
            this.btnDeleteAllOrdenedPairs.TabIndex = 6;
            this.btnDeleteAllOrdenedPairs.Text = "Eliminar Todos Los Pares Ordenados";
            this.btnDeleteAllOrdenedPairs.UseVisualStyleBackColor = true;
            this.btnDeleteAllOrdenedPairs.Click += new System.EventHandler(this.btnDeleteAllOrdenedPairs_Click);
            // 
            // btnDeleteSelectedOrdenedPair
            // 
            this.btnDeleteSelectedOrdenedPair.Location = new System.Drawing.Point(9, 139);
            this.btnDeleteSelectedOrdenedPair.Name = "btnDeleteSelectedOrdenedPair";
            this.btnDeleteSelectedOrdenedPair.Size = new System.Drawing.Size(492, 31);
            this.btnDeleteSelectedOrdenedPair.TabIndex = 5;
            this.btnDeleteSelectedOrdenedPair.Text = "Eliminar Par Ordenado Seleccionado";
            this.btnDeleteSelectedOrdenedPair.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedOrdenedPair.Click += new System.EventHandler(this.btnDeleteSelectedOrdenedPair_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(494, 115);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtOrdenedPairsCount);
            this.groupBox3.Controls.Add(this.txtPolynomialDegree);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtBackwardInterpolatingPolynomial);
            this.groupBox3.Controls.Add(this.txtForwardInterpolatingPolynomial);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(13, 325);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(508, 121);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultados";
            // 
            // txtBackwardInterpolatingPolynomial
            // 
            this.txtBackwardInterpolatingPolynomial.Location = new System.Drawing.Point(124, 44);
            this.txtBackwardInterpolatingPolynomial.Name = "txtBackwardInterpolatingPolynomial";
            this.txtBackwardInterpolatingPolynomial.Size = new System.Drawing.Size(376, 20);
            this.txtBackwardInterpolatingPolynomial.TabIndex = 3;
            // 
            // txtForwardInterpolatingPolynomial
            // 
            this.txtForwardInterpolatingPolynomial.Location = new System.Drawing.Point(124, 18);
            this.txtForwardInterpolatingPolynomial.Name = "txtForwardInterpolatingPolynomial";
            this.txtForwardInterpolatingPolynomial.Size = new System.Drawing.Size(376, 20);
            this.txtForwardInterpolatingPolynomial.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Polinomio Regresivo :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Polinomio Progresivo :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnEvaluatePolynomial);
            this.groupBox4.Controls.Add(this.btnExit);
            this.groupBox4.Controls.Add(this.btnCalculatePolynomial);
            this.groupBox4.Location = new System.Drawing.Point(13, 557);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(509, 128);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Operaciones";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(7, 92);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(494, 31);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalculatePolynomial
            // 
            this.btnCalculatePolynomial.Location = new System.Drawing.Point(7, 19);
            this.btnCalculatePolynomial.Name = "btnCalculatePolynomial";
            this.btnCalculatePolynomial.Size = new System.Drawing.Size(494, 31);
            this.btnCalculatePolynomial.TabIndex = 6;
            this.btnCalculatePolynomial.Text = "Calcular Polinomios";
            this.btnCalculatePolynomial.UseVisualStyleBackColor = true;
            this.btnCalculatePolynomial.Click += new System.EventHandler(this.btnCalculatePolynomial_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtResultOfEvaluation);
            this.groupBox5.Controls.Add(this.txtInterpolationInterval);
            this.groupBox5.Controls.Add(this.txtXValueToEvaluate);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(12, 452);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(510, 100);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Evaluar Punto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Valor de X a Evaluar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Intervalo de Interpolacion:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Resultado Obtenido:";
            // 
            // txtXValueToEvaluate
            // 
            this.txtXValueToEvaluate.Location = new System.Drawing.Point(144, 23);
            this.txtXValueToEvaluate.Name = "txtXValueToEvaluate";
            this.txtXValueToEvaluate.Size = new System.Drawing.Size(357, 20);
            this.txtXValueToEvaluate.TabIndex = 4;
            // 
            // txtInterpolationInterval
            // 
            this.txtInterpolationInterval.Location = new System.Drawing.Point(143, 49);
            this.txtInterpolationInterval.Name = "txtInterpolationInterval";
            this.txtInterpolationInterval.Size = new System.Drawing.Size(357, 20);
            this.txtInterpolationInterval.TabIndex = 5;
            // 
            // txtResultOfEvaluation
            // 
            this.txtResultOfEvaluation.Location = new System.Drawing.Point(143, 73);
            this.txtResultOfEvaluation.Name = "txtResultOfEvaluation";
            this.txtResultOfEvaluation.Size = new System.Drawing.Size(357, 20);
            this.txtResultOfEvaluation.TabIndex = 6;
            // 
            // btnEvaluatePolynomial
            // 
            this.btnEvaluatePolynomial.Location = new System.Drawing.Point(7, 56);
            this.btnEvaluatePolynomial.Name = "btnEvaluatePolynomial";
            this.btnEvaluatePolynomial.Size = new System.Drawing.Size(494, 31);
            this.btnEvaluatePolynomial.TabIndex = 8;
            this.btnEvaluatePolynomial.Text = "Evaluar Polinomios Interpolantes en Valor Ingresado";
            this.btnEvaluatePolynomial.UseVisualStyleBackColor = true;
            this.btnEvaluatePolynomial.Click += new System.EventHandler(this.btnEvaluatePolynomial_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Grado del Polinomio :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Cantidad de Puntos Ingresados :";
            // 
            // txtPolynomialDegree
            // 
            this.txtPolynomialDegree.Location = new System.Drawing.Point(172, 68);
            this.txtPolynomialDegree.Name = "txtPolynomialDegree";
            this.txtPolynomialDegree.Size = new System.Drawing.Size(328, 20);
            this.txtPolynomialDegree.TabIndex = 6;
            // 
            // txtOrdenedPairsCount
            // 
            this.txtOrdenedPairsCount.Location = new System.Drawing.Point(173, 94);
            this.txtOrdenedPairsCount.Name = "txtOrdenedPairsCount";
            this.txtOrdenedPairsCount.Size = new System.Drawing.Size(328, 20);
            this.txtOrdenedPairsCount.TabIndex = 7;
            this.txtOrdenedPairsCount.Text = "0";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 690);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP-Matematica-Superior-2C-2012";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddOrdenedPair;
        private System.Windows.Forms.TextBox txtYValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtXValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeleteSelectedOrdenedPair;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBackwardInterpolatingPolynomial;
        private System.Windows.Forms.TextBox txtForwardInterpolatingPolynomial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalculatePolynomial;
        private System.Windows.Forms.Button btnDeleteAllOrdenedPairs;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnEvaluatePolynomial;
        private System.Windows.Forms.TextBox txtResultOfEvaluation;
        private System.Windows.Forms.TextBox txtInterpolationInterval;
        private System.Windows.Forms.TextBox txtXValueToEvaluate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOrdenedPairsCount;
        private System.Windows.Forms.TextBox txtPolynomialDegree;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

