
using Microsoft.EntityFrameworkCore;
using AppContext = PR2.Models.AppContext;
using PR2.Models;

namespace PR2
{
    public partial class FormAddAndEdit : Form
    {
        string msgError = "Поле не может быть пустым";
        private Supplier selectedSupplier;

        public SupplierType SelectedSupplierType { get; set; } 
        public string NameSupplier { get; set; } 
        public string Inn { get; set; } 

        public FormAddAndEdit()
        {
            InitializeComponent();
        }

        public FormAddAndEdit(Supplier supplier) : this()
        {
            selectedSupplier = supplier;
            
            if (selectedSupplier != null)
            {
                
                comboBoxTypeId.Text=selectedSupplier.IdSupplierType.ToString();
                textBoxName.Text = selectedSupplier.NameSupplier; 
                textBoxInn.Text = selectedSupplier.Inn; 
                SelectedSupplierType = selectedSupplier.SupplierType;
                checkBox.Checked = selectedSupplier.IsActive;
            }
            LoadSupplierTypes();
        }

        private async void FormExit_Load(object sender, EventArgs e)
        {
            await LoadSupplierTypes();
        }

        private async Task LoadSupplierTypes()
        {
            try
            {
                using (var db = new AppContext())
                {
                    var supplierTypes = await db.SupplierTypes.ToListAsync();
                    comboBoxTypeId.DataSource = supplierTypes;
                    comboBoxTypeId.DisplayMember = "TypeSupplier";
                    comboBoxTypeId.ValueMember = "Id"; 

                
                    if (SelectedSupplierType != null)
                    {
                        comboBoxTypeId.SelectedItem = supplierTypes.FirstOrDefault(st => st.Id == SelectedSupplierType.Id);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке типов поставщиков: {ex.Message}");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxTypeId.SelectedItem is SupplierType selectedType)
            {
                // Сохраняем выбранный тип поставщика
                SelectedSupplierType = selectedType;
            }

            
            NameSupplier = textBoxName.Text; 

           
            Inn = textBoxInn.Text; 

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCanel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; 
            this.Close(); 
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_TextChanged(object sender, EventArgs e)
        {
            SupplierType type = (SupplierType)comboBoxTypeId.SelectedItem;
            MessageBox.Show(type.TypeSupplier);
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            // Проверяем, пустое ли поле
            if (String.IsNullOrEmpty(textBoxName.Text))
            {
                errorProviderName.SetError(textBoxName, msgError);
                buttonSave.Enabled = false; // Деактивируем кнопку "Сохранить"
            }
            else
            {
                errorProviderName.Clear();
                buttonSave.Enabled = true; // Активируем кнопку "Сохранить"
            }
        }

        private void textBoxName_Validated(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxName.Text))
            {
                errorProviderName.SetError(textBoxName, msgError);
                buttonSave.Enabled = false;
            }
            else
            {
                errorProviderName.Clear();
                buttonSave.Enabled = true;
            }
        }

        private void textBoxInn_TextChanged(object sender, EventArgs e)
        {
            // Проверяем, пустое ли поле
            if (String.IsNullOrEmpty(textBoxInn.Text))
            {
                errorProviderName.SetError(textBoxInn, msgError);
                buttonSave.Enabled = false; // Деактивируем кнопку "Сохранить"
            }
            else
            {
                errorProviderName.Clear();
                buttonSave.Enabled = true; // Активируем кнопку "Сохранить"
            }
        }

        private void textBoxInn_Validated(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxInn.Text))
            {
                errorProviderInn.SetError(textBoxInn, msgError);
                buttonSave.Enabled = false;
            }
            else
            {
                errorProviderInn.Clear();
                buttonSave.Enabled = true;
            }
        }
    }
}