﻿namespace YearlyAcademicPlan
{
    partial class AddCourse
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 32);
            label1.Name = "label1";
            label1.Size = new Size(164, 32);
            label1.TabIndex = 0;
            label1.Text = "Course Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 111);
            label2.Name = "label2";
            label2.Size = new Size(174, 32);
            label2.TabIndex = 1;
            label2.Text = "Course Credits:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 190);
            label3.Name = "label3";
            label3.Size = new Size(277, 32);
            label3.TabIndex = 2;
            label3.Text = "Preceding Course Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 261);
            label4.Name = "label4";
            label4.Size = new Size(198, 32);
            label4.TabIndex = 3;
            label4.Text = "Following Course";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(330, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(330, 108);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 39);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(330, 183);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 39);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(330, 254);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 39);
            textBox4.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(41, 350);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 46);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(283, 350);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 46);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddCourse
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddCourse";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Course";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button btnSave;
        private Button btnCancel;
    }
}