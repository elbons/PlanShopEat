using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

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
            //load dish data from folder
            string baseDataFilePath = @"D:\PlanShopEat\Data"; //TODO: this needs to be in a config file at least. maybe take in user input for loading from other locations if needed?
            DirectoryInfo d = new DirectoryInfo(baseDataFilePath);
            FileInfo[] files = d.GetFiles("*.xml");
            foreach(FileInfo file in files)
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(file.FullName);
                XmlNode recipeTitle = doc.DocumentElement.SelectSingleNode("/collection/recipe/title");
                listBoxFoodChoices.Items.Add(recipeTitle.InnerText);
            }            
        }

        private void Main_Resize(object sender, System.EventArgs e)
        {
            int totalHeight = this.Height;
            int totalWidth = this.Width;
            int border = 2;

            groupBoxDishes.Left = (totalWidth - border * 2) / 3 * 2;
        }

        private void buttonPrintMenu_Click(object sender, EventArgs e)
        {
            //TODO: dimensions are still a bit off, make a new "printable version" form that is bigger? decide on format of boxes            
            Bitmap printscreen = new Bitmap(this.groupBoxWeekMenu.Width, this.groupBoxWeekMenu.Height);
            Graphics graphics = Graphics.FromImage(printscreen as Image);
            graphics.CopyFromScreen(0, 0, 0, 0, printscreen.Size);
            Thread.Sleep(2000);
            //TODO: param file save location in the config
            printscreen.Save(@"C:\Temp\testingScreenshot.jpg", ImageFormat.Jpeg);
        }
    }
}
