using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32.TaskScheduler;
using MySql.Data.MySqlClient;
using System.IO;
using System.Diagnostics;

namespace kursovaja
{
    public partial class ReservationForm : Form
    {
        public int count;
        private string NameBackup;
        private string NameBD;
        private string PathBackup;
        private List<DateTime> DateBackup = new List<DateTime>();
        MySqlConnection mySqlConnection;

        public ReservationForm(int count)
        {
            this.count = count;

            InitializeComponent();
            addingBD_ComboBox();
            connection();

            this.tabPage1.Text = "Пути";
            this.tabPage2.Text = "Расписание";
            IntervalComboBox.SelectedIndex = 0;
            TabControl.TabPages.Remove(tabPage2);
        }

        // добавить в ComboBox список существующих бд
        private void addingBD_ComboBox()
        {
            string connectString = "server=localhost;port=3306;username=root;password=mysql;";
            MySqlConnection myConnection = new MySqlConnection(connectString);
            string query = "show databases";
            myConnection.Open();

            MySqlCommand command = new MySqlCommand(query, myConnection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                DB_ComboBox.Items.Add(reader.GetString(0));
            }

            reader.Close();
            myConnection.Close();
        }

        private void connection()
        {
            string connectString = "server=localhost;port=3306;username=root;password=mysql;database=kursovaja;";
            mySqlConnection = new MySqlConnection(connectString);
        }

        // задать каталог через кнопку, куда будем загружать бэкап
        private void CatalogButton2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;

            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                TextBoxPathBackup.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
        }

        // кнопка подтверждения после ввода данных
        private void OkButtonPath_Click(object sender, EventArgs e)
        {
            if (BackupNameTextBox.Text == "")
            {
                MessageBox.Show("Нет названия задачи");
                return;
            }

            if (DB_ComboBox.Text == "")
            {
                MessageBox.Show("Не выбрана бд");
                return;
            }

            if (TextBoxPathBackup.Text == "")
            {
                MessageBox.Show("Нет каталога для бэкапа");
                return;
            }

            this.NameBackup = BackupNameTextBox.Text;
            this.PathBackup = TextBoxPathBackup.Text;
            this.NameBD = DB_ComboBox.Text;

            TabControl.TabPages.Remove(tabPage1);
            TabControl.TabPages.Add(tabPage2);
        }

        // добавить задачу в планировщик windows
        private void DataTimeButton_Click(object sender, EventArgs e)
        {
            using (TaskService ts = new TaskService())
            {
                TaskDefinition td = ts.NewTask();

                td.RegistrationInfo.Description = NameBackup;

                // Соединение даты и времени
                DateTime tp = TimePicker.Value;
                DateTime dt = new DateTime(DatePicker.Value.Year, DatePicker.Value.Month, DatePicker.Value.Day,
                    tp.Hour, tp.Minute, tp.Second);

                // Добавление триггера в зависимости от частоты задачи
                if (IntervalComboBox.Text == "Один раз")
                {
                    td.Triggers.Add(new DailyTrigger { StartBoundary = dt, EndBoundary = dt.AddSeconds(5)});
                }

                else if (IntervalComboBox.Text == "Ежедневно")
                {
                    td.Triggers.Add(new DailyTrigger { StartBoundary = dt,  DaysInterval = 1});
                }

                else if (IntervalComboBox.Text == "Дни недели")
                {
                    List<string> daysList = new List<string>();
                    for (int i = 0; i < CheckedListBoxWeek.Items.Count; i++)
                    {
                        if (CheckedListBoxWeek.GetItemChecked(i))
                        {
                            daysList.Add((string)CheckedListBoxWeek.Items[i]);
                        }
                    }

                    if (daysList.Contains("Понедельник"))
                    {
                        td.Triggers.Add(new WeeklyTrigger { StartBoundary = dt, DaysOfWeek = DaysOfTheWeek.Monday});
                    }
                    if (daysList.Contains("Вторник"))
                    {
                        td.Triggers.Add(new WeeklyTrigger { StartBoundary = dt, DaysOfWeek = DaysOfTheWeek.Tuesday});
                    }
                    if (daysList.Contains("Среда"))
                    {
                        td.Triggers.Add(new WeeklyTrigger { StartBoundary = dt, DaysOfWeek = DaysOfTheWeek.Wednesday});
                    }
                    if (daysList.Contains("Четверг"))
                    {
                        td.Triggers.Add(new WeeklyTrigger { StartBoundary = dt, DaysOfWeek = DaysOfTheWeek.Thursday});
                    }
                    if (daysList.Contains("Пятница"))
                    {
                        td.Triggers.Add(new WeeklyTrigger { StartBoundary = dt, DaysOfWeek = DaysOfTheWeek.Friday});
                    }
                    if (daysList.Contains("Суббота"))
                    {
                        td.Triggers.Add(new WeeklyTrigger { StartBoundary = dt, DaysOfWeek = DaysOfTheWeek.Saturday});
                    }
                    if (daysList.Contains("Воскресенье"))
                    {
                        td.Triggers.Add(new WeeklyTrigger { StartBoundary = dt, DaysOfWeek = DaysOfTheWeek.Sunday});
                    }
                }

                else if (IntervalComboBox.Text == "Дни месяца")
                {
                    for(int i = 0; i < DateBackup.Count(); i++)
                    {
                        DateTime db = new DateTime(DateBackup[i].Year, DateBackup[i].Month, DateBackup[i].Day,
                            tp.Hour, tp.Minute, tp.Second);
                        td.Triggers.Add(new DailyTrigger { StartBoundary = db, EndBoundary = db.AddSeconds(5)});
                    }
                }

                // Параметры запуска задачи другого проекта с созданием бэкапа
                td.Actions.Add(new ExecAction("C:\\Users\\serge\\source\\repos\\SchedulerWindows\\SchedulerWindows\\bin\\Debug\\netcoreapp3.1\\SchedulerWindows.exe",
                    $"{NameBackup}",
                    null));

                TaskService.Instance.RootFolder.RegisterTaskDefinition(BackupNameTextBox.Text, td);
            }
            
            InsertAuto();
            this.Close();
        }

        // Запись новой задачи в таблицу бд с текущими задачами
        public void InsertAuto()
        {
            // Оператор SQL
            string sql = string.Format("Insert Into BackupList" +
                   "(id, Name, NameBD, PathBackup, Date, BackupCount) Values(@id, @Name, @NameBD, @PathBackup, @Date, @BackupCount)");

            using (MySqlCommand cmd = new MySqlCommand(sql, this.mySqlConnection))
            {
                // Добавить параметры
                cmd.Parameters.AddWithValue("@id", count+1);
                cmd.Parameters.AddWithValue("@Name", NameBackup);
                cmd.Parameters.AddWithValue("@NameBD", NameBD);
                cmd.Parameters.AddWithValue("@PathBackup", PathBackup);
                cmd.Parameters.AddWithValue("@Date", IntervalComboBox.Text);
                cmd.Parameters.AddWithValue("@BackupCount", 0);

                this.mySqlConnection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Отображение календаря или ChekedListBox в зависимости от значения частоты
        private void IntervalComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IntervalComboBox.Text == "Дни недели")
            {
                CheckedListBoxWeek.Visible = true;
            }

            else
            {
                CheckedListBoxWeek.Visible = false;
            }

            if (IntervalComboBox.Text == "Дни месяца")
            {
                MonthCalendar.Visible = true;
                DatePicker.Visible = false;
            }

            else
            {
                DatePicker.Visible = true;
                MonthCalendar.Visible = false;
            }
        }

        // Добавление выбранных дат из календаря в массив дат или удаление при повторном нажатии
        private void MonthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime date = e.Start;

            if (DateBackup.Contains(date))
            {
                this.MonthCalendar.RemoveBoldedDate(date);
                this.DateBackup.Remove(date);
            }

            else
            {
                this.MonthCalendar.AddBoldedDate(date);
                this.DateBackup.Add(date);
            }
        }

        // кнопка возвращения к выбору названия бэкапа, бд и каталога
        private void Back_Button_Click(object sender, EventArgs e)
        {
            TabControl.TabPages.Remove(tabPage2);
            TabControl.TabPages.Add(tabPage1);
        }

        // перевод размера бэкапа из байтов в более удобные единицы измерения
        private string BytesToString(long byteCount)
        {
            string[] suf = { "Byt", "KB", "MB", "GB", "TB", "PB", "EB" };
            if (byteCount == 0)
                return "0" + suf[0];
            long bytes = Math.Abs(byteCount);
            int place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            double num = Math.Round(bytes / Math.Pow(1024, place), 1);
            return (Math.Sign(byteCount) * num).ToString() + suf[place];
        }

        // кнопка создания пробной копии
        private void Create_CopyBD_Button_Click(object sender, EventArgs e)
        {
            string commands = $@"D:
                                 cd D:\Ampps\mysql\bin
                                 mysqldump -uroot -pmysql {NameBD} > {NameBD}.sql";

            createProcess(commands);
            
            System.IO.FileInfo file = new System.IO.FileInfo($@"D:\Ampps\mysql\bin\{NameBD}.sql");
            long size = file.Length;

            if (IntervalComboBox.Text == "Один раз")
            {
                size = file.Length;
            }

            else if (IntervalComboBox.Text == "Ежедневно" || IntervalComboBox.Text == "Дни недели")
            {
                size = file.Length * 5;
            }

            else if (IntervalComboBox.Text == "Дни месяца")
            {
                size = file.Length * DateBackup.Count;
            }

            NumRequiredMemory_Label.Text = BytesToString(size);
            NumRequiredMemory_Label.Update();
        }

        // процесс создания копии
        private void createProcess(string commands)
        {
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    RedirectStandardInput = true,
                    UseShellExecute = false,
                    WindowStyle = ProcessWindowStyle.Hidden
                }
            };
            process.Start();

            using (StreamWriter pWriter = process.StandardInput)
            {
                if (pWriter.BaseStream.CanWrite)
                {
                    foreach (var line in commands.Split('\n'))
                        pWriter.WriteLine(line);
                }
            }

            process.WaitForExit();
        }
    }
}
