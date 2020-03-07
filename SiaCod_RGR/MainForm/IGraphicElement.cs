using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SiaCod_RGR
{
    public interface IGraphicElement
    {
        void ResetSelect();
        void Draw(Graphics g);
        Point GetPositoin();
        bool IsSelected();
        bool CheckIsItHere(ICityStorage cityStorage, ICity city);
        bool IsChoosen(int x, int y);
    }
}
