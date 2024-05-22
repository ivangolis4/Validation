using System.Windows.Forms;

namespace Validation
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
            panel1 = new Panel();
            Close_Button = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            TBUSERNAME = new TextBox();
            TBPASSWORD = new TextBox();
            TBEMAIL = new TextBox();
            DATETIME = new DateTimePicker();
            RBMALE = new RadioButton();
            RBFEMALE = new RadioButton();
            BTNREGISTER = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(Close_Button);
            panel1.Dock = DockStyle.Top;
            panel1.ImeMode = ImeMode.AlphaFull;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(363, 26);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // Close_Button
            // 
            Close_Button.AutoSize = true;
            Close_Button.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Close_Button.Location = new Point(339, 1);
            Close_Button.Name = "Close_Button";
            Close_Button.Size = new Size(24, 25);
            Close_Button.TabIndex = 1;
            Close_Button.Text = "X";
            Close_Button.Click += Close_Button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(103, 40);
            label1.Name = "label1";
            label1.Size = new Size(148, 27);
            label1.TabIndex = 1;
            label1.Text = "REGISTRATION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 108);
            label2.Name = "label2";
            label2.Size = new Size(73, 16);
            label2.TabIndex = 2;
            label2.Text = "USERNAME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 154);
            label3.Name = "label3";
            label3.Size = new Size(72, 16);
            label3.TabIndex = 3;
            label3.Text = "PASSWORD";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(29, 194);
            label4.Name = "label4";
            label4.Size = new Size(44, 16);
            label4.TabIndex = 4;
            label4.Text = "EMAIL";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Small", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(29, 234);
            label6.Name = "label6";
            label6.Size = new Size(54, 16);
            label6.TabIndex = 6;
            label6.Text = "GENDER";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Small", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(29, 278);
            label5.Name = "label5";
            label5.Size = new Size(72, 16);
            label5.TabIndex = 7;
            label5.Text = "BIRTHDATE";
            // 
            // TBUSERNAME
            // 
            TBUSERNAME.Location = new Point(123, 101);
            TBUSERNAME.Name = "TBUSERNAME";
            TBUSERNAME.PlaceholderText = "Enter your username";
            TBUSERNAME.Size = new Size(183, 23);
            TBUSERNAME.TabIndex = 8;
            // 
            // TBPASSWORD
            // 
            TBPASSWORD.Location = new Point(123, 147);
            TBPASSWORD.Name = "TBPASSWORD";
            TBPASSWORD.PasswordChar = '•';
            TBPASSWORD.PlaceholderText = "Enter your password";
            TBPASSWORD.Size = new Size(183, 23);
            TBPASSWORD.TabIndex = 9;
            // 
            // TBEMAIL
            // 
            TBEMAIL.Location = new Point(123, 192);
            TBEMAIL.Name = "TBEMAIL";
            TBEMAIL.PlaceholderText = "example@gmail.com";
            TBEMAIL.Size = new Size(183, 23);
            TBEMAIL.TabIndex = 10;
            // 
            // DATETIME
            // 
            DATETIME.CustomFormat = "MMM d, yyyy";
            DATETIME.Format = DateTimePickerFormat.Custom;
            DATETIME.Location = new Point(123, 271);
            DATETIME.Name = "DATETIME";
            DATETIME.Size = new Size(183, 23);
            DATETIME.TabIndex = 11;
            DATETIME.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // RBMALE
            // 
            RBMALE.AutoSize = true;
            RBMALE.Location = new Point(123, 231);
            RBMALE.Name = "RBMALE";
            RBMALE.Size = new Size(56, 19);
            RBMALE.TabIndex = 12;
            RBMALE.TabStop = true;
            RBMALE.Text = "MALE";
            RBMALE.UseVisualStyleBackColor = true;
            // 
            // RBFEMALE
            // 
            RBFEMALE.AutoSize = true;
            RBFEMALE.Location = new Point(223, 231);
            RBFEMALE.Name = "RBFEMALE";
            RBFEMALE.Size = new Size(68, 19);
            RBFEMALE.TabIndex = 13;
            RBFEMALE.TabStop = true;
            RBFEMALE.Text = "FEMALE";
            RBFEMALE.UseVisualStyleBackColor = true;
            // 
            // BTNREGISTER
            // 
            BTNREGISTER.FlatStyle = FlatStyle.Flat;
            BTNREGISTER.Location = new Point(145, 330);
            BTNREGISTER.Name = "BTNREGISTER";
            BTNREGISTER.Size = new Size(75, 23);
            BTNREGISTER.TabIndex = 14;
            BTNREGISTER.Text = "REGISTER";
            BTNREGISTER.UseVisualStyleBackColor = true;
            BTNREGISTER.Click += BTNREGISTER_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 450);
            Controls.Add(BTNREGISTER);
            Controls.Add(RBFEMALE);
            Controls.Add(RBMALE);
            Controls.Add(DATETIME);
            Controls.Add(TBEMAIL);
            Controls.Add(TBPASSWORD);
            Controls.Add(TBUSERNAME);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            ImeMode = ImeMode.On;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label Close_Button;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label5;
        private TextBox TBUSERNAME;
        private TextBox TBPASSWORD;
        private TextBox TBEMAIL;
        private DateTimePicker DATETIME;
        private RadioButton RBMALE;
        private RadioButton RBFEMALE;
        private Button BTNREGISTER;
    }
}
