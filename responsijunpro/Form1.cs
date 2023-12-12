using Npgsql;
using System.Data;

namespace responsijunpro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=user;Password=user;Database=responsijunpro";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            btLoad_Click_1();
        }

        private void boxDep_SelectedIndexChanged(object sender, EventArgs e)
        {
            boxDep.AutoCompleteCustomSource.Add(_id_dep);
            boxDep.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            boxDep.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void btLoad_Click_1()
        {
            try
            {
                conn.Open();
                dvgData.DataSource = null;
                sql = "select * from karyawan_select()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dvgData.DataSource = dt;
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dvgData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0)
            {
                r = dvgData.Rows[e.RowIndex];
                boxNama.Text = r.Cells["_nama"].Value.ToString();
                boxDep.Text = r.Cells["_id_dep"].Value.ToString();
            }
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                sql = "select * from karyawan_insert(:_nama :_id_dep)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_nama", boxNama.Text);
                cmd.Parameters.AddWithValue("_id_dep", boxDep.Text);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Karyawan Berhasil Ditambahkan", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    btLoad_Click_1();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private string get_departemen_name(int id)
        {
            string name = string.Empty;
            try
            {
                conn.Open();

                sql = "select * from get_departemen_name(:_id_dep)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id_dep", id);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return name;
        }


    }

}