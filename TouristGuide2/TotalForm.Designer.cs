namespace TouristGuide2
{
    partial class TotalForm
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
            this.from_box = new System.Windows.Forms.DateTimePicker();
            this.Countries_box = new System.Windows.Forms.TextBox();
            this.Excursion_box = new System.Windows.Forms.ComboBox();
            this.Service_box = new System.Windows.Forms.ComboBox();
            this.Accomodations_box = new System.Windows.Forms.ComboBox();
            this.Cities_box = new System.Windows.Forms.TextBox();
            this.Company_box = new System.Windows.Forms.TextBox();
            this.OpenBase = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // from_box
            // 
            this.from_box.Checked = false;
            this.from_box.Location = new System.Drawing.Point(560, 168);
            this.from_box.Name = "from_box";
            this.from_box.ShowCheckBox = true;
            this.from_box.Size = new System.Drawing.Size(152, 20);
            this.from_box.TabIndex = 106;
            this.from_box.Value = new System.DateTime(2017, 4, 5, 12, 44, 14, 0);
            // 
            // Countries_box
            // 
            this.Countries_box.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.Countries_box.Location = new System.Drawing.Point(493, 87);
            this.Countries_box.Name = "Countries_box";
            this.Countries_box.Size = new System.Drawing.Size(180, 20);
            this.Countries_box.TabIndex = 105;
            // 
            // Excursion_box
            // 
            this.Excursion_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Excursion_box.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.Excursion_box.FormattingEnabled = true;
            this.Excursion_box.Location = new System.Drawing.Point(885, 87);
            this.Excursion_box.Name = "Excursion_box";
            this.Excursion_box.Size = new System.Drawing.Size(158, 21);
            this.Excursion_box.TabIndex = 104;
            // 
            // Service_box
            // 
            this.Service_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Service_box.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.Service_box.FormattingEnabled = true;
            this.Service_box.Location = new System.Drawing.Point(131, 170);
            this.Service_box.Name = "Service_box";
            this.Service_box.Size = new System.Drawing.Size(158, 21);
            this.Service_box.TabIndex = 103;
            // 
            // Accomodations_box
            // 
            this.Accomodations_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Accomodations_box.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.Accomodations_box.FormattingEnabled = true;
            this.Accomodations_box.Location = new System.Drawing.Point(700, 87);
            this.Accomodations_box.Name = "Accomodations_box";
            this.Accomodations_box.Size = new System.Drawing.Size(158, 21);
            this.Accomodations_box.TabIndex = 102;
            // 
            // Cities_box
            // 
            this.Cities_box.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.Cities_box.Location = new System.Drawing.Point(287, 87);
            this.Cities_box.Name = "Cities_box";
            this.Cities_box.Size = new System.Drawing.Size(180, 20);
            this.Cities_box.TabIndex = 101;
            // 
            // Company_box
            // 
            this.Company_box.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.Company_box.Location = new System.Drawing.Point(131, 87);
            this.Company_box.Name = "Company_box";
            this.Company_box.Size = new System.Drawing.Size(138, 20);
            this.Company_box.TabIndex = 100;
            // 
            // OpenBase
            // 
            this.OpenBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.OpenBase.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenBase.Location = new System.Drawing.Point(947, 503);
            this.OpenBase.Name = "OpenBase";
            this.OpenBase.Size = new System.Drawing.Size(137, 41);
            this.OpenBase.TabIndex = 108;
            this.OpenBase.Text = "Открыть базу";
            this.OpenBase.UseVisualStyleBackColor = false;
            this.OpenBase.Click += new System.EventHandler(this.OpenBase_Click);
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Home.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Home.Location = new System.Drawing.Point(947, 550);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(137, 41);
            this.Home.TabIndex = 107;
            this.Home.Text = "На главную";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView1.Location = new System.Drawing.Point(24, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(906, 365);
            this.dataGridView1.TabIndex = 112;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Название турагенства";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 90;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Город(список городов)";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 155;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Старана(список стран)";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 135;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Условия проживания и проезда";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 95;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Экскурсии";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 80;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Сервис принимающей стороны";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Длительность (дней)";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 85;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Дата отправления";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Цена (грн)";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 60;
            // 
            // TotalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 603);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.OpenBase);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.from_box);
            this.Controls.Add(this.Countries_box);
            this.Controls.Add(this.Excursion_box);
            this.Controls.Add(this.Service_box);
            this.Controls.Add(this.Accomodations_box);
            this.Controls.Add(this.Cities_box);
            this.Controls.Add(this.Company_box);
            this.MaximizeBox = false;
            this.Name = "TotalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TotalForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.DateTimePicker from_box;
        protected System.Windows.Forms.TextBox Countries_box;
        protected System.Windows.Forms.ComboBox Excursion_box;
        protected System.Windows.Forms.ComboBox Service_box;
        protected System.Windows.Forms.ComboBox Accomodations_box;
        protected System.Windows.Forms.TextBox Cities_box;
        protected System.Windows.Forms.TextBox Company_box;
        protected System.Windows.Forms.Button OpenBase;
        protected System.Windows.Forms.Button Home;
        protected System.Windows.Forms.OpenFileDialog openFileDialog1;
        protected System.Windows.Forms.DataGridView dataGridView1;
        protected System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        protected System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        protected System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        protected System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        protected System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        protected System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        protected System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        protected System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        protected System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}