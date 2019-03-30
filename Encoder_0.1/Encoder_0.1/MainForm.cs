using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encoder_0._1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void encodeBtn_MouseMove(object sender, MouseEventArgs e)
        {
            encodeBtn.BackgroundImage = Properties.Resources.encode_enabled;
        }

        private void encodeBtn_MouseLeave(object sender, EventArgs e)
        {
            encodeBtn.BackgroundImage = Properties.Resources.encode;
        }

        private void decodeBtn_MouseMove(object sender, MouseEventArgs e)
        {
            decodeBtn.BackgroundImage = Properties.Resources.decode_enabled;
        }

        private void decodeBtn_MouseLeave(object sender, EventArgs e)
        {
            decodeBtn.BackgroundImage = Properties.Resources.decode;
        }

        private void encodeBtn_Click(object sender, EventArgs e)
        {
            if (messageTB.Text != "")
                messageTB.Text = Encoder.Encode(messageTB.Text);
        }

        private void decodeBtn_Click(object sender, EventArgs e)
        {
            if (messageTB.Text != "")                
                messageTB.Text = Encoder.Decode(messageTB.Text);
        }
    }
}
