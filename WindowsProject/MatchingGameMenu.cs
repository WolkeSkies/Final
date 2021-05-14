using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormProject
{
    public partial class MatchingGameMenu : Form
    {
        public MatchingGameMenu()
        {
            InitializeComponent();
        }

        private void SinglePlayerButton_Click(object sender, EventArgs e)
        {

        }

        private void MultiplayerButton_Click(object sender, EventArgs e)
        {
            var frm = new Multiplayer();
            frm.Show();
            this.Hide();
        }
    }
}
