﻿using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoCHDM
{
    public partial class frmXuatHoaDon : Form
    {
        public frmXuatHoaDon()
        {
            InitializeComponent();
        }

        private void frmXuatHoaDon_Load(object sender, EventArgs e)
        {
            btTK.Text = Const.TK.Hienthiten;

            this.reportViewer1.RefreshReport();
            ReportDataSource rds = new ReportDataSource("DataSet1", frmHoaDon.listhd);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }

        private void btDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDangNhap dn = new frmDangNhap();
            dn.Show();
        }

        private void showMenuTopUp()
        {
            if (panMenuTopUp.Visible == false)
            {
                panMenuTopUp.Visible = true;
            }
            else
            {
                panMenuTopUp.Visible = false;
            }
        }

        private void picDotList_Click(object sender, EventArgs e)
        {
            showMenuTopUp();
        }

        private void btHelp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
