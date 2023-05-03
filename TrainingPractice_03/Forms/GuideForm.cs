using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingPractice_03.Forms
{
    public partial class GuideForm : Form
    {
        DataBase _dataBase=new DataBase();
        public GuideForm()
        {
            InitializeComponent();
        }

        private void GuideForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDgv();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow;
            selectedRow = e.RowIndex;
            if (selectedRow >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                nameTxt.Text = row.Cells[1].Value.ToString();
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            _dataBase.openConnection();
            if (nameTxt.Text != "")
            {
                var addQuery = $"INSERT INTO supplierdir(sup_name) VALUES ('{nameTxt.Text}')";

                var command = new SqlCommand(addQuery, _dataBase.GetConnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Новая запись успешно создана!");
                RefreshDgv();
            }
            else
            {
                MessageBox.Show("Введите название поставщика!");
            }
            _dataBase.closeConnection();
        }
        
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "Код поставщика");
            dataGridView1.Columns.Add("name", "Название поставщика");
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1));
        }

        private void RefreshDgv()
        {
            dataGridView1.Rows.Clear();
            string queryString = $"SELECT * FROM supplierdir";
            var command = new SqlCommand(queryString, _dataBase.GetConnection());
            _dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dataGridView1, reader);
            }
            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshDgv();
        }
        //удаление по ТЗ не нужно
        /*
        private void del_btn_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[index].Visible=false;
            if (index!=-1)
            {
                _dataBase.openConnection();
                var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                var deleteQuery = $"DELETE FROM fuel WHERE sup_id = {id}";
                var command = new SqlCommand(deleteQuery, _dataBase.GetConnection());
                command.ExecuteNonQuery();
                deleteQuery = $"DELETE FROM supplierdir WHERE sup_id = {id}";
                command = new SqlCommand(deleteQuery, _dataBase.GetConnection());
                command.ExecuteNonQuery();
                _dataBase.closeConnection();
            }
        }*/

        private void edit_btn_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
            var name = nameTxt.Text;
            if (nameTxt.Text != string.Empty)
            {
                dataGridView1.Rows[index].SetValues(id, name);
                _dataBase.openConnection();
                var changequery = $"UPDATE supplierdir SET sup_name = '{name}' WHERE sup_id = {id}";
                var command = new SqlCommand(changequery, _dataBase.GetConnection());
                command.ExecuteNonQuery();
                _dataBase.closeConnection();
                RefreshDgv();
            }
            else
            {
                MessageBox.Show("Введите название поставщика!");
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
