using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheFlagGame
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }
        private string playerName;

        public GameForm(string name)
        {
            InitializeComponent();
            playerName = name;
        }


        private void GameForm_Load(object sender, EventArgs e)
        {

        }
    }
}
