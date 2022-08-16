using Microsoft.Win32.TaskScheduler;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kursovaja
{
    public partial class MenuForm : Form
    {
        public int count;
        public MySqlConnection myConnection;

        public MenuForm()
        {
            InitializeComponent();
            connection();
            LoadData();
        }

        // загрузка записей задач из бд в datagridview
        private void LoadData()
        {
            string query = "SELECT * FROM backuplist";
            List<string[]> data = new List<string[]>();

            myConnection.Open();

            MySqlCommand command = new MySqlCommand(query, myConnection);

            MySqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                data.Add(new string[6]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
            }

            reader.Close();
            myConnection.Close();

            foreach(string[] s in data)
            {
                BackupList.Rows.Add(s);
                count = int.Parse(s[0]);
            }
        }

        // кнопка добавления задачи
        private void AddButton_Click(object sender, EventArgs e)
        {
            ReservationForm reservation = new ReservationForm(count);
            reservation.ShowDialog();
            BackupList.Rows.Clear();
            LoadData();
        }

        // кнопка удаления задачи
        private void deleteBackupButton_Click(object sender, EventArgs e)
        {
            if (BackupList.CurrentRow == null) { return; }

            int deleteId = BackupList.CurrentCell.RowIndex;
            if (deleteId != -1)
            {
                string taskName = BackupList.Rows[deleteId].Cells[1].Value.ToString();
                int id = int.Parse(BackupList.Rows[deleteId].Cells[0].Value.ToString());
                string query = $"DELETE FROM backuplist WHERE id = {id}";

                myConnection.Open();
                
                MySqlCommand command = new MySqlCommand(query, myConnection);
                command.ExecuteNonQuery();
                
                myConnection.Close();
                
                BackupList.Rows.RemoveAt(deleteId);
                BackupList.Refresh();

                using (TaskService ts = new TaskService())
                {
                    ts.RootFolder.DeleteTask(taskName);
                }
            }
        }

        // подключение к бд с задачами
        private void connection()
        {
            string connectString = "server=localhost;port=3306;username=root;password=mysql;database=kursovaja;";
            myConnection = new MySqlConnection(connectString);
        }

        // кнопка обновления datagridview
        private void updateDataGridView_Click(object sender, EventArgs e)
        {
            BackupList.Rows.Clear();
            LoadData();
            BackupList.Refresh();
        }
    }
}
