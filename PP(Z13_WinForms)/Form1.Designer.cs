namespace PP_Z13_WinForms_
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
            this.Zadanie = new System.Windows.Forms.GroupBox();
            this.cgbcjr = new System.Windows.Forms.Label();
            this.roster = new System.Windows.Forms.RichTextBox();
            this.data = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.RichTextBox();
            this.Result = new System.Windows.Forms.Button();
            this.Zadanie.SuspendLayout();
            this.SuspendLayout();
            // 
            // Zadanie
            // 
            this.Zadanie.Controls.Add(this.search);
            this.Zadanie.Controls.Add(this.data);
            this.Zadanie.Controls.Add(this.roster);
            this.Zadanie.Controls.Add(this.cgbcjr);
            this.Zadanie.Location = new System.Drawing.Point(12, 12);
            this.Zadanie.Name = "Zadanie";
            this.Zadanie.Size = new System.Drawing.Size(427, 651);
            this.Zadanie.TabIndex = 0;
            this.Zadanie.TabStop = false;
            this.Zadanie.Text = "Задание";
            // 
            // cgbcjr
            // 
            this.cgbcjr.AutoSize = true;
            this.cgbcjr.Location = new System.Drawing.Point(6, 27);
            this.cgbcjr.Name = "cgbcjr";
            this.cgbcjr.Size = new System.Drawing.Size(59, 17);
            this.cgbcjr.TabIndex = 0;
            this.cgbcjr.Text = "Список:";
            // 
            // roster
            // 
            this.roster.Location = new System.Drawing.Point(9, 47);
            this.roster.Name = "roster";
            this.roster.Size = new System.Drawing.Size(412, 434);
            this.roster.TabIndex = 1;
            this.roster.Text = "";
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.Location = new System.Drawing.Point(6, 484);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(107, 17);
            this.data.TabIndex = 2;
            this.data.Text = "Поиск по дате:";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(9, 504);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(412, 137);
            this.search.TabIndex = 3;
            this.search.Text = "";
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(109, 672);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(208, 61);
            this.Result.TabIndex = 4;
            this.Result.Text = "Результат";
            this.Result.UseVisualStyleBackColor = true;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 742);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Zadanie);
            this.Name = "Form1";
            this.Text = "Практика 13";
            this.Zadanie.ResumeLayout(false);
            this.Zadanie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Zadanie;
        private System.Windows.Forms.RichTextBox search;
        private System.Windows.Forms.Label data;
        private System.Windows.Forms.RichTextBox roster;
        private System.Windows.Forms.Label cgbcjr;
        private System.Windows.Forms.Button Result;
    }
}

