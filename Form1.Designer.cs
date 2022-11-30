namespace NetworkOnSubnets
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbIP_Network = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMaskFull = new System.Windows.Forms.TextBox();
            this.tbMaskShort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSubnets = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbComputers = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAllipAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnComputerAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFromTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Network\'s IP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbIP_Network
            // 
            this.tbIP_Network.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbIP_Network.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbIP_Network.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbIP_Network.Location = new System.Drawing.Point(23, 53);
            this.tbIP_Network.Name = "tbIP_Network";
            this.tbIP_Network.Size = new System.Drawing.Size(211, 30);
            this.tbIP_Network.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(350, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter subnet mask";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbMaskFull
            // 
            this.tbMaskFull.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMaskFull.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMaskFull.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbMaskFull.Location = new System.Drawing.Point(280, 53);
            this.tbMaskFull.Name = "tbMaskFull";
            this.tbMaskFull.Size = new System.Drawing.Size(211, 30);
            this.tbMaskFull.TabIndex = 3;
            // 
            // tbMaskShort
            // 
            this.tbMaskShort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMaskShort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMaskShort.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbMaskShort.Location = new System.Drawing.Point(535, 53);
            this.tbMaskShort.Name = "tbMaskShort";
            this.tbMaskShort.Size = new System.Drawing.Size(77, 30);
            this.tbMaskShort.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(497, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "or";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(643, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Enter subnets amount";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbSubnets
            // 
            this.tbSubnets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSubnets.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSubnets.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSubnets.Location = new System.Drawing.Point(726, 55);
            this.tbSubnets.Name = "tbSubnets";
            this.tbSubnets.Size = new System.Drawing.Size(77, 30);
            this.tbSubnets.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(903, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(311, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Enter min computers amount";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbComputers
            // 
            this.tbComputers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbComputers.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbComputers.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbComputers.Location = new System.Drawing.Point(969, 53);
            this.tbComputers.Name = "tbComputers";
            this.tbComputers.Size = new System.Drawing.Size(172, 30);
            this.tbComputers.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(67, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "(0.0.0.0)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(329, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "(0.0.0.0)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(558, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "/0";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(12, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1199, 51);
            this.button1.TabIndex = 13;
            this.button1.Text = "PRESS ME TO SEE THE MAGIC";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.columnIP,
            this.ColumnMask,
            this.ColumnAllipAmount,
            this.ColumnComputerAmount,
            this.ColumnFromTo});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.Location = new System.Drawing.Point(12, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1199, 309);
            this.dataGridView1.TabIndex = 19;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "";
            this.ColumnName.MinimumWidth = 6;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.Width = 125;
            // 
            // columnIP
            // 
            this.columnIP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.columnIP.HeaderText = "Nerwork\'s/Subnet\'s IP";
            this.columnIP.MinimumWidth = 6;
            this.columnIP.Name = "columnIP";
            this.columnIP.Width = 164;
            // 
            // ColumnMask
            // 
            this.ColumnMask.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnMask.HeaderText = "Network mask";
            this.ColumnMask.MinimumWidth = 6;
            this.ColumnMask.Name = "ColumnMask";
            this.ColumnMask.Width = 121;
            // 
            // ColumnAllipAmount
            // 
            this.ColumnAllipAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnAllipAmount.HeaderText = "All IP amount";
            this.ColumnAllipAmount.MinimumWidth = 6;
            this.ColumnAllipAmount.Name = "ColumnAllipAmount";
            this.ColumnAllipAmount.Width = 125;
            // 
            // ColumnComputerAmount
            // 
            this.ColumnComputerAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnComputerAmount.HeaderText = "Available computer amount";
            this.ColumnComputerAmount.MinimumWidth = 6;
            this.ColumnComputerAmount.Name = "ColumnComputerAmount";
            this.ColumnComputerAmount.Width = 125;
            // 
            // ColumnFromTo
            // 
            this.ColumnFromTo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnFromTo.HeaderText = "IP from ... to ...";
            this.ColumnFromTo.MinimumWidth = 6;
            this.ColumnFromTo.Name = "ColumnFromTo";
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.Color.SkyBlue;
            this.btClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClear.ForeColor = System.Drawing.Color.Navy;
            this.btClear.Location = new System.Drawing.Point(1025, 524);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(186, 29);
            this.btClear.TabIndex = 20;
            this.btClear.Text = "CLEAR";
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1226, 561);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbComputers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbSubnets);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMaskShort);
            this.Controls.Add(this.tbMaskFull);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbIP_Network);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Deviding the network into subnets (prod. by Karpenych)";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tbIP_Network;
        private Label label2;
        private TextBox tbMaskFull;
        private TextBox tbMaskShort;
        private Label label3;
        private Label label4;
        private TextBox tbSubnets;
        private Label label5;
        private TextBox tbComputers;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn columnIP;
        private DataGridViewTextBoxColumn ColumnMask;
        private DataGridViewTextBoxColumn ColumnAllipAmount;
        private DataGridViewTextBoxColumn ColumnComputerAmount;
        private DataGridViewTextBoxColumn ColumnFromTo;
        private Button btClear;
    }
}