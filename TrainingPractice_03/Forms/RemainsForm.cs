using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace TrainingPractice_03.Forms
{
    public partial class RemainsForm : Form
    {
        DataBase _dataBase = new DataBase();
        decimal d;
        DateTime c;
        IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };
        public RemainsForm()
        {
            InitializeComponent();
            CultureInfo customCulture = (CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        }
        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow;
            selectedRow = e.RowIndex;
            if (selectedRow >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                id_fuelTxt.Text = row.Cells[1].Value.ToString();
                dateTxt.Text = row.Cells[2].Value.ToString();
                startVolumeTxt.Text = row.Cells[3].Value.ToString();
                volumeSaleTxt.Text = row.Cells[4].Value.ToString();
            }
        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("remain_id", "Код учёта");
            dataGridView1.Columns.Add("fuel_id", "Код вида топлива");
            dataGridView1.Columns.Add("remain_date", "Дата");
            dataGridView1.Columns.Add("vol_init", "Объём на начало дня (л)");
            dataGridView1.Columns.Add("vol_sold", "Объём продажи (л)");
        }
        private void RefreshDgv()
        {
            dataGridView1.Rows.Clear();
            string queryString = $"SELECT * FROM remains";
            var command = new SqlCommand(queryString, _dataBase.GetConnection());
            _dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader.GetInt32(0), reader.GetInt32(1), reader.GetDateTime(2),
                    reader.GetDecimal(3), reader.GetDecimal(4));
            }
            reader.Close();
        }

        private void RemainsForm_Load(object sender, EventArgs e)
        {
            var queryString = $"SELECT fuel_id FROM fuel";
            var command = new SqlCommand(queryString, _dataBase.GetConnection());
            _dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            id_fuelTxt.Items.Clear();
            while (reader.Read())
            {
                id_fuelTxt.Items.Add(reader[0].ToString());
            }
            reader.Close();
            CreateColumns();
            RefreshDgv();
        }

        private void updBtn_Click(object sender, EventArgs e)
        {
            RefreshDgv();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            _dataBase.openConnection();
            var try1= decimal.TryParse(startVolumeTxt.Text, out d);
            var try2 = decimal.TryParse(volumeSaleTxt.Text,out d);
            if (dateTxt.Text != string.Empty && try1&&try2&&DateTime.TryParse(dateTxt.Text,out c))
            {
                var addQuery = $"INSERT INTO remains(fuel_id,remain_date,vol_init,vol_sold)" +
                    $" VALUES ({id_fuelTxt.Text},'{dateTxt.Text}'," +
                    $"{decimal.Parse(startVolumeTxt.Text)}" +
                    $",{decimal.Parse(volumeSaleTxt.Text)})";
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

        //По логике редактирование не нужно!
        /*
        private void edit_btn_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
            var id_fuel = id_fuelTxt.Text;
            var date = dateTxt.Text;
            var startVolume = startVolumeTxt.Text;
            var volumeSale = volumeSaleTxt.Text;
            if (dateTxt.Text != string.Empty && decimal.TryParse(startVolumeTxt.Text, out d)
                && decimal.TryParse(volumeSaleTxt.Text, out d))
            {
                dataGridView1.Rows[index].SetValues(id, id_fuel, date, startVolume, volumeSale);
                _dataBase.openConnection();
                var changequery = $"UPDATE remains SET id_fuel = '{id_fuel}', " +
                    $"date = {date}, startVolume = {startVolume}, volumeSale = {volumeSale}" +
                    $" WHERE remain_id = {int.Parse(id)}";
                var command = new SqlCommand(changequery, _dataBase.GetConnection());
                command.ExecuteNonQuery();
                _dataBase.closeConnection();
            }
            else
            {
                MessageBox.Show("Неверный ввод!");
            }
        }*/

        private void del_btn_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[index].Visible = false;
            if (index != -1)
            {
                _dataBase.openConnection();
                var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                var deleteQuery = $"DELETE FROM remains WHERE remain_id = {id}";
                var command = new SqlCommand(deleteQuery, _dataBase.GetConnection());
                command.ExecuteNonQuery();
                _dataBase.closeConnection();
            }
            RefreshDgv();
        }

        private void expBtn_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            //Книга.
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            //Таблица.
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
            ExcelWorkSheet.Columns.ColumnWidth = 27;
            ExcelApp.Cells[1, 1] = "Код учёта";
            ExcelApp.Cells[1, 2] = "Код вида топлива";
            ExcelApp.Cells[1, 3] = "Дата";
            ExcelApp.Cells[1, 4] = "Объём на начало дня (л)";
            ExcelApp.Cells[1, 5] = "Объём продажи (л)";
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }
            //Вызываем нашу созданную эксельку.
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            if (rb1.Checked)
            {
                dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
            }
            else if (rb2.Checked)
            {
                dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);
            }
            else if (rb3.Checked)
            {
                dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Ascending);
            }
            else if (rb4.Checked)
            {
                dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Ascending);
            }
            else if (rb5.Checked)
            {
                dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Ascending);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
