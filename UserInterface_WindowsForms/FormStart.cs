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
    public partial class FormStart : Form
    {
        bool sidebarExpand;
        public static string connection = "";
        private const int AnimationStep = 10;
        private const int AnimationSpeed = 10;

        private Button currentButton;
        private Form activeForm;

        public FormStart()
        {
            InitializeComponent();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            {
                if (sidebarExpand)
                {
                    // Minimize the panel
                    sidebar.Width -= AnimationStep;
                    if (sidebar.Width <= sidebar.MinimumSize.Width)
                    {
                        sidebar.Width = sidebar.MinimumSize.Width;
                        sidebarTimer.Stop();
                        sidebarExpand = false;
                    }
                }
                else
                {
                    // Expand the panel
                    sidebar.Width += AnimationStep;
                    if (sidebar.Width >= sidebar.MaximumSize.Width) // Set MaximumWidth to the desired expanded width
                    {
                        sidebar.Width = sidebar.MaximumSize.Width;
                        sidebarTimer.Stop();
                        sidebarExpand = true;
                    }
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void FormStart_Load(object sender, EventArgs e)
        {
            sidebar.Width = sidebar.MinimumSize.Width;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form1(), sender);
            buttonStart.Visible = false;
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            buttonStart.Visible = true;
            Filtre.filters.Clear();
            Filtre.selectedBrands.Clear();
            Filtre.selectedCpus.Clear();
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            buttonStart.Visible = false;
            if (activeForm != null)
            {
                activeForm.Close();
            }
            OpenChildForm(new FormInfo(), sender);
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            connection = "";
            foreach (string str in Filtre.filters)
            {
                if (str != Filtre.filters.Last())
                {
                    connection += str + " and ";
                }
                else
                {
                    connection += str;
                }
            }
            buttonStart.Visible = false;
            OpenChildForm(new Form2(), sender);
        }

        private void buttonFavorite_Click(object sender, EventArgs e)
        {
            buttonStart.Visible = false;
            if (activeForm != null)
            {
                activeForm.Close();
            }
            OpenChildForm(new FormFavorite(), sender);
        }
    }
}
