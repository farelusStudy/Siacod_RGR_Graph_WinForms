using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;

namespace SiaCod_RGR
{
    class City : ICity
    {
        int _x, _y;
        
        int _id;
        int _rad;
        static int GeneralCount = 1;

        bool _selected;

        ICityStorage _neighbors;
        Pen _pen;
        IDataTable _weights;
        IDataTable _distSums;

        public City(int x, int y)
        {
            _id = GeneralCount;
            GeneralCount++;

            _x = x;
            _y = y;

            _neighbors = new CityStorage();
            _pen = new Pen(Color.Black, 5);
            _weights = new DataTable();
            _distSums = new DataTable();

            _rad = 15;
            _selected = false;
        }

        public void CalcShortestDistSum()
        {
            ICityStorage queue = new CityStorage();
            ICityStorage resultStorage = new CityStorage();

            queue.Add(this);
            _distSums.SetData(_id, 0);

            while (!queue.isEmpty())
            {
                int index = 0;
                ICity currentCity = GetMinFromTabAndStor(_distSums, queue, ref index);
                int CurrentCityDist = _distSums.GetInfo(currentCity.Id);
                for (int i = 0; i < currentCity.GetCntOfNeighbors(); i++)
                {
                    ICity currentNeighbor = currentCity.GetNeighbor(i);
                    int tmpDist = currentCity.GetWeightToNeighbor(currentNeighbor.Id) + CurrentCityDist;

                    if (tmpDist < _distSums.GetInfo(currentNeighbor.Id))
                    {
                        _distSums.SetData(currentNeighbor.Id, tmpDist);
                        queue.Add(currentNeighbor);//new
                    }
                    if (!CheckIsItHere(resultStorage, currentNeighbor) &&
                        !CheckIsItHere(queue, currentNeighbor))
                    {
                        queue.Add(currentNeighbor);
                    }
                }
                resultStorage.Add(currentCity);
                queue.Delete(index);
            }
        }

        public ICity GetMinFromTabAndStor(IDataTable table, ICityStorage storage, ref int index)
        {
            if (storage.isEmpty())
                return null;

            ICity vertex = storage[0];
            index = 0;
            int tmpMin = table.GetInfo(vertex.Id);
            for (int i = 1; i < storage.Count; i++)
            {
                ICity CurrentVertex = storage[i];
                int currentMin = table.GetInfo(CurrentVertex.Id);
                if (currentMin < tmpMin)
                {
                    vertex = CurrentVertex;
                    tmpMin = currentMin;
                    index = i;
                }
            }
            return vertex;
        }

        ////////////////////////////////////////////////////Draw/////////////////////////////////////////

        public void Draw(Graphics g)
        {
            if (_selected)
            {
                _pen.Color = Color.Red;
            }
            else
            {
                _pen.Color = Color.Black;
            }

            for (int i = 0; i < _neighbors.Count; i++)
            {
                DrawArrowTo(_neighbors[i], g);
            }
            g.DrawEllipse(_pen, _x - _rad, _y - _rad, 2 * _rad, 2 * _rad);
            DrawId(g);
        }

        private void DrawId(Graphics g)
        {
            Font drawFont = new Font("Times New Roman", 15);//Arial
            SolidBrush drawBrush = new SolidBrush(Color.Blue);

            int koef = 2;
            if (_id > 9)
            {
                koef = 1;
            }
            g.DrawString(_id.ToString(), drawFont, drawBrush,
             new Point(_x - _rad / koef, _y - _rad / 2));
        }

        private void DrawWeightTo(int weight, PointF middleOfLine, double sin, double cos, int koef, Graphics g)
        {
            SolidBrush drawBrush = new SolidBrush(Color.Blue);
            int fontSize = 13;
            int length = 1;
            int cnt = 1;

            for (int i = 1; i <= weight; i*=10)
            {
                cnt++;
            }
            length = cnt * fontSize/2;
            

            if (koef < 0)
            {
                if ((cos > 0.9 || cos < -0.9))
                {
                    if (cos > 0)
                    {
                        length -= (int)(length * cos);
                    }
                    else
                    {
                        length += (int)(length * cos);
                    }
                }
                else if (cnt > 2)
                {
                    length /= 2;
                    if (cos < -0.4 && cos > -0.9)
                    {
                        length += cnt;
                        if (cos < 0)
                        {
                            length = cnt * fontSize / 2 - cnt;
                        }
                    }
                }
            }

            PointF position = new PointF((float)(middleOfLine.X + (cos * (length))-length),
                                           (float)(middleOfLine.Y + (sin * (length)))-length);
            if (koef < 0)
            {
                if (cnt > 2)
                {
                    cnt--;
                }
                g.DrawLine(new Pen(drawBrush), position, new PointF(position.X + (cnt) * fontSize - fontSize, position.Y));
            }
            
            Font drawFont = new Font("Times New Roman", fontSize);//Arial

            g.DrawString(weight.ToString(), drawFont, drawBrush, position);
        }

        private void DrawArrowTo(ICity city, Graphics g)
        {
            PointF p0 = new PointF(_x, _y);
            PointF pEnd = new PointF(city.GetPositoin().X, city.GetPositoin().Y);

            float X = pEnd.X - p0.X;
            float Y = pEnd.Y - p0.Y;

            double lineLength = Math.Sqrt(X * X + Y * Y);
            double sin, cos;

            cos = X / lineLength;
            sin = Y / lineLength;

            PointF endPoint = new PointF((float)(p0.X + (cos * (lineLength - _rad))), 
                                         (float)(p0.Y + (sin * (lineLength - _rad))));

            PointF startPoint = new PointF((float)(p0.X + (cos * (_rad))), 
                                           (float)(p0.Y + (sin * (_rad))));

            PointF arrowPoint = new PointF((float)(p0.X + (cos * (lineLength - _rad - 10))), 
                                           (float)(p0.Y + (sin * (lineLength - _rad - 10))));

            PointF middlePoint = new PointF((float)(p0.X + (cos * (lineLength - lineLength / 2))),
                                           (float)(p0.Y + (sin * (lineLength - lineLength / 2))));

            float vectorX, vectorY;
            if (X < 10 && X > -10)
            {
                vectorX = 1;
                vectorY = -X / Y;
            }
            else
            {
                vectorX = -Y / X;
                vectorY = 1;
            }

            int koef;

            if (_id < city.Id)
                koef = 1;
            else
                koef = -1;

            PointF normVector = new PointF(vectorX, vectorY);

            double NormLength = Math.Sqrt(normVector.X * normVector.X +
                    normVector.Y * normVector.Y);

            double cosNorm = normVector.X / NormLength;
            double sinNorm = normVector.Y / NormLength;

            Pen linePen = new Pen(Color.Black, 2);

            g.DrawLine(linePen, startPoint, endPoint);

            if (koef > 0) 
            {
                DrawWeightTo(_weights.GetInfo(city.Id), middlePoint, koef * sinNorm, koef * cosNorm, koef, g);
            }
            
        }

        ////////////////////////////////////////////////////END Draw/////////////////////////////////////////


        public void SetRoadTo(ICity newneighbor, int weight)
        {
            if (!CheckIsItHere(_neighbors, newneighbor))
            {
                _neighbors.Add(newneighbor);
                _weights.SetData(newneighbor.Id, weight);
                _neighbors.Sort();
                newneighbor.SetRoadTo(this, weight);
            }
        }

        public void Delete(ICityStorage storage)
        {
            //for (int i = 0; i < _INeighborFrom.Count; i++) //del or fix
            //{
            //    for (int j = 0; j < _INeighborFrom[i].GetCntOfNeighbors(); j++)
            //    {
            //        if (_INeighborFrom[i].GetNeighbor(j).GetId() == _id)
            //        {
            //            _INeighborFrom[i].DeleteNeighbor(j);
            //        }
            //    }
            //}
            _neighbors = null;
            _distSums = null;
            _weights = null;
            GeneralCount = 1;
        }

        public void DeleteNeighbor(int index)
        {
            _neighbors.Delete(index);
        }

        public void ResetSelect()
        {
            if (_selected)
                _selected = false;
            else
                _selected = true;
        }


        ////////////////////////////////////////////////////Getters/////////////////////////////////////////


        public int GetDistTo(int Id) { return _distSums.GetInfo(Id); }

        public int GetCntOfNeighbors() { return _neighbors.Count; }

        public int Id => _id;
        public int GetWeightToNeighbor(int index) { return _weights.GetInfo(index); }

        public ICity GetNeighbor(int index) { return _neighbors[index]; }

        public Point GetPositoin() { return new Point(_x, _y); }

        public ICityStorage GetNeighbors() { return _neighbors; }


        ////////////////////////////////////////////////////Bool QA/////////////////////////////////////////

        public bool IsSelected() { return _selected; }

        public bool CheckIsItHere(ICityStorage cityStorage, ICity city)//fix
        {
            for (int i = 0; i < cityStorage.Count; i++)
            {
                if (cityStorage[i].Id== city.Id)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsChoosen(int x, int y)
        {
            if (x > _x - _rad && _x + _rad > x && y > _y - _rad && _y + _rad > y)
            {
                ResetSelect();
                return true;
            }
            return false;
        }
    }
}
