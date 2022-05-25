namespace Курсовая_работа_2й_семестр_Методы_Программирования
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьТаблицуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.режимРедактированияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выключитьРежимРедаактированияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьЗаписьОРабочемToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьСтоимостьОдногоЧасаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.анализToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рассчитатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.максимальнуюСтоимостьОдногоЧасаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.количествоОтработанныхЧасовПоФамилииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьТаблицуФамилияРаботникаСуммарнаяСтоимостьОтработанногоВремениToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qualification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkshopNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostOfOneHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountOfTimeWorked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AverageAmountOfTimeWorkedPerDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.удалитьСведенияОРаботникахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.редактированиеToolStripMenuItem,
            this.анализToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1071, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьТаблицуToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьТаблицуToolStripMenuItem
            // 
            this.открытьТаблицуToolStripMenuItem.Name = "открытьТаблицуToolStripMenuItem";
            this.открытьТаблицуToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.открытьТаблицуToolStripMenuItem.Text = "Открыть";
            this.открытьТаблицуToolStripMenuItem.Click += new System.EventHandler(this.открытьТаблицуToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // редактированиеToolStripMenuItem
            // 
            this.редактированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.режимРедактированияToolStripMenuItem,
            this.удалитьЗаписьОРабочемToolStripMenuItem,
            this.изменитьСтоимостьОдногоЧасаToolStripMenuItem});
            this.редактированиеToolStripMenuItem.Name = "редактированиеToolStripMenuItem";
            this.редактированиеToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.редактированиеToolStripMenuItem.Text = "Редактирование";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(372, 26);
            this.добавитьToolStripMenuItem.Text = "Добавить рабочего";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // режимРедактированияToolStripMenuItem
            // 
            this.режимРедактированияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.выключитьРежимРедаактированияToolStripMenuItem});
            this.режимРедактированияToolStripMenuItem.Name = "режимРедактированияToolStripMenuItem";
            this.режимРедактированияToolStripMenuItem.Size = new System.Drawing.Size(372, 26);
            this.режимРедактированияToolStripMenuItem.Text = "Режим редактирования";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(349, 26);
            this.toolStripMenuItem1.Text = "Включить режим редаактирования";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // выключитьРежимРедаактированияToolStripMenuItem
            // 
            this.выключитьРежимРедаактированияToolStripMenuItem.Name = "выключитьРежимРедаактированияToolStripMenuItem";
            this.выключитьРежимРедаактированияToolStripMenuItem.Size = new System.Drawing.Size(349, 26);
            this.выключитьРежимРедаактированияToolStripMenuItem.Text = "Выключить режим редаактирования";
            this.выключитьРежимРедаактированияToolStripMenuItem.Click += new System.EventHandler(this.выключитьРежимРедаактированияToolStripMenuItem_Click);
            // 
            // удалитьЗаписьОРабочемToolStripMenuItem
            // 
            this.удалитьЗаписьОРабочемToolStripMenuItem.Name = "удалитьЗаписьОРабочемToolStripMenuItem";
            this.удалитьЗаписьОРабочемToolStripMenuItem.Size = new System.Drawing.Size(372, 26);
            this.удалитьЗаписьОРабочемToolStripMenuItem.Text = "Удалить запись о рабочем";
            this.удалитьЗаписьОРабочемToolStripMenuItem.Click += new System.EventHandler(this.удалитьЗаписьОРабочемToolStripMenuItem_Click);
            // 
            // изменитьСтоимостьОдногоЧасаToolStripMenuItem
            // 
            this.изменитьСтоимостьОдногоЧасаToolStripMenuItem.Name = "изменитьСтоимостьОдногоЧасаToolStripMenuItem";
            this.изменитьСтоимостьОдногоЧасаToolStripMenuItem.Size = new System.Drawing.Size(372, 26);
            this.изменитьСтоимостьОдногоЧасаToolStripMenuItem.Text = "Изменить стоимость одного часа на X%";
            this.изменитьСтоимостьОдногоЧасаToolStripMenuItem.Click += new System.EventHandler(this.изменитьСтоимостьОдногоЧасаToolStripMenuItem_Click);
            // 
            // анализToolStripMenuItem
            // 
            this.анализToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рассчитатьToolStripMenuItem,
            this.максимальнуюСтоимостьОдногоЧасаToolStripMenuItem,
            this.количествоОтработанныхЧасовПоФамилииToolStripMenuItem,
            this.создатьТаблицуФамилияРаботникаСуммарнаяСтоимостьОтработанногоВремениToolStripMenuItem,
            this.удалитьСведенияОРаботникахToolStripMenuItem});
            this.анализToolStripMenuItem.Name = "анализToolStripMenuItem";
            this.анализToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.анализToolStripMenuItem.Text = "Анализ";
            // 
            // рассчитатьToolStripMenuItem
            // 
            this.рассчитатьToolStripMenuItem.Name = "рассчитатьToolStripMenuItem";
            this.рассчитатьToolStripMenuItem.Size = new System.Drawing.Size(917, 26);
            this.рассчитатьToolStripMenuItem.Text = "Рассчитать среднее количество времени, отработанного за час";
            this.рассчитатьToolStripMenuItem.Click += new System.EventHandler(this.рассчитатьToolStripMenuItem_Click);
            // 
            // максимальнуюСтоимостьОдногоЧасаToolStripMenuItem
            // 
            this.максимальнуюСтоимостьОдногоЧасаToolStripMenuItem.Name = "максимальнуюСтоимостьОдногоЧасаToolStripMenuItem";
            this.максимальнуюСтоимостьОдногоЧасаToolStripMenuItem.Size = new System.Drawing.Size(917, 26);
            this.максимальнуюСтоимостьОдногоЧасаToolStripMenuItem.Text = "Вывести максимальную стоимость одного часа";
            this.максимальнуюСтоимостьОдногоЧасаToolStripMenuItem.Click += new System.EventHandler(this.максимальнуюСтоимостьОдногоЧасаToolStripMenuItem_Click);
            // 
            // количествоОтработанныхЧасовПоФамилииToolStripMenuItem
            // 
            this.количествоОтработанныхЧасовПоФамилииToolStripMenuItem.Name = "количествоОтработанныхЧасовПоФамилииToolStripMenuItem";
            this.количествоОтработанныхЧасовПоФамилииToolStripMenuItem.Size = new System.Drawing.Size(917, 26);
            this.количествоОтработанныхЧасовПоФамилииToolStripMenuItem.Text = "Количество отработанных часов по дате и фамилии ";
            this.количествоОтработанныхЧасовПоФамилииToolStripMenuItem.Click += new System.EventHandler(this.количествоОтработанныхЧасовПоФамилииToolStripMenuItem_Click);
            // 
            // создатьТаблицуФамилияРаботникаСуммарнаяСтоимостьОтработанногоВремениToolStripMenuItem
            // 
            this.создатьТаблицуФамилияРаботникаСуммарнаяСтоимостьОтработанногоВремениToolStripMenuItem.Name = "создатьТаблицуФамилияРаботникаСуммарнаяСтоимостьОтработанногоВремениToolStripMenu" +
    "Item";
            this.создатьТаблицуФамилияРаботникаСуммарнаяСтоимостьОтработанногоВремениToolStripMenuItem.Size = new System.Drawing.Size(917, 26);
            this.создатьТаблицуФамилияРаботникаСуммарнаяСтоимостьОтработанногоВремениToolStripMenuItem.Text = "Создать таблицу для соответветствующего цеха: фамилия работника - суммарная стоим" +
    "ость отработанного времени";
            this.создатьТаблицуФамилияРаботникаСуммарнаяСтоимостьОтработанногоВремениToolStripMenuItem.Click += new System.EventHandler(this.создатьТаблицуФамилияРаботникаСуммарнаяСтоимостьОтработанногоВремениToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LastName,
            this.Qualification,
            this.WorkshopNumber,
            this.Date,
            this.CostOfOneHour,
            this.AmountOfTimeWorked,
            this.AverageAmountOfTimeWorkedPerDay});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1071, 416);
            this.dataGridView1.TabIndex = 1;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Фамилия рабочего ";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 154;
            // 
            // Qualification
            // 
            this.Qualification.HeaderText = "Разряд";
            this.Qualification.MinimumWidth = 6;
            this.Qualification.Name = "Qualification";
            this.Qualification.ReadOnly = true;
            this.Qualification.Width = 85;
            // 
            // WorkshopNumber
            // 
            this.WorkshopNumber.HeaderText = "Номер цеха";
            this.WorkshopNumber.MinimumWidth = 6;
            this.WorkshopNumber.Name = "WorkshopNumber";
            this.WorkshopNumber.ReadOnly = true;
            this.WorkshopNumber.Width = 105;
            // 
            // Date
            // 
            this.Date.HeaderText = "Дата";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 71;
            // 
            // CostOfOneHour
            // 
            this.CostOfOneHour.HeaderText = "Стоимость одного часа";
            this.CostOfOneHour.MinimumWidth = 6;
            this.CostOfOneHour.Name = "CostOfOneHour";
            this.CostOfOneHour.ReadOnly = true;
            this.CostOfOneHour.Width = 108;
            // 
            // AmountOfTimeWorked
            // 
            this.AmountOfTimeWorked.HeaderText = "Количество отработанного времени";
            this.AmountOfTimeWorked.MinimumWidth = 6;
            this.AmountOfTimeWorked.Name = "AmountOfTimeWorked";
            this.AmountOfTimeWorked.ReadOnly = true;
            this.AmountOfTimeWorked.Width = 179;
            // 
            // AverageAmountOfTimeWorkedPerDay
            // 
            this.AverageAmountOfTimeWorkedPerDay.HeaderText = "Среднее количество времени, отработанного за день";
            this.AverageAmountOfTimeWorkedPerDay.MinimumWidth = 6;
            this.AverageAmountOfTimeWorkedPerDay.Name = "AverageAmountOfTimeWorkedPerDay";
            this.AverageAmountOfTimeWorkedPerDay.ReadOnly = true;
            this.AverageAmountOfTimeWorkedPerDay.Width = 199;
            // 
            // удалитьСведенияОРаботникахToolStripMenuItem
            // 
            this.удалитьСведенияОРаботникахToolStripMenuItem.Name = "удалитьСведенияОРаботникахToolStripMenuItem";
            this.удалитьСведенияОРаботникахToolStripMenuItem.Size = new System.Drawing.Size(917, 26);
            this.удалитьСведенияОРаботникахToolStripMenuItem.Text = "Удалить информацию о  работниках, у которых кол-во отработанных часов за день мен" +
    "ьше среднего";
            this.удалитьСведенияОРаботникахToolStripMenuItem.Click += new System.EventHandler(this.удалитьСведенияОРаботникахToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 444);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Таблица о повременной оплате труда рабочих";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem анализToolStripMenuItem;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem режимРедактированияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выключитьРежимРедаактированияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьЗаписьОРабочемToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рассчитатьToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qualification;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkshopNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostOfOneHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountOfTimeWorked;
        private System.Windows.Forms.DataGridViewTextBoxColumn AverageAmountOfTimeWorkedPerDay;
        private System.Windows.Forms.ToolStripMenuItem максимальнуюСтоимостьОдногоЧасаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem количествоОтработанныхЧасовПоФамилииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьТаблицуФамилияРаботникаСуммарнаяСтоимостьОтработанногоВремениToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьТаблицуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьСтоимостьОдногоЧасаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьСведенияОРаботникахToolStripMenuItem;
    }
}

