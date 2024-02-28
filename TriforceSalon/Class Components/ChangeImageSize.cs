using System.Drawing.Drawing2D;
using System.Drawing;

namespace TriforceSalon.Class_Components
{
    public class ChangeImageSize
    {
        public Image ResizeImages(Image image, int width, int height)
        {
            var destImage = new Bitmap(width, height);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.DrawImage(image, 0, 0, width, height);
            }
            return destImage;
        }
    }
}
