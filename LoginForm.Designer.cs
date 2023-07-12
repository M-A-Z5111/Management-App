namespace FinalProject
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Clearbt = new Button();
            Loginbt = new Button();
            Exitbt = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Andalus", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(290, 9);
            label1.Name = "label1";
            label1.Size = new Size(211, 61);
            label1.TabIndex = 0;
            label1.Text = "Welocome";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(389, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(385, 320);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Andalus", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 73);
            label2.Name = "label2";
            label2.Size = new Size(319, 31);
            label2.TabIndex = 2;
            label2.Text = "Please Sign in to get in to the system...";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 148);
            label3.Name = "label3";
            label3.Size = new Size(79, 26);
            label3.TabIndex = 3;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 242);
            label4.Name = "label4";
            label4.Size = new Size(74, 26);
            label4.TabIndex = 4;
            label4.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(224, 224, 224);
            textBox1.Location = new Point(106, 151);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(236, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(224, 224, 224);
            textBox2.Location = new Point(106, 245);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(236, 23);
            textBox2.TabIndex = 6;
            // 
            // Clearbt
            // 
            Clearbt.BackColor = Color.FromArgb(224, 224, 224);
            Clearbt.FlatStyle = FlatStyle.Popup;
            Clearbt.Font = new Font("Andalus", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Clearbt.Location = new Point(106, 312);
            Clearbt.Name = "Clearbt";
            Clearbt.Size = new Size(62, 34);
            Clearbt.TabIndex = 7;
            Clearbt.Text = "Clear";
            Clearbt.UseVisualStyleBackColor = false;
            Clearbt.Click += Clearbt_Click;
            // 
            // Loginbt
            // 
            Loginbt.BackColor = Color.FromArgb(224, 224, 224);
            Loginbt.FlatStyle = FlatStyle.Popup;
            Loginbt.Font = new Font("Andalus", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Loginbt.Location = new Point(280, 312);
            Loginbt.Name = "Loginbt";
            Loginbt.Size = new Size(62, 34);
            Loginbt.TabIndex = 8;
            Loginbt.Text = "Login";
            Loginbt.UseVisualStyleBackColor = false;
            Loginbt.Click += Loginbt_Click;
            // 
            // Exitbt
            // 
            Exitbt.BackColor = Color.FromArgb(224, 224, 224);
            Exitbt.FlatStyle = FlatStyle.Popup;
            Exitbt.Font = new Font("Andalus", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Exitbt.Location = new Point(12, 390);
            Exitbt.Name = "Exitbt";
            Exitbt.Size = new Size(70, 36);
            Exitbt.TabIndex = 9;
            Exitbt.Text = "Exit";
            Exitbt.UseVisualStyleBackColor = false;
            Exitbt.Click += Exitbt_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(810, 450);
            Controls.Add(Exitbt);
            Controls.Add(Loginbt);
            Controls.Add(Clearbt);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button Clearbt;
        private Button Loginbt;
        private Button Exitbt;
    }
}