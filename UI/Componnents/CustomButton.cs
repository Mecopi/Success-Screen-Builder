using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SuccessScreenBuilder.UI
{
	class CustomButton : Button
	{
		#region Properties
		private uint _xRadius = 5;
		private uint _yRadius = 5;
		private Alignement _Alignement = Alignement.None;
		#endregion
		#region Enums
		public enum Alignement
		{
			None = 0,
			Left = 1,
			Middle = 2,
			Right = 3
		}
		#endregion
		public CustomButton()
		{
			FlatStyle = FlatStyle.Flat;
			Size = new Size(60, 60);
			FlatAppearance.BorderSize = 0;
			Paint += CustomButton_Paint;
			Resize += CustomButton_Resize;
			LocationChanged += CustomButton_LocationChanged;
			if (Parent != null)
				BackColor = Color.FromArgb(255, Parent.BackColor);
		}
		#region Events
		private void CustomButton_LocationChanged(object sender, EventArgs e) => UpdateAlignement();
		private void CustomButton_Resize(object sender, EventArgs e)
		{
			CornerClass.Corner(this, _xRadius, _yRadius);
			UpdateAlignement();
		}
		private void CustomButton_Paint(object sender, PaintEventArgs e) => CornerClass.Corner(this, _xRadius, _yRadius);
		#endregion
		#region Properties
		public string Opacity
		{
			get => ((BackColor.A + 1) * 100) / 255 + "%";
			set
			{
				string realValue = "";
				value.ToList().FindAll(Char => "0123456789".Contains(Char)).ForEach(Char => realValue += Char);
				int percentCalcul = ((Int32.Parse(realValue) * 255) / 100);
				BackColor = Color.FromArgb(percentCalcul, Color.FromArgb(BackColor.R, BackColor.G, BackColor.B));
			}
		}
		public string Corner
		{
			get => _xRadius + ";" + _yRadius;
			set
			{
				_xRadius = uint.Parse(value.Split(';')[0]);
				_yRadius = uint.Parse(value.Split(';')[1]);
				CornerClass.Corner(this, _xRadius, _yRadius);
			}
		}
		public uint WidthCorner
		{
			get => _xRadius;
		}
		public uint HeightCorner
		{
			get => _yRadius;
		}
		public Alignement Align
		{
			get => _Alignement;
			set
			{
				_Alignement = value;
				UpdateAlignement();
			}
		}

		#endregion
		#region Functions
		private void UpdateAlignement()
		{
			if (Parent != null && _Alignement != Alignement.None)
			{
				switch (_Alignement)
				{
					case Alignement.Left:
						Location = new Point(6, Location.Y);
						break;
					case Alignement.Middle:
						Location = new Point((Parent.Width / 2) - (Width / 2), Location.Y);
						break;
					case Alignement.Right:
						Location = new Point((Parent.Width - 6) - Width, Location.Y);
						break;
				}
			}
		}
		#endregion
	}
}
