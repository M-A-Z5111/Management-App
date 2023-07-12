namespace FinalProject
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            Airplaneform = new Button();
            TravelerForm = new Button();
            TicketForm = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Airplaneform
            // 
            Airplaneform.BackColor = Color.FromArgb(224, 224, 224);
            Airplaneform.FlatStyle = FlatStyle.Popup;
            Airplaneform.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Airplaneform.ForeColor = Color.Black;
            Airplaneform.Location = new Point(27, 12);
            Airplaneform.Name = "Airplaneform";
            Airplaneform.Size = new Size(138, 81);
            Airplaneform.TabIndex = 0;
            Airplaneform.Text = "Airplane";
            Airplaneform.UseVisualStyleBackColor = false;
            Airplaneform.Click += Airplaneform_Click;
            // 
            // TravelerForm
            // 
            TravelerForm.BackColor = Color.FromArgb(224, 224, 224);
            TravelerForm.FlatStyle = FlatStyle.Popup;
            TravelerForm.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TravelerForm.Location = new Point(27, 136);
            TravelerForm.Name = "TravelerForm";
            TravelerForm.Size = new Size(138, 81);
            TravelerForm.TabIndex = 1;
            TravelerForm.Text = "Traveler";
            TravelerForm.UseVisualStyleBackColor = false;
            TravelerForm.Click += TravelerForm_Click;
            // 
            // TicketForm
            // 
            TicketForm.BackColor = Color.FromArgb(224, 224, 224);
            TicketForm.FlatStyle = FlatStyle.Popup;
            TicketForm.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TicketForm.Location = new Point(27, 254);
            TicketForm.Name = "TicketForm";
            TicketForm.Size = new Size(138, 81);
            TicketForm.TabIndex = 2;
            TicketForm.Text = "Ticket";
            TicketForm.UseVisualStyleBackColor = false;
            TicketForm.Click += TicketForm_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(200, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(588, 305);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(TicketForm);
            Controls.Add(TravelerForm);
            Controls.Add(Airplaneform);
            ForeColor = SystemColors.ControlText;
            Name = "Main";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Button Airplaneform;
        private Button TravelerForm;
        private Button TicketForm;
        private PictureBox pictureBox1;
    }
}