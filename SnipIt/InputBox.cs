using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SnipIt
{
    public partial class InputBox : Form
    {
        public InputBox()
        {
            InitializeComponent();
        }

        public string Title { get; set; }
        public string Prompt { get; set; }
        public string Entry { get; set; }
        public bool SelectOption { get; set; }
        public string[] Options { get; set; }
        public string OptionSelected { get; private set; }

        private FlowLayoutPanel flow;

        private void InputBox_Load(object sender, EventArgs e)
        {
            if (this.SelectOption && this.Options.Length != 0)
            {
                flow = new FlowLayoutPanel();
                flow.AutoSize = true;
                flow.Top = txtEntry.Top + txtEntry.Height;
                flow.Left = txtEntry.Left;
                flow.FlowDirection = FlowDirection.LeftToRight;
                flow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;

                foreach (string option in this.Options)
                {
                    RadioButton radio = new RadioButton();
                    radio.AutoSize = true;
                    radio.AutoCheck = true;
                    radio.Text = option;
                    
                    flow.Controls.Add(radio);
                }

                ((RadioButton)flow.Controls[0]).Checked = true;

                this.Controls.Add(flow);
            }

            this.Text = Title;
            lblTitle.Text = Prompt;
            txtEntry.Text = Entry;
            txtEntry.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtEntry.Text))
            {
                MessageBox.Show("Please enter a value!", "Blank Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DialogResult = DialogResult.None;
            }
            else
            {
                this.Entry = txtEntry.Text;
                if (this.SelectOption && this.Options.Length != 0)
                {
                    // get the text of the selected radio button
                    this.OptionSelected = flow.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
                }
            }
            
        }
        
    }
}
