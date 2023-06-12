using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using POOProject;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UserInterface_WindowsForms
{
    public partial class Form2 : Form
    {

        IEnumerable<Laptop> searches = new List<Laptop>();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            flowLayoutPanel1.Margin = new Padding(0);       // Set the margin to 0
            flowLayoutPanel1.Padding = new Padding(0);      // Set the padding to 0
            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
            string host = "localhost";
            string dbase = "laptop";
            string uit = "root";
            string pwd = "0711";
            string query = "";

            string connectionString = $"Server={host};Database={dbase};Uid={uit};Pwd={pwd};";
            SQLConnector db = new SQLConnector();
            
            string brandCondition = "";
            string cpuCondition = "";
            string gpuCondition = "";

            if (Filtre.selectedBrands.Count > 0 && !string.IsNullOrEmpty(FormStart.connection))
            {
                brandCondition = string.Format(" and brand IN ('{0}')", string.Join("', '", Filtre.selectedBrands)); 
            }
            if (Filtre.selectedBrands.Count > 0 && string.IsNullOrEmpty(FormStart.connection))
            {
                brandCondition = string.Format(format: "brand IN ('{0}')", string.Join("', '", Filtre.selectedBrands));
            }

            if (Filtre.selectedCpus.Count > 0 && !string.IsNullOrEmpty(FormStart.connection))
            {
                cpuCondition = string.Format("\n and (cpu LIKE '%{0}%')", string.Join("%' or cpu LIKE '%", Filtre.selectedCpus), ")");
            }
            if (Filtre.selectedCpus.Count > 0 && string.IsNullOrEmpty(FormStart.connection))
            {
                cpuCondition = string.Format(format: "\n (cpu LIKE '%{0}%')", string.Join("%' or cpu LIKE '%", Filtre.selectedCpus), ")");
            }
            if(!string.IsNullOrEmpty(brandCondition))
            {
                cpuCondition = string.Format(format: "\n and (cpu LIKE '%{0}%')", string.Join("%' or cpu LIKE '%", Filtre.selectedCpus), ")");
            }

            if (Filtre.selectedGpus.Count > 0 && !string.IsNullOrEmpty(FormStart.connection))
            {
                gpuCondition = string.Format("\n and (gpu LIKE '%{0}%')", string.Join("%' or gpu LIKE '%", Filtre.selectedGpus), ")");
            }
            if (Filtre.selectedGpus.Count > 0 && string.IsNullOrEmpty(FormStart.connection))
            {
                gpuCondition = string.Format(format: "\n (gpu LIKE '%{0}%')", string.Join("%' or gpu LIKE '%", Filtre.selectedGpus), ")");
            }
            if (!string.IsNullOrEmpty(cpuCondition))
            {
                gpuCondition = string.Format(format: "\n and (gpu LIKE '%{0}%')", string.Join("%' or gpu LIKE '%", Filtre.selectedGpus), ")");
            }
            if (!string.IsNullOrEmpty(brandCondition))
            {
                gpuCondition = string.Format(format: "\n and (gpu LIKE '%{0}%')", string.Join("%' or gpu LIKE '%", Filtre.selectedGpus), ")");
            }


            string con = FormStart.connection + brandCondition + cpuCondition + gpuCondition;

            // Use the brandCondition string in your SQL query to filter the results
            //string sqlQuery = "SELECT * FROM YourTable " + (Filtre.selectedBrands.Count > 0 ? "WHERE " + brandCondition : "");
            List<Laptop> laptops = db.ExtractLaptop(connectionString, con);

            labelError.Visible = false;

            if (laptops.Count == 0 )
            {
                labelError.Visible = true;
            }

            foreach (Laptop l in laptops)
            {
                UserControl1 card = new UserControl1();
                card.LoadLaptopData(l);
                flowLayoutPanel1.Controls.Add(card);
            }
        }
    }
}
