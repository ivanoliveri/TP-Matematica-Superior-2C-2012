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
            var newOrdenedPair = new OrdenedPair()
            {
                xValue = int.Parse(txtXValue.Text),
                yValue = int.Parse(txtYValue.Text)
            };

            ordenedPairs.Add(newOrdenedPair);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ordenedPairs;
        }
    }
}
