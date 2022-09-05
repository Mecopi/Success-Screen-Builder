using SuccessScreenBuilder.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuccessScreenBuilder
{
    public class SuccessScreen
    {
        public int Category { get; private set; }
        public Image? Image { get; private set; }

        public Panel _Panel;
        public PictureBox _PictureBox;
        public PictureBox _CheckBox;

        public SuccessScreen(int category, Image image)
        {
            Category = category;
            Image = image;
            InitDisplay();
        }
        //687

        private void InitDisplay()
        {
            _Panel = new Panel();
            _Panel.BackColor = Color.FromArgb(19, 19, 19);
            _Panel.Size = new Size(687, 94);
            
            _PictureBox = new PictureBox();
            _PictureBox.Image = Image;
            _PictureBox.Location = new Point(0, 0);
            _PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            _PictureBox.Size = new Size(651, 94);

            _CheckBox = new PictureBox();
            _CheckBox.Size = new Size(18, 18);
            _CheckBox.Image = new Bitmap(18, 18);
            _CheckBox.Location = new Point(662, (94 / 2 ) - (18 / 2));
            CornerClass.Corner(_CheckBox, 10, 10);

            _Panel.Controls.Add(_PictureBox);
            _Panel.Controls.Add(_CheckBox);
        }
        
    }
}
