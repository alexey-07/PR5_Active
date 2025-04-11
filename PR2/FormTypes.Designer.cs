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
            dataGridViewTop = new DataGridView();
            dataGridViewFill = new DataGridView();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            buttonStory = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFill).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTop
            // 
            dataGridViewTop.BackgroundColor = Color.FromArgb(103, 186, 128);
            dataGridViewTop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTop.Dock = DockStyle.Top;
            dataGridViewTop.Location = new Point(0, 0);
            dataGridViewTop.Name = "dataGridViewTop";
            dataGridViewTop.Size = new Size(800, 60);
            dataGridViewTop.TabIndex = 0;
            // 
            // dataGridViewFill
            // 
            dataGridViewFill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFill.BackgroundColor = Color.FromArgb(244, 232, 211);
            dataGridViewFill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFill.Dock = DockStyle.Fill;
            dataGridViewFill.Location = new Point(0, 60);
            dataGridViewFill.MultiSelect = false;
            dataGridViewFill.Name = "dataGridViewFill";
            dataGridViewFill.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewFill.Size = new Size(800, 390);
            dataGridViewFill.TabIndex = 1;
            dataGridViewFill.CellClick += dataGridViewFill_CellClick;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.White;
            buttonAdd.Location = new Point(22, 12);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(151, 35);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.White;
            buttonEdit.Location = new Point(174, 12);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(151, 35);
            buttonEdit.TabIndex = 3;
            buttonEdit.Text = "Редактировать";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.White;
            buttonDelete.Location = new Point(326, 12);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(151, 35);
            buttonDelete.TabIndex = 4;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonStory
            // 
            buttonStory.BackColor = Color.White;
            buttonStory.Location = new Point(478, 12);
            buttonStory.Name = "buttonStory";
            buttonStory.Size = new Size(151, 35);
            buttonStory.TabIndex = 5;
            buttonStory.Text = "История поставок";
            buttonStory.UseVisualStyleBackColor = false;
            buttonStory.Click += buttonStory_Click;
            // 
            // FormTypes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonStory);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewFill);
            Controls.Add(dataGridViewTop);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormTypes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главный экран";
            Load += FormTypes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTop).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFill).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewTop;
        private DataGridView dataGridViewFill;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonDelete;
        private Button buttonStory;
    }
}
