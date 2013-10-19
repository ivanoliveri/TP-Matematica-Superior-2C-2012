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
            this.btnDeleteSelectedOrdenedPair = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBackwardInterpolatingPolynomial = new System.Windows.Forms.TextBox();
            this.txtForwardInterpolatingPolynomial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(378, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso de Pares Ordenados";
            // 
            // btnAddOrdenedPair
            // 
            this.btnAddOrdenedPair.Location = new System.Drawing.Point(7, 55);
            this.btnAddOrdenedPair.Name = "btnAddOrdenedPair";
            this.btnAddOrdenedPair.Size = new System.Drawing.Size(364, 31);
            this.btnAddOrdenedPair.TabIndex = 4;
            this.btnAddOrdenedPair.Text = "Agregar";
            this.btnAddOrdenedPair.UseVisualStyleBackColor = true;
            this.btnAddOrdenedPair.Click += new System.EventHandler(this.btnAddOrdenedPair_Click);
            // 
            // txtYValue
            // 
            this.txtYValue.Location = new System.Drawing.Point(271, 28);
            this.txtYValue.Name = "txtYValue";
            this.txtYValue.Size = new System.Drawing.Size(100, 20);
            this.txtYValue.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor de Y :";
            // 
            // txtXValue
            // 
            this.txtXValue.Location = new System.Drawing.Point(75, 28);
            this.txtXValue.Name = "txtXValue";
            this.txtXValue.Size = new System.Drawing.Size(100, 20);
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
            this.groupBox2.Controls.Add(this.btnDeleteSelectedOrdenedPair);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 195);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Valores Ingresados";
            // 
            // btnDeleteSelectedOrdenedPair
            // 
            this.btnDeleteSelectedOrdenedPair.Location = new System.Drawing.Point(9, 155);
            this.btnDeleteSelectedOrdenedPair.Name = "btnDeleteSelectedOrdenedPair";
            this.btnDeleteSelectedOrdenedPair.Size = new System.Drawing.Size(364, 31);
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
            this.dataGridView1.Size = new System.Drawing.Size(364, 128);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBackwardInterpolatingPolynomial);
            this.groupBox3.Controls.Add(this.txtForwardInterpolatingPolynomial);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(13, 316);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(377, 96);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultados";
            // 
            // txtBackwardInterpolatingPolynomial
            // 
            this.txtBackwardInterpolatingPolynomial.Location = new System.Drawing.Point(124, 59);
            this.txtBackwardInterpolatingPolynomial.Name = "txtBackwardInterpolatingPolynomial";
            this.txtBackwardInterpolatingPolynomial.Size = new System.Drawing.Size(246, 20);
            this.txtBackwardInterpolatingPolynomial.TabIndex = 3;
            // 
            // txtForwardInterpolatingPolynomial
            // 
            this.txtForwardInterpolatingPolynomial.Location = new System.Drawing.Point(124, 26);
            this.txtForwardInterpolatingPolynomial.Name = "txtForwardInterpolatingPolynomial";
            this.txtForwardInterpolatingPolynomial.Size = new System.Drawing.Size(246, 20);
            this.txtForwardInterpolatingPolynomial.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Polinomio Regresivo :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Polinomio Progresivo :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnExit);
            this.groupBox4.Controls.Add(this.btnCalculate);
            this.groupBox4.Location = new System.Drawing.Point(12, 419);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(378, 97);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Operaciones";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(7, 19);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(364, 31);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(7, 56);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(364, 31);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 521);
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
        private System.Windows.Forms.Button btnCalculate;
    }
}

