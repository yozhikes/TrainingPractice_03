using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingPractice_03.Forms
{
    public partial class FuelForm : Form
    {
        DataBase _dataBase = new DataBase();
        int d;
        public FuelForm()
        {
            InitializeComponent();
        }

        private void updBtn_Click(object sender, EventArgs e)
        {
            RefreshDgv();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            _dataBase.openConnection();
            if (nameTxt.Text != string.Empty&&int.TryParse(priceTxt.Text, out d))
            {
                var addQuery = $"INSERT INTO fuel(fuel_name,price,sup_id) VALUES ('{nameTxt.Text}'," +
                    $"{decimal.Parse(priceTxt.Text)},{decimal.Parse(id_guideTxt.Text)})";
                var command = new SqlCommand(addQuery, _dataBase.GetConnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Новая запись успешно создана!");
                RefreshDgv();
            }
            else
            {
                MessageBox.Show("Неверный ввод!");
            }
            _dataBase.closeConnection();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
            var name = nameTxt.Text;
            var price = priceTxt.Text;
            var sup_id = id_guideTxt.Text;
            if (nameTxt.Text != string.Empty && int.TryParse(priceTxt.Text, out d))
            {
                dataGridView1.Rows[index].SetValues(id, name,price,sup_id);
                _dataBase.openConnection();
                var changequery = $"UPDATE fuel SET fuel_name = '{name}', " +
                    $"price = {price}, sup_id = {sup_id} WHERE fuel_id = {int.Parse(id)}";
                var command = new SqlCommand(changequery, _dataBase.GetConnection());
                command.ExecuteNonQuery();
                _dataBase.closeConnection();
            }
            else
            {
                MessageBox.Show("Неверный ввод!");
            }
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[index].Visible = false;
            if (index != -1)
            {
                _dataBase.openConnection();
                var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                var deleteQuery = $"DELETE FROM fuel WHERE fuel_id = {id}";
                var command = new SqlCommand(deleteQuery, _dataBase.GetConnection());
                command.ExecuteNonQuery();
                _dataBase.closeConnection();
            }
        }

        private void FuelForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_GasStationDataSet.supplierdir". При необходимости она может быть перемещена или удалена.
            this.supplierdirTableAdapter.Fill(this.bD_GasStationDataSet.supplierdir);
            CreateColumns();
            RefreshDgv();
        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("fuel_id", "Код вида");
            dataGridView1.Columns.Add("fuel_name", "Название вида");
            dataGridView1.Columns.Add("price", "Цена");
            dataGridView1.Columns.Add("sup_id", "Код поставщика");
        }
        private void RefreshDgv()
        {
            dataGridView1.Rows.Clear();
            string queryString = $"SELECT * FROM fuel";
            var command = new SqlCommand(queryString, _dataBase.GetConnection());
            _dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader.GetInt32(0), reader.GetString(1),reader.GetDecimal(2),reader.GetInt32(3));
            }
            reader.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow;
            selectedRow = e.RowIndex;
            if (selectedRow >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                nameTxt.Text = row.Cells[1].Value.ToString();
                priceTxt.Text = row.Cells[2].Value.ToString();
                id_guideTxt.Text = row.Cells[3].Value.ToString();
            }
        }

        private void filter_txt_TextChanged(object sender, EventArgs e)
        {
            if (more_radio.Checked)
            {
                more_radio_CheckedChanged(sender, e);
            }
            else if (less_radio.Checked)
            {
                less_radio_CheckedChanged(sender, e);
            }
        }

        private void more_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (int.TryParse(filter_txt.Text, out d))
            {
                for(int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (decimal.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString())
                        < decimal.Parse(filter_txt.Text))
                    {
                        dataGridView1.Rows[i].Visible=false;
                    }
                    else
                    {
                        dataGridView1.Rows[i].Visible = true;
                    }
                }
            }
        }

        private void less_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (int.TryParse(filter_txt.Text, out d))
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (decimal.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString())
                        > decimal.Parse(filter_txt.Text))
                    {
                        dataGridView1.Rows[i].Visible = false;
                    }
                    else
                    {
                        dataGridView1.Rows[i].Visible = true;
                    }
                }
            }
        }

        private void clrFilter_btn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                dataGridView1.Rows[i].Visible = true;
            }
            filter_txt.Text = string.Empty;
            more_radio.Checked = false;
            less_radio.Checked = false;
        }
    }
}
