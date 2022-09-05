using SuccessScreenBuilder;

namespace SuccessScreenBuilder.UI
{
    class CornerClass
    {
        public static void Corner(Control Item, uint x = 7, uint y = 7) => Item.Region = Region.FromHrgn(WinAPI.CreateRoundRectRgn(0, 0, Item.Width, Item.Height, x, y));
        public static void CornerAll(Control Item)
        {
            Corner(Item);
            foreach (Control Control in Item.Controls)
            {
                if (Control.HasChildren)
                {
                    foreach (Control Children in Control.Controls)
                    {
                        Corner(Children);
                    }
                }
                Corner(Control);
            }
        }
        public static void CornerAll(Control Item, uint XR, uint YR)
        {
            Corner(Item, XR, YR);
            foreach (Control Control in Item.Controls)
            {
                if (Control.HasChildren)
                {
                    foreach (Control Children in Control.Controls)
                    {
                        Corner(Children, XR, YR);
                    }
                }
                Corner(Control, XR, YR);
            }
        }
    }
}

