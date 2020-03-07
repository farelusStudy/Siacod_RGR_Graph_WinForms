using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SiaCod_RGR
{
    class CityStorage : ICityStorage
    {
        int _count;
        ICity[] _cities;

        public CityStorage(int size = 0)
        {
            _cities = new ICity[size];

            _count = 0;
        }

        public void Add(ICity newCity)
        {
            ICity[] tmpArr = new ICity[_count];
            for (int i = 0; i < _count; i++)
            {
                tmpArr[i] = _cities[i];
            }
            _count++;
            _cities = new ICity[_count];
            for (int i = 0; i < _count - 1; i++)
            {
                _cities[i] = tmpArr[i];
            }
            _cities[_count - 1] = newCity;
        }

        public void Sort()
        {
            int i = 0;
            foreach (var city in _cities.OrderBy(c => c.Id))
            {
                _cities[i] = city;
                i++;
            }
        }

        public void Delete(int index)
        {
            if (index < _count) 
            {
                for (int i = index; i < _count - 1; i++)
                {
                    _cities[i] = _cities[i + 1];
                }
                _count--;
                _cities[_count] = null;
            }
        }

        public ICity this[int index]
        {
            get
            {
                if (index < _count)
                {
                    return _cities[index];
                }
                return null;
            }
        }

        public int Count => _count;

        public bool isEmpty()
        {
            return _count == 0;
        }
    }
}
