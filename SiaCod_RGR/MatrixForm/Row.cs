using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SiaCod_RGR
{
    public class Row
    {
        int _size;
        int _id;
        int _width;
        int _height;
        int _index;
        Point _startPos;
        ICityStorage _Graph;
        MatrixElement[] _elements;

        public Row(Point startPosition, int width, int height, ICityStorage Graph, int index)
        {
            _Graph = Graph;
            _startPos = startPosition;
            _index = index;
            _id = _Graph[_index].Id;
            _size = _Graph.Count+ 2;
            _elements = new MatrixElement[_size];

            _width = width;
            _height = height;

            CalcPositions();
        }

        public void CalcPositions()
        {
            int sum = 0;
            Point currentStart = new Point(_startPos.X, _startPos.Y);
            _elements[0] = new MatrixElement(currentStart, _width, _height);
            _elements[0].SetNode(_id);
            for (int i = 0; i < _size - 2; i++)
            {
                currentStart.X += _width;
                ICity currentCity = _Graph[i];
                _elements[i+1] = new MatrixElement(currentStart, _width, _height, currentCity.Id);
                int currentData = _Graph[_index].GetDistTo(currentCity.Id);
                _elements[i+1].SetNode(currentData);
                sum += currentData;
            }
            currentStart.X += _width;
            _elements[_size - 1] = new MatrixElement(currentStart, _width, _height);
            _elements[_size - 1].SetNode(sum);
        }

        public void Draw(Graphics g)
        {
            for (int i = 0; i < _elements.Length; i++)
            {
                _elements[i].Draw(g);
            }
        }

        public MatrixElement GetElement(int index)
        {
            if (index < _size)
            {
                return _elements[index];
            }
            return null;
        }

        public void ResetSelect()
        {
            for (int i = 1; i < _size-1; i++)
            {
                _elements[i].ResetSelect();
            }
        }

        public int GetSize() { return _size; }
        public int GetId() { return _id; }

        public bool IsChoosen(int x, int y)
        {
            for (int i = 0; i < _elements.Length; i++)
            {
                if (_elements[i].IsChoosen(x, y))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
