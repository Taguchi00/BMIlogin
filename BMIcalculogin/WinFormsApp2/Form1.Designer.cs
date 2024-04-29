namespace WinFormsApp2
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtUserLog = new Guna.UI2.WinForms.Guna2TextBox();
            btnLogin = new Guna.UI2.WinForms.Guna2Button();
            txtPassLog = new Guna.UI2.WinForms.Guna2TextBox();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtUserLog
            // 
            txtUserLog.BorderColor = Color.Black;
            txtUserLog.CustomizableEdges = customizableEdges1;
            txtUserLog.DefaultText = "";
            txtUserLog.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUserLog.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUserLog.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUserLog.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUserLog.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUserLog.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUserLog.ForeColor = Color.Black;
            txtUserLog.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUserLog.Location = new Point(12, 74);
            txtUserLog.Name = "txtUserLog";
            txtUserLog.PasswordChar = '\0';
            txtUserLog.PlaceholderText = "Username";
            txtUserLog.SelectedText = "";
            txtUserLog.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtUserLog.Size = new Size(212, 36);
            txtUserLog.TabIndex = 0;
            txtUserLog.TextChanged += guna2TextBox1_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.CustomizableEdges = customizableEdges3;
            btnLogin.DisabledState.BorderColor = Color.DarkGray;
            btnLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogin.FillColor = Color.Black;
            btnLogin.Font = new Font("Segoe UI", 9F);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(12, 208);
            btnLogin.Name = "btnLogin";
            btnLogin.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnLogin.Size = new Size(212, 36);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "LOGIN";
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassLog
            // 
            txtPassLog.BorderColor = Color.Black;
            txtPassLog.CustomizableEdges = customizableEdges5;
            txtPassLog.DefaultText = "";
            txtPassLog.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPassLog.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPassLog.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPassLog.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPassLog.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassLog.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassLog.ForeColor = Color.Black;
            txtPassLog.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassLog.Location = new Point(12, 131);
            txtPassLog.Name = "txtPassLog";
            txtPassLog.PasswordChar = '\0';
            txtPassLog.PlaceholderText = "Password";
            txtPassLog.SelectedText = "";
            txtPassLog.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtPassLog.Size = new Size(212, 36);
            txtPassLog.TabIndex = 6;
            // 
            // guna2Button2
            // 
            guna2Button2.BackColor = Color.Transparent;
            guna2Button2.BorderColor = Color.FromArgb(25, 77, 91);
            guna2Button2.BorderThickness = 1;
            guna2Button2.CustomBorderColor = Color.Transparent;
            guna2Button2.CustomizableEdges = customizableEdges7;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.Transparent;
            guna2Button2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button2.ForeColor = Color.FromArgb(25, 77, 91);
            guna2Button2.Location = new Point(359, 438);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Button2.Size = new Size(76, 30);
            guna2Button2.TabIndex = 9;
            guna2Button2.Text = "Login";
            guna2Button2.TextOffset = new Point(2, -1);
            // 
            // guna2Button3
            // 
            guna2Button3.BackColor = Color.Transparent;
            guna2Button3.BorderColor = Color.FromArgb(25, 77, 91);
            guna2Button3.CustomizableEdges = customizableEdges9;
            guna2Button3.DisabledState.BorderColor = Color.DarkGray;
            guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button3.FillColor = Color.Transparent;
            guna2Button3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button3.ForeColor = Color.FromArgb(25, 77, 91);
            guna2Button3.Location = new Point(209, 509);
            guna2Button3.Name = "guna2Button3";
            guna2Button3.PressedColor = Color.Transparent;
            guna2Button3.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2Button3.Size = new Size(76, 30);
            guna2Button3.TabIndex = 14;
            guna2Button3.Text = "Sign Up";
            guna2Button3.TextOffset = new Point(3, -1);
            guna2Button3.Click += guna2Button3_Click;
            // 
            // guna2CheckBox1
            // 
            guna2CheckBox1.AutoSize = true;
            guna2CheckBox1.BackColor = Color.Transparent;
            guna2CheckBox1.CheckedState.BorderColor = Color.DimGray;
            guna2CheckBox1.CheckedState.BorderRadius = 1;
            guna2CheckBox1.CheckedState.BorderThickness = 1;
            guna2CheckBox1.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            guna2CheckBox1.ForeColor = Color.Black;
            guna2CheckBox1.Location = new Point(12, 183);
            guna2CheckBox1.Name = "guna2CheckBox1";
            guna2CheckBox1.Size = new Size(108, 19);
            guna2CheckBox1.TabIndex = 15;
            guna2CheckBox1.Text = "Show Password";
            guna2CheckBox1.UncheckedState.BorderColor = Color.DimGray;
            guna2CheckBox1.UncheckedState.BorderRadius = 1;
            guna2CheckBox1.UncheckedState.BorderThickness = 1;
            guna2CheckBox1.UncheckedState.FillColor = Color.White;
            guna2CheckBox1.UseVisualStyleBackColor = false;
            guna2CheckBox1.CheckedChanged += guna2CheckBox1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 260);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 28;
            label1.Text = "Create Account";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(85, 18);
            label2.Name = "label2";
            label2.Size = new Size(69, 30);
            label2.TabIndex = 31;
            label2.Text = "Login";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(255, 308);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(guna2CheckBox1);
            Controls.Add(guna2Button3);
            Controls.Add(guna2Button2);
            Controls.Add(txtPassLog);
            Controls.Add(btnLogin);
            Controls.Add(txtUserLog);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtUserLog;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2TextBox txtPassLog;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
        private Label label1;
        private Label label2;
    }
}
