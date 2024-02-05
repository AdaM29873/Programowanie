namespace egzamin
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            emailBox = new TextBox();
            passwordBox = new TextBox();
            passwordBox2 = new TextBox();
            Zatwierdz = new Button();
            label5 = new Label();
            label_answer = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Teal;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(484, 86);
            label1.TabIndex = 0;
            label1.Text = "Rejestruj konto";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 114);
            label2.Name = "label2";
            label2.Size = new Size(152, 32);
            label2.TabIndex = 1;
            label2.Text = "Podaj e-mail:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 194);
            label3.Name = "label3";
            label3.Size = new Size(141, 32);
            label3.TabIndex = 2;
            label3.Text = "Podaj hasło:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 269);
            label4.Name = "label4";
            label4.Size = new Size(167, 32);
            label4.TabIndex = 3;
            label4.Text = "Powtórz hasło:";
            // 
            // emailBox
            // 
            emailBox.Location = new Point(12, 149);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(141, 23);
            emailBox.TabIndex = 4;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(12, 229);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(141, 23);
            passwordBox.TabIndex = 5;
            passwordBox.UseSystemPasswordChar = true;
            // 
            // passwordBox2
            // 
            passwordBox2.Location = new Point(12, 304);
            passwordBox2.Name = "passwordBox2";
            passwordBox2.Size = new Size(141, 23);
            passwordBox2.TabIndex = 6;
            passwordBox2.UseSystemPasswordChar = true;
            // 
            // Zatwierdz
            // 
            Zatwierdz.Location = new Point(141, 446);
            Zatwierdz.Name = "Zatwierdz";
            Zatwierdz.Size = new Size(162, 54);
            Zatwierdz.TabIndex = 7;
            Zatwierdz.Text = "ZATWIERDŹ";
            Zatwierdz.UseVisualStyleBackColor = true;
            Zatwierdz.Click += Zatwierdz_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(172, 524);
            label5.Name = "label5";
            label5.Size = new Size(106, 15);
            label5.TabIndex = 8;
            label5.Text = "Autor 06411208126";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_answer
            // 
            label_answer.AutoSize = true;
            label_answer.Location = new Point(172, 524);
            label_answer.Name = "label_answer";
            label_answer.Size = new Size(106, 15);
            label_answer.TabIndex = 9;
            label_answer.Text = "Autor 06411208126";
            label_answer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 718);
            Controls.Add(label_answer);
            Controls.Add(label5);
            Controls.Add(Zatwierdz);
            Controls.Add(passwordBox2);
            Controls.Add(passwordBox);
            Controls.Add(emailBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox emailBox;
        private TextBox passwordBox;
        private TextBox passwordBox2;
        private Button Zatwierdz;
        private Label label5;
        private Label label_answer;
    }
}