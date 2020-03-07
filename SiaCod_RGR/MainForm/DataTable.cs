using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SiaCod_RGR
{
    class DataTable: IDataTable
    {
        int[,] _table;
        int _size;
        int _count;

        public DataTable(int size = 0)
        {
            if (size != 0)
            {
                _size = size;
            }
            else
            {
                _size = 10;
            }
            _count = 0;
            
            _table = new int[_size, 2];
        }

        public void SetData(int Id, int Data)
        {
            if (IsThere(Id))
            {
                _table[GetIndexPlusOne(Id) - 1, 1] = Data;
                return;
            }
            if (_count == _size)
            {
                int[,] tmpArr = new int[_size, 2];
                for (int i = 0; i < _count; i++)
                {
                    tmpArr[i, 0] = _table[i, 0];
                    tmpArr[i, 1] = _table[i, 1];
                }

                _size++;
                _table = new int[_size, 2];

                for (int i = 0; i < _count; i++)
                {
                    _table[i, 0] = tmpArr[i, 0];
                    _table[i, 1] = tmpArr[i, 1];
                }
            }

            _table[_count, 0] = Id;
            _table[_count, 1] = Data;

            _count++;
        }
        public void DeleteData(int Id)
        {
            int index = GetIndexPlusOne(Id);
            if (index < _count && index != 0)
            {
                _count--;
                for (int i = index; i < _count; i++)
                {
                    _table[i, 0] = _table[i + 1, 0];
                    _table[i, 1] = _table[i + 1, 1];
                }
                _table[_count, 0] = 0;
                _table[_count, 1] = 0;
            }
        }

        public int GetInfo(int Id)
        {
            int index = GetIndexPlusOne(Id);
            if (index != 0)
            {
                return _table[ index - 1, 1];
            }
            else
            {
                return 5000;
            }
        }

        private int GetIndexPlusOne(int Id)
        {
            int index = 0;
            for (int i = 0; i < _count; i++)
            {
                if (Id == _table[i, 0])
                {
                    index = i + 1;
                }
            }
            return index;
        }

        public bool IsThere(int Id)
        {
            if (GetIndexPlusOne(Id) == 0)
                return false;
            else return true;
        }

    }
}
