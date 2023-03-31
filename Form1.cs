using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chipset_Wafer_Simulator
{
    public partial class Form1 : Form
    {
        bool toggle;
        public Form1()
        {
            InitializeComponent();
        }


        private void btn_com_add_Click(object sender, EventArgs e)
        {
            string company = cbox_company.Text;
            cbox_company.Items.Add(company);
            cbox_company.Text = "";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string company = cbox_company.Text;
            string pname = tbox_name.Text;
            WDirection wd = GetWDirection();
            double radius = (double)nud_radius.Value;
            bool ptype = rb_p.Checked;
            Wafer wafer = new Wafer(company, pname, wd, radius, ptype);
            // lbox_wafer.Items.Add(wafer);
            lbox_wafer.Items.Add(tbox_name.Text);
            tbox_name.Text = "";
            ResetControl();
        }

        private void ResetControl()
        {
            cbox_company.Text = "";
            tbox_name.Text = "";
            rb_100.Checked = true;
            nud_radius.Value = 0;
            rb_p.Checked = true;
        }

        private WDirection GetWDirection()
        {
            if (rb_100.Checked)
            {
                return WDirection.WD_100;
            }
            if (rb_110.Checked)
            {
                return WDirection.WD_110;
            }
            return WDirection.WD_111;
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            int index = lbox_wafer.SelectedIndex;
            lbox_wafer.Items.RemoveAt(index);
        }

        private void lbox_wafer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbox_wafer.SelectedIndex == -1)//선택 항목이 없다면
            {
                btn_remove.Enabled = false;
                ResetControl();
                return;
            }
            btn_remove.Enabled = true;
            Wafer wafer = lbox_wafer.SelectedItem as Wafer;
            SetControlWafer(wafer);
        }

        private void SetControlWafer(Wafer wafer)
        {
            cbox_company.Text = wafer.Company;
            tbox_name.Text = wafer.Name;
            SetWDir(wafer.WDir);
            nud_radius.Value = (decimal)wafer.Radius;
            SetType(wafer.PType);
        }

        private void SetType(bool pt)
        {
            if (pt)
            {
                rb_p.Checked = true;
            }
            else
            {
                rb_n.Checked = true;
            }
        }

        private void SetWDir(WDirection wd)
        {
            switch (wd)
            {
                case WDirection.WD_100: rb_100.Checked = true; break;
                case WDirection.WD_110: rb_110.Checked = true; break;
                case WDirection.WD_111: rb_111.Checked = true; break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChangeBackColor();
        }

        private void ChangeBackColor()
        {
            if (toggle)
            {
                BackColor = Color.Red;
            }
            else
            {
                BackColor = Color.Blue;
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                toggle ^= true;
                ChangeBackColor();
            }

        }
    }

}
