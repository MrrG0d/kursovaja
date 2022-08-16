
namespace kursovaja
{
    partial class ReservationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationForm));
            this.CatalogButton2 = new System.Windows.Forms.Button();
            this.TextBoxPathBackup = new System.Windows.Forms.TextBox();
            this.OkButtonPath = new System.Windows.Forms.Button();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DB_ComboBox = new System.Windows.Forms.ComboBox();
            this.CatalogBackup_Label = new System.Windows.Forms.Label();
            this.BD_Label = new System.Windows.Forms.Label();
            this.NameBackupLabel = new System.Windows.Forms.Label();
            this.BackupNameTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Create_CopyBD_Button = new System.Windows.Forms.Button();
            this.NumRequiredMemory_Label = new System.Windows.Forms.Label();
            this.requiredMemory_Label = new System.Windows.Forms.Label();
            this.Back_Button = new System.Windows.Forms.Button();
            this.frequency_Label = new System.Windows.Forms.Label();
            this.TimeStart_Label = new System.Windows.Forms.Label();
            this.MonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.CheckedListBoxWeek = new System.Windows.Forms.CheckedListBox();
            this.IntervalComboBox = new System.Windows.Forms.ComboBox();
            this.DataTimeButton = new System.Windows.Forms.Button();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CatalogButton2
            // 
            this.CatalogButton2.Location = new System.Drawing.Point(375, 208);
            this.CatalogButton2.Name = "CatalogButton2";
            this.CatalogButton2.Size = new System.Drawing.Size(90, 24);
            this.CatalogButton2.TabIndex = 2;
            this.CatalogButton2.Text = "Выбрать...";
            this.CatalogButton2.UseVisualStyleBackColor = true;
            this.CatalogButton2.Click += new System.EventHandler(this.CatalogButton2_Click);
            // 
            // TextBoxPathBackup
            // 
            this.TextBoxPathBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxPathBackup.Location = new System.Drawing.Point(11, 208);
            this.TextBoxPathBackup.Name = "TextBoxPathBackup";
            this.TextBoxPathBackup.Size = new System.Drawing.Size(321, 24);
            this.TextBoxPathBackup.TabIndex = 3;
            // 
            // OkButtonPath
            // 
            this.OkButtonPath.Location = new System.Drawing.Point(370, 446);
            this.OkButtonPath.Name = "OkButtonPath";
            this.OkButtonPath.Size = new System.Drawing.Size(95, 29);
            this.OkButtonPath.TabIndex = 4;
            this.OkButtonPath.Text = "Ok";
            this.OkButtonPath.UseVisualStyleBackColor = true;
            this.OkButtonPath.Click += new System.EventHandler(this.OkButtonPath_Click);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(494, 532);
            this.TabControl.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DB_ComboBox);
            this.tabPage1.Controls.Add(this.CatalogBackup_Label);
            this.tabPage1.Controls.Add(this.BD_Label);
            this.tabPage1.Controls.Add(this.NameBackupLabel);
            this.tabPage1.Controls.Add(this.BackupNameTextBox);
            this.tabPage1.Controls.Add(this.OkButtonPath);
            this.tabPage1.Controls.Add(this.CatalogButton2);
            this.tabPage1.Controls.Add(this.TextBoxPathBackup);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(486, 503);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DB_ComboBox
            // 
            this.DB_ComboBox.FormattingEnabled = true;
            this.DB_ComboBox.Location = new System.Drawing.Point(11, 140);
            this.DB_ComboBox.Name = "DB_ComboBox";
            this.DB_ComboBox.Size = new System.Drawing.Size(261, 24);
            this.DB_ComboBox.TabIndex = 9;
            // 
            // CatalogBackup_Label
            // 
            this.CatalogBackup_Label.AutoSize = true;
            this.CatalogBackup_Label.Location = new System.Drawing.Point(8, 188);
            this.CatalogBackup_Label.Name = "CatalogBackup_Label";
            this.CatalogBackup_Label.Size = new System.Drawing.Size(147, 17);
            this.CatalogBackup_Label.TabIndex = 8;
            this.CatalogBackup_Label.Text = "Дирректория бэкапа";
            // 
            // BD_Label
            // 
            this.BD_Label.AutoSize = true;
            this.BD_Label.Location = new System.Drawing.Point(8, 119);
            this.BD_Label.Name = "BD_Label";
            this.BD_Label.Size = new System.Drawing.Size(89, 17);
            this.BD_Label.TabIndex = 7;
            this.BD_Label.Text = "Выбрать БД";
            // 
            // NameBackupLabel
            // 
            this.NameBackupLabel.AutoSize = true;
            this.NameBackupLabel.Location = new System.Drawing.Point(8, 54);
            this.NameBackupLabel.Name = "NameBackupLabel";
            this.NameBackupLabel.Size = new System.Drawing.Size(122, 17);
            this.NameBackupLabel.TabIndex = 6;
            this.NameBackupLabel.Text = "Название бэкапа";
            // 
            // BackupNameTextBox
            // 
            this.BackupNameTextBox.Location = new System.Drawing.Point(11, 74);
            this.BackupNameTextBox.Name = "BackupNameTextBox";
            this.BackupNameTextBox.Size = new System.Drawing.Size(261, 22);
            this.BackupNameTextBox.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Create_CopyBD_Button);
            this.tabPage2.Controls.Add(this.NumRequiredMemory_Label);
            this.tabPage2.Controls.Add(this.requiredMemory_Label);
            this.tabPage2.Controls.Add(this.Back_Button);
            this.tabPage2.Controls.Add(this.frequency_Label);
            this.tabPage2.Controls.Add(this.TimeStart_Label);
            this.tabPage2.Controls.Add(this.MonthCalendar);
            this.tabPage2.Controls.Add(this.CheckedListBoxWeek);
            this.tabPage2.Controls.Add(this.IntervalComboBox);
            this.tabPage2.Controls.Add(this.DataTimeButton);
            this.tabPage2.Controls.Add(this.TimePicker);
            this.tabPage2.Controls.Add(this.DatePicker);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(486, 503);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Create_CopyBD_Button
            // 
            this.Create_CopyBD_Button.Location = new System.Drawing.Point(33, 430);
            this.Create_CopyBD_Button.Name = "Create_CopyBD_Button";
            this.Create_CopyBD_Button.Size = new System.Drawing.Size(93, 23);
            this.Create_CopyBD_Button.TabIndex = 11;
            this.Create_CopyBD_Button.Text = "Создать";
            this.Create_CopyBD_Button.UseVisualStyleBackColor = true;
            this.Create_CopyBD_Button.Click += new System.EventHandler(this.Create_CopyBD_Button_Click);
            // 
            // NumRequiredMemory_Label
            // 
            this.NumRequiredMemory_Label.AutoSize = true;
            this.NumRequiredMemory_Label.Location = new System.Drawing.Point(264, 405);
            this.NumRequiredMemory_Label.Name = "NumRequiredMemory_Label";
            this.NumRequiredMemory_Label.Size = new System.Drawing.Size(16, 17);
            this.NumRequiredMemory_Label.TabIndex = 10;
            this.NumRequiredMemory_Label.Text = "0";
            // 
            // requiredMemory_Label
            // 
            this.requiredMemory_Label.Location = new System.Drawing.Point(30, 387);
            this.requiredMemory_Label.Name = "requiredMemory_Label";
            this.requiredMemory_Label.Size = new System.Drawing.Size(357, 40);
            this.requiredMemory_Label.TabIndex = 9;
            this.requiredMemory_Label.Text = "Создать пробную копию и узнать предварительно необходимое количество памяти:";
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(33, 459);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(75, 23);
            this.Back_Button.TabIndex = 8;
            this.Back_Button.Text = "Back";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // frequency_Label
            // 
            this.frequency_Label.AutoSize = true;
            this.frequency_Label.Location = new System.Drawing.Point(30, 106);
            this.frequency_Label.Name = "frequency_Label";
            this.frequency_Label.Size = new System.Drawing.Size(202, 17);
            this.frequency_Label.TabIndex = 7;
            this.frequency_Label.Text = "Как часто запускать задачу?";
            // 
            // TimeStart_Label
            // 
            this.TimeStart_Label.AutoSize = true;
            this.TimeStart_Label.Location = new System.Drawing.Point(30, 49);
            this.TimeStart_Label.Name = "TimeStart_Label";
            this.TimeStart_Label.Size = new System.Drawing.Size(161, 17);
            this.TimeStart_Label.TabIndex = 6;
            this.TimeStart_Label.Text = "Время запуска задачи:";
            // 
            // MonthCalendar
            // 
            this.MonthCalendar.Location = new System.Drawing.Point(33, 171);
            this.MonthCalendar.MaxSelectionCount = 1;
            this.MonthCalendar.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.MonthCalendar.Name = "MonthCalendar";
            this.MonthCalendar.TabIndex = 5;
            this.MonthCalendar.Visible = false;
            this.MonthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendar_DateSelected);
            // 
            // CheckedListBoxWeek
            // 
            this.CheckedListBoxWeek.CheckOnClick = true;
            this.CheckedListBoxWeek.FormattingEnabled = true;
            this.CheckedListBoxWeek.Items.AddRange(new object[] {
            "Понедельник",
            "Вторник",
            "Среда",
            "Четверг",
            "Пятница",
            "Суббота",
            "Воскресенье"});
            this.CheckedListBoxWeek.Location = new System.Drawing.Point(33, 171);
            this.CheckedListBoxWeek.Name = "CheckedListBoxWeek";
            this.CheckedListBoxWeek.Size = new System.Drawing.Size(164, 174);
            this.CheckedListBoxWeek.TabIndex = 4;
            this.CheckedListBoxWeek.Visible = false;
            // 
            // IntervalComboBox
            // 
            this.IntervalComboBox.FormattingEnabled = true;
            this.IntervalComboBox.Items.AddRange(new object[] {
            "Один раз",
            "Ежедневно",
            "Дни недели",
            "Дни месяца"});
            this.IntervalComboBox.Location = new System.Drawing.Point(33, 126);
            this.IntervalComboBox.Name = "IntervalComboBox";
            this.IntervalComboBox.Size = new System.Drawing.Size(121, 24);
            this.IntervalComboBox.TabIndex = 3;
            this.IntervalComboBox.Text = "Один раз";
            this.IntervalComboBox.SelectedIndexChanged += new System.EventHandler(this.IntervalComboBox_SelectedIndexChanged);
            // 
            // DataTimeButton
            // 
            this.DataTimeButton.Location = new System.Drawing.Point(368, 459);
            this.DataTimeButton.Name = "DataTimeButton";
            this.DataTimeButton.Size = new System.Drawing.Size(75, 23);
            this.DataTimeButton.TabIndex = 2;
            this.DataTimeButton.Text = "Ok";
            this.DataTimeButton.UseVisualStyleBackColor = true;
            this.DataTimeButton.Click += new System.EventHandler(this.DataTimeButton_Click);
            // 
            // TimePicker
            // 
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePicker.Location = new System.Drawing.Point(335, 49);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.ShowUpDown = true;
            this.TimePicker.Size = new System.Drawing.Size(108, 22);
            this.TimePicker.TabIndex = 1;
            // 
            // DatePicker
            // 
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePicker.Location = new System.Drawing.Point(211, 49);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(108, 22);
            this.DatePicker.TabIndex = 0;
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 532);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReservationForm";
            this.Text = "Бэкапер";
            this.TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CatalogButton2;
        private System.Windows.Forms.TextBox TextBoxPathBackup;
        private System.Windows.Forms.Button OkButtonPath;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.DateTimePicker TimePicker;
        private System.Windows.Forms.Button DataTimeButton;
        private System.Windows.Forms.TextBox BackupNameTextBox;
        private System.Windows.Forms.CheckedListBox CheckedListBoxWeek;
        private System.Windows.Forms.ComboBox IntervalComboBox;
        private System.Windows.Forms.MonthCalendar MonthCalendar;
        private System.Windows.Forms.Label CatalogBackup_Label;
        private System.Windows.Forms.Label BD_Label;
        private System.Windows.Forms.Label NameBackupLabel;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Label frequency_Label;
        private System.Windows.Forms.Label TimeStart_Label;
        private System.Windows.Forms.Label NumRequiredMemory_Label;
        private System.Windows.Forms.Label requiredMemory_Label;
        private System.Windows.Forms.ComboBox DB_ComboBox;
        private System.Windows.Forms.Button Create_CopyBD_Button;
    }
}