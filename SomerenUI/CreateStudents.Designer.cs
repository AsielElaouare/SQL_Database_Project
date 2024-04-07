namespace SomerenUI
{
    partial class CreateStudents
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
            firstNameBox = new System.Windows.Forms.TextBox();
            firstNameLbl = new System.Windows.Forms.Label();
            lastNameLbl = new System.Windows.Forms.Label();
            studentNumberLbl = new System.Windows.Forms.Label();
            phoneNumberLbl = new System.Windows.Forms.Label();
            studentClassLbl = new System.Windows.Forms.Label();
            phoneNumberBox = new System.Windows.Forms.TextBox();
            studentNumberBox = new System.Windows.Forms.TextBox();
            lastNameBox = new System.Windows.Forms.TextBox();
            studentClassBox = new System.Windows.Forms.TextBox();
            addStudentBtn = new System.Windows.Forms.Button();
            roomBox = new System.Windows.Forms.TextBox();
            roomLbl = new System.Windows.Forms.Label();
            updateBtn = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // firstNameBox
            // 
            firstNameBox.Location = new System.Drawing.Point(176, 42);
            firstNameBox.Name = "firstNameBox";
            firstNameBox.Size = new System.Drawing.Size(125, 27);
            firstNameBox.TabIndex = 0;
            // 
            // firstNameLbl
            // 
            firstNameLbl.AutoSize = true;
            firstNameLbl.Location = new System.Drawing.Point(55, 42);
            firstNameLbl.Name = "firstNameLbl";
            firstNameLbl.Size = new System.Drawing.Size(77, 20);
            firstNameLbl.TabIndex = 1;
            firstNameLbl.Text = "First name";
            // 
            // lastNameLbl
            // 
            lastNameLbl.AutoSize = true;
            lastNameLbl.Location = new System.Drawing.Point(55, 86);
            lastNameLbl.Name = "lastNameLbl";
            lastNameLbl.Size = new System.Drawing.Size(76, 20);
            lastNameLbl.TabIndex = 2;
            lastNameLbl.Text = "Last name";
            // 
            // studentNumberLbl
            // 
            studentNumberLbl.AutoSize = true;
            studentNumberLbl.Location = new System.Drawing.Point(55, 130);
            studentNumberLbl.Name = "studentNumberLbl";
            studentNumberLbl.Size = new System.Drawing.Size(115, 20);
            studentNumberLbl.TabIndex = 3;
            studentNumberLbl.Text = "Student number";
            // 
            // phoneNumberLbl
            // 
            phoneNumberLbl.AutoSize = true;
            phoneNumberLbl.Location = new System.Drawing.Point(55, 176);
            phoneNumberLbl.Name = "phoneNumberLbl";
            phoneNumberLbl.Size = new System.Drawing.Size(105, 20);
            phoneNumberLbl.TabIndex = 4;
            phoneNumberLbl.Text = "Phone number";
            // 
            // studentClassLbl
            // 
            studentClassLbl.AutoSize = true;
            studentClassLbl.Location = new System.Drawing.Point(55, 218);
            studentClassLbl.Name = "studentClassLbl";
            studentClassLbl.Size = new System.Drawing.Size(95, 20);
            studentClassLbl.TabIndex = 5;
            studentClassLbl.Text = "Student class";
            // 
            // phoneNumberBox
            // 
            phoneNumberBox.Location = new System.Drawing.Point(176, 176);
            phoneNumberBox.Name = "phoneNumberBox";
            phoneNumberBox.Size = new System.Drawing.Size(125, 27);
            phoneNumberBox.TabIndex = 6;
            // 
            // studentNumberBox
            // 
            studentNumberBox.Location = new System.Drawing.Point(176, 130);
            studentNumberBox.Name = "studentNumberBox";
            studentNumberBox.Size = new System.Drawing.Size(125, 27);
            studentNumberBox.TabIndex = 7;
            // 
            // lastNameBox
            // 
            lastNameBox.Location = new System.Drawing.Point(176, 86);
            lastNameBox.Name = "lastNameBox";
            lastNameBox.Size = new System.Drawing.Size(125, 27);
            lastNameBox.TabIndex = 8;
            // 
            // studentClassBox
            // 
            studentClassBox.Location = new System.Drawing.Point(176, 220);
            studentClassBox.Name = "studentClassBox";
            studentClassBox.Size = new System.Drawing.Size(125, 27);
            studentClassBox.TabIndex = 9;
            // 
            // addStudentBtn
            // 
            addStudentBtn.Location = new System.Drawing.Point(353, 155);
            addStudentBtn.Name = "addStudentBtn";
            addStudentBtn.Size = new System.Drawing.Size(123, 29);
            addStudentBtn.TabIndex = 10;
            addStudentBtn.Text = "Add Student";
            addStudentBtn.UseVisualStyleBackColor = true;
            addStudentBtn.Click += addStudentBtn_Click;
            // 
            // roomBox
            // 
            roomBox.Location = new System.Drawing.Point(176, 271);
            roomBox.Name = "roomBox";
            roomBox.Size = new System.Drawing.Size(125, 27);
            roomBox.TabIndex = 11;
            // 
            // roomLbl
            // 
            roomLbl.AutoSize = true;
            roomLbl.Location = new System.Drawing.Point(65, 274);
            roomLbl.Name = "roomLbl";
            roomLbl.Size = new System.Drawing.Size(49, 20);
            roomLbl.TabIndex = 12;
            roomLbl.Text = "Room";
            // 
            // updateBtn
            // 
            updateBtn.Location = new System.Drawing.Point(353, 231);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new System.Drawing.Size(123, 29);
            updateBtn.TabIndex = 13;
            updateBtn.Text = "Update Student";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // CreateStudents
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(692, 482);
            Controls.Add(updateBtn);
            Controls.Add(roomLbl);
            Controls.Add(roomBox);
            Controls.Add(addStudentBtn);
            Controls.Add(studentClassBox);
            Controls.Add(lastNameBox);
            Controls.Add(studentNumberBox);
            Controls.Add(phoneNumberBox);
            Controls.Add(studentClassLbl);
            Controls.Add(phoneNumberLbl);
            Controls.Add(studentNumberLbl);
            Controls.Add(lastNameLbl);
            Controls.Add(firstNameLbl);
            Controls.Add(firstNameBox);
            Name = "CreateStudents";
            Text = "addStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.Label studentNumberLbl;
        private System.Windows.Forms.Label phoneNumberLbl;
        private System.Windows.Forms.Label studentClassLbl;
        private System.Windows.Forms.TextBox phoneNumberBox;
        private System.Windows.Forms.TextBox studentNumberBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox studentClassBox;
        private System.Windows.Forms.Button addStudentBtn;
        private System.Windows.Forms.TextBox roomBox;
        private System.Windows.Forms.Label roomLbl;
        private System.Windows.Forms.Button updateBtn;
    }
}