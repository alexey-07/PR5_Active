namespace PR2
{
    partial class FormStore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStore));
            dataGridViewTopStore = new DataGridView();
            dataGridViewFillStore = new DataGridView();
            labelStore = new Label();
            labelNoDeliveries = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTopStore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFillStore).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTopStore
            // 
            dataGridViewTopStore.BackgroundColor = Color.FromArgb(103, 186, 128);
            dataGridViewTopStore.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTopStore.Dock = DockStyle.Top;
            dataGridViewTopStore.Location = new Point(0, 0);
            dataGridViewTopStore.Name = "dataGridViewTopStore";
            dataGridViewTopStore.Size = new Size(981, 63);
            dataGridViewTopStore.TabIndex = 0;
            // 
            // dataGridViewFillStore
            // 
            dataGridViewFillStore.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFillStore.BackgroundColor = Color.FromArgb(244, 232, 211);
            dataGridViewFillStore.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFillStore.Dock = DockStyle.Fill;
            dataGridViewFillStore.Location = new Point(0, 63);
            dataGridViewFillStore.MultiSelect = false;
            dataGridViewFillStore.Name = "dataGridViewFillStore";
            dataGridViewFillStore.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewFillStore.Size = new Size(981, 439);
            dataGridViewFillStore.TabIndex = 1;
            dataGridViewFillStore.CellContentClick += dataGridViewFillStore_CellContentClick;
            // 
            // labelStore
            // 
            labelStore.AutoSize = true;
            labelStore.BackColor = Color.White;
            labelStore.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelStore.Location = new Point(12, 22);
            labelStore.Name = "labelStore";
            labelStore.Size = new Size(147, 21);
            labelStore.TabIndex = 2;
            labelStore.Text = "История поставок: ";
            labelStore.Click += labelStore_Click;
            // 
            // labelNoDeliveries
            // 
            labelNoDeliveries.AutoSize = true;
            labelNoDeliveries.BackColor = Color.FromArgb(244, 232, 211);
            labelNoDeliveries.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelNoDeliveries.Location = new Point(43, 113);
            labelNoDeliveries.Name = "labelNoDeliveries";
            labelNoDeliveries.Size = new Size(0, 25);
            labelNoDeliveries.TabIndex = 3;
            // 
            // FormStore
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 502);
            Controls.Add(labelNoDeliveries);
            Controls.Add(labelStore);
            Controls.Add(dataGridViewFillStore);
            Controls.Add(dataGridViewTopStore);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormStore";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "История поставок";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTopStore).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFillStore).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewTopStore;
        private DataGridView dataGridViewFillStore;
        private Label labelStore;
        private Label labelNoDeliveries;
    }
}