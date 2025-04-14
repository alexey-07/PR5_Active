namespace PR2
{
    partial class FormTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTypes));
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            buttonStory = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panelMain = new Panel();
            dataGridViewFill = new DataGridView();
            flowLayoutPanel1.SuspendLayout();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFill).BeginInit();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.FromArgb(103, 186, 128);
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Location = new Point(18, 18);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(151, 35);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.FromArgb(103, 186, 128);
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Location = new Point(175, 18);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(151, 35);
            buttonEdit.TabIndex = 3;
            buttonEdit.Text = "Редактировать";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(103, 186, 128);
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Location = new Point(332, 18);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(151, 35);
            buttonDelete.TabIndex = 4;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonStory
            // 
            buttonStory.BackColor = Color.FromArgb(103, 186, 128);
            buttonStory.FlatStyle = FlatStyle.Flat;
            buttonStory.Location = new Point(489, 18);
            buttonStory.Name = "buttonStory";
            buttonStory.Size = new Size(151, 35);
            buttonStory.TabIndex = 5;
            buttonStory.Text = "История поставок";
            buttonStory.UseVisualStyleBackColor = false;
            buttonStory.Click += buttonStory_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.BackColor = Color.FromArgb(244, 232, 211);
            flowLayoutPanel1.Controls.Add(buttonAdd);
            flowLayoutPanel1.Controls.Add(buttonEdit);
            flowLayoutPanel1.Controls.Add(buttonDelete);
            flowLayoutPanel1.Controls.Add(buttonStory);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(15);
            flowLayoutPanel1.Size = new Size(800, 71);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(244, 232, 211);
            panelMain.Controls.Add(dataGridViewFill);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 71);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(15);
            panelMain.Size = new Size(800, 379);
            panelMain.TabIndex = 8;
            // 
            // dataGridViewFill
            // 
            dataGridViewFill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFill.BackgroundColor = Color.White;
            dataGridViewFill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFill.Dock = DockStyle.Fill;
            dataGridViewFill.Location = new Point(15, 15);
            dataGridViewFill.MultiSelect = false;
            dataGridViewFill.Name = "dataGridViewFill";
            dataGridViewFill.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewFill.Size = new Size(770, 349);
            dataGridViewFill.TabIndex = 2;
            // 
            // FormTypes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panelMain);
            Controls.Add(flowLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormTypes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главный экран";
            Load += FormTypes_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewFill).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonDelete;
        private Button buttonStory;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panelMain;
        private DataGridView dataGridViewFill;
    }
}
