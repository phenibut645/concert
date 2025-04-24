
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace concert.Pages.Images
{
    public partial class Images: UserControl
    {
        public Images()
        {
            List<string> images = GetImagePaths();
            int startX = 50;
            int startY = 50;
            int picturesInRow = 4;
            int spaceBetweenPicturesX = 100;
            int spaceBetweenPicturesY = 100;
            int currentX = startX;
            int currentY = startY;
            int currentPicturesCountInRow = 0;
            foreach (string imagePath in images)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Location = new Point(currentX, currentY);
                pictureBox.Image = Image.FromFile(imagePath);
                if (currentPicturesCountInRow == picturesInRow)
                {
                    currentPicturesCountInRow = 0;
                    currentY += spaceBetweenPicturesY + pictureBox.Height;
                    currentX = startX;
                }
                else
                {
                    currentPicturesCountInRow++;
                    currentX += spaceBetweenPicturesX + pictureBox.Width;         
                }
            }
        }

        private List<string> GetImagePaths()
        {
            return new List<string>();
        }
    }
}
