﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnipIt
{
    public partial class CaptureForm : Form
    {
        private Panel selPanel = new Panel();

        // start position of cursor
        private Point startPos;

        public CaptureForm()
        {
            InitializeComponent();
        }

        private void CaptureForm_Load(object sender, EventArgs e)
        {
            int totWidth = 0, totHeight = 0;
            int leftX = 0;
            
            this.Hide();

            // get the total width of all screens
            // and the biggest height of any screen
            // and the leftmost x position
            foreach (Screen item in Screen.AllScreens)
            {
                totWidth += item.Bounds.Width;

                if (item.Bounds.Height > totHeight)
                {
                    totHeight = item.Bounds.Height;
                }

                if (item.Bounds.X < leftX)
                {
                    leftX = item.Bounds.X;
                }
            }

            // use the X position of the first screen
            this.SetBounds(leftX, 0, totWidth, totHeight);

            this.Show();
            this.TopMost = true;
            this.ContextMenu = new ContextMenu();
            this.ContextMenu.MenuItems.Add("Close").Click += Close_Click;
            this.selPanel.BackColor = Color.White;

            Cursor = Cursors.Cross;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            this.Close();
            Program.ControllerForm.Show();
        }

        private void CaptureForm_MouseDown(object sender, MouseEventArgs e)
        {
            // show the selection panel if not already shown
            if (this.Controls.Contains(this.selPanel))
            {
                this.Controls.Remove(this.selPanel);
            }

            // reset the selection panel size and position
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.selPanel.Size = new Size(0, 0);
                this.selPanel.Location = e.Location;

                startPos = e.Location;

                this.Controls.Add(selPanel);
            }
        }

        private void CaptureForm_MouseMove(object sender, MouseEventArgs e)
        {
            // selection is being made, resize and reposition the panel
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (e.X > startPos.Y)
                {
                    if (e.Y > startPos.Y)
                    {
                        // right and down
                        this.selPanel.Width = e.X - this.selPanel.Location.X;
                        this.selPanel.Height = e.Y - this.selPanel.Location.Y;
                    }
                    else
                    {
                        // right and up
                        this.selPanel.Location = new Point(startPos.X, e.Y);
                        this.selPanel.Width = e.X - startPos.X;
                        this.selPanel.Height = startPos.Y - e.Y;
                    }
                }
                else
                {
                    if (e.Y > startPos.Y)
                    {
                        // left and down
                        this.selPanel.Location = new Point(e.X, startPos.Y);
                        this.selPanel.Width = startPos.X - e.X;
                        this.selPanel.Height = e.Y - startPos.Y;
                    }
                    else
                    {
                        // left and up
                        this.selPanel.Location = e.Location;
                        this.selPanel.Width = startPos.X - e.X;
                        this.selPanel.Height = startPos.Y - e.Y;
                    }
                }
            }
        }

        private void CaptureForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (this.Controls.Contains(this.selPanel))
                {
                    if (this.selPanel.Size.Width > 0 && this.selPanel.Size.Height > 0)
                    {
                        using (Bitmap bmp = new Bitmap(this.selPanel.Size.Width, this.selPanel.Size.Height))
                        using (Graphics gfx = Graphics.FromImage(bmp))
                        {
                            Point panelPosition = new Point(this.selPanel.Location.X + this.Bounds.X, this.selPanel.Location.Y + this.Bounds.Y);

                            // make sure this form isn't copied
                            this.Opacity = 0;

                            // copy the selection area from the screen
                            gfx.CopyFromScreen(panelPosition, new Point(0, 0), this.selPanel.Size, CopyPixelOperation.SourceCopy);

                            MainForm snipForm;

                            if (Program.MultiSnip)
                                snipForm = new MainForm();
                            else
                                snipForm = Program.ControllerForm;
                            
                            // load captured image
                            snipForm.PictureBox1.Image = Image.FromHbitmap(bmp.GetHbitmap());
                            snipForm.PictureBox1.Visible = true;

                            // hold original image
                            snipForm.originalImage = Image.FromHbitmap(bmp.GetHbitmap());

                            //// picturebox has automatically resized
                            //// resize the form
                            //snipForm.Height = snipForm.Height + snipForm.PictureBox1.Height + 5;
                            //snipForm.Width = snipForm.PictureBox1.Width + 12;

                            //// change panel container dimensions for border
                            //snipForm.Panel1.Height = snipForm.Height - 32;
                            //snipForm.Panel1.Width = snipForm.Width - 6;

                            // show new form to top left of current snip position
                            snipForm.StartPosition = FormStartPosition.Manual;
                            snipForm.Location = panelPosition;
                            
                            Cursor = Cursors.Default;

                            this.Close();

                            if (Program.MultiSnip)
                            {
                                Program.ControllerForm.Text = "SnipIt - Main";

                                // show each snip and set non main settings
                                foreach (Form showForm in Application.OpenForms)
                                {
                                    showForm.Show();
                                }
                                snipForm.ShowInTaskbar = false;
                                snipForm.cmdnew.Enabled = false;
                            }

                            snipForm.Show();
                        }
                    }
                }
            }
        }
    }
}