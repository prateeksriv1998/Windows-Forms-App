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
using System.Net.NetworkInformation;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Json;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        TcpClient tcpClient;
        NetworkStream stream;

        public Form1()
        {
            InitializeComponent();
            btnDisconnect.Enabled = false;
            btnDisableAutoSend.Enabled = false;
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
            if (code == "") txtMessage.Text = "";
            if (!string.IsNullOrEmpty(code))
            {
                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {
                    if (dr.Cells[0].Value.ToString().Equals(code))
                    {
                        txtMessage.Text = $"<STX>DATA,{dr.Cells[1].Value.ToString()}<ETX>";
                        break;
                    }
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void applicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tcp/Ip Demo App V1.0", "About Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnconnect_Click(object sender, EventArgs e)
        {
            try
            {
                tcpClient = new TcpClient(txtipaddress.Text, Convert.ToInt32(txtport.Text.Trim()));
                if (tcpClient.Client.Connected)
                {
                    txtstatus.AppendText($"Connected to remote host {Environment.NewLine}");
                    if (btnconnect.Enabled == true) btnconnect.Enabled = false;
                    if (btnDisconnect.Enabled == false) btnDisconnect.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnping_Click(object sender, EventArgs e)
        {
            try
            {
                Ping myPing = new Ping();
                PingReply reply = myPing.Send(txtipaddress.Text, Convert.ToInt32(txtport.Text));
                if (reply != null)
                {
                    txtstatus.AppendText($"Ping : {reply.Status} at Address : {reply.Address} {Environment.NewLine}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (tcpClient.Connected && txtMessage.Text.Length > 0)
                {
                    // Translate the passed message into ASCII and store it as a Byte array.
                    byte[] data = Encoding.ASCII.GetBytes(txtMessage.Text.Trim());

                    // Get a client stream for reading and writing.
                    stream = tcpClient.GetStream();

                    // Send the message to the connected TcpServer.
                    stream.Write(data, 0, data.Length);
                    txtstatus.AppendText($"Sent: {txtMessage.Text}{Environment.NewLine}");
                    txtMessage.Text = "";
                    txtbarcode.Text = "";
                    txtbarcode.Focus();
                }
                else
                {
                    MessageBox.Show("The server has lost connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (btnDisconnect.Enabled == true) btnDisconnect.Enabled = false;
                    if (btnconnect.Enabled == false) btnconnect.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (tcpClient.Connected)
                {
                    tcpClient.Client.Close();
                    txtstatus.AppendText($"Remote Host Disconnected.{Environment.NewLine}");
                }
                else
                    MessageBox.Show("The server has disconnected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (btnDisconnect.Enabled == true) btnDisconnect.Enabled = false;
                if (btnconnect.Enabled == false) btnconnect.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {
            if (btnAutosend.Enabled == true) return;
            if (string.IsNullOrEmpty(txtMessage.Text)) return;
            if (txtMessage.Text.StartsWith("<STX>") && txtMessage.Text.EndsWith("<ETX>")) btnSend_Click(sender, e);
            txtbarcode.Focus();
        }

        private void btnAutosend_Click(object sender, EventArgs e)
        {
            btnAutosend.Enabled = false;
            btnDisableAutoSend.Enabled = true;
        }

        private void btnDisableAutoSend_Click(object sender, EventArgs e)
        {
            btnAutosend.Enabled = true;
            btnDisableAutoSend.Enabled = false;
        }
    }
}
