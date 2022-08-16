
namespace kursovaja
{
    partial class MenuForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.AddButton = new System.Windows.Forms.Button();
            this.updateDataGridView = new System.Windows.Forms.Button();
            this.deleteBackupButton = new System.Windows.Forms.Button();
            this.BackupList = new System.Windows.Forms.DataGridView();
            this.id_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_BD_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Path_Backup_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Backup_Count_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BackupList)).BeginInit();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 12);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(189, 66);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // updateDataGridView
            // 
            this.updateDataGridView.Location = new System.Drawing.Point(402, 12);
            this.updateDataGridView.Name = "updateDataGridView";
            this.updateDataGridView.Size = new System.Drawing.Size(189, 66);
            this.updateDataGridView.TabIndex = 1;
            this.updateDataGridView.Text = "Обновить";
            this.updateDataGridView.UseVisualStyleBackColor = true;
            this.updateDataGridView.Click += new System.EventHandler(this.updateDataGridView_Click);
            // 
            // deleteBackupButton
            // 
            this.deleteBackupButton.Location = new System.Drawing.Point(207, 12);
            this.deleteBackupButton.Name = "deleteBackupButton";
            this.deleteBackupButton.Size = new System.Drawing.Size(189, 66);
            this.deleteBackupButton.TabIndex = 2;
            this.deleteBackupButton.Text = "Удалить";
            this.deleteBackupButton.UseVisualStyleBackColor = true;
            this.deleteBackupButton.Click += new System.EventHandler(this.deleteBackupButton_Click);
            // 
            // BackupList
            // 
            this.BackupList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BackupList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BackupList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_column,
            this.Name_column,
            this.Name_BD_column,
            this.Path_Backup_column,
            this.Date_column,
            this.Backup_Count_column});
            this.BackupList.Location = new System.Drawing.Point(12, 95);
            this.BackupList.Name = "BackupList";
            this.BackupList.RowHeadersWidth = 51;
            this.BackupList.RowTemplate.Height = 24;
            this.BackupList.Size = new System.Drawing.Size(949, 421);
            this.BackupList.TabIndex = 3;
            // 
            // id_column
            // 
            this.id_column.HeaderText = "id";
            this.id_column.MinimumWidth = 6;
            this.id_column.Name = "id_column";
            // 
            // Name_column
            // 
            this.Name_column.HeaderText = "Name";
            this.Name_column.MinimumWidth = 6;
            this.Name_column.Name = "Name_column";
            // 
            // Name_BD_column
            // 
            this.Name_BD_column.HeaderText = "Name_BD";
            this.Name_BD_column.MinimumWidth = 6;
            this.Name_BD_column.Name = "Name_BD_column";
            // 
            // Path_Backup_column
            // 
            this.Path_Backup_column.HeaderText = "Path_Backup";
            this.Path_Backup_column.MinimumWidth = 6;
            this.Path_Backup_column.Name = "Path_Backup_column";
            // 
            // Date_column
            // 
            this.Date_column.HeaderText = "Date";
            this.Date_column.MinimumWidth = 6;
            this.Date_column.Name = "Date_column";
            // 
            // Backup_Count_column
            // 
            this.Backup_Count_column.HeaderText = "Backup_Count";
            this.Backup_Count_column.MinimumWidth = 6;
            this.Backup_Count_column.Name = "Backup_Count_column";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(973, 538);
            this.Controls.Add(this.BackupList);
            this.Controls.Add(this.deleteBackupButton);
            this.Controls.Add(this.updateDataGridView);
            this.Controls.Add(this.AddButton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuForm";
            this.Text = "Бэкапер";
            ((System.ComponentModel.ISupportInitialize)(this.BackupList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button updateDataGridView;
        private System.Windows.Forms.Button deleteBackupButton;
        private System.Windows.Forms.DataGridView BackupList;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_BD_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path_Backup_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Backup_Count_column;
    }
}

