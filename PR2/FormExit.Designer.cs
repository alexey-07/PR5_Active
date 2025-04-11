namespace PR2
{
    partial class FormExit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExit));
            textBoxName = new TextBox();
            textBoxInn = new TextBox();
            label2 = new Label();
            labelName = new Label();
            label4 = new Label();
            label5 = new Label();
            checkBox = new CheckBox();
            buttonCanel = new Button();
            buttonSave = new Button();
            comboBoxTypeId = new ComboBox();
            errorProviderName = new ErrorProvider(components);
            errorProviderInn = new ErrorProvider(components);
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)errorProviderName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderInn).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(13, 72);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(350, 23);
            textBoxName.TabIndex = 2;
            textBoxName.TextChanged += textBoxName_TextChanged;
            textBoxName.Validated += textBoxName_Validated;
            // 
            // textBoxInn
            // 
            textBoxInn.Location = new Point(13, 116);
            textBoxInn.Name = "textBoxInn";
            textBoxInn.Size = new Size(350, 23);
            textBoxInn.TabIndex = 3;
            textBoxInn.TextChanged += textBoxInn_TextChanged;
            textBoxInn.Validated += textBoxInn_Validated;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 10);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 7;
            label2.Text = "ID Типа поставщика";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(13, 54);
            labelName.Name = "labelName";
            labelName.Size = new Size(59, 15);
            labelName.TabIndex = 8;
            labelName.Text = "Название";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 98);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 9;
            label4.Text = "ИНН";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 142);
            label5.Name = "label5";
            label5.Size = new Size(121, 15);
            label5.TabIndex = 10;
            label5.Text = "Активно / неактивно";
            // 
            // checkBox
            // 
            checkBox.AutoSize = true;
            checkBox.Location = new Point(13, 160);
            checkBox.Name = "checkBox";
            checkBox.Size = new Size(72, 19);
            checkBox.TabIndex = 22;
            checkBox.Text = "Активно";
            checkBox.UseVisualStyleBackColor = true;
            checkBox.CheckedChanged += checkBox_CheckedChanged;
            checkBox.TextChanged += checkBox_TextChanged;
            // 
            // buttonCanel
            // 
            buttonCanel.BackColor = Color.White;
            buttonCanel.Location = new Point(13, 13);
            buttonCanel.Name = "buttonCanel";
            buttonCanel.Size = new Size(75, 28);
            buttonCanel.TabIndex = 13;
            buttonCanel.Text = "Отмена";
            buttonCanel.UseVisualStyleBackColor = false;
            buttonCanel.Click += buttonCanel_Click;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.White;
            buttonSave.Location = new Point(94, 13);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 28);
            buttonSave.TabIndex = 14;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // comboBoxTypeId
            // 
            comboBoxTypeId.FormattingEnabled = true;
            comboBoxTypeId.Location = new Point(13, 28);
            comboBoxTypeId.Name = "comboBoxTypeId";
            comboBoxTypeId.Size = new Size(350, 23);
            comboBoxTypeId.TabIndex = 24;
            // 
            // errorProviderName
            // 
            errorProviderName.ContainerControl = this;
            // 
            // errorProviderInn
            // 
            errorProviderInn.ContainerControl = this;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(buttonCanel);
            flowLayoutPanel1.Controls.Add(buttonSave);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 201);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.Size = new Size(384, 55);
            flowLayoutPanel1.TabIndex = 25;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(label2);
            flowLayoutPanel2.Controls.Add(comboBoxTypeId);
            flowLayoutPanel2.Controls.Add(labelName);
            flowLayoutPanel2.Controls.Add(textBoxName);
            flowLayoutPanel2.Controls.Add(label4);
            flowLayoutPanel2.Controls.Add(textBoxInn);
            flowLayoutPanel2.Controls.Add(label5);
            flowLayoutPanel2.Controls.Add(checkBox);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(10, 10, 20, 10);
            flowLayoutPanel2.Size = new Size(384, 201);
            flowLayoutPanel2.TabIndex = 26;
            // 
            // FormExit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(384, 256);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormExit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Справочник";
            Load += FormExit_Load;
            ((System.ComponentModel.ISupportInitialize)errorProviderName).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderInn).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBoxName;
        private TextBox textBoxInn;
        private Label label2;
        private Label labelName;
        private Label label4;
        private Label label5;
        private Button buttonCanel;
        private Button buttonSave;
        protected internal CheckBox checkBox;
        private ComboBox comboBoxTypeId;
        private ErrorProvider errorProviderName;
        private ErrorProvider errorProviderInn;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
    }
}