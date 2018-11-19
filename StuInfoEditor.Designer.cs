namespace StuDataManagementSystem
{
    partial class StuInfoEditorForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.studenBirthDateTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.studentGenderTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.studentPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.studentChangeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "BirthDate";
            // 
            // studenBirthDateTextBox
            // 
            this.studenBirthDateTextBox.Location = new System.Drawing.Point(398, 304);
            this.studenBirthDateTextBox.Name = "studenBirthDateTextBox";
            this.studenBirthDateTextBox.Size = new System.Drawing.Size(334, 35);
            this.studenBirthDateTextBox.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Gender";
            // 
            // studentGenderTextBox
            // 
            this.studentGenderTextBox.Location = new System.Drawing.Point(398, 173);
            this.studentGenderTextBox.Name = "studentGenderTextBox";
            this.studentGenderTextBox.Size = new System.Drawing.Size(334, 35);
            this.studentGenderTextBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "PhoneNumber";
            // 
            // studentPhoneNumberTextBox
            // 
            this.studentPhoneNumberTextBox.Location = new System.Drawing.Point(398, 455);
            this.studentPhoneNumberTextBox.Name = "studentPhoneNumberTextBox";
            this.studentPhoneNumberTextBox.Size = new System.Drawing.Size(334, 35);
            this.studentPhoneNumberTextBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Username";
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.Location = new System.Drawing.Point(398, 51);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(334, 35);
            this.studentNameTextBox.TabIndex = 10;
            // 
            // studentChangeButton
            // 
            this.studentChangeButton.Location = new System.Drawing.Point(407, 624);
            this.studentChangeButton.Name = "studentChangeButton";
            this.studentChangeButton.Size = new System.Drawing.Size(263, 55);
            this.studentChangeButton.TabIndex = 18;
            this.studentChangeButton.Text = "Change";
            this.studentChangeButton.UseVisualStyleBackColor = true;
            this.studentChangeButton.Click += new System.EventHandler(this.studentChangeButton_Click);
            // 
            // StuInfoEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 769);
            this.Controls.Add(this.studentChangeButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.studenBirthDateTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.studentGenderTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.studentPhoneNumberTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentNameTextBox);
            this.Name = "StuInfoEditorForm";
            this.Text = "StuInfoEditor";
            this.Load += new System.EventHandler(this.StuInfoEditorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox studenBirthDateTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox studentGenderTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox studentPhoneNumberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox studentNameTextBox;
        private System.Windows.Forms.Button studentChangeButton;
    }
}