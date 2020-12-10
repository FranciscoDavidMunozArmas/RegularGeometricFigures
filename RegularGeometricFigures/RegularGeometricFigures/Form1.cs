using RegularGeometricFigures.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegularGeometricFigures
{
    public partial class Form1 : Form
    {
        private RegularFigure obj;
        public Form1()
        {
            InitializeComponent();
            obj = new RegularFigure();
            obj.Initialize(this.txtSize, this.txtPerimeter, this.txtArea, this.picCanvas, this.tkbSides.Value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            obj.Initialize(this.txtSize, this.txtPerimeter, this.txtArea, this.picCanvas, this.tkbSides.Value);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            FormAction();
        }

        private void tkbSides_ValueChanged(object sender, EventArgs e)
        {
            FormAction();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            try
            {
                obj.Initialize(this.txtSize, this.txtPerimeter, this.txtArea, this.picCanvas, this.tkbSides.Value);
                this.txtSize.Text = "0";
                tkbSides.Value = tkbSides.Minimum;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void FormAction()
        {
            try
            {
                this.picCanvas.Refresh();
                obj.ReadData(this.txtSize, this.tkbSides.Value);
                obj.Perimeter();
                obj.Area();
                obj.PrintData(this.txtPerimeter, this.txtArea);
                obj.GraphShape(this.picCanvas);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                obj.CloseForm(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
