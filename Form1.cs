using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Data.SqlClient;
using System.Configuration;

namespace lefko
{

    public partial class Form1 : Form
    {
        SerialPort _serialPort = new SerialPort("COM1", 9600, Parity.None, 8, StopBits.One);
        SqlDataAdapter sda;
        DataTable dt = new DataTable();
        int i = 0;


        public Form1()
        {
            InitializeComponent();
            textMatrix.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!_serialPort.IsOpen)
            {
                _serialPort.Open();
            }

            _serialPort.Handshake = Handshake.None;
            _serialPort.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
            _serialPort.WriteTimeout = 500;
            
            //SQL data table
            dataGridView1.DataSource = getData();
            textMatrix.Select();
            WindowState = FormWindowState.Maximized;

        }

        private DataTable getData()
        {
            string connString = ConfigurationManager.ConnectionStrings["lefko.Properties.Settings.Table_lefko"].ConnectionString;
            SqlConnection con = new SqlConnection(connString);
            DataTable dt = new DataTable();
            using (con)
            {
                using(SqlCommand cmd = new SqlCommand("SELECT * FROM Table_lefko2 ORDER BY [Date et Heure] DESC", con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    // load data table 
                    dt.Load(reader);
                }
            }

            return dt;
        }

        void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            string data = _serialPort.ReadLine();
            // Invokes the delegate on the UI thread, and sends the data that was received to the invoked method.  
            // ---- The "si_DataReceived" method will be executed on the UI thread which allows populating of the textbox.  
            this.BeginInvoke(new SetTextDeleg(si_DataReceived), new object[] { data });
        }

        private delegate void SetTextDeleg(string text);
        private void si_DataReceived(string data) { textPoids.Text = data.Trim(); }

        private void Excel_Click(object sender, EventArgs e)
        {
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dataGridView1.Rows.Count ; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
            //workbook.SaveAs("c:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            app.Quit();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["lefko.Properties.Settings.Table_lefko"].ConnectionString;

            SqlConnection con = new SqlConnection(connString);

            int index = dataGridView1.Rows.Count-1;
            if (index == -1)
            {
                MessageBox.Show("Invalid row", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                dataGridView1.Rows.RemoveAt(0);

            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            
            if (textMatrix.Text == "" || textEmp.Text == "" || textPoids.Text == "")
            {
                MessageBox.Show("Please fill out all boxes", "Not enough information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string connString = ConfigurationManager.ConnectionStrings["lefko.Properties.Settings.Table_lefko"].ConnectionString;
                
                SqlConnection con = new SqlConnection(connString);
                dt = dataGridView1.DataSource as DataTable;

                //Add item to rows
                String date = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss ");
                String matrix = textMatrix.Text;
                //String matrix = textMatrix.Text.Substring(0, 13); // 702078-211002 BT-5744 3 de5
                if(textLabel.Text.Length < 26)
                {
                    String boite = textLabel.Text;
                    DataRow row = dt.NewRow();
                    row[0] = date.ToString();
                    row[1] = matrix.ToString();
                    row[2] = boite.ToString();
                    row[3] = textEmp.Text.ToString();
                    row[4] = textPoids.Text.ToString();
                    dt.Rows.InsertAt(row, 0);
                }
                else
                {
                    String boite = textLabel.Text.Substring(14, 13);
                    DataRow row = dt.NewRow();
                    row[0] = date.ToString();
                    row[1] = matrix.ToString();
                    row[2] = boite.ToString();
                    row[3] = textEmp.Text.ToString();
                    row[4] = textPoids.Text.ToString();
                    dt.Rows.InsertAt(row, 0);
                }
                
                // Empty the text box for next scan
                textMatrix.Text = String.Empty;
                textEmp.Text = String.Empty;
                textLabel.Text = String.Empty;
                i++;
            }
        }

        private void Add_Click(object sender, EventArgs e, int choice)
        {
            string connString = ConfigurationManager.ConnectionStrings["lefko.Properties.Settings.Table_lefko"].ConnectionString;

            SqlConnection con = new SqlConnection(connString);
            dt = dataGridView1.DataSource as DataTable;

            //Add item to rows
            String date = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss ");
            String matrix = textMatrix.Text;
            


            DataRow row = dt.NewRow();
            row[0] = date.ToString();
            row[1] = matrix.ToString();


            dt.Rows.InsertAt(row, 0);


            // Empty the text box for next scan
            textMatrix.Text = String.Empty;
            textEmp.Text = String.Empty;
            textLabel.Text = String.Empty;
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                Delete_Click(sender, e);
                // these last two lines will stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;

            }
        }

        private void textBoite_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textEmp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textEmp.Text == "DELETE")
                {
                    Delete_Click(sender, e);
                    textMatrix.Text = String.Empty;
                    textEmp.Text = String.Empty;
                    textLabel.Text = String.Empty;
                    textMatrix.Focus();
                    // these last two lines will stop the beep sound
                    e.SuppressKeyPress = true;
                    e.Handled = true;
                }
                else if (textEmp.Text == "CLEAR")
                {

                    textMatrix.Text = String.Empty;
                    textEmp.Text = String.Empty;
                    textLabel.Text = String.Empty;
                    textMatrix.Focus();
                    // these last two lines will stop the beep sound
                    e.SuppressKeyPress = true;
                    e.Handled = true;
                }
                else
                {
                    Add_Click(sender, e);
                    textMatrix.Focus();
                    // these last two lines will stop the beep sound
                    e.SuppressKeyPress = true;
                    e.Handled = true;
                }
                
            }
        }

        private void textMatrix_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(textMatrix.Text == "DELETE")
                {
                    Delete_Click(sender, e);
                    textMatrix.Text = String.Empty;
                    textEmp.Text = String.Empty;
                    textLabel.Text = String.Empty;
                    textMatrix.Focus();
                    // these last two lines will stop the beep sound
                    e.SuppressKeyPress = true;
                    e.Handled = true;
                }
                else if (textMatrix.Text == "CLEAR")
                {
                   
                    textMatrix.Text = String.Empty;
                    textEmp.Text = String.Empty;
                    textLabel.Text = String.Empty;
                    textMatrix.Focus();
                    // these last two lines will stop the beep sound
                    e.SuppressKeyPress = true;
                    e.Handled = true;
                }
                else
                {
                    textLabel.Focus();
                    // these last two lines will stop the beep sound
                    e.SuppressKeyPress = true;
                    e.Handled = true;
                }
               
            }

            
        }

        private void textMatrix_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["lefko.Properties.Settings.Table_lefko"].ConnectionString;

            SqlConnection con = new SqlConnection(connString);
            dt = dataGridView1.DataSource as DataTable; 
            try
            {
                //Update data to database
                sda = new SqlDataAdapter(@"SELECT * FROM Table_lefko2", con);
                SqlCommandBuilder scb = new SqlCommandBuilder(sda);
                sda.Update(dt);
                dt.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Could not delete row from database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Form1_Load(sender, e);
                

            }
           
        }

        private void textLabel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(textMatrix.Text == textLabel.Text)
                {
                    Add_Click(sender, e, 1);
                    textMatrix.Focus();
                }
                else if (textLabel.Text == "DELETE")
                {
                    Delete_Click(sender, e);
                    textMatrix.Text = String.Empty;
                    textEmp.Text = String.Empty;
                    textLabel.Text = String.Empty;
                    textMatrix.Focus();
                    // these last two lines will stop the beep sound
                    e.SuppressKeyPress = true;
                    e.Handled = true;
                }
                else if (textLabel.Text == "CLEAR")
                {
                    
                    textMatrix.Text = String.Empty;
                    textEmp.Text = String.Empty;
                    textLabel.Text = String.Empty;
                    textMatrix.Focus();
                    // these last two lines will stop the beep sound
                    e.SuppressKeyPress = true;
                    e.Handled = true;
                }
                else
                {
                    textEmp.Focus();
                    // these last two lines will stop the beep sound
                    e.SuppressKeyPress = true;
                    e.Handled = true;
                }


               
            }
        }
    }
}


