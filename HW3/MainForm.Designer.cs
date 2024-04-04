namespace HW3
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.time_label = new System.Windows.Forms.Label();
            this.card = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.search_button = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.clients = new System.Windows.Forms.DataGridView();
            this.list_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.status_label = new System.Windows.Forms.Label();
            this.getting = new System.Windows.Forms.RadioButton();
            this.occupied = new System.Windows.Forms.RadioButton();
            this.empty = new System.Windows.Forms.RadioButton();
            this.booked = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.num_label = new System.Windows.Forms.Label();
            this.co_label = new System.Windows.Forms.Label();
            this.ci_label = new System.Windows.Forms.Label();
            this.checkout = new System.Windows.Forms.TextBox();
            this.checkin = new System.Windows.Forms.TextBox();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.status_combobox = new System.Windows.Forms.ComboBox();
            this.st_label = new System.Windows.Forms.Label();
            this.u_pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clients)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.u_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time_label.Location = new System.Drawing.Point(12, 9);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(58, 18);
            this.time_label.TabIndex = 0;
            this.time_label.Text = "Время";
            // 
            // card
            // 
            this.card.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.card.Location = new System.Drawing.Point(121, 589);
            this.card.Name = "card";
            this.card.Size = new System.Drawing.Size(180, 55);
            this.card.TabIndex = 1;
            this.card.Text = "Просмотр карточки";
            this.card.UseVisualStyleBackColor = true;
            this.card.Click += new System.EventHandler(this.ShowCard);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Teal;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.splitContainer1.Panel1.Controls.Add(this.search_button);
            this.splitContainer1.Panel1.Controls.Add(this.search);
            this.splitContainer1.Panel1.Controls.Add(this.clients);
            this.splitContainer1.Panel1.Controls.Add(this.list_label);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Teal;
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Panel2.Controls.Add(this.num_label);
            this.splitContainer1.Panel2.Controls.Add(this.co_label);
            this.splitContainer1.Panel2.Controls.Add(this.ci_label);
            this.splitContainer1.Panel2.Controls.Add(this.checkout);
            this.splitContainer1.Panel2.Controls.Add(this.checkin);
            this.splitContainer1.Panel2.Controls.Add(this.name_textbox);
            this.splitContainer1.Panel2.Controls.Add(this.card);
            this.splitContainer1.Panel2.Controls.Add(this.status_combobox);
            this.splitContainer1.Panel2.Controls.Add(this.st_label);
            this.splitContainer1.Panel2.Controls.Add(this.u_pic);
            this.splitContainer1.Size = new System.Drawing.Size(1138, 659);
            this.splitContainer1.SplitterDistance = 821;
            this.splitContainer1.TabIndex = 2;
            // 
            // search_button
            // 
            this.search_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search_button.BackgroundImage")));
            this.search_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.search_button.Location = new System.Drawing.Point(756, 12);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(47, 47);
            this.search_button.TabIndex = 5;
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(233, 12);
            this.search.Multiline = true;
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(513, 47);
            this.search.TabIndex = 4;
            // 
            // clients
            // 
            this.clients.BackgroundColor = System.Drawing.Color.OldLace;
            this.clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clients.Location = new System.Drawing.Point(233, 114);
            this.clients.Name = "clients";
            this.clients.RowHeadersWidth = 62;
            this.clients.RowTemplate.Height = 28;
            this.clients.Size = new System.Drawing.Size(570, 530);
            this.clients.TabIndex = 3;
            this.clients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewInfo);
            this.clients.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewInfo);
            this.clients.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewInfo);
            // 
            // list_label
            // 
            this.list_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list_label.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.list_label.Location = new System.Drawing.Point(233, 70);
            this.list_label.Name = "list_label";
            this.list_label.Size = new System.Drawing.Size(200, 30);
            this.list_label.TabIndex = 2;
            this.list_label.Text = "Список гостей";
            this.list_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.time_label);
            this.panel1.Controls.Add(this.status_label);
            this.panel1.Controls.Add(this.getting);
            this.panel1.Controls.Add(this.occupied);
            this.panel1.Controls.Add(this.empty);
            this.panel1.Controls.Add(this.booked);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 667);
            this.panel1.TabIndex = 0;
            // 
            // status_label
            // 
            this.status_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.status_label.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.status_label.Location = new System.Drawing.Point(17, 70);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(100, 30);
            this.status_label.TabIndex = 9;
            this.status_label.Text = "Статус";
            // 
            // getting
            // 
            this.getting.AutoSize = true;
            this.getting.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getting.Location = new System.Drawing.Point(17, 212);
            this.getting.Name = "getting";
            this.getting.Size = new System.Drawing.Size(153, 22);
            this.getting.TabIndex = 8;
            this.getting.TabStop = true;
            this.getting.Text = "Выписываются";
            this.getting.UseVisualStyleBackColor = true;
            this.getting.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // occupied
            // 
            this.occupied.AutoSize = true;
            this.occupied.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.occupied.Location = new System.Drawing.Point(17, 181);
            this.occupied.Name = "occupied";
            this.occupied.Size = new System.Drawing.Size(93, 22);
            this.occupied.TabIndex = 7;
            this.occupied.TabStop = true;
            this.occupied.Text = "Заняты";
            this.occupied.UseVisualStyleBackColor = true;
            this.occupied.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // empty
            // 
            this.empty.AutoSize = true;
            this.empty.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.empty.Location = new System.Drawing.Point(17, 150);
            this.empty.Name = "empty";
            this.empty.Size = new System.Drawing.Size(123, 22);
            this.empty.TabIndex = 6;
            this.empty.TabStop = true;
            this.empty.Text = "Свободные";
            this.empty.UseVisualStyleBackColor = true;
            this.empty.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // booked
            // 
            this.booked.AutoSize = true;
            this.booked.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.booked.Location = new System.Drawing.Point(17, 119);
            this.booked.Name = "booked";
            this.booked.Size = new System.Drawing.Size(183, 22);
            this.booked.TabIndex = 5;
            this.booked.TabStop = true;
            this.booked.Text = "Зарезервировано";
            this.booked.UseVisualStyleBackColor = true;
            this.booked.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Teal;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(203, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(54, 30);
            this.textBox1.TabIndex = 9;
            // 
            // num_label
            // 
            this.num_label.AutoSize = true;
            this.num_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_label.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num_label.Location = new System.Drawing.Point(57, 26);
            this.num_label.Name = "num_label";
            this.num_label.Size = new System.Drawing.Size(112, 29);
            this.num_label.TabIndex = 8;
            this.num_label.Text = "Номер №";
            // 
            // co_label
            // 
            this.co_label.AutoSize = true;
            this.co_label.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.co_label.Location = new System.Drawing.Point(16, 486);
            this.co_label.Name = "co_label";
            this.co_label.Size = new System.Drawing.Size(152, 20);
            this.co_label.TabIndex = 7;
            this.co_label.Text = "Дата выезда :";
            // 
            // ci_label
            // 
            this.ci_label.AutoSize = true;
            this.ci_label.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ci_label.Location = new System.Drawing.Point(16, 398);
            this.ci_label.Name = "ci_label";
            this.ci_label.Size = new System.Drawing.Size(152, 20);
            this.ci_label.TabIndex = 6;
            this.ci_label.Text = "Дата заезда :";
            // 
            // checkout
            // 
            this.checkout.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkout.Location = new System.Drawing.Point(121, 509);
            this.checkout.Multiline = true;
            this.checkout.Name = "checkout";
            this.checkout.Size = new System.Drawing.Size(180, 50);
            this.checkout.TabIndex = 5;
            // 
            // checkin
            // 
            this.checkin.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkin.Location = new System.Drawing.Point(121, 421);
            this.checkin.Multiline = true;
            this.checkin.Name = "checkin";
            this.checkin.Size = new System.Drawing.Size(180, 50);
            this.checkin.TabIndex = 4;
            // 
            // name_textbox
            // 
            this.name_textbox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_textbox.Location = new System.Drawing.Point(20, 331);
            this.name_textbox.Multiline = true;
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(281, 50);
            this.name_textbox.TabIndex = 3;
            this.name_textbox.Text = "ФИО";
            this.name_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // status_combobox
            // 
            this.status_combobox.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.status_combobox.FormattingEnabled = true;
            this.status_combobox.Items.AddRange(new object[] {
            "Зарезервировано",
            "Свободные",
            "Заняты",
            "Выписываются"});
            this.status_combobox.Location = new System.Drawing.Point(121, 288);
            this.status_combobox.Name = "status_combobox";
            this.status_combobox.Size = new System.Drawing.Size(180, 26);
            this.status_combobox.TabIndex = 2;
            this.status_combobox.Text = "Статус";
            // 
            // st_label
            // 
            this.st_label.AutoSize = true;
            this.st_label.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.st_label.Location = new System.Drawing.Point(16, 290);
            this.st_label.Name = "st_label";
            this.st_label.Size = new System.Drawing.Size(97, 20);
            this.st_label.TabIndex = 1;
            this.st_label.Text = "Статус :";
            // 
            // u_pic
            // 
            this.u_pic.Location = new System.Drawing.Point(57, 66);
            this.u_pic.Name = "u_pic";
            this.u_pic.Size = new System.Drawing.Size(200, 200);
            this.u_pic.TabIndex = 0;
            this.u_pic.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 659);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Главная форма";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clients)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.u_pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.Button card;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox status_combobox;
        private System.Windows.Forms.Label st_label;
        private System.Windows.Forms.PictureBox u_pic;
        private System.Windows.Forms.Label list_label;
        private System.Windows.Forms.DataGridView clients;
        private System.Windows.Forms.RadioButton getting;
        private System.Windows.Forms.RadioButton occupied;
        private System.Windows.Forms.RadioButton empty;
        private System.Windows.Forms.RadioButton booked;
        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.Label co_label;
        private System.Windows.Forms.Label ci_label;
        private System.Windows.Forms.TextBox checkout;
        private System.Windows.Forms.TextBox checkin;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label num_label;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.TextBox textBox1;
    }
}

