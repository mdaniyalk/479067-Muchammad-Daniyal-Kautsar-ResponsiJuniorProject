namespace responsijunpro
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
            pictureBox1 = new PictureBox();
            txtNama = new Label();
            txtDep = new Label();
            boxNama = new TextBox();
            boxDep = new ComboBox();
            btInsert = new Button();
            btEdit = new Button();
            btDelete = new Button();
            dvgData = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgData).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 82);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtNama
            // 
            txtNama.AutoSize = true;
            txtNama.Location = new Point(19, 118);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(93, 15);
            txtNama.TabIndex = 1;
            txtNama.Text = "Nama Karyawan";
            // 
            // txtDep
            // 
            txtDep.AutoSize = true;
            txtDep.Location = new Point(20, 148);
            txtDep.Name = "txtDep";
            txtDep.Size = new Size(85, 15);
            txtDep.TabIndex = 2;
            txtDep.Text = "Dep. Karyawan";
            txtDep.TextAlign = ContentAlignment.MiddleRight;
            // 
            // boxNama
            // 
            boxNama.Location = new Point(142, 115);
            boxNama.Name = "boxNama";
            boxNama.Size = new Size(176, 23);
            boxNama.TabIndex = 4;
            // 
            // boxDep
            // 
            boxDep.FormattingEnabled = true;
            boxDep.Location = new Point(142, 145);
            boxDep.Name = "boxDep";
            boxDep.Size = new Size(176, 23);
            boxDep.TabIndex = 5;
            boxDep.SelectedIndexChanged += boxDep_SelectedIndexChanged;
            // 
            // btInsert
            // 
            btInsert.Location = new Point(20, 174);
            btInsert.Name = "btInsert";
            btInsert.Size = new Size(75, 23);
            btInsert.TabIndex = 6;
            btInsert.Text = "Insert";
            btInsert.UseVisualStyleBackColor = true;
            btInsert.Click += btInsert_Click;
            // 
            // btEdit
            // 
            btEdit.Location = new Point(188, 174);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(75, 23);
            btEdit.TabIndex = 7;
            btEdit.Text = "Edit";
            btEdit.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(352, 174);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(75, 23);
            btDelete.TabIndex = 8;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = true;
            // 
            // dvgData
            // 
            dvgData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgData.Location = new Point(19, 203);
            dvgData.Name = "dvgData";
            dvgData.RowTemplate.Height = 25;
            dvgData.Size = new Size(408, 181);
            dvgData.TabIndex = 9;
            dvgData.CellClick += dvgData_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(310, 12);
            label1.Name = "label1";
            label1.Size = new Size(123, 90);
            label1.TabIndex = 10;
            label1.Text = "ID Departemen\r\nHR: HR\r\nENG: Engineer\r\nDEV: Developer\r\nPM: Product Manager\r\nFIN: Finance";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 396);
            Controls.Add(label1);
            Controls.Add(dvgData);
            Controls.Add(btDelete);
            Controls.Add(btEdit);
            Controls.Add(btInsert);
            Controls.Add(boxDep);
            Controls.Add(boxNama);
            Controls.Add(txtDep);
            Controls.Add(txtNama);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Management HR";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgData).EndInit();
            ResumeLayout(false);
            PerformLayout();
            Load += Form1_Load;
        }



        #endregion

        private PictureBox pictureBox1;
        private Label txtNama;
        private Label txtDep;
        private TextBox boxNama;
        private ComboBox boxDep;
        private Button btInsert;
        private Button btEdit;
        private Button btDelete;
        private DataGridView dvgData;
        private Label label1;
    }
}