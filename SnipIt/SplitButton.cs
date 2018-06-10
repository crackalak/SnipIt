using System;
using System.Drawing;
using System.Windows.Forms;

namespace SnipIt
{
    class SplitButton : Button
    {
        const int SplitSectionWidth = 18;
        static int BorderSize = SystemInformation.Border3DSize.Width * 2;

        Rectangle dropDownRectangle;
        bool openMenu = false;
        readonly int dpiScale = 1;

        public SplitButton()
        {
            Graphics gfx = this.CreateGraphics();

            dpiScale = (int)(gfx.DpiX / 96);
        }

        void ContextMenuStrip_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            if (e.CloseReason == ToolStripDropDownCloseReason.ItemClicked || !dropDownRectangle.Contains(PointToClient(Cursor.Position)))
            {
                // menu item has been clicked
                // or something else has gained focus that isn't the splitbutton
                openMenu = false;
            }
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            Graphics g = pevent.Graphics;

            Rectangle bounds = this.ClientRectangle;

            int sectionWidth = SplitSectionWidth * dpiScale;
            
            dropDownRectangle = new Rectangle(bounds.Right - sectionWidth, 0, sectionWidth, bounds.Height);

            // draw two lines at the edge of the dropdown button
            g.DrawLine(SystemPens.ButtonShadow, bounds.Right - sectionWidth, BorderSize, bounds.Right - sectionWidth, bounds.Bottom - BorderSize);
            g.DrawLine(SystemPens.ButtonFace, bounds.Right - sectionWidth - 1, BorderSize, bounds.Right - sectionWidth - 1, bounds.Bottom - BorderSize);

            PaintArrow(g, dropDownRectangle);
        }

        private void PaintArrow(Graphics g, Rectangle dropDownRect)
        {
            Point middle = new Point(Convert.ToInt32(dropDownRect.Left + dropDownRect.Width / 2), Convert.ToInt32(dropDownRect.Top + dropDownRect.Height / 2));

            //if the width is odd - favor pushing it over one pixel right.
            middle.X += (dropDownRect.Width % 2);

            Point[] arrow = new[] 
            {
                new Point(middle.X - 4 * dpiScale, middle.Y - 1 * dpiScale),
                new Point(middle.X + 4 * dpiScale, middle.Y - 1 * dpiScale),
                new Point(middle.X, middle.Y + 3 * dpiScale)
            };

            g.FillPolygon(SystemBrushes.ControlText, arrow);
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            if (dropDownRectangle.Contains(mevent.Location))
            {
                openMenu = !openMenu;
                ShowContextMenu();
            }
            else
            {
                base.OnMouseDown(mevent);
            }
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            if (mevent.Button == MouseButtons.Right && ClientRectangle.Contains(mevent.Location)) {
                openMenu = true;
                ShowContextMenu();
            }
            else if (ClientRectangle.Contains(mevent.Location) && !dropDownRectangle.Contains(mevent.Location))
            {
                base.OnMouseUp(mevent);
            }
        }

        private void ShowContextMenu()
        {
            if (openMenu)
            {
                this.ContextMenuStrip.Show(this, new Point(1, Height), ToolStripDropDownDirection.BelowRight);
            }
            else
            {
                this.ContextMenuStrip.Close();
            }
        }

        public override ContextMenuStrip ContextMenuStrip
        {
            get
            {
                return base.ContextMenuStrip;
            }
            set
            {
                if (base.ContextMenuStrip != null)
                {
                    // remove old event handlers
                    base.ContextMenuStrip.Closed -= ContextMenuStrip_Closed;
                }

                base.ContextMenuStrip = value;

                if (base.ContextMenuStrip != null)
                {
                    // hook up new event hanlders
                    base.ContextMenuStrip.Closed += ContextMenuStrip_Closed;
                }
            }
        }
    }
}
