namespace Validation
{
    partial class Display
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
            LBUSERNAME = new Label();
            LBPASSWORD = new Label();
            LBEMAIL = new Label();
            LBGENDER = new Label();
            label9 = new Label();
            LBBIRTHDATE = new Label();
            panel1 = new Panel();
            Close_Button = new Label();
            BTN = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(40, 53);
            label1.Name = "label1";
            label1.Size = new Size(92, 21);
            label1.TabIndex = 0;
            label1.Text = "USERNAME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(40, 89);
            label2.Name = "label2";
            label2.Size = new Size(94, 21);
            label2.TabIndex = 1;
            label2.Text = "PASSWORD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(40, 130);
            label3.Name = "label3";
            label3.Size = new Size(54, 21);
            label3.TabIndex = 2;
            label3.Text = "EMAIL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(40, 165);
            label4.Name = "label4";
            label4.Size = new Size(70, 21);
            label4.TabIndex = 3;
            label4.Text = "GENDER";
            // 
            // LBUSERNAME
            // 
            LBUSERNAME.AutoSize = true;
            LBUSERNAME.Font = new Font("Segoe UI", 12F);
            LBUSERNAME.Location = new Point(152, 53);
            LBUSERNAME.Name = "LBUSERNAME";
            LBUSERNAME.Size = new Size(52, 21);
            LBUSERNAME.TabIndex = 4;
            LBUSERNAME.Text = "label5";
            // 
            // LBPASSWORD
            // 
            LBPASSWORD.AutoSize = true;
            LBPASSWORD.Font = new Font("Segoe UI", 12F);
            LBPASSWORD.Location = new Point(152, 89);
            LBPASSWORD.Name = "LBPASSWORD";
            LBPASSWORD.Size = new Size(52, 21);
            LBPASSWORD.TabIndex = 5;
            LBPASSWORD.Text = "label6";
            // 
            // LBEMAIL
            // 
            LBEMAIL.AutoSize = true;
            LBEMAIL.Font = new Font("Segoe UI", 12F);
            LBEMAIL.Location = new Point(152, 130);
            LBEMAIL.Name = "LBEMAIL";
            LBEMAIL.Size = new Size(52, 21);
            LBEMAIL.TabIndex = 6;
            LBEMAIL.Text = "label7";
            // 
            // LBGENDER
            // 
            LBGENDER.AutoSize = true;
            LBGENDER.Font = new Font("Segoe UI", 12F);
            LBGENDER.Location = new Point(152, 165);
            LBGENDER.Name = "LBGENDER";
            LBGENDER.Size = new Size(52, 21);
            LBGENDER.TabIndex = 7;
            LBGENDER.Text = "label8";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(42, 202);
            label9.Name = "label9";
            label9.Size = new Size(87, 21);
            label9.TabIndex = 8;
            label9.Text = "BIRTHDATE";
            // 
            // LBBIRTHDATE
            // 
            LBBIRTHDATE.AutoSize = true;
            LBBIRTHDATE.Font = new Font("Segoe UI", 12F);
            LBBIRTHDATE.Location = new Point(152, 202);
            LBBIRTHDATE.Name = "LBBIRTHDATE";
            LBBIRTHDATE.Size = new Size(61, 21);
            LBBIRTHDATE.TabIndex = 9;
            LBBIRTHDATE.Text = "label10";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(Close_Button);
            panel1.Dock = DockStyle.Top;
            panel1.ImeMode = ImeMode.AlphaFull;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(358, 26);
            panel1.TabIndex = 10;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
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
            // BTN
            // 
            BTN.FlatStyle = FlatStyle.Flat;
            BTN.Location = new Point(152, 254);
            BTN.Name = "BTN";
            BTN.Size = new Size(75, 23);
            BTN.TabIndex = 15;
            BTN.Text = "BACK";
            BTN.UseVisualStyleBackColor = true;
            BTN.Click += BTNREGISTER_Click;
            // 
            // Display
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 349);
            Controls.Add(BTN);
            Controls.Add(panel1);
            Controls.Add(LBBIRTHDATE);
            Controls.Add(label9);
            Controls.Add(LBGENDER);
            Controls.Add(LBEMAIL);
            Controls.Add(LBPASSWORD);
            Controls.Add(LBUSERNAME);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Display";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Display";
            Load += Display_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label LBUSERNAME;
        private Label LBPASSWORD;
        private Label LBEMAIL;
        private Label LBGENDER;
        private Label label9;
        private Label LBBIRTHDATE;
        private Panel panel1;
        private Label Close_Button;
        private Button BTN;
    }
}