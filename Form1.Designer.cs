namespace LabPrakt4zad
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
            this.University = new System.Windows.Forms.ComboBox();
            this.Faculties = new System.Windows.Forms.ComboBox();
            this.Students = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // University
            // 
            this.University.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.University.FormattingEnabled = true;
            this.University.Location = new System.Drawing.Point(13, 34);
            this.University.Name = "University";
            this.University.Size = new System.Drawing.Size(388, 28);
            this.University.TabIndex = 0;
            // 
            // Faculties
            // 
            this.Faculties.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Faculties.FormattingEnabled = true;
            this.Faculties.Location = new System.Drawing.Point(13, 128);
            this.Faculties.Name = "Faculties";
            this.Faculties.Size = new System.Drawing.Size(388, 28);
            this.Faculties.TabIndex = 1;
            // 
            // Students
            // 
            this.Students.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Students.FormattingEnabled = true;
            this.Students.Location = new System.Drawing.Point(13, 220);
            this.Students.Name = "Students";
            this.Students.Size = new System.Drawing.Size(388, 28);
            this.Students.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Students);
            this.Controls.Add(this.Faculties);
            this.Controls.Add(this.University);
            this.Name = "Form1";
            this.Text = "Students";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox University;
        private System.Windows.Forms.ComboBox Faculties;
        private System.Windows.Forms.ComboBox Students;
    }
}

