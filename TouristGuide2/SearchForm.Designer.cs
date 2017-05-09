namespace TouristGuide2
{
    partial class SearchForm
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
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.MaxDurationBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.MinDurationBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Max_cost_box = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Min_cost_box = new System.Windows.Forms.TextBox();
            this.SearchTour = new System.Windows.Forms.Button();
            this.return_to_base = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // from_box
            // 
            this.from_box.TabIndex = 108;
            // 
            // Countries_box
            // 
            this.Countries_box.Location = new System.Drawing.Point(490, 81);
            this.Countries_box.TabIndex = 102;
            // 
            // Excursion_box
            // 
            this.Excursion_box.Items.AddRange(new object[] {
            "",
            "Без экскурсий",
            "1 экскурсия",
            "2 экскурсий",
            "3 экскурсии",
            "4 экскурсии",
            "5 экскурсий"});
            this.Excursion_box.Location = new System.Drawing.Point(883, 81);
            // 
            // Service_box
            // 
            this.Service_box.Items.AddRange(new object[] {
            "",
            "Низкий класс",
            "Средний класс",
            "Высокий класс",
            "Всё включено"});
            this.Service_box.TabIndex = 105;
            // 
            // Accomodations_box
            // 
            this.Accomodations_box.Items.AddRange(new object[] {
            "",
            "Низкий класс",
            "Средний класс",
            "Высокий класс"});
            this.Accomodations_box.Location = new System.Drawing.Point(698, 81);
            this.Accomodations_box.TabIndex = 103;
            // 
            // Cities_box
            // 
            this.Cities_box.Location = new System.Drawing.Point(285, 81);
            // 
            // Company_box
            // 
            this.Company_box.Location = new System.Drawing.Point(129, 81);
            // 
            // OpenBase
            // 
            this.OpenBase.Location = new System.Drawing.Point(947, 301);
            this.OpenBase.TabIndex = 114;
            // 
            // Home
            // 
            this.Home.TabIndex = 116;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(923, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 27);
            this.label8.TabIndex = 115;
            this.label8.Text = "Экскурсии";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(512, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 39);
            this.label10.TabIndex = 114;
            this.label10.Text = "Страна или список стран";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(697, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 39);
            this.label3.TabIndex = 113;
            this.label3.Text = "Условия проживания и проезда";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(306, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 39);
            this.label2.TabIndex = 112;
            this.label2.Text = "Город или список городов";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(146, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 111;
            this.label1.Text = "Турагенство";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(571, 131);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(136, 18);
            this.label15.TabIndex = 119;
            this.label15.Text = "Дата отправления";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(346, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(168, 18);
            this.label11.TabIndex = 118;
            this.label11.Text = "Длительность путевки";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(130, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 40);
            this.label6.TabIndex = 117;
            this.label6.Text = "Сервис принимающей стороны\r\n\r\n";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(821, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 27);
            this.label5.TabIndex = 116;
            this.label5.Text = "Цена";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(314, 168);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 27);
            this.label12.TabIndex = 124;
            this.label12.Text = "от";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(403, 168);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 27);
            this.label13.TabIndex = 123;
            this.label13.Text = "до";
            // 
            // MaxDurationBox
            // 
            this.MaxDurationBox.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.MaxDurationBox.Location = new System.Drawing.Point(434, 168);
            this.MaxDurationBox.Name = "MaxDurationBox";
            this.MaxDurationBox.Size = new System.Drawing.Size(50, 20);
            this.MaxDurationBox.TabIndex = 107;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(490, 168);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 27);
            this.label14.TabIndex = 121;
            this.label14.Text = "дней";
            // 
            // MinDurationBox
            // 
            this.MinDurationBox.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.MinDurationBox.Location = new System.Drawing.Point(347, 168);
            this.MinDurationBox.Name = "MinDurationBox";
            this.MinDurationBox.Size = new System.Drawing.Size(50, 20);
            this.MinDurationBox.TabIndex = 106;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(743, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 27);
            this.label7.TabIndex = 129;
            this.label7.Text = "от";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(832, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 27);
            this.label4.TabIndex = 128;
            this.label4.Text = "до";
            // 
            // Max_cost_box
            // 
            this.Max_cost_box.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.Max_cost_box.Location = new System.Drawing.Point(863, 168);
            this.Max_cost_box.Name = "Max_cost_box";
            this.Max_cost_box.Size = new System.Drawing.Size(50, 20);
            this.Max_cost_box.TabIndex = 110;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(919, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 27);
            this.label9.TabIndex = 126;
            this.label9.Text = "грн.";
            // 
            // Min_cost_box
            // 
            this.Min_cost_box.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.Min_cost_box.Location = new System.Drawing.Point(776, 168);
            this.Min_cost_box.Name = "Min_cost_box";
            this.Min_cost_box.Size = new System.Drawing.Size(50, 20);
            this.Min_cost_box.TabIndex = 109;
            // 
            // SearchTour
            // 
            this.SearchTour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SearchTour.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.SearchTour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchTour.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTour.Location = new System.Drawing.Point(24, 52);
            this.SearchTour.Name = "SearchTour";
            this.SearchTour.Size = new System.Drawing.Size(89, 50);
            this.SearchTour.TabIndex = 111;
            this.SearchTour.Text = "Искать путёвку";
            this.SearchTour.UseVisualStyleBackColor = false;
            this.SearchTour.Click += new System.EventHandler(this.SearchTour_Click);
            // 
            // return_to_base
            // 
            this.return_to_base.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.return_to_base.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.return_to_base.Location = new System.Drawing.Point(947, 226);
            this.return_to_base.Name = "return_to_base";
            this.return_to_base.Size = new System.Drawing.Size(137, 69);
            this.return_to_base.TabIndex = 113;
            this.return_to_base.Text = "Вернуться к основной базе";
            this.return_to_base.UseVisualStyleBackColor = false;
            this.return_to_base.Click += new System.EventHandler(this.return_to_base_Click);
            // 
            // Info
            // 
            this.Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Info.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Info.Location = new System.Drawing.Point(947, 503);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(137, 41);
            this.Info.TabIndex = 115;
            this.Info.Text = "Справка";
            this.Info.UseVisualStyleBackColor = false;
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1096, 603);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.return_to_base);
            this.Controls.Add(this.SearchTour);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Max_cost_box);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Min_cost_box);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.MaxDurationBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.MinDurationBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchForm_KeyDown);
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
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.MinDurationBox, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.MaxDurationBox, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.Min_cost_box, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.Max_cost_box, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.SearchTour, 0);
            this.Controls.SetChildIndex(this.return_to_base, 0);
            this.Controls.SetChildIndex(this.Info, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox MaxDurationBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox MinDurationBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Max_cost_box;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Min_cost_box;
        private System.Windows.Forms.Button SearchTour;
        private System.Windows.Forms.Button return_to_base;
        private System.Windows.Forms.Button Info;
    }
}