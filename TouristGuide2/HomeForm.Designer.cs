namespace TouristGuide2
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.label1 = new System.Windows.Forms.Label();
            this.SearchForm = new System.Windows.Forms.Button();
            this.AddForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(300, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 56);
            this.label1.TabIndex = 6;
            this.label1.Text = "Справочник туриста";
            // 
            // SearchForm
            // 
            this.SearchForm.BackColor = System.Drawing.Color.LightBlue;
            this.SearchForm.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchForm.Location = new System.Drawing.Point(426, 483);
            this.SearchForm.Name = "SearchForm";
            this.SearchForm.Size = new System.Drawing.Size(278, 55);
            this.SearchForm.TabIndex = 5;
            this.SearchForm.Text = "Поиск по путёвкам";
            this.SearchForm.UseVisualStyleBackColor = false;
            this.SearchForm.Click += new System.EventHandler(this.SearchForm_Click);
            // 
            // AddForm
            // 
            this.AddForm.BackColor = System.Drawing.Color.LightBlue;
            this.AddForm.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddForm.Location = new System.Drawing.Point(390, 391);
            this.AddForm.Name = "AddForm";
            this.AddForm.Size = new System.Drawing.Size(339, 58);
            this.AddForm.TabIndex = 4;
            this.AddForm.Text = "Контроль каталогов";
            this.AddForm.UseVisualStyleBackColor = false;
            this.AddForm.Click += new System.EventHandler(this.AddForm_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1096, 603);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchForm);
            this.Controls.Add(this.AddForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tourist Guide";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomeForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchForm;
        private System.Windows.Forms.Button AddForm;
    }
}

