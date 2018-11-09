using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanShopEat
{
   public partial class Main : Form
   {
      public Main()
      {
         InitializeComponent();
      }

        private void Main_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void Main_Resize(object sender, System.EventArgs e)
        {
            int totalHeight = this.Height;
            int totalWidth = this.Width;
            int border = 2;

            groupBoxDishes.Left = (totalWidth - border * 2) / 3 * 2;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
