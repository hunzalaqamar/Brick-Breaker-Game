using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace Assignment_5
{
    public partial class LosingForm : Form
    {
        public LosingForm()
        {
            InitializeComponent();
            string _filePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + @"\losegamesound.wav";
            SoundPlayer AS = new SoundPlayer(_filePath);
            AS.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
