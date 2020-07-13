namespace video_RentalAssign26
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Cus_delete = new System.Windows.Forms.Button();
            this.Cus_update = new System.Windows.Forms.Button();
            this.cus_add = new System.Windows.Forms.Button();
            this.addres_cus = new System.Windows.Forms.TextBox();
            this.ph_cus = new System.Windows.Forms.TextBox();
            this.email_cus = new System.Windows.Forms.TextBox();
            this.name_cus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpReturn = new System.Windows.Forms.DateTimePicker();
            this.dtpIssue = new System.Windows.Forms.DateTimePicker();
            this.delete_rental = new System.Windows.Forms.Button();
            this.return_rental = new System.Windows.Forms.Button();
            this.Rental_issue = new System.Windows.Forms.Button();
            this.mov_RenID = new System.Windows.Forms.TextBox();
            this.Rent_cusID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.mov_genre = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.mov_plot = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.mov_copies = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.mov_cost = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.mov_year = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mov_rate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Mov_title = new System.Windows.Forms.TextBox();
            this.Database = new System.Windows.Forms.DataGridView();
            this.cus_data = new System.Windows.Forms.Button();
            this.video_data = new System.Windows.Forms.Button();
            this.rental_data = new System.Windows.Forms.Button();
            this.best_video = new System.Windows.Forms.Button();
            this.best_cus = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Database)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Cus_delete);
            this.groupBox1.Controls.Add(this.Cus_update);
            this.groupBox1.Controls.Add(this.cus_add);
            this.groupBox1.Controls.Add(this.addres_cus);
            this.groupBox1.Controls.Add(this.ph_cus);
            this.groupBox1.Controls.Add(this.email_cus);
            this.groupBox1.Controls.Add(this.name_cus);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "About Customer ";
            // 
            // Cus_delete
            // 
            this.Cus_delete.Location = new System.Drawing.Point(277, 126);
            this.Cus_delete.Name = "Cus_delete";
            this.Cus_delete.Size = new System.Drawing.Size(75, 23);
            this.Cus_delete.TabIndex = 10;
            this.Cus_delete.Text = "Delete";
            this.Cus_delete.UseVisualStyleBackColor = true;
            this.Cus_delete.Click += new System.EventHandler(this.Cus_delete_Click);
            // 
            // Cus_update
            // 
            this.Cus_update.Location = new System.Drawing.Point(277, 80);
            this.Cus_update.Name = "Cus_update";
            this.Cus_update.Size = new System.Drawing.Size(75, 23);
            this.Cus_update.TabIndex = 9;
            this.Cus_update.Text = "Update";
            this.Cus_update.UseVisualStyleBackColor = true;
            this.Cus_update.Click += new System.EventHandler(this.Cus_update_Click);
            // 
            // cus_add
            // 
            this.cus_add.Location = new System.Drawing.Point(277, 32);
            this.cus_add.Name = "cus_add";
            this.cus_add.Size = new System.Drawing.Size(75, 23);
            this.cus_add.TabIndex = 8;
            this.cus_add.Text = "Add ";
            this.cus_add.UseVisualStyleBackColor = true;
            this.cus_add.Click += new System.EventHandler(this.cus_add_Click);
            // 
            // addres_cus
            // 
            this.addres_cus.Location = new System.Drawing.Point(126, 146);
            this.addres_cus.Name = "addres_cus";
            this.addres_cus.Size = new System.Drawing.Size(127, 20);
            this.addres_cus.TabIndex = 7;
            // 
            // ph_cus
            // 
            this.ph_cus.Location = new System.Drawing.Point(126, 105);
            this.ph_cus.Name = "ph_cus";
            this.ph_cus.Size = new System.Drawing.Size(127, 20);
            this.ph_cus.TabIndex = 6;
            // 
            // email_cus
            // 
            this.email_cus.Location = new System.Drawing.Point(126, 67);
            this.email_cus.Name = "email_cus";
            this.email_cus.Size = new System.Drawing.Size(127, 20);
            this.email_cus.TabIndex = 5;
            this.email_cus.TextChanged += new System.EventHandler(this.email_cus_TextChanged);
            // 
            // name_cus
            // 
            this.name_cus.Location = new System.Drawing.Point(126, 32);
            this.name_cus.Name = "name_cus";
            this.name_cus.Size = new System.Drawing.Size(127, 20);
            this.name_cus.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpReturn);
            this.groupBox2.Controls.Add(this.dtpIssue);
            this.groupBox2.Controls.Add(this.delete_rental);
            this.groupBox2.Controls.Add(this.return_rental);
            this.groupBox2.Controls.Add(this.Rental_issue);
            this.groupBox2.Controls.Add(this.mov_RenID);
            this.groupBox2.Controls.Add(this.Rent_cusID);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(416, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 181);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "About Rentals";
            // 
            // dtpReturn
            // 
            this.dtpReturn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturn.Location = new System.Drawing.Point(144, 143);
            this.dtpReturn.Name = "dtpReturn";
            this.dtpReturn.Size = new System.Drawing.Size(127, 20);
            this.dtpReturn.TabIndex = 12;
            // 
            // dtpIssue
            // 
            this.dtpIssue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIssue.Location = new System.Drawing.Point(144, 104);
            this.dtpIssue.Name = "dtpIssue";
            this.dtpIssue.Size = new System.Drawing.Size(127, 20);
            this.dtpIssue.TabIndex = 11;
            // 
            // delete_rental
            // 
            this.delete_rental.Location = new System.Drawing.Point(312, 102);
            this.delete_rental.Name = "delete_rental";
            this.delete_rental.Size = new System.Drawing.Size(75, 23);
            this.delete_rental.TabIndex = 10;
            this.delete_rental.Text = "Delete";
            this.delete_rental.UseVisualStyleBackColor = true;
            this.delete_rental.Click += new System.EventHandler(this.delete_rental_Click);
            // 
            // return_rental
            // 
            this.return_rental.Location = new System.Drawing.Point(312, 67);
            this.return_rental.Name = "return_rental";
            this.return_rental.Size = new System.Drawing.Size(75, 23);
            this.return_rental.TabIndex = 9;
            this.return_rental.Text = "Return";
            this.return_rental.UseVisualStyleBackColor = true;
            this.return_rental.Click += new System.EventHandler(this.return_rental_Click);
            // 
            // Rental_issue
            // 
            this.Rental_issue.Location = new System.Drawing.Point(312, 32);
            this.Rental_issue.Name = "Rental_issue";
            this.Rental_issue.Size = new System.Drawing.Size(75, 23);
            this.Rental_issue.TabIndex = 8;
            this.Rental_issue.Text = "Issue";
            this.Rental_issue.UseVisualStyleBackColor = true;
            this.Rental_issue.Click += new System.EventHandler(this.Rental_issue_Click);
            // 
            // mov_RenID
            // 
            this.mov_RenID.Location = new System.Drawing.Point(144, 66);
            this.mov_RenID.Name = "mov_RenID";
            this.mov_RenID.Size = new System.Drawing.Size(127, 20);
            this.mov_RenID.TabIndex = 5;
            // 
            // Rent_cusID
            // 
            this.Rent_cusID.Location = new System.Drawing.Point(144, 31);
            this.Rent_cusID.Name = "Rent_cusID";
            this.Rent_cusID.Size = new System.Drawing.Size(127, 20);
            this.Rent_cusID.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Movie ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Issue Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "Return Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Customer ID";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.mov_genre);
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.mov_plot);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.mov_copies);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.mov_cost);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.mov_year);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.mov_rate);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.Mov_title);
            this.groupBox3.Location = new System.Drawing.Point(25, 220);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(783, 145);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "About Video";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(668, 86);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 15;
            this.button7.Text = "Delete";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(540, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 24);
            this.label15.TabIndex = 21;
            this.label15.Text = "Genre";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(558, 103);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 14;
            this.button8.Text = "Update";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // mov_genre
            // 
            this.mov_genre.Location = new System.Drawing.Point(644, 35);
            this.mov_genre.Name = "mov_genre";
            this.mov_genre.Size = new System.Drawing.Size(127, 20);
            this.mov_genre.TabIndex = 22;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(558, 68);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 13;
            this.button9.Text = "Add ";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(294, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 24);
            this.label12.TabIndex = 17;
            this.label12.Text = "Plot";
            // 
            // mov_plot
            // 
            this.mov_plot.Location = new System.Drawing.Point(398, 108);
            this.mov_plot.Name = "mov_plot";
            this.mov_plot.Size = new System.Drawing.Size(127, 20);
            this.mov_plot.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(294, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 24);
            this.label13.TabIndex = 16;
            this.label13.Text = "Copies";
            // 
            // mov_copies
            // 
            this.mov_copies.Location = new System.Drawing.Point(398, 70);
            this.mov_copies.Name = "mov_copies";
            this.mov_copies.Size = new System.Drawing.Size(127, 20);
            this.mov_copies.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(294, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 24);
            this.label14.TabIndex = 15;
            this.label14.Text = "Cost";
            // 
            // mov_cost
            // 
            this.mov_cost.Enabled = false;
            this.mov_cost.Location = new System.Drawing.Point(398, 35);
            this.mov_cost.Name = "mov_cost";
            this.mov_cost.Size = new System.Drawing.Size(127, 20);
            this.mov_cost.TabIndex = 18;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(128, 149);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(127, 20);
            this.textBox5.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(24, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 24);
            this.label11.TabIndex = 4;
            this.label11.Text = "Year";
            // 
            // mov_year
            // 
            this.mov_year.Location = new System.Drawing.Point(128, 108);
            this.mov_year.Name = "mov_year";
            this.mov_year.Size = new System.Drawing.Size(127, 20);
            this.mov_year.TabIndex = 13;
            this.mov_year.TextChanged += new System.EventHandler(this.mov_year_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 24);
            this.label10.TabIndex = 3;
            this.label10.Text = "Rate";
            // 
            // mov_rate
            // 
            this.mov_rate.Location = new System.Drawing.Point(128, 70);
            this.mov_rate.Name = "mov_rate";
            this.mov_rate.Size = new System.Drawing.Size(127, 20);
            this.mov_rate.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 24);
            this.label9.TabIndex = 2;
            this.label9.Text = "Title";
            // 
            // Mov_title
            // 
            this.Mov_title.Location = new System.Drawing.Point(128, 35);
            this.Mov_title.Name = "Mov_title";
            this.Mov_title.Size = new System.Drawing.Size(127, 20);
            this.Mov_title.TabIndex = 11;
            // 
            // Database
            // 
            this.Database.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Database.Location = new System.Drawing.Point(27, 386);
            this.Database.Name = "Database";
            this.Database.Size = new System.Drawing.Size(741, 150);
            this.Database.TabIndex = 13;
            this.Database.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Database_CellClick);
            this.Database.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Database_CellContentClick);
            // 
            // cus_data
            // 
            this.cus_data.Location = new System.Drawing.Point(774, 429);
            this.cus_data.Name = "cus_data";
            this.cus_data.Size = new System.Drawing.Size(75, 23);
            this.cus_data.TabIndex = 25;
            this.cus_data.Text = "Customers";
            this.cus_data.UseVisualStyleBackColor = true;
            this.cus_data.Click += new System.EventHandler(this.cus_data_Click);
            // 
            // video_data
            // 
            this.video_data.Location = new System.Drawing.Point(774, 400);
            this.video_data.Name = "video_data";
            this.video_data.Size = new System.Drawing.Size(75, 23);
            this.video_data.TabIndex = 24;
            this.video_data.Text = "Videos";
            this.video_data.UseVisualStyleBackColor = true;
            this.video_data.Click += new System.EventHandler(this.video_data_Click);
            // 
            // rental_data
            // 
            this.rental_data.Location = new System.Drawing.Point(774, 458);
            this.rental_data.Name = "rental_data";
            this.rental_data.Size = new System.Drawing.Size(75, 23);
            this.rental_data.TabIndex = 23;
            this.rental_data.Text = "Rentals";
            this.rental_data.UseVisualStyleBackColor = true;
            this.rental_data.Click += new System.EventHandler(this.rental_data_Click);
            // 
            // best_video
            // 
            this.best_video.Location = new System.Drawing.Point(416, 542);
            this.best_video.Name = "best_video";
            this.best_video.Size = new System.Drawing.Size(89, 23);
            this.best_video.TabIndex = 26;
            this.best_video.Text = "Best Video";
            this.best_video.UseVisualStyleBackColor = true;
            this.best_video.Click += new System.EventHandler(this.best_video_Click);
            // 
            // best_cus
            // 
            this.best_cus.Location = new System.Drawing.Point(246, 542);
            this.best_cus.Name = "best_cus";
            this.best_cus.Size = new System.Drawing.Size(133, 23);
            this.best_cus.TabIndex = 27;
            this.best_cus.Text = "Best Customer";
            this.best_cus.UseVisualStyleBackColor = true;
            this.best_cus.Click += new System.EventHandler(this.best_cus_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(887, 568);
            this.Controls.Add(this.best_cus);
            this.Controls.Add(this.best_video);
            this.Controls.Add(this.cus_data);
            this.Controls.Add(this.video_data);
            this.Controls.Add(this.Database);
            this.Controls.Add(this.rental_data);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Database)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Cus_delete;
        private System.Windows.Forms.Button Cus_update;
        private System.Windows.Forms.Button cus_add;
        private System.Windows.Forms.TextBox addres_cus;
        private System.Windows.Forms.TextBox ph_cus;
        private System.Windows.Forms.TextBox email_cus;
        private System.Windows.Forms.TextBox name_cus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpReturn;
        private System.Windows.Forms.DateTimePicker dtpIssue;
        private System.Windows.Forms.Button delete_rental;
        private System.Windows.Forms.Button return_rental;
        private System.Windows.Forms.Button Rental_issue;
        private System.Windows.Forms.TextBox mov_RenID;
        private System.Windows.Forms.TextBox Rent_cusID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox mov_genre;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox mov_plot;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox mov_copies;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox mov_cost;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox mov_year;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox mov_rate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Mov_title;
        private System.Windows.Forms.DataGridView Database;
        private System.Windows.Forms.Button cus_data;
        private System.Windows.Forms.Button video_data;
        private System.Windows.Forms.Button rental_data;
        private System.Windows.Forms.Button best_video;
        private System.Windows.Forms.Button best_cus;
    }
}