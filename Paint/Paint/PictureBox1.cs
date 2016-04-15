using System;
using System.Drawing;

namespace Paint
{
    public class PictureBox1
    {
        public bool Height { get; internal set; }
        public Bitmap Image { get; internal set; }
        public string Width { get; internal set; }
        
        internal void Refresh()
        {
            throw new NotImplementedException();
        }
    }
}