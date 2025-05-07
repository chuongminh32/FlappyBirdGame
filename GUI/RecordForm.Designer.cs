namespace Flappybird
{
    partial class RecordForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgvTopPlayer = new DataGridView();
            txtName = new Label();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTopPlayer).BeginInit();
            SuspendLayout();
            // 
            // dgvTopPlayer
            // 
            dgvTopPlayer.AllowUserToAddRows = false;
            dgvTopPlayer.AllowUserToDeleteRows = false;
            dgvTopPlayer.AllowUserToResizeColumns = false;
            dgvTopPlayer.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.Linen;
            dgvTopPlayer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvTopPlayer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTopPlayer.BackgroundColor = Color.Moccasin;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.DarkRed;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvTopPlayer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvTopPlayer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvTopPlayer.DefaultCellStyle = dataGridViewCellStyle3;
            dgvTopPlayer.EnableHeadersVisualStyles = false;
            dgvTopPlayer.GridColor = Color.LightSalmon;
            dgvTopPlayer.Location = new Point(101, 109);
            dgvTopPlayer.MultiSelect = false;
            dgvTopPlayer.Name = "dgvTopPlayer";
            dgvTopPlayer.ReadOnly = true;
            dgvTopPlayer.RowHeadersVisible = false;
            dgvTopPlayer.RowHeadersWidth = 51;
            dgvTopPlayer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTopPlayer.Size = new Size(587, 254);
            dgvTopPlayer.TabIndex = 20;
            // 
            // txtName
            // 
            txtName.AutoSize = true;
            txtName.BackColor = Color.Transparent;
            txtName.Font = new Font("Segoe UI Variable Display", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.ForeColor = Color.OrangeRed;
            txtName.Location = new Point(281, 48);
            txtName.Name = "txtName";
            txtName.Size = new Size(189, 40);
            txtName.TabIndex = 21;
            txtName.Text = "TOP PLAYER";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Tomato;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.Snow;
            btnBack.Location = new Point(101, 48);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(126, 40);
            btnBack.TabIndex = 22;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // RecordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.background1;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(txtName);
            Controls.Add(dgvTopPlayer);
            Name = "RecordForm";
            Text = "Form1";
            FormClosing += RecordForm_FormClosing;
            Load += RecordForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTopPlayer).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private DataGridView dgvTopPlayer;
        private Label txtName;
        private Button btnBack;
    }
}
