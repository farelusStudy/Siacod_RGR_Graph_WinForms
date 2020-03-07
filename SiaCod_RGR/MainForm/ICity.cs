using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace SiaCod_RGR
{
    public interface ICity : IGraphicElement
    {
        void CalcShortestDistSum();
        void SetRoadTo(ICity newneighbor, int weight);
        void Delete(ICityStorage storage);
        void DeleteNeighbor(int index);

        int GetCntOfNeighbors();
        int Id { get; }

        int GetWeightToNeighbor(int index);
        int GetDistTo(int Id);
        ICity GetNeighbor(int index);
        ICityStorage GetNeighbors();
    }
}
