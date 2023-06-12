using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using POOProject;
namespace UserInterface_WindowsForms
{
    public partial class UserControl1 : UserControl
    {
        private Color originalBackColor;
        public static List<Laptop> favoriteList = new List<Laptop>();
        Laptop Laptop { get; set; }
        public UserControl1()
        {
            BackColor = Color.White;
            Size = new Size(200, 200);
            originalBackColor = this.BackColor;
            this.MouseEnter += CardPhone_MouseEnter;
            this.MouseLeave += CardPhone_MouseLeave;
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
           
           
        }


        public void LoadLaptopData(Laptop laptop)
        {
            Laptop = laptop;
            // Method implementation
            lblModel.Text = laptop.Brand + " " + laptop.Model + " cu procesor \n" + laptop.Cpu + ", " + laptop.ScreenSize + "\", " + laptop.Ram + " Gb, " + laptop.Gpu;
            labelPrice.Text = laptop.Price.ToString() + " lei";
            pictureBox1.Image = ResizeImage(laptop.Image);
        }

            public Image ResizeImage(byte[] origImage)
        {
            
                using (MemoryStream ms = new MemoryStream(origImage))
                {
                    Image originalImage = Image.FromStream(ms);

                    Bitmap resizedImage = new Bitmap(221, 221);

                    using (Graphics g = Graphics.FromImage(resizedImage))
                    {
                        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                        g.DrawImage(originalImage, 0, 0, 221, 221);
                    }
                    return resizedImage;
                
             
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            // Get the clicked PictureBox
            PictureBox pictureBox = (PictureBox)sender;

            // Retrieve the laptop information from the PictureBox's Tag property
            Laptop laptop = (Laptop)pictureBox.Tag;

            // Add the laptop to the list
            favoriteList.Add(laptop);

            // Perform any other operations with the laptop information
        }

        private void CardPhone_MouseEnter(object sender, EventArgs e)
        {

            this.BackColor = Color.LightCyan;
        }

        private void CardPhone_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = originalBackColor;
        }
    }
}
