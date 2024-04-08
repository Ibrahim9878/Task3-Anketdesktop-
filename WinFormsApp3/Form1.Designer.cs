namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            buttonChange = new Button();
            Add = new Button();
            dateTimePicker1 = new DateTimePicker();
            PhoneBox = new TextBox();
            MailBox = new TextBox();
            SurnameBox = new TextBox();
            NameBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            listBox1 = new ListBox();
            buttonLoad = new Button();
            buttonSave = new Button();
            FileBox = new TextBox();
            label6 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonChange);
            groupBox1.Controls.Add(Add);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(PhoneBox);
            groupBox1.Controls.Add(MailBox);
            groupBox1.Controls.Add(SurnameBox);
            groupBox1.Controls.Add(NameBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(355, 368);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Anket";
            // 
            // buttonChange
            // 
            buttonChange.Location = new Point(237, 292);
            buttonChange.Name = "buttonChange";
            buttonChange.Size = new Size(82, 32);
            buttonChange.TabIndex = 11;
            buttonChange.Text = "Change";
            buttonChange.UseVisualStyleBackColor = true;
            buttonChange.Click += buttonChange_Click;
            // 
            // Add
            // 
            Add.Location = new Point(237, 330);
            Add.Name = "Add";
            Add.Size = new Size(82, 32);
            Add.TabIndex = 10;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(87, 189);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 9;
            // 
            // PhoneBox
            // 
            PhoneBox.Location = new Point(86, 149);
            PhoneBox.Name = "PhoneBox";
            PhoneBox.PlaceholderText = "Phone";
            PhoneBox.Size = new Size(201, 23);
            PhoneBox.TabIndex = 8;
            // 
            // MailBox
            // 
            MailBox.Location = new Point(86, 113);
            MailBox.Name = "MailBox";
            MailBox.PlaceholderText = "Email";
            MailBox.Size = new Size(201, 23);
            MailBox.TabIndex = 7;
            // 
            // SurnameBox
            // 
            SurnameBox.Location = new Point(86, 74);
            SurnameBox.Name = "SurnameBox";
            SurnameBox.PlaceholderText = "Surname";
            SurnameBox.Size = new Size(201, 23);
            SurnameBox.TabIndex = 6;
            // 
            // NameBox
            // 
            NameBox.Location = new Point(86, 38);
            NameBox.Name = "NameBox";
            NameBox.PlaceholderText = "Name";
            NameBox.Size = new Size(201, 23);
            NameBox.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(6, 189);
            label5.Name = "label5";
            label5.Size = new Size(62, 21);
            label5.TabIndex = 4;
            label5.Text = "Dogum";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(9, 149);
            label4.Name = "label4";
            label4.Size = new Size(28, 21);
            label4.TabIndex = 3;
            label4.Text = "Tel";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 113);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 77);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 1;
            label2.Text = "Soyad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 41);
            label1.Name = "label1";
            label1.Size = new Size(29, 21);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(373, 33);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(202, 289);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(373, 366);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(74, 26);
            buttonLoad.TabIndex = 12;
            buttonLoad.Text = "Load";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(453, 366);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(106, 26);
            buttonSave.TabIndex = 13;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // FileBox
            // 
            FileBox.Location = new Point(373, 337);
            FileBox.Name = "FileBox";
            FileBox.PlaceholderText = "File Name";
            FileBox.Size = new Size(186, 23);
            FileBox.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(442, 15);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 15;
            label6.Text = "Users";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 398);
            Controls.Add(label6);
            Controls.Add(FileBox);
            Controls.Add(buttonSave);
            Controls.Add(buttonLoad);
            Controls.Add(listBox1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox listBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button Add;
        private DateTimePicker dateTimePicker1;
        private TextBox PhoneBox;
        private TextBox MailBox;
        private TextBox SurnameBox;
        private TextBox NameBox;
        private Label label5;
        private Button buttonChange;
        private Button buttonLoad;
        private Button buttonSave;
        private TextBox FileBox;
        private Label label6;
    }
}