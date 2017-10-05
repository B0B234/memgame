using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memgamev1
{
    public partial class asker : Form
    {
        public asker()
        {
            InitializeComponent();
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                this.Hide();
                game game = new game();
                game.ShowDialog();
                this.Close();
            }

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
