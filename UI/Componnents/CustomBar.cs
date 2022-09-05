using System;
using System.Drawing;
using System.Windows.Forms;

namespace SuccessScreenBuilder.UI
{
	class CustomBar : Panel
	{
		#region Properties
		private bool _canMinimize = true, _canClose = true;
		private Point _movingPoint;
		private uint _X, _Y;
		private Form _Caller;
		#endregion

		public CustomBar()
		{
			#region Setting Panel Properties
			BackColor = Color.Transparent;
			Dock = DockStyle.Top;
			HandleCreated += CustomBar_HandleCreated;
			#endregion

		}
		#region Events
		private void CustomBar_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				_movingPoint = Control.MousePosition;
				_movingPoint.X -= (int)_X;
				_movingPoint.Y -= (int)_Y;
				_Caller.Location = _movingPoint;
			}
		}
		private void CustomBar_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				_X = Convert.ToUInt32(Control.MousePosition.X - _Caller.Location.X);
				_Y = Convert.ToUInt32(Control.MousePosition.Y - _Caller.Location.Y);
			}
		}
		private void CustomBar_HandleCreated(object sender, EventArgs e)
		{
			Width = FindForm().Width;
			_Caller = FindForm();
			MouseDown += CustomBar_MouseDown;
			MouseMove += CustomBar_MouseMove;
			Resize += CustomBar_Resize;
			RefreshControls();
		}

		private void CustomBar_Resize(object sender, EventArgs e)
		{
			RefreshControls();
		}

		private void MinimizeButton_Click(object sender, EventArgs e)
		{
			_Caller.WindowState = FormWindowState.Minimized;
		}

		private void CloseButton_Click(object sender, EventArgs e)
		{
			_Caller.Close();
		}
		#endregion
		private void RefreshControls()
		{
			Controls.Clear();
			if (_canClose)
			{
				CustomButton closeButton = new CustomButton();
				closeButton.Text = "";
				closeButton.BackgroundImage = Properties.Resources.Fermer;
				closeButton.BackgroundImageLayout = ImageLayout.Zoom;
				closeButton.BackColor = Color.Transparent;
				closeButton.TabStop = false;
				closeButton.Size = new Size(24, 24);
				closeButton.Location = new Point(Width - 30, (Height / 2) - (closeButton.Height / 2));
				closeButton.Click += CloseButton_Click;
				Controls.Add(closeButton);
			}
			if (_canMinimize)
			{
				CustomButton minimizeButton = new CustomButton();
				minimizeButton.Text = "";
				minimizeButton.BackgroundImage = Properties.Resources.Reduire;
				minimizeButton.BackgroundImageLayout = ImageLayout.Zoom;
				minimizeButton.BackColor = Color.Transparent;
				minimizeButton.TabStop = false;
				minimizeButton.Size = new Size(20, 6);
				minimizeButton.Location = new Point(_canClose ? Width - 56 : Width - 30, Height - 10);
				minimizeButton.Click += MinimizeButton_Click;
				Controls.Add(minimizeButton);
			}
		}
		public bool HasMinimize
		{
			get => _canMinimize;
			set => _canMinimize = value;
		}
		public bool HasClose
		{
			get => _canClose;
			set => _canClose = value;
		}
	}
}
