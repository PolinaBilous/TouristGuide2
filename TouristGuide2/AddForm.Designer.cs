namespace TouristGuide2
{
    partial class AddForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddTour = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.deleteCitiesBox = new System.Windows.Forms.TextBox();
            this.deleteCompanyBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.Duration_box = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Cost_box = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Edit = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // from_box
            // 
            this.from_box.Checked = true;
            this.from_box.Location = new System.Drawing.Point(549, 122);
            this.from_box.MinDate = new System.DateTime(2017, 5, 7, 0, 0, 0, 0);
            this.from_box.TabIndex = 107;
            this.from_box.Value = new System.DateTime(2017, 5, 7, 0, 0, 0, 0);
            // 
            // Countries_box
            // 
            this.Countries_box.Location = new System.Drawing.Point(489, 51);
            this.Countries_box.TabIndex = 102;
            this.Countries_box.TextChanged += new System.EventHandler(this.Countries_box_TextChanged);
            // 
            // Excursion_box
            // 
            this.Excursion_box.Items.AddRange(new object[] {
            "",
            "Без экскурсий",
            "1 экскурсия",
            "2 экскурсии",
            "3 экскурсии",
            "4 экскурсии",
            "5 экскурсий"});
            this.Excursion_box.Location = new System.Drawing.Point(881, 51);
            // 
            // Service_box
            // 
            this.Service_box.Items.AddRange(new object[] {
            "",
            "Низкий класс",
            "Средний класс",
            "Высокий класс",
            "Всё включено"});
            this.Service_box.Location = new System.Drawing.Point(127, 123);
            this.Service_box.TabIndex = 105;
            // 
            // Accomodations_box
            // 
            this.Accomodations_box.Items.AddRange(new object[] {
            "",
            "Низкий класс",
            "Средний класс",
            "Высокий класс"});
            this.Accomodations_box.Location = new System.Drawing.Point(696, 51);
            this.Accomodations_box.TabIndex = 103;
            // 
            // Cities_box
            // 
            this.Cities_box.Location = new System.Drawing.Point(287, 51);
            this.Cities_box.TextChanged += new System.EventHandler(this.Cities_box_TextChanged);
            // 
            // Company_box
            // 
            this.Company_box.Location = new System.Drawing.Point(127, 51);
            this.Company_box.TextChanged += new System.EventHandler(this.Company_box_TextChanged);
            // 
            // OpenBase
            // 
            this.OpenBase.Location = new System.Drawing.Point(947, 320);
            this.OpenBase.TabIndex = 115;
            // 
            // Home
            // 
            this.Home.TabIndex = 117;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(511, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 39);
            this.label10.TabIndex = 114;
            this.label10.Text = "Страна или список стран";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(923, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 27);
            this.label4.TabIndex = 113;
            this.label4.Text = "Экскурсии";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(693, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 39);
            this.label3.TabIndex = 112;
            this.label3.Text = "Условия проживания и проезда";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(308, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 39);
            this.label2.TabIndex = 111;
            this.label2.Text = "Город или список городов*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(142, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 110;
            this.label1.Text = "Турагенство*";
            // 
            // AddTour
            // 
            this.AddTour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.AddTour.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.AddTour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTour.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddTour.Location = new System.Drawing.Point(24, 25);
            this.AddTour.Name = "AddTour";
            this.AddTour.Size = new System.Drawing.Size(89, 47);
            this.AddTour.TabIndex = 109;
            this.AddTour.Text = "Добавить путёвку";
            this.AddTour.UseVisualStyleBackColor = false;
            this.AddTour.Click += new System.EventHandler(this.AddTour_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(546, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 18);
            this.label13.TabIndex = 119;
            this.label13.Text = "Дата отправления";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(327, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(176, 18);
            this.label11.TabIndex = 118;
            this.label11.Text = "Длительность путевки*";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(124, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 40);
            this.label6.TabIndex = 117;
            this.label6.Text = "Сервис принимающей стороны\r\n\r\n";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(775, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 27);
            this.label5.TabIndex = 116;
            this.label5.Text = "Цена*";
            // 
            // deleteCitiesBox
            // 
            this.deleteCitiesBox.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.deleteCitiesBox.Location = new System.Drawing.Point(323, 190);
            this.deleteCitiesBox.Name = "deleteCitiesBox";
            this.deleteCitiesBox.Size = new System.Drawing.Size(180, 20);
            this.deleteCitiesBox.TabIndex = 111;
            // 
            // deleteCompanyBox
            // 
            this.deleteCompanyBox.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.deleteCompanyBox.Location = new System.Drawing.Point(127, 190);
            this.deleteCompanyBox.Name = "deleteCompanyBox";
            this.deleteCompanyBox.Size = new System.Drawing.Size(138, 20);
            this.deleteCompanyBox.TabIndex = 110;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(320, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 27);
            this.label7.TabIndex = 122;
            this.label7.Text = "Город (список городов)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(142, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 18);
            this.label8.TabIndex = 121;
            this.label8.Text = "Турагенство";
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.delete.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete.Location = new System.Drawing.Point(24, 157);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(89, 47);
            this.delete.TabIndex = 112;
            this.delete.Text = "Удалить путёвку";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(428, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 27);
            this.label12.TabIndex = 126;
            this.label12.Text = "дней";
            // 
            // Duration_box
            // 
            this.Duration_box.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.Duration_box.Location = new System.Drawing.Point(363, 120);
            this.Duration_box.Name = "Duration_box";
            this.Duration_box.Size = new System.Drawing.Size(50, 20);
            this.Duration_box.TabIndex = 106;
            this.Duration_box.TextChanged += new System.EventHandler(this.Duration_box_TextChanged);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(858, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 27);
            this.label9.TabIndex = 129;
            this.label9.Text = "грн.";
            // 
            // Cost_box
            // 
            this.Cost_box.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.Cost_box.Location = new System.Drawing.Point(741, 121);
            this.Cost_box.Name = "Cost_box";
            this.Cost_box.Size = new System.Drawing.Size(100, 20);
            this.Cost_box.TabIndex = 108;
            this.Cost_box.TextChanged += new System.EventHandler(this.Cost_box_TextChanged);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.save.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save.Location = new System.Drawing.Point(947, 273);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(137, 41);
            this.save.TabIndex = 114;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Edit.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Edit.Location = new System.Drawing.Point(947, 226);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(137, 41);
            this.Edit.TabIndex = 113;
            this.Edit.Text = "Редактировать";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Info
            // 
            this.Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Info.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Info.Location = new System.Drawing.Point(947, 503);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(137, 41);
            this.Info.TabIndex = 116;
            this.Info.Text = "Справка";
            this.Info.UseVisualStyleBackColor = false;
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 100;
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1096, 603);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Cost_box);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Duration_box);
            this.Controls.Add(this.deleteCitiesBox);
            this.Controls.Add(this.deleteCompanyBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddTour);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddForm_KeyDown);
            this.Controls.SetChildIndex(this.Company_box, 0);
            this.Controls.SetChildIndex(this.Cities_box, 0);
            this.Controls.SetChildIndex(this.Accomodations_box, 0);
            this.Controls.SetChildIndex(this.Service_box, 0);
            this.Controls.SetChildIndex(this.Excursion_box, 0);
            this.Controls.SetChildIndex(this.Countries_box, 0);
            this.Controls.SetChildIndex(this.from_box, 0);
            this.Controls.SetChildIndex(this.Home, 0);
            this.Controls.SetChildIndex(this.OpenBase, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.AddTour, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.delete, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.deleteCompanyBox, 0);
            this.Controls.SetChildIndex(this.deleteCitiesBox, 0);
            this.Controls.SetChildIndex(this.Duration_box, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.Cost_box, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.save, 0);
            this.Controls.SetChildIndex(this.Edit, 0);
            this.Controls.SetChildIndex(this.Info, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddTour;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox deleteCitiesBox;
        private System.Windows.Forms.TextBox deleteCompanyBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Duration_box;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Cost_box;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Info;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}