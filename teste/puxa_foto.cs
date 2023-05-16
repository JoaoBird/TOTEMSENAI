using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace teste
{
    public class puxa_foto
    {
        public Image LoadImage(string filePath)
        {
            Image image = Image.FromFile(filePath);
            return image;
        }
    }
}