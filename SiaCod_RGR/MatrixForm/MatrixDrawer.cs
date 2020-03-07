using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SiaCod_RGR
{
    public class MatrixDrawer : IMatrixDrawer
    {
        ICityStorage _graph;
        int _size;
        int _startX;
        int _startY;
        int _width;

        public MatrixDrawer(ICityStorage Graph)
        {
            _graph = Graph;
            _size = _graph.Count;
            _startX = 10;
            _startY = 10;
            _width = 50;
        }

        public void Draw(Graphics g)
        {
            Font font = new Font("Times New Roman", _width / 3 - 1);//Arial
            SolidBrush brush = new SolidBrush(Color.Green);

            int x = _startX;
            int y = _startY;
            
            for (int i = 0; i <= _size; i++)
            {
                x += _width;
                if (i < _size)
                {
                    g.DrawString(_graph[i].Id.ToString(), font, brush, new Point(x, y));
                    g.DrawString(_graph[i].Id.ToString(), font, brush, new Point(y, x));
                }
                else g.DrawString("Sum", font, brush, new Point(x, y));

                g.DrawLine(new Pen(Color.Black, 2), new Point(x, y), new Point(x, _width * (_size + 1) + _startY));
                g.DrawLine(new Pen(Color.Black, 2), new Point(y, x), new Point(_width * (_size + 2) + _startX, x));
            }
            x = _startX + _width;
            y = _startY + _width;
            brush = new SolidBrush(Color.Black);
            for (int i = 0; i < _size; i++)
            {
                ICity MainCity = _graph[i];
                int currentSum = 0;

                for (int j = 0; j <= _size; j++)
                {        
                    int value;
                    if (j < _size)
                    {
                        ICity Guest = _graph[j];
                        value = MainCity.GetDistTo(Guest.Id);
                        currentSum += value;
                    }
                    else value = currentSum;
                    g.DrawString(value.ToString(), font, brush, new Point(x, y));
                    x += _width;
                }
                x = _startX+ _width;
                y += _width;
            }
        }

        public void SetWidth(int value)
        {
            _width = value;
        }
    }
}
