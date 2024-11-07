using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using SimThe;

namespace QLSimThe
{
    public partial class QLSim : Form
    {
        private Connect dbHelper;

        public QLSim()
        {
            InitializeComponent();
            dbHelper = new Connect();

            LoadSimData();
        }

        private void LoadSimData()
        {
            string query = "SELECT Sim.ID, Sim.SoSim, Mang.TenMang, Sim.NgayKichHoat, Sim.NgayHetHan " +
                           "FROM Sim " +
                           "JOIN Mang ON Sim.MangID = Mang.ID " +
                           "ORDER BY Sim.NgayKichHoat ASC";

            DataTable simTable = dbHelper.GetData(query);
            dataGridView1.DataSource = simTable;
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }
    }
}
