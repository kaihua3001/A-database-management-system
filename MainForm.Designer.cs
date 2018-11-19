namespace StuDataManagementSystem
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.mainFormDataGridView = new System.Windows.Forms.DataGridView();
            this.mainFormDeleteBotton = new System.Windows.Forms.Button();
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.studentPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.studentGenderTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.studenBirthDateTextBox = new System.Windows.Forms.TextBox();
            this.studentChangeButton = new System.Windows.Forms.Button();
            this.mainFormSearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainFormDataGridView
            // 
            this.mainFormDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainFormDataGridView.Location = new System.Drawing.Point(88, 66);
            this.mainFormDataGridView.MultiSelect = false;
            this.mainFormDataGridView.Name = "mainFormDataGridView";
            this.mainFormDataGridView.ReadOnly = true;
            this.mainFormDataGridView.RowTemplate.Height = 37;
            this.mainFormDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainFormDataGridView.Size = new System.Drawing.Size(1169, 565);
            this.mainFormDataGridView.TabIndex = 0;
            this.mainFormDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mainFormDataGridView_CellContentClick);
            this.mainFormDataGridView.Click += new System.EventHandler(this.mainFormDataGridView_Click);
            this.mainFormDataGridView.DoubleClick += new System.EventHandler(this.mainFormDataGridView_DoubleClick);
            // 
            // mainFormDeleteBotton
            // 
            this.mainFormDeleteBotton.Location = new System.Drawing.Point(76, 757);
            this.mainFormDeleteBotton.Name = "mainFormDeleteBotton";
            this.mainFormDeleteBotton.Size = new System.Drawing.Size(263, 55);
            this.mainFormDeleteBotton.TabIndex = 1;
            this.mainFormDeleteBotton.Text = "Delete";
            this.mainFormDeleteBotton.UseVisualStyleBackColor = true;
            this.mainFormDeleteBotton.Click += new System.EventHandler(this.button1_Click);
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.Location = new System.Drawing.Point(547, 688);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(334, 35);
            this.studentNameTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(421, 691);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 752);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "PhoneNumber";
            // 
            // studentPhoneNumberTextBox
            // 
            this.studentPhoneNumberTextBox.Location = new System.Drawing.Point(547, 752);
            this.studentPhoneNumberTextBox.Name = "studentPhoneNumberTextBox";
            this.studentPhoneNumberTextBox.Size = new System.Drawing.Size(334, 35);
            this.studentPhoneNumberTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(910, 693);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Gender";
            // 
            // studentGenderTextBox
            // 
            this.studentGenderTextBox.Location = new System.Drawing.Point(1022, 688);
            this.studentGenderTextBox.Name = "studentGenderTextBox";
            this.studentGenderTextBox.Size = new System.Drawing.Size(334, 35);
            this.studentGenderTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(887, 757);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "BirthDate";
            // 
            // studenBirthDateTextBox
            // 
            this.studenBirthDateTextBox.Location = new System.Drawing.Point(1022, 752);
            this.studenBirthDateTextBox.Name = "studenBirthDateTextBox";
            this.studenBirthDateTextBox.Size = new System.Drawing.Size(334, 35);
            this.studenBirthDateTextBox.TabIndex = 8;
            // 
            // studentChangeButton
            // 
            this.studentChangeButton.Location = new System.Drawing.Point(76, 668);
            this.studentChangeButton.Name = "studentChangeButton";
            this.studentChangeButton.Size = new System.Drawing.Size(263, 55);
            this.studentChangeButton.TabIndex = 10;
            this.studentChangeButton.Text = "Change";
            this.studentChangeButton.UseVisualStyleBackColor = true;
            this.studentChangeButton.Click += new System.EventHandler(this.studentChangeButton_Click);
            // 
            // mainFormSearchButton
            // 
            this.mainFormSearchButton.Location = new System.Drawing.Point(88, 5);
            this.mainFormSearchButton.Name = "mainFormSearchButton";
            this.mainFormSearchButton.Size = new System.Drawing.Size(263, 55);
            this.mainFormSearchButton.TabIndex = 11;
            this.mainFormSearchButton.Text = "Search";
            this.mainFormSearchButton.UseVisualStyleBackColor = true;
            this.mainFormSearchButton.Click += new System.EventHandler(this.mainFormSearchButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 839);
            this.Controls.Add(this.mainFormSearchButton);
            this.Controls.Add(this.studentChangeButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.studenBirthDateTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.studentGenderTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.studentPhoneNumberTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentNameTextBox);
            this.Controls.Add(this.mainFormDeleteBotton);
            this.Controls.Add(this.mainFormDataGridView);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainFormDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView mainFormDataGridView;
        private System.Windows.Forms.Button mainFormDeleteBotton;
        private System.Windows.Forms.TextBox studentNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox studentPhoneNumberTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox studentGenderTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox studenBirthDateTextBox;
        private System.Windows.Forms.Button studentChangeButton;
        private System.Windows.Forms.Button mainFormSearchButton;
    }
}

