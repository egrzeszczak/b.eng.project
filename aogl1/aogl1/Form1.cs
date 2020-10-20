using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aogl1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Schowaj sideMenu + Schowaj wszystie podopcje w sideMenu
            sidePanelCollapse();
            sidePanelHideAll();
        }

        #region SideMenu

        private void sidePanelHideAll()
        {
            panelFile.Visible = false;
            panelSettings.Visible = false;
            panelLaser.Visible = false;
        }

        private void sidePanelCollapse()
        {
            panelSideMenu.Width = 64;
            menuFile.Text = "";
            menuSettings.Text = "";
            menuLaser.Text = "";
            menuLeave.Text = "";
        }

        private void sidePanelExtend()
        {
            panelSideMenu.Width = 300;
            menuFile.Text = "Plik";
            menuSettings.Text = "Opcje";
            menuLaser.Text = "Laser";
            menuLeave.Text = "Wyjdź";
        }

        private void sidePanelHideSubMenu()
        {
            if (panelFile.Visible)
            {
                panelFile.Visible = false;
            }
            if (panelSettings.Visible)
            {
                panelSettings.Visible = false;
            }
            if (panelLaser.Visible)
            {
                panelLaser.Visible = false;
            }
        }

        private void sidePanelShowSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                sidePanelHideAll();
                sidePanelExtend();
                subMenu.Visible = true;
            } else
            {
                sidePanelCollapse();
                subMenu.Visible = false;
            }
        }

        #endregion

        private void menuFile_Click(object sender, EventArgs e)
        {
            sidePanelShowSubMenu(panelFile);
        }

        private void menuSettings_Click(object sender, EventArgs e)
        {
            sidePanelShowSubMenu(panelSettings);
        }

        private void menuLaser_Click(object sender, EventArgs e)
        {
            sidePanelShowSubMenu(panelLaser);
        }

        private void menuLeave_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //
    }
}
