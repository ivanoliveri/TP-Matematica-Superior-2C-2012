using System;
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

            var newOrdenedPair = new OrdenedPair()
            {
                xValue = int.Parse(txtXValue.Text),
                yValue = int.Parse(txtYValue.Text)
            };

            ordenedPairs.Add(newOrdenedPair);
            ordenedPairs = ordenedPairs.OrderByDescending(aPair => aPair.xValue).Reverse().ToList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ordenedPairs;

            txtXValue.Clear();      
            txtYValue.Clear();
        }

        private void btnDeleteSelectedOrdenedPair_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)            {
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

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var interpolatingPolynomial = new InterpolatingPolynomial() { ordenedPairs=this.ordenedPairs};
            txtForwardInterpolatingPolynomial.Text = interpolatingPolynomial.calculateInterpolatingPolynomialUsingForwardDifferences();
        }

    }
}
