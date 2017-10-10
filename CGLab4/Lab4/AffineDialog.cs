using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGLab6
{
    public partial class AffineDialog : Form
    {
        AffineTransformation parent;
        public AffineDialog(AffineTransformation p)
        {
            InitializeComponent();
            parent = p;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            parent.ApplyTransformation();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
