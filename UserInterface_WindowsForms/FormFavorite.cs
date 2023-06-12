using POOProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface_WindowsForms
{
    public partial class FormFavorite : Form
    {
        public FormFavorite()
        {
            InitializeComponent();
        }

        private void FormFavorite_Load(object sender, EventArgs e)
        {
            //flowLayoutPanel1.Margin = new Padding(0);       // Set the margin to 0
            //flowLayoutPanel1.Padding = new Padding(0);      // Set the padding to 0
            //flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
            //string host = "localhost";
            //string dbase = "laptop";
            //string uit = "root";
            //string pwd = "0711";
            //string query = "";

            //string connectionString = $"Server={host};Database={dbase};Uid={uit};Pwd={pwd};";
            //SQLConnector db = new SQLConnector();
            //List<Laptop> laptops = db.ExtractLaptop(connectionString, FormStart.connection);
            
            labelError.Visible = false;

            if (UserControl1.favoriteList.Count == 0)
            {
                labelError.Visible = true;
            }

            foreach (Laptop l in UserControl1.favoriteList)
            {
                UserControl1 card = new UserControl1();
                card.LoadLaptopData(l);
                flowLayoutPanel1.Controls.Add(card);
            }
        }
    }
}
