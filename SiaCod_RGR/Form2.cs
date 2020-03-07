using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SiaCod_RGR
{
    public partial class DataMatrix : Form
    {
        public DataMatrix()
        {
            InitializeComponent();
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer | 
                ControlStyles.UserPaint | 
                ControlStyles.AllPaintingInWmPaint, 
                true);

            _width = 50;
        }

        int _width;
        IMatrixDrawer _matrixDrawer;
        Table _table;

        int _posX, _posY;


        public void SetMatrixDrawer(IMatrixDrawer md)
        {
            _matrixDrawer = md;
            Refresh();
        }

        public void SetTable(Table table)
        {
            _table = table;
            Refresh();
        }

        private void pMain_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            _width--;
            _matrixDrawer.SetWidth(_width);
            Refresh();
        }

        private void pMain_MouseMove(object sender, MouseEventArgs e)
        {
            _posX = e.X;
            _posY = e.Y;
        }

        private void pMain_Click(object sender, EventArgs e)
        {

        }

        private void DataMatrix_Click(object sender, EventArgs e)
        {
            if (_table.IsChoosen(_posX, _posY))
            {
                _table.ReChoose();
            }
            Refresh();
        }

        private void DataMatrix_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            _table.Draw(g);
        }

        private void DataMatrix_MouseMove(object sender, MouseEventArgs e)
        {
            _posX = e.X;
            _posY = e.Y;
        }

        private void DataMatrix_Load(object sender, EventArgs e)
        {
            
        }

        private void btnWidthPlus_Click(object sender, EventArgs e)
        {
            _table.Resize(0, 5);
            Refresh();
        }

        private void btnHeightMinus_Click(object sender, EventArgs e)
        {
            _table.Resize(-5, 0);
            Refresh();
        }

        private void btnHeightPlus_Click(object sender, EventArgs e)
        {
            _table.Resize(5, 0);
            Refresh();
        }

        private void btnWidthMinus_Click(object sender, EventArgs e)
        {
            _table.Resize(0, -5);
            Refresh();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            _width++;
            _matrixDrawer.SetWidth(_width);
            Refresh();
        }
    }
}
