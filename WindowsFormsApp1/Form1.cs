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
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnupload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtfileupload.Text = openFileDialog.FileName;
            }
        }

        private void btnsheet_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtsheet.Text))
                {
                    string constr = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='{txtfileupload.Text}'; Extended Properties = Excel 12.0; ";
                    OleDbConnection con = new OleDbConnection(constr);
                    OleDbDataAdapter da = new OleDbDataAdapter($"select * from [{txtsheet.Text}$]", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Please enter sheet name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtbarcode_TextChanged(object sender, EventArgs e)
        {
            string code = txtbarcode.Text;
            if (code == "") lblcode.Text = "";
            if (!string.IsNullOrEmpty(code))
            {
                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {
                    if (dr.Cells[0].Value.ToString().Equals(code))
                    {
                        lblcode.Text = $"Value = {dr.Cells[1].Value.ToString()}";
                        break;
                    }
                }
            }
        }
    }
}
