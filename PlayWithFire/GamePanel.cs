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
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }
    }
    public partial class GamePanel : Form
    {
        // columns - id, name, surname, email
        public GamePanel()
        {
            InitializeComponent();

            this.Size = new Size(1000, 1000);
            this.StartPosition = FormStartPosition.CenterScreen;

            this.pbCanvas.Location = new Point(0, 0);
            this.pbCanvas.Size = this.ClientSize;


        }
    }
}
