namespace TouristGuide2
{
    partial class EditTour
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
            this.components = new System.ComponentModel.Container();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Countries_box = new System.Windows.Forms.TextBox();
            this.Cities_box = new System.Windows.Forms.TextBox();
            this.Company_box = new System.Windows.Forms.TextBox();
            this.Excursion_box = new System.Windows.Forms.ComboBox();
            this.Accomodations_box = new System.Windows.Forms.ComboBox();
            this.Service_box = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Duration_box = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Cost_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.from_box = new System.Windows.Forms.DateTimePicker();
            this.Edit = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(399, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 39);
            this.label10.TabIndex = 132;
            this.label10.Text = "Страна или список стран";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(199, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 39);
            this.label2.TabIndex = 131;
            this.label2.Text = "Город или список городов*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 130;
            this.label1.Text = "Турагенство*";
            // 
            // Countries_box
            // 
            this.Countries_box.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.Countries_box.Location = new System.Drawing.Point(372, 62);
            this.Countries_box.Name = "Countries_box";
            this.Countries_box.Size = new System.Drawing.Size(180, 20);
            this.Countries_box.TabIndex = 135;
            this.Countries_box.TextChanged += new System.EventHandler(this.Countries_box_TextChanged);
            // 
            // Cities_box
            // 
            this.Cities_box.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.Cities_box.Location = new System.Drawing.Point(174, 62);
            this.Cities_box.Name = "Cities_box";
            this.Cities_box.Size = new System.Drawing.Size(180, 20);
            this.Cities_box.TabIndex = 134;
            this.Cities_box.TextChanged += new System.EventHandler(this.Cities_box_TextChanged);
            // 
            // Company_box
            // 
            this.Company_box.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.Company_box.Location = new System.Drawing.Point(10, 62);
            this.Company_box.Name = "Company_box";
            this.Company_box.Size = new System.Drawing.Size(138, 20);
            this.Company_box.TabIndex = 133;
            this.Company_box.TextChanged += new System.EventHandler(this.Company_box_TextChanged);
            // 
            // Excursion_box
            // 
            this.Excursion_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Excursion_box.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.Excursion_box.FormattingEnabled = true;
            this.Excursion_box.Items.AddRange(new object[] {
            "",
            "Без экскурсий",
            "1 экскурсия",
            "2 экскурсии",
            "3 экскурсии",
            "4 экскурсии",
            "5 экскурсий"});
            this.Excursion_box.Location = new System.Drawing.Point(196, 147);
            this.Excursion_box.Name = "Excursion_box";
            this.Excursion_box.Size = new System.Drawing.Size(158, 21);
            this.Excursion_box.TabIndex = 137;
            // 
            // Accomodations_box
            // 
            this.Accomodations_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Accomodations_box.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.Accomodations_box.FormattingEnabled = true;
            this.Accomodations_box.Items.AddRange(new object[] {
            "",
            "Низкий класс",
            "Средний класс",
            "Высокий класс"});
            this.Accomodations_box.Location = new System.Drawing.Point(11, 147);
            this.Accomodations_box.Name = "Accomodations_box";
            this.Accomodations_box.Size = new System.Drawing.Size(158, 21);
            this.Accomodations_box.TabIndex = 136;
            // 
            // Service_box
            // 
            this.Service_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Service_box.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.Service_box.FormattingEnabled = true;
            this.Service_box.Items.AddRange(new object[] {
            "",
            "Низкий класс",
            "Средний класс",
            "Высокий класс",
            "Всё включено"});
            this.Service_box.Location = new System.Drawing.Point(385, 147);
            this.Service_box.Name = "Service_box";
            this.Service_box.Size = new System.Drawing.Size(158, 21);
            this.Service_box.TabIndex = 138;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(228, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 27);
            this.label4.TabIndex = 140;
            this.label4.Text = "Экскурсии";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 43);
            this.label3.TabIndex = 139;
            this.label3.Text = "Условия проживания и проезда";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(391, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 40);
            this.label6.TabIndex = 141;
            this.label6.Text = "Сервис принимающей стороны\r\n\r\n";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(97, 219);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 27);
            this.label12.TabIndex = 144;
            this.label12.Text = "дней";
            // 
            // Duration_box
            // 
            this.Duration_box.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.Duration_box.Location = new System.Drawing.Point(32, 220);
            this.Duration_box.Name = "Duration_box";
            this.Duration_box.Size = new System.Drawing.Size(50, 20);
            this.Duration_box.TabIndex = 139;
            this.Duration_box.TextChanged += new System.EventHandler(this.Duration_box_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(7, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(176, 18);
            this.label11.TabIndex = 142;
            this.label11.Text = "Длительность путевки*";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(513, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 27);
            this.label9.TabIndex = 147;
            this.label9.Text = "грн.";
            // 
            // Cost_box
            // 
            this.Cost_box.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.Cost_box.Location = new System.Drawing.Point(407, 219);
            this.Cost_box.Name = "Cost_box";
            this.Cost_box.Size = new System.Drawing.Size(100, 20);
            this.Cost_box.TabIndex = 141;
            this.Cost_box.TextChanged += new System.EventHandler(this.Cost_box_TextChanged);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(443, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 27);
            this.label5.TabIndex = 145;
            this.label5.Text = "Цена*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(210, 190);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 18);
            this.label13.TabIndex = 148;
            this.label13.Text = "Дата отправления";
            // 
            // from_box
            // 
            this.from_box.Checked = false;
            this.from_box.Location = new System.Drawing.Point(202, 220);
            this.from_box.Name = "from_box";
            this.from_box.ShowCheckBox = true;
            this.from_box.Size = new System.Drawing.Size(152, 20);
            this.from_box.TabIndex = 140;
            this.from_box.Value = new System.DateTime(2017, 4, 5, 12, 44, 14, 0);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Edit.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Edit.Location = new System.Drawing.Point(209, 270);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(137, 41);
            this.Edit.TabIndex = 150;
            this.Edit.Text = "Изменить";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // error
            // 
            this.error.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.error.ContainerControl = this;
            // 
            // EditTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(567, 335);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.from_box);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Cost_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Duration_box);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Service_box);
            this.Controls.Add(this.Excursion_box);
            this.Controls.Add(this.Accomodations_box);
            this.Controls.Add(this.Countries_box);
            this.Controls.Add(this.Cities_box);
            this.Controls.Add(this.Company_box);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditTour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактировать";
            this.Load += new System.EventHandler(this.EditTour_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditTour_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.TextBox Countries_box;
        protected System.Windows.Forms.TextBox Cities_box;
        protected System.Windows.Forms.TextBox Company_box;
        protected System.Windows.Forms.ComboBox Excursion_box;
        protected System.Windows.Forms.ComboBox Accomodations_box;
        protected System.Windows.Forms.ComboBox Service_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Duration_box;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Cost_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        protected System.Windows.Forms.DateTimePicker from_box;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.ErrorProvider error;
    }
}