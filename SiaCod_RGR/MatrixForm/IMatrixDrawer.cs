using System.Drawing;

namespace SiaCod_RGR
{
    public interface IMatrixDrawer
    {
        void Draw(Graphics g);
        void SetWidth(int value);
    }
}