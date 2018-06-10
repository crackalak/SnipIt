using System;
using System.Linq;
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
                flow = new FlowLayoutPanel
                {
                    AutoSize = true,
                    Top = txtEntry.Top + txtEntry.Height,
                    Left = txtEntry.Left,
                    FlowDirection = FlowDirection.LeftToRight,
                    AutoSizeMode = AutoSizeMode.GrowAndShrink
                };

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
