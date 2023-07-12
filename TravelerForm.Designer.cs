namespace FinalProject
{
    partial class TravelerForm
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
            nametb = new TextBox();
            agetb = new TextBox();
            weighttb = new TextBox();
            destinationtb = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Destination = new Label();
            travelergv = new DataGridView();
            travelerIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            allowedWeightDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            destinationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            travelerBindingSource = new BindingSource(components);
            insertb = new Button();
            deleteb = new Button();
            updateb = new Button();
            refreshb = new Button();
            ((System.ComponentModel.ISupportInitialize)travelergv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)travelerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // nametb
            // 
            nametb.Location = new Point(12, 42);
            nametb.Name = "nametb";
            nametb.Size = new Size(125, 23);
            nametb.TabIndex = 0;
            // 
            // agetb
            // 
            agetb.Location = new Point(12, 122);
            agetb.Name = "agetb";
            agetb.Size = new Size(125, 23);
            agetb.TabIndex = 1;
            // 
            // weighttb
            // 
            weighttb.Location = new Point(12, 200);
            weighttb.Name = "weighttb";
            weighttb.Size = new Size(125, 23);
            weighttb.TabIndex = 2;
            // 
            // destinationtb
            // 
            destinationtb.Location = new Point(12, 286);
            destinationtb.Name = "destinationtb";
            destinationtb.Size = new Size(125, 23);
            destinationtb.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(55, 26);
            label1.TabIndex = 4;
            label1.Text = " Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 93);
            label2.Name = "label2";
            label2.Size = new Size(37, 26);
            label2.TabIndex = 5;
            label2.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 171);
            label3.Name = "label3";
            label3.Size = new Size(145, 26);
            label3.TabIndex = 6;
            label3.Text = "Allowed Weight(Kg)";
            // 
            // Destination
            // 
            Destination.AutoSize = true;
            Destination.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Destination.Location = new Point(12, 257);
            Destination.Name = "Destination";
            Destination.Size = new Size(88, 26);
            Destination.TabIndex = 7;
            Destination.Text = "Destination";
            // 
            // travelergv
            // 
            travelergv.AutoGenerateColumns = false;
            travelergv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            travelergv.Columns.AddRange(new DataGridViewColumn[] { travelerIdDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, ageDataGridViewTextBoxColumn, allowedWeightDataGridViewTextBoxColumn, destinationDataGridViewTextBoxColumn });
            travelergv.DataSource = travelerBindingSource;
            travelergv.Location = new Point(163, 12);
            travelergv.Name = "travelergv";
            travelergv.RowTemplate.Height = 25;
            travelergv.Size = new Size(626, 381);
            travelergv.TabIndex = 8;
            travelergv.CellContentClick += travelergv_CellContentClick;
            // 
            // travelerIdDataGridViewTextBoxColumn
            // 
            travelerIdDataGridViewTextBoxColumn.DataPropertyName = "TravelerId";
            travelerIdDataGridViewTextBoxColumn.HeaderText = "TravelerId";
            travelerIdDataGridViewTextBoxColumn.Name = "travelerIdDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            ageDataGridViewTextBoxColumn.HeaderText = "Age";
            ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // allowedWeightDataGridViewTextBoxColumn
            // 
            allowedWeightDataGridViewTextBoxColumn.DataPropertyName = "AllowedWeight";
            allowedWeightDataGridViewTextBoxColumn.HeaderText = "AllowedWeight";
            allowedWeightDataGridViewTextBoxColumn.Name = "allowedWeightDataGridViewTextBoxColumn";
            // 
            // destinationDataGridViewTextBoxColumn
            // 
            destinationDataGridViewTextBoxColumn.DataPropertyName = "Destination";
            destinationDataGridViewTextBoxColumn.HeaderText = "Destination";
            destinationDataGridViewTextBoxColumn.Name = "destinationDataGridViewTextBoxColumn";
            // 
            // travelerBindingSource
            // 
            travelerBindingSource.DataSource = typeof(Repositorys.Models.Traveler);
            // 
            // insertb
            // 
            insertb.BackColor = Color.FromArgb(224, 224, 224);
            insertb.FlatStyle = FlatStyle.Popup;
            insertb.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            insertb.Location = new Point(687, 411);
            insertb.Name = "insertb";
            insertb.Size = new Size(101, 27);
            insertb.TabIndex = 9;
            insertb.Text = "Insert";
            insertb.UseVisualStyleBackColor = false;
            insertb.Click += insertb_Click;
            // 
            // deleteb
            // 
            deleteb.BackColor = Color.FromArgb(224, 224, 224);
            deleteb.FlatStyle = FlatStyle.Popup;
            deleteb.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            deleteb.Location = new Point(563, 411);
            deleteb.Name = "deleteb";
            deleteb.Size = new Size(101, 27);
            deleteb.TabIndex = 10;
            deleteb.Text = "Delete";
            deleteb.UseVisualStyleBackColor = false;
            deleteb.Click += deleteb_Click;
            // 
            // updateb
            // 
            updateb.BackColor = Color.FromArgb(224, 224, 224);
            updateb.FlatStyle = FlatStyle.Popup;
            updateb.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            updateb.Location = new Point(435, 411);
            updateb.Name = "updateb";
            updateb.Size = new Size(101, 27);
            updateb.TabIndex = 11;
            updateb.Text = "Update";
            updateb.UseVisualStyleBackColor = false;
            updateb.Click += updateb_Click;
            // 
            // refreshb
            // 
            refreshb.BackColor = Color.FromArgb(224, 224, 224);
            refreshb.FlatStyle = FlatStyle.Popup;
            refreshb.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            refreshb.Location = new Point(312, 411);
            refreshb.Name = "refreshb";
            refreshb.Size = new Size(101, 27);
            refreshb.TabIndex = 12;
            refreshb.Text = "Refresh";
            refreshb.UseVisualStyleBackColor = false;
            refreshb.Click += refreshb_Click;
            // 
            // TravelerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(refreshb);
            Controls.Add(updateb);
            Controls.Add(deleteb);
            Controls.Add(insertb);
            Controls.Add(travelergv);
            Controls.Add(Destination);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(destinationtb);
            Controls.Add(weighttb);
            Controls.Add(agetb);
            Controls.Add(nametb);
            Name = "TravelerForm";
            Text = "TravelerForm";
            ((System.ComponentModel.ISupportInitialize)travelergv).EndInit();
            ((System.ComponentModel.ISupportInitialize)travelerBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nametb;
        private TextBox agetb;
        private TextBox weighttb;
        private TextBox destinationtb;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label Destination;
        private DataGridView travelergv;
        private DataGridViewTextBoxColumn travelerIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn allowedWeightDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private BindingSource travelerBindingSource;
        private Button insertb;
        private Button deleteb;
        private Button updateb;
        private Button refreshb;
    }
}