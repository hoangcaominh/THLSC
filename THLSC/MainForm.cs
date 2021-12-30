using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THLSC
{
    public partial class MainForm : Form
    {
        private readonly int _count = 0;

        public MainForm()
        {
            InitializeComponent();
            // TODO: dynamically create cells for 3rd condition data
        }

        private void Attach(object sender, EventArgs e)
        {
            if (true)
            {
                MessageBox.Show("No game was found. Please run a game and try again.", "Game not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Settings(object sender, EventArgs e)
        {

        }

        private void About(object sender, EventArgs e)
        {
            MessageBox.Show("Touhou Live Survival Counter by Cao Minh\n" + 
                "Version 0.1\n\n" + 
                "This is a tool used for counting things during a survival run.\n" + 
                "It supports Touhou 6, 7, 8, 9, 10, 11, 12, 12.8, 13, 14, 15, 16, 17 and 18.\n" +
                "This tool is written based on RealTimeDRCPointsDisplayer.\n" + 
                "", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
