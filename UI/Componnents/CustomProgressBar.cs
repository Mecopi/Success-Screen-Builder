using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuccessScreenBuilder.UI
{
	public class Bar : Panel
	{
		Color _BarColor { get; set; }

		int pbValue = 1;
		int Min = 0;
		int Max = 100;
		public Bar()
		{
			Size = new Size(200, 20);
			BackColor = Color.Transparent;
			DoubleBuffered = true;
			Paint += CustomProgressBar_Paint;
			BarColor = Color.Red;
		}

		public Color BarColor
		{
			get => _BarColor;
			set
			{
				_BarColor = value;
				Invalidate();
			}
		}
		public int Value
		{
			get => pbValue;
			set
			{
				if (value >= Min && value <= Max)
				{
					pbValue = value;
					Invalidate();
				}
			}
		}
		public int MinValue
		{
			get => Min;
			set
			{
				Min = value >= 0 ? value : 0;
				Invalidate();
			}
		}
		public int MaxValue
		{
			get => Max;
			set
			{
				Max = value > Min ? value : Min + 1;
				Invalidate();
			}
		}

		private void CustomProgressBar_Paint(object sender, PaintEventArgs e)
		{
			SolidBrush brush = new SolidBrush(BarColor);
			e.Graphics.FillRectangle(brush, new RectangleF(0, 0, ((float)Size.Width / MaxValue) * pbValue, Height));
		}
	}
}
