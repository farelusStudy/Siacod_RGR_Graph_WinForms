using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SiaCod_RGR
{
    public interface ICityStorage
    {
        void Add(ICity newCity);
        void Delete(int index);
        void Sort();

        ICity this[int index] { get; }
        int Count { get; }

        bool isEmpty();
    }
}
