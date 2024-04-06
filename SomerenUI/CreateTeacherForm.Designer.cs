namespace SomerenUI
{
    partial class CreateTeacherForm
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            FirstNameTxt = new System.Windows.Forms.TextBox();
            LastNameTxt = new System.Windows.Forms.TextBox();
            PhonenumberTxt = new System.Windows.Forms.TextBox();
            SubmitButton = new System.Windows.Forms.Button();
            BirthDatePicker = new System.Windows.Forms.DateTimePicker();
            label5 = new System.Windows.Forms.Label();
            Roomtxt = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(98, 65);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(94, 25);
            label1.TabIndex = 0;
            label1.Text = "First name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(98, 109);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(92, 25);
            label2.TabIndex = 1;
            label2.Text = "Last name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(98, 154);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(124, 25);
            label3.TabIndex = 2;
            label3.Text = "Phonenumber";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(98, 200);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(112, 25);
            label4.TabIndex = 3;
            label4.Text = "Date of Birth";
            // 
            // FirstNameTxt
            // 
            FirstNameTxt.Location = new System.Drawing.Point(303, 65);
            FirstNameTxt.Name = "FirstNameTxt";
            FirstNameTxt.Size = new System.Drawing.Size(150, 31);
            FirstNameTxt.TabIndex = 6;
            // 
            // LastNameTxt
            // 
            LastNameTxt.Location = new System.Drawing.Point(303, 109);
            LastNameTxt.Name = "LastNameTxt";
            LastNameTxt.Size = new System.Drawing.Size(150, 31);
            LastNameTxt.TabIndex = 7;
            // 
            // PhonenumberTxt
            // 
            PhonenumberTxt.Location = new System.Drawing.Point(303, 154);
            PhonenumberTxt.Name = "PhonenumberTxt";
            PhonenumberTxt.Size = new System.Drawing.Size(150, 31);
            PhonenumberTxt.TabIndex = 8;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new System.Drawing.Point(195, 305);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new System.Drawing.Size(133, 48);
            SubmitButton.TabIndex = 10;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // BirthDatePicker
            // 
            BirthDatePicker.Location = new System.Drawing.Point(303, 200);
            BirthDatePicker.Name = "BirthDatePicker";
            BirthDatePicker.Size = new System.Drawing.Size(300, 31);
            BirthDatePicker.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(98, 252);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(60, 25);
            label5.TabIndex = 12;
            label5.Text = "Room";
            // 
            // Roomtxt
            // 
            Roomtxt.Location = new System.Drawing.Point(303, 252);
            Roomtxt.Name = "Roomtxt";
            Roomtxt.Size = new System.Drawing.Size(150, 31);
            Roomtxt.TabIndex = 13;
            // 
            // CreateTeacherForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
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
            Name = "CreateTeacherForm";
            Text = "CreateTeacherForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FirstNameTxt;
        private System.Windows.Forms.TextBox LastNameTxt;
        private System.Windows.Forms.TextBox PhonenumberTxt;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.DateTimePicker BirthDatePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Roomtxt;
    }
}