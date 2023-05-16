using System.Drawing;

namespace teste
{
    internal class MediaItem
    {
        private Image image;
        private string v;

        public MediaItem(Image image, string v)
        {
            this.image = image;
            this.v = v;
        }
    }
}