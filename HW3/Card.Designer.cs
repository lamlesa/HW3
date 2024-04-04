namespace HW3
{
    partial class Card
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Card));
            this.label = new System.Windows.Forms.Label();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.birth_textbox = new System.Windows.Forms.TextBox();
            this.payment = new System.Windows.Forms.ComboBox();
            this.days_label = new System.Windows.Forms.Label();
            this.animals = new System.Windows.Forms.CheckBox();
            this.SNP_label = new System.Windows.Forms.Label();
            this.burth_label = new System.Windows.Forms.Label();
            this.days_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.d_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.ForeColor = System.Drawing.Color.Red;
            this.label.Location = new System.Drawing.Point(77, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(234, 38);
            this.label.TabIndex = 0;
            this.label.Text = "Карточка гостя";
            // 
            // name_textbox
            // 
            this.name_textbox.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_textbox.Location = new System.Drawing.Point(49, 93);
            this.name_textbox.Multiline = true;
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.ReadOnly = true;
            this.name_textbox.Size = new System.Drawing.Size(290, 55);
            this.name_textbox.TabIndex = 1;
            this.name_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // birth_textbox
            // 
            this.birth_textbox.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birth_textbox.Location = new System.Drawing.Point(49, 201);
            this.birth_textbox.Multiline = true;
            this.birth_textbox.Name = "birth_textbox";
            this.birth_textbox.ReadOnly = true;
            this.birth_textbox.Size = new System.Drawing.Size(290, 55);
            this.birth_textbox.TabIndex = 2;
            this.birth_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // payment
            // 
            this.payment.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.payment.FormattingEnabled = true;
            this.payment.Items.AddRange(new object[] {
            "Карта",
            "Наличные"});
            this.payment.Location = new System.Drawing.Point(218, 299);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(121, 26);
            this.payment.TabIndex = 3;
            this.payment.Text = "Оплата";
            // 
            // days_label
            // 
            this.days_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.days_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.days_label.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.days_label.ForeColor = System.Drawing.Color.Black;
            this.days_label.Location = new System.Drawing.Point(0, 0);
            this.days_label.Name = "days_label";
            this.days_label.Size = new System.Drawing.Size(388, 47);
            this.days_label.TabIndex = 4;
            this.days_label.Text = "Количество дней";
            this.days_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // animals
            // 
            this.animals.AutoSize = true;
            this.animals.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.animals.Location = new System.Drawing.Point(38, 436);
            this.animals.Name = "animals";
            this.animals.Size = new System.Drawing.Size(312, 26);
            this.animals.TabIndex = 6;
            this.animals.Text = "Путешествую с животными";
            this.animals.UseVisualStyleBackColor = true;
            // 
            // SNP_label
            // 
            this.SNP_label.AutoSize = true;
            this.SNP_label.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SNP_label.Location = new System.Drawing.Point(45, 59);
            this.SNP_label.Name = "SNP_label";
            this.SNP_label.Size = new System.Drawing.Size(70, 22);
            this.SNP_label.TabIndex = 7;
            this.SNP_label.Text = "ФИО :";
            // 
            // burth_label
            // 
            this.burth_label.AutoSize = true;
            this.burth_label.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.burth_label.Location = new System.Drawing.Point(45, 165);
            this.burth_label.Name = "burth_label";
            this.burth_label.Size = new System.Drawing.Size(190, 22);
            this.burth_label.TabIndex = 8;
            this.burth_label.Text = "Дата рождения :";
            // 
            // days_textbox
            // 
            this.days_textbox.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.days_textbox.Location = new System.Drawing.Point(254, 363);
            this.days_textbox.Name = "days_textbox";
            this.days_textbox.ReadOnly = true;
            this.days_textbox.Size = new System.Drawing.Size(85, 26);
            this.days_textbox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(45, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Оплата :";
            // 
            // d_label
            // 
            this.d_label.AutoSize = true;
            this.d_label.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.d_label.Location = new System.Drawing.Point(34, 367);
            this.d_label.Name = "d_label";
            this.d_label.Size = new System.Drawing.Size(214, 22);
            this.d_label.TabIndex = 11;
            this.d_label.Text = "Количество дней :";
            // 
            // Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(388, 494);
            this.Controls.Add(this.d_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.days_textbox);
            this.Controls.Add(this.burth_label);
            this.Controls.Add(this.SNP_label);
            this.Controls.Add(this.animals);
            this.Controls.Add(this.days_label);
            this.Controls.Add(this.payment);
            this.Controls.Add(this.birth_textbox);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Card";
            this.Text = "Карточка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.TextBox birth_textbox;
        private System.Windows.Forms.ComboBox payment;
        private System.Windows.Forms.Label days_label;
        private System.Windows.Forms.CheckBox animals;
        private System.Windows.Forms.Label SNP_label;
        private System.Windows.Forms.Label burth_label;
        private System.Windows.Forms.TextBox days_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label d_label;
    }
}