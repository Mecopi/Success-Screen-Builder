using SuccessScreenBuilder.UI;
using SuccessScreenBuilder.Managers;
using System.Media;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace SuccessScreenBuilder
{
    public partial class Form1 : Form
    {
        private static Form1? _Instance;
        private Thread _gettingThread;

        public Color backColorScreen = ColorTranslator.FromHtml("#3e3f40");
        private List<SuccessScreen> showedListScreen = new List<SuccessScreen>();
        private List<SuccessScreen> selectedScreens = new List<SuccessScreen>();


        public Form1()
        {
            InitializeComponent();
            CornerClass.Corner(this, 10, 10);
            CornerClass.Corner(gettingFilesStatusBar, 10, 10);
            new FileManager();
            _Instance = this;
            Application.ApplicationExit += Application_ApplicationExit;
        }

        private void Application_ApplicationExit(object? sender, EventArgs e)
        {
            if(_gettingThread != null && _gettingThread.IsAlive)
                _gettingThread.Abort();
        }

        public static Form1? Instance => _Instance;

        private void Form1_Load(object sender, EventArgs e)
        {
            _gettingThread = new Thread(new ThreadStart(delegate {
                try
                {
                    FileManager.Instance?.Init();
                    Instance!.Invoke(delegate
                    {
                        hookingFilesPanel.Visible = false;
                        selectDjsPanel.Visible = true;
                        groupBox1.Visible = true;
                    });
                }
                catch { }
            }));
            _gettingThread.Start();
        }
        private void ShowingCode(int category)
        {
            foreach (SuccessScreen successScreen in showedListScreen)
            {
                successScreen._PictureBox.Click -= _PictureBox_Click;
            }
            showedListScreen.Clear();
            DJSuccessPanelShow.Controls.Clear();
            foreach (SuccessScreen successScreen in FileManager.Instance!.Success)
            {
                if (successScreen.Category == category)
                    showedListScreen.Add(successScreen);
            }
            for (int i = 0; i < showedListScreen.Count; i++)
            {
                if (i > 0)
                    showedListScreen[i]._Panel.Location = new Point(0, 94 * i + (i * 1));
                else
                    showedListScreen[i]._Panel.Location = new Point(0, 94 * i);
                DJSuccessPanelShow.Controls.Add(showedListScreen[i]._Panel);
                showedListScreen[i]._PictureBox.Click += _PictureBox_Click;
            }
        }

        private void _PictureBox_Click(object? sender, EventArgs e)
        {
            foreach(SuccessScreen successScreen in showedListScreen)
            {
                if(successScreen._PictureBox == sender)
                {
                    if(selectedScreens.Contains(successScreen))
                    {
                        selectedScreens.Remove(successScreen);
                        Graphics graphic = Graphics.FromImage(successScreen._CheckBox.Image);
                        graphic.FillRectangle(new SolidBrush(Color.FromArgb(19, 19, 19)), new Rectangle(0, 0, 18, 18));
                        successScreen._CheckBox.Invalidate();
                    }
                    else
                    {
                        selectedScreens.Add(successScreen);
                        Graphics graphic = Graphics.FromImage(successScreen._CheckBox.Image);
                        graphic.FillRectangle(new SolidBrush(Color.FromArgb(68, 165, 114)), new Rectangle(0, 0, 18, 18));
                        successScreen._CheckBox.Invalidate();
                    }
                    break;
                }
            }
        }

        private void select0Button_Click(object sender, EventArgs e)
        {
            ShowingCode(0);
        }
        private void select1Button_Click(object sender, EventArgs e)
        {
            ShowingCode(1);
        }

        private void select2Button_Click(object sender, EventArgs e)
        {
            ShowingCode(2);
        }

        private void select3Button_Click(object sender, EventArgs e)
        {
            ShowingCode(3);
        }

        private void select4Button_Click(object sender, EventArgs e)
        {
            ShowingCode(4);
        }

        private void previsualisationButton_Click(object sender, EventArgs e)
        {
            

        }

        private void exportationButton_Click(object sender, EventArgs e)
        {
            try
            {
                backColorScreen = ColorTranslator.FromHtml(backScreenColor.Text);
            }
            catch 
            {
                backColorScreen = ColorTranslator.FromHtml("#3e3f40");
            }

            int RowsCount = (int)Math.Round(selectedScreens.Count / numericUpDown1.Value) == 0 ? 1 : (int)Math.Round(selectedScreens.Count / numericUpDown1.Value) +1;
            Bitmap finalScreen = new Bitmap(370 * RowsCount, 50 * (int)numericUpDown1.Value);
            Graphics graphic = Graphics.FromImage(finalScreen);
            graphic.FillRectangle(new SolidBrush(backColorScreen), new Rectangle(0, 0, finalScreen.Width, finalScreen.Height));
            Point newDrawPoint = new Point(0, 0);
            int totalTreated = 0;
            for (int i = 0; i < 5; i++)
            {
                List<SuccessScreen> toTreat = GetScreensByCategory(i);
                for (int j = 0; j < toTreat.Count; j++)
                {
                    if (totalTreated % (int)numericUpDown1.Value == 0 && totalTreated > 0)
                    {
                        newDrawPoint.X += 370;
                        newDrawPoint.Y = 0;
                    }
                    graphic.DrawImage(ResizeImage(toTreat[j].Image, 370, 50), newDrawPoint);
                    newDrawPoint.Y += 50;
                    totalTreated++;
                }
            }
            finalScreen.Save(FileManager.ExecutionFolder + "\\final.png");
        }

        public List<SuccessScreen> GetScreensByCategory(int category)
        {
            List<SuccessScreen> toReturn = new List<SuccessScreen>();
            foreach(SuccessScreen successScreen in selectedScreens)
            {
                if(successScreen.Category == category)
                    toReturn.Add(successScreen); 
            }
            return toReturn;
        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
    }
}