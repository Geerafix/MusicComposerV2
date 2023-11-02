using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicComposer
{
    public partial class TracksControl : UserControl
    {
        public TracksControl()
        {
            InitializeComponent();
        }
        private void menuButton_Click(object sender, EventArgs e)
        {
            MainFrame mainFrame = (this.ParentForm as MainFrame);
            mainFrame.toMenuFromTracks();
        }
    }
}
