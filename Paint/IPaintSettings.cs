
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Paint
{
    public interface IPaintSettings
    {

        int Width
        {
            get;
        }

        Color PrimaryColor
        {
            get;
        }

        Color SecondaryColor
        {
            get;
        }

        BrushType BrushType
        {
            get;
        }

        HatchStyle HatchStyle
        {
            get;
        }

        DashStyle LineStyle
        {
            get;
        }

        Image TextureBrushImage
        {
            get;
        }
    }
}