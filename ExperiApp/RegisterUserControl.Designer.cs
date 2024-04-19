namespace ExperiApp
{
    partial class RegisterUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            RegConPassBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            BackButton = new Button();
            RegisterButton = new Button();
            RegPassBox = new TextBox();
            RegUserBox = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(RegConPassBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(BackButton);
            panel1.Controls.Add(RegisterButton);
            panel1.Controls.Add(RegPassBox);
            panel1.Controls.Add(RegUserBox);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(316, 411);
            panel1.TabIndex = 1;
            // 
            // RegConPassBox
            // 
            RegConPassBox.Location = new Point(37, 247);
            RegConPassBox.Name = "RegConPassBox";
            RegConPassBox.Size = new Size(249, 23);
            RegConPassBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 229);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 7;
            label4.Text = "Confirm Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 164);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 100);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 5;
            label2.Text = "Username";
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Transparent;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Location = new Point(112, 330);
            BackButton.Margin = new Padding(0);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(97, 26);
            BackButton.TabIndex = 4;
            BackButton.Text = "Back To Sign In";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(125, 304);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(75, 23);
            RegisterButton.TabIndex = 3;
            RegisterButton.Text = "Sign Up";
            RegisterButton.UseVisualStyleBackColor = true;
            // 
            // RegPassBox
            // 
            RegPassBox.Location = new Point(37, 182);
            RegPassBox.Name = "RegPassBox";
            RegPassBox.Size = new Size(249, 23);
            RegPassBox.TabIndex = 2;
            // 
            // RegUserBox
            // 
            RegUserBox.Location = new Point(37, 118);
            RegUserBox.Name = "RegUserBox";
            RegUserBox.Size = new Size(249, 23);
            RegUserBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(120, 49);
            label1.Name = "label1";
            label1.Size = new Size(87, 30);
            label1.TabIndex = 0;
            label1.Text = "Register";
            // 
            // RegisterUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            Controls.Add(panel1);
            Name = "RegisterUserControl";
            Size = new Size(783, 411);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Button BackButton;
        private Button RegisterButton;
        private TextBox RegPassBox;
        private TextBox RegUserBox;
        private Label label1;
        private TextBox RegConPassBox;
        private Label label4;
    }
}
