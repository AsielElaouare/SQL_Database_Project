namespace SomerenUI
{
    partial class UpdateTeacherForm
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
            Roomtxt = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            BirthDatePicker = new System.Windows.Forms.DateTimePicker();
            SubmitButton = new System.Windows.Forms.Button();
            PhonenumberTxt = new System.Windows.Forms.TextBox();
            LastNameTxt = new System.Windows.Forms.TextBox();
            FirstNameTxt = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            IdComboBox = new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // Roomtxt
            // 
            Roomtxt.Location = new System.Drawing.Point(353, 268);
            Roomtxt.Name = "Roomtxt";
            Roomtxt.Size = new System.Drawing.Size(150, 31);
            Roomtxt.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(148, 268);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(60, 25);
            label5.TabIndex = 23;
            label5.Text = "Room";
            // 
            // BirthDatePicker
            // 
            BirthDatePicker.Location = new System.Drawing.Point(353, 216);
            BirthDatePicker.Name = "BirthDatePicker";
            BirthDatePicker.Size = new System.Drawing.Size(300, 31);
            BirthDatePicker.TabIndex = 22;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new System.Drawing.Point(245, 321);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new System.Drawing.Size(133, 48);
            SubmitButton.TabIndex = 21;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // PhonenumberTxt
            // 
            PhonenumberTxt.Location = new System.Drawing.Point(353, 170);
            PhonenumberTxt.Name = "PhonenumberTxt";
            PhonenumberTxt.Size = new System.Drawing.Size(150, 31);
            PhonenumberTxt.TabIndex = 20;
            // 
            // LastNameTxt
            // 
            LastNameTxt.Location = new System.Drawing.Point(353, 125);
            LastNameTxt.Name = "LastNameTxt";
            LastNameTxt.Size = new System.Drawing.Size(150, 31);
            LastNameTxt.TabIndex = 19;
            // 
            // FirstNameTxt
            // 
            FirstNameTxt.Location = new System.Drawing.Point(353, 81);
            FirstNameTxt.Name = "FirstNameTxt";
            FirstNameTxt.Size = new System.Drawing.Size(150, 31);
            FirstNameTxt.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(148, 216);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(112, 25);
            label4.TabIndex = 17;
            label4.Text = "Date of Birth";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(148, 170);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(124, 25);
            label3.TabIndex = 16;
            label3.Text = "Phonenumber";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(148, 125);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(92, 25);
            label2.TabIndex = 15;
            label2.Text = "Last name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(148, 81);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(94, 25);
            label1.TabIndex = 14;
            label1.Text = "First name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(148, 45);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(30, 25);
            label6.TabIndex = 25;
            label6.Text = "ID";
            // 
            // IdComboBox
            // 
            IdComboBox.FormattingEnabled = true;
            IdComboBox.Location = new System.Drawing.Point(353, 37);
            IdComboBox.Name = "IdComboBox";
            IdComboBox.Size = new System.Drawing.Size(150, 33);
            IdComboBox.TabIndex = 26;
            IdComboBox.SelectedIndexChanged += IdComboBox_SelectedIndexChanged;
            // 
            // UpdateTeacherForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(IdComboBox);
            Controls.Add(label6);
            Controls.Add(Roomtxt);
            Controls.Add(label5);
            Controls.Add(BirthDatePicker);
            Controls.Add(SubmitButton);
            Controls.Add(PhonenumberTxt);
            Controls.Add(LastNameTxt);
            Controls.Add(FirstNameTxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdateTeacherForm";
            Text = "UpdateTeacherForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox Roomtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker BirthDatePicker;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.TextBox PhonenumberTxt;
        private System.Windows.Forms.TextBox LastNameTxt;
        private System.Windows.Forms.TextBox FirstNameTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox IdComboBox;
    }
}