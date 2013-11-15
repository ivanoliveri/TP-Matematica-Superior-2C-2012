﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Domain;

namespace GUI
{
    public partial class frmMain : Form
    {

        public List<OrdenedPair> ordenedPairs { set; get; }

        public float maxX { set; get; }

        public float minX { set; get; }

        public frmMain()
        {
            ordenedPairs = new List<OrdenedPair>();

            InitializeComponent();
            
        }

		private void btnAddOrdenedPair_Click(object sender, EventArgs e)
        {

            if (txtXValue.Text.Trim().Equals("") || txtYValue.Text.Trim().Equals(""))
            {
                MessageBox.Show("No has ingresado los valores de X y/o Y.");
                return;
            }

            float parsedX , parsedY ;

            if ((float.TryParse(txtXValue.Text, out parsedX)) & (float.TryParse(txtYValue.Text, out parsedY)))
            {
                if(ordenedPairs.Count(aPair=> aPair.xValue.Equals(parsedX)).Equals(0) ){
                    var newOrdenedPair = new OrdenedPair()
                    {
                        xValue = float.Parse(txtXValue.Text),
                        yValue = float.Parse(txtYValue.Text)
                    };


                    ordenedPairs.Add(newOrdenedPair);
                    ordenedPairs = ordenedPairs.OrderByDescending(aPair => aPair.xValue).Reverse().ToList();
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = ordenedPairs;

                    txtXValue.Clear();
                    txtYValue.Clear();
                }
                else
                {
                    MessageBox.Show("Ya has ingresado un Y para ese valor de X.");
                }
            }
            else
            {
                MessageBox.Show("Datos no válidos ingresados de X y/o Y.");
                return;
            }

        }

        private void btnDeleteSelectedOrdenedPair_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null){
                var index = dataGridView1.CurrentCell.RowIndex;
                ordenedPairs.RemoveAt(index);
                ordenedPairs = ordenedPairs.OrderByDescending(aPair => aPair.xValue).Reverse().ToList();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ordenedPairs;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDeleteAllOrdenedPairs_Click(object sender, EventArgs e)
        {
            this.ordenedPairs = new List<OrdenedPair>();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ordenedPairs;
            txtBackwardInterpolatingPolynomial.Clear();
            txtForwardInterpolatingPolynomial.Clear();
            txtXValueToEvaluate.Clear();
            txtInterpolationInterval.Clear();
            txtResultOfEvaluation.Clear();
        }

        private void btnCalculatePolynomial_Click(object sender, EventArgs e)
        {
            if (this.ordenedPairs.Any())
            {
                var interpolatingPolynomial = new InterpolatingPolynomial() { ordenedPairs = this.ordenedPairs };

                txtForwardInterpolatingPolynomial.Text = interpolatingPolynomial.calculateInterpolatingPolynomialUsingForwardDifferences();

                txtBackwardInterpolatingPolynomial.Text = interpolatingPolynomial.calculateInterpolatingPolynomialUsingBackwardDifferences();

                var xValues = new List<float>();

                ordenedPairs.ForEach(aPair=> xValues.Add(aPair.xValue));

                this.maxX = xValues.Max();

                this.minX = xValues.Min();

                txtInterpolationInterval.Text =
                    new StringBuilder().Append("[")
                        .Append(this.minX)
                        .Append(",")
                        .Append(this.maxX)
                        .Append("]")
                        .ToString();
            }
            else
            {

                MessageBox.Show("No has ingresado datos.");

                return;
            }
        }

        private void btnEvaluatePolynomial_Click(object sender, EventArgs e){

            float aValue;

            if (txtBackwardInterpolatingPolynomial.Text.Trim().Equals("") ||
                txtForwardInterpolatingPolynomial.Text.Trim().Equals("")){

                    MessageBox.Show("Para evaluar un valor primero es necesario calcular los polinomios de interpolacion.");

                    return;                
            }

            if (!float.TryParse(txtXValueToEvaluate.Text, out aValue))
            {

                MessageBox.Show("El valor ingresado no es un numero.");

                return;
            }

            if (float.Parse(txtXValueToEvaluate.Text) > this.maxX ||
                (float.Parse(txtXValueToEvaluate.Text) < this.minX)){
                
                MessageBox.Show("El valor a evaluar no se encuentra dentro del intervalo de interpolacion.");

                return;
            }
        }

    }
}
