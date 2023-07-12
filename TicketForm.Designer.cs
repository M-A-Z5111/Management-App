namespace FinalProject
{
    partial class TicketForm
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
            components = new System.ComponentModel.Container();
            pricetb = new TextBox();
            seattb = new TextBox();
            triptb = new TextBox();
            ticketgv = new DataGridView();
            ticketnbDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            seatnbDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tripnbDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ticketBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            insertb = new Button();
            deleteb = new Button();
            updateb = new Button();
            refreshb = new Button();
            ((System.ComponentModel.ISupportInitialize)ticketgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ticketBindingSource).BeginInit();
            SuspendLayout();
            // 
            // pricetb
            // 
            pricetb.Location = new Point(12, 69);
            pricetb.Name = "pricetb";
            pricetb.Size = new Size(117, 23);
            pricetb.TabIndex = 0;
            // 
            // seattb
            // 
            seattb.Location = new Point(12, 151);
            seattb.Name = "seattb";
            seattb.Size = new Size(117, 23);
            seattb.TabIndex = 1;
            // 
            // triptb
            // 
            triptb.Location = new Point(12, 245);
            triptb.Name = "triptb";
            triptb.Size = new Size(117, 23);
            triptb.TabIndex = 2;
            // 
            // ticketgv
            // 
            ticketgv.AutoGenerateColumns = false;
            ticketgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ticketgv.Columns.AddRange(new DataGridViewColumn[] { ticketnbDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, seatnbDataGridViewTextBoxColumn, tripnbDataGridViewTextBoxColumn });
            ticketgv.DataSource = ticketBindingSource;
            ticketgv.Location = new Point(149, 13);
            ticketgv.Name = "ticketgv";
            ticketgv.RowTemplate.Height = 25;
            ticketgv.Size = new Size(625, 364);
            ticketgv.TabIndex = 3;
            ticketgv.CellContentClick += ticketgv_CellContentClick;
            // 
            // ticketnbDataGridViewTextBoxColumn
            // 
            ticketnbDataGridViewTextBoxColumn.DataPropertyName = "Ticketnb";
            ticketnbDataGridViewTextBoxColumn.HeaderText = "Ticketnb";
            ticketnbDataGridViewTextBoxColumn.Name = "ticketnbDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // seatnbDataGridViewTextBoxColumn
            // 
            seatnbDataGridViewTextBoxColumn.DataPropertyName = "Seatnb";
            seatnbDataGridViewTextBoxColumn.HeaderText = "Seatnb";
            seatnbDataGridViewTextBoxColumn.Name = "seatnbDataGridViewTextBoxColumn";
            // 
            // tripnbDataGridViewTextBoxColumn
            // 
            tripnbDataGridViewTextBoxColumn.DataPropertyName = "Tripnb";
            tripnbDataGridViewTextBoxColumn.HeaderText = "Tripnb";
            tripnbDataGridViewTextBoxColumn.Name = "tripnbDataGridViewTextBoxColumn";
            // 
            // ticketBindingSource
            // 
            ticketBindingSource.DataSource = typeof(Repositorys.Models.Ticket);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 40);
            label1.Name = "label1";
            label1.Size = new Size(44, 26);
            label1.TabIndex = 4;
            label1.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 122);
            label2.Name = "label2";
            label2.Size = new Size(97, 26);
            label2.TabIndex = 5;
            label2.Text = "Seat Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 216);
            label3.Name = "label3";
            label3.Size = new Size(97, 26);
            label3.TabIndex = 6;
            label3.Text = "Trip Number";
            // 
            // insertb
            // 
            insertb.BackColor = Color.FromArgb(224, 224, 224);
            insertb.FlatStyle = FlatStyle.Popup;
            insertb.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            insertb.Location = new Point(670, 403);
            insertb.Name = "insertb";
            insertb.Size = new Size(104, 31);
            insertb.TabIndex = 7;
            insertb.Text = "Insert";
            insertb.UseVisualStyleBackColor = false;
            insertb.Click += insertb_Click;
            // 
            // deleteb
            // 
            deleteb.BackColor = Color.FromArgb(224, 224, 224);
            deleteb.FlatStyle = FlatStyle.Popup;
            deleteb.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            deleteb.Location = new Point(532, 403);
            deleteb.Name = "deleteb";
            deleteb.Size = new Size(104, 31);
            deleteb.TabIndex = 8;
            deleteb.Text = "Delete";
            deleteb.UseVisualStyleBackColor = false;
            deleteb.Click += deleteb_Click;
            // 
            // updateb
            // 
            updateb.BackColor = Color.FromArgb(224, 224, 224);
            updateb.FlatStyle = FlatStyle.Popup;
            updateb.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            updateb.Location = new Point(394, 403);
            updateb.Name = "updateb";
            updateb.Size = new Size(104, 31);
            updateb.TabIndex = 9;
            updateb.Text = "Update";
            updateb.UseVisualStyleBackColor = false;
            updateb.Click += updateb_Click;
            // 
            // refreshb
            // 
            refreshb.BackColor = Color.FromArgb(224, 224, 224);
            refreshb.FlatStyle = FlatStyle.Popup;
            refreshb.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            refreshb.Location = new Point(261, 403);
            refreshb.Name = "refreshb";
            refreshb.Size = new Size(104, 31);
            refreshb.TabIndex = 10;
            refreshb.Text = "Refresh";
            refreshb.UseVisualStyleBackColor = false;
            refreshb.Click += refreshb_Click;
            // 
            // TicketForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(refreshb);
            Controls.Add(updateb);
            Controls.Add(deleteb);
            Controls.Add(insertb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ticketgv);
            Controls.Add(triptb);
            Controls.Add(seattb);
            Controls.Add(pricetb);
            Name = "TicketForm";
            Text = "TicketForm";
            ((System.ComponentModel.ISupportInitialize)ticketgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)ticketBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox pricetb;
        private TextBox seattb;
        private TextBox triptb;
        private DataGridView ticketgv;
        private DataGridViewTextBoxColumn ticketnbDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn seatnbDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tripnbDataGridViewTextBoxColumn;
        private BindingSource ticketBindingSource;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button insertb;
        private Button deleteb;
        private Button updateb;
        private Button refreshb;
    }
}