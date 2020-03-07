using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SiaCod_RGR
{
    public class Table
    {
        int _width;
        int _height;
        int _size;
        int _from;
        int _to;

        MatrixElement[] _colIs;
        Row[] _rows;
        Point _startPos;
        ICityStorage _graph;
        MatrixElement _chosenElem;

        public Table(Point position, ICityStorage graph)
        {
            _graph = graph;
            _startPos = position;
            _size = _graph.Count;
            _rows = new Row[_size];
            _colIs = new MatrixElement[_size];

            _width = 70;
            _height = 35;
            _chosenElem = null;
            CalcPositions();
        }

        public void CalcPositions()
        {
            Point currentRowStart = new Point(_startPos.X, _startPos.Y + _height);
            Point currentColStart = new Point(_startPos.X + _width, _startPos.Y);
            for (int i = 0; i < _size; i++)
            {
                _colIs[i] = new MatrixElement(currentColStart, _width, _height);
                _colIs[i].SetNode(_graph[i].Id);
                currentColStart.X += _width;
                _rows[i] = new Row(currentRowStart, _width, _height, _graph, i);
                currentRowStart.Y += _height;
            }
        }

        public void ReChoose()
        {
            for (int i = 0; i < _rows.Length; i++)
            {
                _rows[i].ResetSelect();
            }
            if (_chosenElem!=null)
            {
                _chosenElem.SetSelect();
            }
        }

        public void Resize(int height, int width)
        {
            //if ((_height - height - 5 > 4 * _size || height >= 0) && (_width - width - 5 > 8 * _size || width >= 0))
            {
                _height += height;
                _width += width;
                _rows = new Row[_size];
                _colIs = new MatrixElement[_size];
                CalcPositions();
            }
        }

        public void Draw(Graphics g)
        {
            for (int i = 0; i < _size; i++)
            {
                _colIs[i].Draw(g);
                _rows[i].Draw(g);
            }

            Font drawFont = new Font("Times New Roman", 15);//Arial
            SolidBrush drawBrush = new SolidBrush(Color.Blue);
            //string output = "Выберите одно из значений таблицы для вывода кратчайшего пути от одной вершины графа, до другой." + '\r' + '\n' +
            //    "(Строки первая вершина, колонки вторая)" + '\r' + '\n' +
            //    "Кратчайший путь межу данными вершин: " + GetPath();
            //g.DrawString(output, drawFont, drawBrush, new Point(10, 10));
        }

        public string GetPath()
        {
            int firstId = _rows[_from].GetId();
            int secondId = _rows[_from].GetElement(_to).GetId();
            ICity firstCity = null;
            ICity secondCity = null;
            for (int i = 0; i < _graph.Count; i++)
            {
                ICity currentCity1 = _graph[i];
                if (currentCity1.Id== firstId)
                {
                    firstCity = currentCity1;
                }
                if (currentCity1.Id== secondId)
                {
                    secondCity = currentCity1;
                }
            }
            if (firstCity == null | secondCity == null)
            {
                return "";
            }
            int sum = firstCity.GetDistTo(secondCity.Id);
            if (sum >= 5000)
            {
                return "Отсутствует какой-либо путь между данными вершинами";
            }
            string path = "";
            ICityStorage qeue = secondCity.GetNeighbors();//new
            ICity currentCity = secondCity;
            List<string> pathList = new List<string>();
            while (sum > 0)
            {
                
                for (int i = 0; i < qeue.Count; i++)
                {
                    ICity tmpCity = qeue[i];
                    int weight = tmpCity.GetWeightToNeighbor(currentCity.Id);
                    if (firstCity.GetDistTo(tmpCity.Id) == firstCity.GetDistTo(currentCity.Id) - weight)
                    {
                        //path += currentCity.GetId() + " <- ";
                        pathList.Add(currentCity.Id.ToString());
                        sum -= weight;
                        currentCity = tmpCity;
                        break;
                    }
                }
                qeue = currentCity.GetNeighbors(); //new
            }
            for (int i = pathList.Count - 1; i >= 0; i--)
            {
                path += " -> " + pathList[i];
            }
            return firstCity.Id.ToString() + path;
        }

        public bool IsChoosen(int x, int y)
        {
            for (int i = 0; i < _rows.Length; i++)
            {
                for (int j = 1; j < _rows[i].GetSize() - 1; j++) 
                {
                    MatrixElement currentElem = _rows[i].GetElement(j);
                    if (currentElem.IsChoosen(x, y))
                    {
                        if (!currentElem.IsSelected())
                        {
                            _from = i;
                            _to = j;
                            _chosenElem = currentElem;
                        }
                        else
                        {
                            _chosenElem = null;
                        }
                        return true;
                    }
                }
            }
            return false;
        }

    }
}
