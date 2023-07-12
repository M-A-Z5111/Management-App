namespace FinalProject
{
    partial class AirplaneForm
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
            Insertbt = new Button();
            Deletebt = new Button();
            Updatebt = new Button();
            airplanegv = new DataGridView();
            airplaneIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ownerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            capacityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            departureTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            colorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            airplaneBindingSource = new BindingSource(components);
            Refreshbt = new Button();
            ownertb = new TextBox();
            DepartureTimetb = new TextBox();
            Capacitytb = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Colortb = new TextBox();
            Searchtext = new TextBox();
            label5 = new Label();
            airplaneBindingSource1 = new BindingSource(components);
            searchbtn = new Button();
            Searchgv = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)airplanegv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)airplaneBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)airplaneBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Searchgv).BeginInit();
            SuspendLayout();
            // 
            // Insertbt
            // 
            Insertbt.BackColor = Color.FromArgb(224, 224, 224);
            Insertbt.FlatStyle = FlatStyle.Popup;
            Insertbt.Font = new Font("Andalus", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Insertbt.Location = new Point(810, 425);
            Insertbt.Name = "Insertbt";
            Insertbt.Size = new Size(90, 26);
            Insertbt.TabIndex = 0;
            Insertbt.Text = "Insert";
            Insertbt.UseVisualStyleBackColor = false;
            Insertbt.Click += Insertbt_Click;
            // 
            // Deletebt
            // 
            Deletebt.BackColor = Color.FromArgb(224, 224, 224);
            Deletebt.FlatStyle = FlatStyle.Popup;
            Deletebt.Font = new Font("Andalus", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Deletebt.Location = new Point(714, 425);
            Deletebt.Name = "Deletebt";
            Deletebt.Size = new Size(90, 26);
            Deletebt.TabIndex = 1;
            Deletebt.Text = "Delete";
            Deletebt.UseVisualStyleBackColor = false;
            Deletebt.Click += Deletebt_Click;
            // 
            // Updatebt
            // 
            Updatebt.BackColor = Color.FromArgb(224, 224, 224);
            Updatebt.FlatStyle = FlatStyle.Popup;
            Updatebt.Font = new Font("Andalus", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Updatebt.Location = new Point(618, 425);
            Updatebt.Name = "Updatebt";
            Updatebt.Size = new Size(90, 26);
            Updatebt.TabIndex = 2;
            Updatebt.Text = "Update";
            Updatebt.UseVisualStyleBackColor = false;
            Updatebt.Click += Updatebt_Click;
            // 
            // airplanegv
            // 
            airplanegv.AutoGenerateColumns = false;
            airplanegv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            airplanegv.Columns.AddRange(new DataGridViewColumn[] { airplaneIdDataGridViewTextBoxColumn, ownerDataGridViewTextBoxColumn, capacityDataGridViewTextBoxColumn, departureTimeDataGridViewTextBoxColumn, colorDataGridViewTextBoxColumn });
            airplanegv.DataSource = airplaneBindingSource;
            airplanegv.Location = new Point(180, 12);
            airplanegv.Name = "airplanegv";
            airplanegv.RowTemplate.Height = 25;
            airplanegv.Size = new Size(720, 272);
            airplanegv.TabIndex = 3;
            airplanegv.CellContentClick += airplanegv_CellContentClick;
            // 
            // airplaneIdDataGridViewTextBoxColumn
            // 
            airplaneIdDataGridViewTextBoxColumn.DataPropertyName = "AirplaneId";
            airplaneIdDataGridViewTextBoxColumn.HeaderText = "AirplaneId";
            airplaneIdDataGridViewTextBoxColumn.Name = "airplaneIdDataGridViewTextBoxColumn";
            // 
            // ownerDataGridViewTextBoxColumn
            // 
            ownerDataGridViewTextBoxColumn.DataPropertyName = "Owner";
            ownerDataGridViewTextBoxColumn.HeaderText = "Owner";
            ownerDataGridViewTextBoxColumn.Name = "ownerDataGridViewTextBoxColumn";
            // 
            // capacityDataGridViewTextBoxColumn
            // 
            capacityDataGridViewTextBoxColumn.DataPropertyName = "Capacity";
            capacityDataGridViewTextBoxColumn.HeaderText = "Capacity";
            capacityDataGridViewTextBoxColumn.Name = "capacityDataGridViewTextBoxColumn";
            // 
            // departureTimeDataGridViewTextBoxColumn
            // 
            departureTimeDataGridViewTextBoxColumn.DataPropertyName = "DepartureTime";
            departureTimeDataGridViewTextBoxColumn.HeaderText = "DepartureTime";
            departureTimeDataGridViewTextBoxColumn.Name = "departureTimeDataGridViewTextBoxColumn";
            // 
            // colorDataGridViewTextBoxColumn
            // 
            colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            colorDataGridViewTextBoxColumn.HeaderText = "Color";
            colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            // 
            // airplaneBindingSource
            // 
            airplaneBindingSource.DataSource = typeof(Repositorys.Models.Airplane);
            // 
            // Refreshbt
            // 
            Refreshbt.BackColor = Color.FromArgb(224, 224, 224);
            Refreshbt.FlatStyle = FlatStyle.Popup;
            Refreshbt.Font = new Font("Andalus", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Refreshbt.Location = new Point(522, 425);
            Refreshbt.Name = "Refreshbt";
            Refreshbt.Size = new Size(90, 26);
            Refreshbt.TabIndex = 4;
            Refreshbt.Text = "Refresh";
            Refreshbt.UseVisualStyleBackColor = false;
            Refreshbt.Click += Refreshbt_Click;
            // 
            // ownertb
            // 
            ownertb.Location = new Point(20, 42);
            ownertb.Name = "ownertb";
            ownertb.Size = new Size(133, 23);
            ownertb.TabIndex = 5;
            // 
            // DepartureTimetb
            // 
            DepartureTimetb.Location = new Point(20, 190);
            DepartureTimetb.Name = "DepartureTimetb";
            DepartureTimetb.Size = new Size(133, 23);
            DepartureTimetb.TabIndex = 6;
            // 
            // Capacitytb
            // 
            Capacitytb.Location = new Point(20, 115);
            Capacitytb.Name = "Capacitytb";
            Capacitytb.Size = new Size(133, 23);
            Capacitytb.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(20, 12);
            label1.Name = "label1";
            label1.Size = new Size(62, 26);
            label1.TabIndex = 8;
            label1.Text = " Owner";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(20, 234);
            label2.Name = "label2";
            label2.Size = new Size(48, 26);
            label2.TabIndex = 9;
            label2.Text = "Color";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(20, 163);
            label3.Name = "label3";
            label3.Size = new Size(112, 26);
            label3.TabIndex = 10;
            label3.Text = "DepartureTime";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(20, 86);
            label4.Name = "label4";
            label4.Size = new Size(71, 26);
            label4.TabIndex = 11;
            label4.Text = "Capacity";
            // 
            // Colortb
            // 
            Colortb.Location = new Point(20, 261);
            Colortb.Name = "Colortb";
            Colortb.Size = new Size(133, 23);
            Colortb.TabIndex = 12;
            // 
            // Searchtext
            // 
            Searchtext.Location = new Point(20, 425);
            Searchtext.Name = "Searchtext";
            Searchtext.Size = new Size(133, 23);
            Searchtext.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(20, 395);
            label5.Name = "label5";
            label5.Size = new Size(56, 26);
            label5.TabIndex = 14;
            label5.Text = "Search";
            // 
            // airplaneBindingSource1
            // 
            airplaneBindingSource1.DataSource = typeof(Repositorys.Models.Airplane);
            // 
            // searchbtn
            // 
            searchbtn.BackColor = Color.FromArgb(224, 224, 224);
            searchbtn.FlatStyle = FlatStyle.Popup;
            searchbtn.Font = new Font("Andalus", 10F, FontStyle.Regular, GraphicsUnit.Point);
            searchbtn.Location = new Point(20, 357);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(90, 26);
            searchbtn.TabIndex = 16;
            searchbtn.Text = "Search";
            searchbtn.UseVisualStyleBackColor = false;
            searchbtn.Click += searchbtn_Click;

            // 
            // Searchgv
            // 
            Searchgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Searchgv.Location = new Point(180, 290);
            Searchgv.Name = "Searchgv";
            Searchgv.RowTemplate.Height = 25;
            Searchgv.Size = new Size(720, 107);
            Searchgv.TabIndex = 17;
            // 
            // AirplaneForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(928, 457);
            Controls.Add(Searchgv);
            Controls.Add(searchbtn);
            Controls.Add(label5);
            Controls.Add(Searchtext);
            Controls.Add(Colortb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Capacitytb);
            Controls.Add(DepartureTimetb);
            Controls.Add(ownertb);
            Controls.Add(Refreshbt);
            Controls.Add(airplanegv);
            Controls.Add(Updatebt);
            Controls.Add(Deletebt);
            Controls.Add(Insertbt);
            Name = "AirplaneForm";
            Text = "AirplaneForm";
            ((System.ComponentModel.ISupportInitialize)airplanegv).EndInit();
            ((System.ComponentModel.ISupportInitialize)airplaneBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)airplaneBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Searchgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Insertbt;
        private Button Deletebt;
        private Button Updatebt;
        private DataGridView airplanegv;
        private Button Refreshbt;
        private TextBox ownertb;
        private TextBox DepartureTimetb;
        private TextBox Capacitytb;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Colortb;
        private DataGridViewTextBoxColumn airplaneIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ownerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn departureTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private BindingSource airplaneBindingSource;
        private TextBox Searchtext;
        private Label label5;
        private Button searchbtn;
        private BindingSource airplaneBindingSource1;
        private DataGridView Searchgv;
        private DataGridViewTextBoxColumn airplaneIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn ownerDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn departureTimeDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn1;
    }
}