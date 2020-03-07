using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SiaCod_RGR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            storage = new CityStorage();
            drawMode = "city";
        }
        int ClickCount = 0;
        ICityStorage storage;
        ICity tmpCity;
        string drawMode;
        private void pDraw_Click(object sender, EventArgs e)
        {
            ClickCount++;
            if (drawMode == "city")//!isChoosen(posX, posY)
            {
                storage.Add(new City(posX, posY));
            }
            else if (tmpCity == null && isChoosen(posX, posY))
            {
                for (int i = 0; i < storage.Count; i++)
                {
                    if (storage[i].IsSelected() == true)
                    {
                        tmpCity = storage[i];
                        break;
                    }
                }
            }
            else if (txtWeight.Text!= "" && isChoosen(posX, posY))
            {
                for (int i = 0; i < storage.Count; i++)
                {
                    ICity current = storage[i];
                    if (current.IsSelected() == true && current.Id!= tmpCity.Id)
                    {
                        tmpCity.SetRoadTo(current, Int32.Parse(txtWeight.Text));
                        tmpCity.ResetSelect();
                        tmpCity = null;
                        current.ResetSelect();
                        break;
                    }
                }
            }
            Refresh();
        }
        int posX, posY;
        private bool isChoosen(int x, int y)
        {
            bool Choosen = false;
            for (int i = 0; i < storage.Count; i++)
            {
                if (storage[i].IsChoosen(x, y))
                {
                    Choosen = true;
                }
            }
            return Choosen;
        }

        private void btnSetRD_Click(object sender, EventArgs e)
        {
            if (txtFrom.Text !="" && txtTo.Text != "" && txtWeight.Text!="")
            {
                int weidht = Int32.Parse(txtWeight.Text);
                for (int i = 0; i < storage.Count; i++)
                {
                    if (Int32.Parse(txtFrom.Text)==storage[i].Id)
                    {
                        for (int j = 0; j < storage.Count; j++)
                        {
                            if (Int32.Parse(txtTo.Text) == storage[j].Id)
                            {
                                storage[i].SetRoadTo(storage[j], weidht);//fix
                                break;
                            }
                        }
                        break;
                    }
                }
            }
            Refresh();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {

        }

        private void txtData_Click(object sender, EventArgs e)
        {
            //txtData.Text = "";
            for (int i = 0; i < storage.Count; i++)
            {
                //txtData.Text +=storage[i].GetId().ToString() +") " + storage[i].GetShortestDistSum().ToString() + '\r' + '\n';
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (storage.Count> 0)
            {
                storage.Delete(storage.Count- 1);
                Refresh();
            }
        }

        private void pDraw_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = pDraw.CreateGraphics();
            for (int i = 0; i < storage.Count; i++)
            {
                storage[i].Draw(g);
            }
        }

        private void btnCalc2_Click(object sender, EventArgs e)
        {
            int minSum = 5000;

            List<string> minDistIds = new List<string>();

            for (int i = 0; i < storage.Count; i++)
            {
                storage[i].CalcShortestDistSum();
                int tmpSum = 0;
                for (int j = 0; j < storage.Count; j++)
                {
                    tmpSum += storage[i].GetDistTo(storage[j].Id);
                }
                if (tmpSum < minSum)
                {
                    minDistIds = new List<string>();
                    minDistIds.Add(string.Format("Shortest Sum: {0}", tmpSum));
                    minDistIds.Add(string.Format("{0}", storage[i].Id));
                    minSum = tmpSum;
                }
                else if (tmpSum == minSum)
                {
                    minDistIds.Add(string.Format("{0}", storage[i].Id));
                }
            }

            txtMainInfo.Text += minDistIds[0] + '\r' + '\n' + "Id: ";
            for (int i = 1; i < minDistIds.Count; i++)
            {
                txtMainInfo.Text += minDistIds[i];
                if (i < minDistIds.Count - 1)
                {
                    txtMainInfo.Text += ", ";
                }
            }

            CreatTabForm();
        }

        private void CreatTabForm()
        {
            if (!storage.isEmpty())
            {
                //MatrixDrawer matrixDrawer = new MatrixDrawer(storage);
                Table table = new Table(new Point(50, 80), storage);
                DataMatrix DataMatrix = new DataMatrix();

                DataMatrix.Width = 1050;
                DataMatrix.Height = 500;
                DataMatrix.SetTable(table);

                DataMatrix.Show();
            }
        }

        private void btnQn_MouseHover(object sender, EventArgs e)
        {
            tTpQn.SetToolTip(btnQn, "Help");
        }

        private void btnTestGraph_Click(object sender, EventArgs e)
        {
            //int[,] positions =
            //{
            //    {50, 200}, //1
            //    {200, 100}, 
            //    {200, 200}, 
            //    {200, 300},
            //    {350, 100},
            //    {350, 200},
            //    {350, 300},
            //    {500, 200}  //8
            //};

            //for (int i = 0; i < positions.Length/2; i++)
            //{
            //    storage.AddCity(new City(positions[i, 0], positions[i, 1]));
            //}

            //int[] weights =
            //{
            //    26, 11, 9, 24, 140, 51, 2, 3, 7, 8
            //};
            //for (int i = 0; i < 3; i++)
            //{
            //    storage[0].SetRoadTo(storage[i+1], weights[i]);
            //}
            //for (int i = 1; i < 4; i++)
            //{
            //    storage[i].SetRoadTo(storage[i + 3], weights[i+2]);
            //}
            //for (int i = 4; i < 7; i++)
            //{
            //    storage[i].SetRoadTo(storage[7], weights[i + 2]);
            //}
            //storage[2].SetRoadTo(storage[6], weights[weights.Length - 1]);

            int[,] positions =
            {
                {50, 200}, //1
                {200, 100}, 
                {200, 200}, 
                {200, 300},
                {350, 100},
                {350, 200},
                {350, 300},
                {500, 200}  //8
            };

            for (int i = 0; i < positions.Length / 2; i++)
            {
                storage.Add(new City(positions[i, 0], positions[i, 1]));
            }

            int[] weights =
            {
                1, 5, 3, 8, 1, 10, 1, 7, 7, 10
            };
            for (int i = 0; i < 3; i++)
            {
                storage[0].SetRoadTo(storage[i + 1], weights[i]);
            }
            for (int i = 1; i < 4; i++)
            {
                storage[i].SetRoadTo(storage[i + 3], weights[i + 2]);
            }
            for (int i = 4; i < 7; i++)
            {
                storage[i].SetRoadTo(storage[7], weights[i + 2]);
            }
            storage[2].SetRoadTo(storage[3], weights[weights.Length - 1]);
            storage[4].SetRoadTo(storage[5], 1);
            Refresh();
        }

        private void btnNewGraph_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < storage.Count; i++)
            {
                storage[i].Delete(storage);
            }
            storage = null;
            storage = new CityStorage();
            Refresh();
        }

        private void btnDrawModes_Click(object sender, EventArgs e)
        {
            if (drawMode == "city")
            {
                drawMode = "road";
                btnDrawModes.Text = "Draw city mode";
            }
            else
            {
                drawMode = "city";
                btnDrawModes.Text = "Draw road mode";
            }
        }

        private void btnQn_Click(object sender, EventArgs e)
        {
            FormHelp formHelp = new FormHelp();
            formHelp.Show();
        }

        private void pDraw_MouseMove(object sender, MouseEventArgs e)
        {
            posX = e.X;
            posY = e.Y;
        }
    }
}
