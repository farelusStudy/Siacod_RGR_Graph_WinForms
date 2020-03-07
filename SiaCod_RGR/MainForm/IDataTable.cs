using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SiaCod_RGR
{
    interface IDataTable
    {
        void SetData(int Id, int Data);
        void DeleteData(int Id);

        int GetInfo(int Id);

        bool IsThere(int Id);
    }
}
