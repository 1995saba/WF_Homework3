namespace HomeworkDateTime
{
    partial class FormDayOfWeek
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
            this.dateTimePickerDay = new System.Windows.Forms.DateTimePicker();
            this.labelDayOfWeek = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePickerDay
            // 
            this.dateTimePickerDay.Location = new System.Drawing.Point(41, 60);
            this.dateTimePickerDay.Name = "dateTimePickerDay";
            this.dateTimePickerDay.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDay.TabIndex = 0;
            this.dateTimePickerDay.ValueChanged += new System.EventHandler(this.DateTimePickerDay_ValueChanged);
            // 
            // labelDayOfWeek
            // 
            this.labelDayOfWeek.AutoSize = true;
            this.labelDayOfWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDayOfWeek.Location = new System.Drawing.Point(308, 56);
            this.labelDayOfWeek.Name = "labelDayOfWeek";
            this.labelDayOfWeek.Size = new System.Drawing.Size(128, 24);
            this.labelDayOfWeek.TabIndex = 1;
            this.labelDayOfWeek.Text = "День недели";
            // 
            // FormDayOfWeek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 194);
            this.Controls.Add(this.labelDayOfWeek);
            this.Controls.Add(this.dateTimePickerDay);
            this.Name = "FormDayOfWeek";
            this.Text = "Вычисление дня недели";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerDay;
        private System.Windows.Forms.Label labelDayOfWeek;
    }
}

