using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schillinger_Quest4_ErrorInputDatabase
{
    public partial class BugForm : Form
    {
        public BugForm()
        {
            InitializeComponent();
        }

        public BugForm(string bugName)
        {
            InitializeComponent();
            //Opens with this file selected
        }
    }
}
