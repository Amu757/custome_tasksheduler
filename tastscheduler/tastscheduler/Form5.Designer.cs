namespace tastscheduler
{
    partial class Form5
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
            btn1 = new Button();
            toexecute = new ComboBox();
            label1 = new Label();
            dateinput = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            txtmin = new ComboBox();
            label4 = new Label();
            txthour = new ComboBox();
            firstrepeat = new ComboBox();
            label6 = new Label();
            repeatdate = new NumericUpDown();
            label7 = new Label();
            checkBox6 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            repeathours = new NumericUpDown();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)repeatdate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repeathours).BeginInit();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.BackColor = Color.Chartreuse;
            btn1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn1.Location = new Point(92, 446);
            btn1.Name = "btn1";
            btn1.Size = new Size(248, 44);
            btn1.TabIndex = 9;
            btn1.Text = "submit";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // toexecute
            // 
            toexecute.FormattingEnabled = true;
            toexecute.Items.AddRange(new object[] { "C:\\Windows\\notepad.exe", "C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe", "C:\\Program Files\\BraveSoftware\\Brave-Browser\\Application\\brave.exe", "C:\\Windows\\System32\\Tasks\\Rapidigital_events\\shutdown.bat" });
            toexecute.Location = new Point(459, 53);
            toexecute.Name = "toexecute";
            toexecute.Size = new Size(148, 23);
            toexecute.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(289, 53);
            label1.Name = "label1";
            label1.Size = new Size(164, 23);
            label1.TabIndex = 11;
            label1.Text = "Event to be trigger";
            // 
            // dateinput
            // 
            dateinput.Location = new Point(463, 112);
            dateinput.Name = "dateinput";
            dateinput.Size = new Size(144, 23);
            dateinput.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(295, 111);
            label2.Name = "label2";
            label2.Size = new Size(104, 23);
            label2.TabIndex = 13;
            label2.Text = "trigger date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(295, 164);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 32;
            label3.Text = "To Trigger ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(462, 186);
            label5.Name = "label5";
            label5.Size = new Size(45, 25);
            label5.TabIndex = 31;
            label5.Text = "Min";
            // 
            // txtmin
            // 
            txtmin.FormattingEnabled = true;
            txtmin.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60" });
            txtmin.Location = new Point(517, 188);
            txtmin.Name = "txtmin";
            txtmin.Size = new Size(90, 23);
            txtmin.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(293, 186);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 29;
            label4.Text = "Hour";
            // 
            // txthour
            // 
            txthour.FormattingEnabled = true;
            txthour.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24" });
            txthour.Location = new Point(353, 188);
            txthour.Name = "txthour";
            txthour.Size = new Size(90, 23);
            txthour.TabIndex = 28;
            // 
            // firstrepeat
            // 
            firstrepeat.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            firstrepeat.FormattingEnabled = true;
            firstrepeat.Items.AddRange(new object[] { "Daily", "Weekly", "Monthly" });
            firstrepeat.Location = new Point(295, 268);
            firstrepeat.Name = "firstrepeat";
            firstrepeat.Size = new Size(120, 26);
            firstrepeat.TabIndex = 34;
            firstrepeat.SelectedIndexChanged += firstrepeat_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(292, 247);
            label6.Name = "label6";
            label6.Size = new Size(55, 18);
            label6.TabIndex = 33;
            label6.Text = "Repeat";
            // 
            // repeatdate
            // 
            repeatdate.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            repeatdate.Location = new Point(492, 269);
            repeatdate.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            repeatdate.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            repeatdate.Name = "repeatdate";
            repeatdate.Size = new Size(120, 24);
            repeatdate.TabIndex = 41;
            repeatdate.Value = new decimal(new int[] { 1, 0, 0, 0 });
            repeatdate.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(432, 278);
            label7.Name = "label7";
            label7.Size = new Size(45, 18);
            label7.TabIndex = 40;
            label7.Text = "Every";
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox6.Location = new Point(477, 337);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(85, 22);
            checkBox6.TabIndex = 48;
            checkBox6.Text = "Saturday";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox7.Location = new Point(314, 365);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(76, 22);
            checkBox7.TabIndex = 47;
            checkBox7.Text = "Sunday";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox5.Location = new Point(403, 337);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(67, 22);
            checkBox5.TabIndex = 46;
            checkBox5.Text = "Friday";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox4.Location = new Point(314, 337);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(88, 22);
            checkBox4.TabIndex = 45;
            checkBox4.Text = "Thursday";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox3.Location = new Point(491, 312);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(105, 22);
            checkBox3.TabIndex = 44;
            checkBox3.Text = "Wednesday";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox2.Location = new Point(403, 312);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(83, 22);
            checkBox2.TabIndex = 43;
            checkBox2.Text = "Tuesday";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(314, 312);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(80, 22);
            checkBox1.TabIndex = 42;
            checkBox1.Text = "Monday";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // repeathours
            // 
            repeathours.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            repeathours.Location = new Point(402, 416);
            repeathours.Name = "repeathours";
            repeathours.Size = new Size(120, 24);
            repeathours.TabIndex = 51;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(456, 395);
            label8.Name = "label8";
            label8.Size = new Size(41, 18);
            label8.TabIndex = 50;
            label8.Text = "Hour";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(401, 394);
            label9.Name = "label9";
            label9.Size = new Size(45, 18);
            label9.TabIndex = 49;
            label9.Text = "Every";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(507, 247);
            label10.Name = "label10";
            label10.Size = new Size(36, 18);
            label10.TabIndex = 52;
            label10.Text = "date";
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(366, 446);
            button1.Name = "button1";
            button1.Size = new Size(211, 44);
            button1.TabIndex = 53;
            button1.Text = "Backup now";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(602, 446);
            button2.Name = "button2";
            button2.Size = new Size(211, 44);
            button2.TabIndex = 54;
            button2.Text = "delete old files";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 600);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(repeathours);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(checkBox6);
            Controls.Add(checkBox7);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(repeatdate);
            Controls.Add(label7);
            Controls.Add(firstrepeat);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(txtmin);
            Controls.Add(label4);
            Controls.Add(txthour);
            Controls.Add(label2);
            Controls.Add(dateinput);
            Controls.Add(label1);
            Controls.Add(toexecute);
            Controls.Add(btn1);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)repeatdate).EndInit();
            ((System.ComponentModel.ISupportInitialize)repeathours).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private ComboBox toexecute;
        private Label label1;
        private DateTimePicker dateinput;
        private Label label2;
        private Label label3;
        private Label label5;
        private ComboBox txtmin;
        private Label label4;
        private ComboBox txthour;
        private ComboBox firstrepeat;
        private Label label6;
        private NumericUpDown repeatdate;
        private Label label7;
        private CheckBox checkBox6;
        private CheckBox checkBox7;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private NumericUpDown repeathours;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button button1;
        private Button button2;
    }
}