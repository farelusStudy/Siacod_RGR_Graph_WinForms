using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SiaCod_RGR
{
    public class MatrixElement
    {
        int _FirstId;
        int _SecondId;
        int _Node;
        int _width;
        int _height;
        int _Id;

        Point _position;
        Rectangle _rectangle;
        Pen _pen;
        Font _drawFont;
        SolidBrush _drawBrush;

        bool _selected;

        public MatrixElement(Point position, int width, int height, int Id = 0)
        {
            _width = width;
            _height = height;
            _position = position;
            _rectangle = new Rectangle(_position.X, _position.Y, _width, _height);
            _pen = new Pen(Color.Black, 2);
            _drawFont = new Font("Times New Roman", (_height+_width)/8);//Arial
            _drawBrush = new SolidBrush(Color.Blue);
            _selected = false;
            _Id = Id;
        }

        public void SetPositionInMatrix(int colId, int rowId)
        {
            _FirstId = colId;
            _SecondId = rowId;
        }

        public void SetNode(int value)
        {
            _Node = value;
        }

        public void Draw(Graphics g)
        {
            if (_selected || _Id == 0)
            {
                //_pen.Color = Color.Red;
                g.FillRectangle(_drawBrush, _rectangle);
                _drawBrush.Color = Color.White;
            }
            else
            {
                _pen.Color = Color.Black;
                g.DrawRectangle(_pen, _rectangle);
            }
            int koef = 1;
            int count = 0;
            for (int i = 1; i < _Node; i*=10)
            {
                count++;
                koef = count;
            }
            Point strPoint = new Point(_position.X + _width / (2 *koef), _position.Y + _height / 3);
            
            g.DrawString(_Node.ToString(), _drawFont, _drawBrush, strPoint);
            _drawBrush.Color = Color.Blue;
        }

        public void ResetSelect()
        {
            _selected = false;
        }

        public void SetSelect()
        {
            _selected = true;
        }

        public int GetId() { return _Id; }

        public bool IsSelected() { return _selected; }

        public bool IsChoosen(int x, int y)
        {
            if (x > _position.X && _position.X + _width > x && y > _position.Y && _position.Y + _height > y)
            {
                return true;
            }
            return false;
        }
    }
}
