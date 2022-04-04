using PlayWithFire.Interfaces;
using PlayWithFire.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayWithFire
{
    public partial class GamePanel : Form
    {
        private IMapService mapService;
        public GamePanel()
        {
            InitializeComponent();

            this.Size = new Size(1000, 1000);
            this.StartPosition = FormStartPosition.CenterScreen;

            this.pbCanvas.Location = new Point(0, 0);
            this.pbCanvas.Size = this.ClientSize;

            mapService = new BasicMapService();
            mapService = new AdvanceMapService();
        }
    }
}
