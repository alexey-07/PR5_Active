using Microsoft.EntityFrameworkCore;
using PR2.Models;
using System.Windows.Forms;
using AppContext = PR2.Models.AppContext;
namespace PR2
{
    public partial class FormTypes : Form
    {
        private AppContext db;

        public FormTypes()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            db = new AppContext();
            LoadMaterialTypes(); // Вызов метода, который загрузит и отобразит типы партнеров

        }

        private async void LoadMaterialTypes()
        {
            try
            {
                var suppliers = db.Suppliers
                   .Include(i => i.SupplierType)
                   .Select(s => new
                   {
                       s.Id,
                       s.SupplierType.TypeSupplier,
                       s.NameSupplier,
                       s.Inn,
                       s.IsActive
                   })
                   .OrderBy(o => o.NameSupplier)
                   .ToList();

                this.dataGridViewFill.DataSource = suppliers;
                // Проверяем, существует ли столбец "AverageQualitySupply"
                if (!dataGridViewFill.Columns.Contains("AverageQualitySupply"))
                {
                    DataGridViewTextBoxColumn newColumn = new DataGridViewTextBoxColumn();
                    newColumn.Name = "AverageQualitySupply";
                    newColumn.HeaderText = "Среднее количество поставок";
                    newColumn.Width = 100;

                    dataGridViewFill.Columns.Add(newColumn);
                }
                foreach (DataGridViewRow row in dataGridViewFill.Rows)
                {
                    int id_supplier = (int)row.Cells["Id"].Value;
                    if (db.SuppliersMaterials.Where(w => w.IdSupplier == id_supplier).Count() != 0)
                    {
                        double avgQuality = db.SuppliersMaterials
                            .Where(w => w.IdSupplier == id_supplier)
                            .Select(s => (double)s.QualitySupply)
                            .Average();

                        row.Cells["AverageQualitySupply"].Value = avgQuality;
                    }
                    else
                    {
                        row.Cells["AverageQualitySupply"].Value = null;
                    }

                }

                // Скрываем столбцы 
                dataGridViewFill.Columns["Id"].Visible = false; // Скрываем столбец Id
                dataGridViewFill.Columns["TypeSupplier"].HeaderText = "Тип поставщика";
                dataGridViewFill.Columns["NameSupplier"].HeaderText = "Наименование";
                dataGridViewFill.Columns["Inn"].HeaderText = "ИНН";
                dataGridViewFill.Columns["IsActive"].HeaderText = "Действующий";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}");
            }
        }

        private void buttonStory_Click(object sender, EventArgs e)
        {
            var selectedSupplierResult = GetSelectedSupplier();
            if (selectedSupplierResult != null)
            {
                int supplierId = selectedSupplierResult.Id;
                ShowDeliveryHistory(supplierId);
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите поставщика для просмотра истории.");
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (FormExit formAdd = new FormExit())
            {
                DialogResult result = formAdd.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                Supplier supplier = new Supplier
                {
                    NameSupplier = formAdd.NameSupplier,
                    IdSupplierType = formAdd.SelectedSupplierType.Id,
                    Inn = formAdd.Inn
                    
                };

                using (var db = new AppContext())
                {
                    db.Suppliers.Add(supplier);
                    db.SaveChanges();
                }

                MessageBox.Show("Новый поставщик добавлен");
                LoadMaterialTypes();
            }
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var selectedSupplierResult = GetSelectedSupplier(); // Получаем выбранного поставщика

            if (selectedSupplierResult != null)
            {
                // Получаем оригинальный объект Supplier из базы данных
                var selectedSupplier = db.Suppliers.Find(selectedSupplierResult.Id);

                if (selectedSupplier != null)
                {
                    using (FormExit formEdit = new FormExit(selectedSupplier)) // Передаем выбранного поставщика в форму редактирования
                    {
                        DialogResult result = formEdit.ShowDialog(this);

                        if (result == DialogResult.OK) // Если пользователь нажал "ОК"
                        {
                            try
                            {
                                // Обновляем свойства выбранного поставщика
                                selectedSupplier.NameSupplier = formEdit.NameSupplier; // Обновляем название поставщика
                                selectedSupplier.IdSupplierType = formEdit.SelectedSupplierType?.Id ?? 0; // Извлекаем Id типа поставщика
                                selectedSupplier.Inn = formEdit.Inn;
                                

                                db.Suppliers.Update(selectedSupplier); // Обновляем запись в базе данных
                                db.SaveChanges(); // Сохраняем изменения
                                MessageBox.Show("Поставщик обновлен");
                                LoadMaterialTypes(); // Обновляем список типов продуктов
                            }
                            catch (DbUpdateException dbEx)
                            {
                                MessageBox.Show($"Ошибка при обновлении: {dbEx.InnerException?.Message ?? dbEx.Message}");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Ошибка при обновлении: {ex.Message}");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Выбранный поставщик не найден в базе данных.");
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите поставщика для редактирования.");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var selectedSupplierResult = GetSelectedSupplier(); // Получаем выбранного поставщика

            if (selectedSupplierResult != null)
            {
                var confirmResult = MessageBox.Show("Вы уверены, что хотите удалить этого поставщика?",
                                                     "Подтверждение удаления",
                                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    // Находим объект Supplier в базе данных по Id
                    var supplierToDelete = db.Suppliers.Find(selectedSupplierResult.Id);

                    if (supplierToDelete != null)
                    {
                        db.Suppliers.Remove(supplierToDelete); // Удаляем найденного поставщика
                        db.SaveChanges(); // Сохраняем изменения в базе данных
                        MessageBox.Show("Поставщик удален");
                        LoadMaterialTypes(); // Обновляем список поставщиков
                    }
                    else
                    {
                        MessageBox.Show("Поставщик не найден в базе данных.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите поставщика для удаления.");
            }
        }
        private dynamic GetSelectedSupplier()
        {
            if (dataGridViewFill.SelectedRows.Count > 0)
            {
                return dataGridViewFill.SelectedRows[0].DataBoundItem; // Получаем выбранный элемент
            }
            return null; // Если ничего не найдено
        }

        private void FormTypes_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewFill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void ShowDeliveryHistory(int supplierId)
        {
            FormStore historyForm = new FormStore(supplierId);
            historyForm.Show(); // Открытие новой формы
        }
    }
}



