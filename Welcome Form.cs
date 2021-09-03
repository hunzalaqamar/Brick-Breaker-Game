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
    public partial class welcomeForm : Form
    {
        SoundPlayer ToStop = new SoundPlayer();
        public welcomeForm()
        {
            InitializeComponent();
            string _filePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + @"\welcomesound.wav";
            SoundPlayer AS = new SoundPlayer(_filePath);
            ToStop = AS;
            AS.PlayLooping();
        }

        private void btn_Easy_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EasyForm().Show();
            ToStop.Stop();
        }

        private void btn_Medium_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MediumForm().Show();
            ToStop.Stop();
        }

        private void btn_Hard_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HardForm().Show();
            ToStop.Stop();
        }

        private void btn_Legendary_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LegendaryForm().Show();
            ToStop.Stop();
        }
    }
}
