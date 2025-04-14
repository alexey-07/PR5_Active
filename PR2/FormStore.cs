//using System.Windows.Forms;
//using Microsoft.EntityFrameworkCore;
//using PR2.Models;
//using AppContext = PR2.Models.AppContext;

//namespace PR2
//{
//    public partial class FormStore : Form
//    {
//        private int supplierId;
//        private AppContext db;
//        protected override void OnLoad(EventArgs e)
//        {
//            base.OnLoad(e);
//            db = new AppContext();

//        }
//        public FormStore(int supplierId)
//        {
//            InitializeComponent();
//            this.supplierId = supplierId;
//            LoadDeliveryHistory(); // Метод для загрузки истории поставок
//            LoadSuppliersMaterials(); // Вызов метода, который загрузит и отобразит материалы поставщиков
//        }
//        private void LoadDeliveryHistory()
//        {
//            using (db = new AppContext())
//            {
//                var deliveries = db.SuppliersMaterials
//                    .Where(d => d.IdSupplier == supplierId)
//                    .Include(d => d.Material.MaterialType) // Загрузка связанных данных
//                    .ToList();

//                if (deliveries.Count == 0)
//                {
//                    MessageBox.Show("У данного поставщика нет поставок.");
//                }
//                else
//                {
//                    dataGridViewFillStore.DataSource = deliveries.Select(sm => new
//                    {
//                        MaterialType = sm.Material.MaterialType.TypeMaterial,
//                        sm.CountPack,
//                        sm.DateOfSupply,
//                        sm.CostForPack,
//                        sm.QualitySupply
//                    }).ToList();
//                }
//            }
//        }


//        private async void LoadSuppliersMaterials()
//        {
//            try
//            {
//                // Загрузка связанных данных
//                this.db.SuppliersMaterials
//                    .Include(sm => sm.Material.MaterialType)
//                    .Load();

//                // Настройка источника данных для DataGridView
//                this.dataGridViewFillStore.DataSource = this.db.SuppliersMaterials.Local
//                    .OrderBy(o => o.Material.MaterialType.TypeMaterial) // Сортировка по типу материала
//                    .Select(sm => new
//                    {
//                        MaterialType = sm.Material.MaterialType.TypeMaterial, // Используем тип материала
//                        sm.CountPack,
//                        sm.DateOfSupply,
//                        sm.CostForPack,
//                        sm.QualitySupply

//                    })
//                    .ToList();

//                // Загрузка материалов поставщиков из базы данных
//                var suppliersMaterials = await db.SuppliersMaterials.ToListAsync();


//                if (dataGridViewFillStore.Columns.Contains("Id"))
//                {
//                    dataGridViewFillStore.Columns["Id"].Visible = false; // Скрываем столбец Id
//                    dataGridViewFillStore.Columns["IdMaterial"].Visible = false; // Скрываем столбец Id
//                    dataGridViewFillStore.Columns["Material"].Visible = false;
//                    dataGridViewFillStore.Columns["Supplier"].Visible = false;


//                    dataGridViewFillStore.Columns["IdSupplier"].HeaderText = "Тип поставщика";
//                    dataGridViewFillStore.Columns["CountPack"].HeaderText = "Количество упаковк";
//                    dataGridViewFillStore.Columns["DateOfSupply"].HeaderText = "Дата поставки";
//                    dataGridViewFillStore.Columns["CostForPack"].HeaderText = "Цена за упаковку";
//                    dataGridViewFillStore.Columns["QualitySupply"].HeaderText = "Качество поставки";
//                }
//            }

//            catch (Exception ex)
//            {
//                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}");
//            }
//        }


//        private void FormStore_Load(object sender, EventArgs e)
//        {

//        }

//        private void dataGridViewFillStore_CellContentClick(object sender, DataGridViewCellEventArgs e)
//        {

//        }

//        private void labelStore_Click(object sender, EventArgs e)
//        {
//            labelStore = new Label();
//            labelStore.Location = new Point(10, 10); // Пример позиции
//            labelStore.Size = new Size(200, 30); // Пример размера
//            this.Controls.Add(labelStore); // Добавление на форму
//        }
//    }
//}

using Microsoft.EntityFrameworkCore;

using AppContext = PR2.Models.AppContext;

namespace PR2
{
    public partial class FormStore : Form
    {
        private int supplierId;
        private AppContext db;


        public FormStore(int supplierId)
        {
            InitializeComponent();
            this.supplierId = supplierId;
            db = new AppContext(); // Инициализация контекста базы данных
            LoadSuppliersMaterials(); // Загрузка материалов поставщиков
            LoadDeliveryHistory(); // Загрузка истории поставок
        }

        private async void LoadDeliveryHistory()
        {
            try
            {
                using (var db = new AppContext()) // Создаем новый экземпляр контекста
                {
                    // Получаем тип поставщика для текущего supplierId
                    var supplierType = await db.Suppliers
                        .Where(s => s.Id == supplierId)
                        .Include(s => s.SupplierType)
                        .Select(s => s.SupplierType.TypeSupplier)
                        .FirstOrDefaultAsync();
                    // Устанавливаем текст в Label для отображения типа поставщика
                    labelStore.Text = $"Тип поставщика: {supplierType}";

                    var deliveries = await db.SuppliersMaterials
                        .Where(d => d.IdSupplier == supplierId)
                        .Include(d => d.Material.MaterialType) // Загрузка связанных данных
                        .ToListAsync(); // Используем ToListAsync для асинхронной загрузки

                    // Если у поставщика нет поставок
                    // 
                    if (!deliveries.Any()) // Используем Any() для проверки наличия элементов
                    {
                        dataGridViewFillStore.DataSource = null; // Очищаем DataGridView
                        labelNoDeliveries.Text = "Нет поставок для данного поставщика."; // Устанавливаем текст в Label
                        labelNoDeliveries.Visible = true; // Делаем Label видимым
                        dataGridViewFillStore.Visible = false; // Скрываем DataGridView
                        return; // Выходим из метода
                    }
                    //if (deliveries.Count == 0)
                    //{

                    //    dataGridViewFillStore.DataSource = null; // Очищаем DataGridView
                    //    return; // Выходим из метода
                    //}

                    // Заполняем DataGridView данными, если они есть
                    dataGridViewFillStore.DataSource = deliveries.Select(sm => new
                    {
                        sm.Id,
                        MaterialType = sm.Material.MaterialType.TypeMaterial,
                        sm.CountPack,
                        sm.DateOfSupply,
                        sm.CostForPack,
                        sm.QualitySupply
                    })
                        .ToList();

                    if (dataGridViewFillStore.Columns.Contains("Id"))
                    {
                        dataGridViewFillStore.Columns["Id"].Visible = false;
                        //dataGridViewFillStore.Columns["IdMaterial"].Visible = false;
                        //dataGridViewFillStore.Columns["Material"].Visible = false;
                        //dataGridViewFillStore.Columns["Supplier"].Visible = false;

                       
                        dataGridViewFillStore.Columns["MaterialType"].HeaderText = "Тип материала";
                        dataGridViewFillStore.Columns["CountPack"].HeaderText = "Количество упаковок";
                        dataGridViewFillStore.Columns["DateOfSupply"].HeaderText = "Дата поставки";
                        dataGridViewFillStore.Columns["CostForPack"].HeaderText = "Цена за упаковку";
                        dataGridViewFillStore.Columns["QualitySupply"].HeaderText = "Качество поставки";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}");
            }
        }

        private async void LoadSuppliersMaterials()
        {
            try
            {
                using (var db = new AppContext()) // Создаем новый экземпляр контекста
                {
                    // Получаем тип поставщика для текущего supplierId
                    var supplierType = await db.Suppliers
                        .Where(s => s.Id == supplierId)
                        .Select(s => s.IdSupplierType) 
                        .FirstOrDefaultAsync();

                    // Загружаем все поставки с тем же типом поставщика
                    var deliveries = await db.SuppliersMaterials
                        .Where(d => d.Material.MaterialType.Id == supplierType) // Фильтруем по типу поставщика
                        .Include(d => d.Material.MaterialType) // Загрузка связанных данных
                        .ToListAsync(); // Используем ToListAsync для асинхронной загрузки

                    // Если у поставщика нет поставок, оставляем DataGridView пустым
                    if (deliveries.Count == 0)
                    {
                        dataGridViewFillStore.DataSource = null; // Очищаем DataGridView
                        return; // Выходим из метода
                    }

                    // Заполняем DataGridView данными, если они есть
                    dataGridViewFillStore.DataSource = deliveries.Select(sm => new
                    {
                        MaterialType = sm.Material.MaterialType.TypeMaterial,
                        sm.CountPack,
                        sm.DateOfSupply,
                        sm.CostForPack,
                        sm.QualitySupply
                    }).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}");
            }
        }

        private void FormStore_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.Dispose(); // Утилизация контекста при закрытии формы
        }

        private void dataGridViewFillStore_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Обработка клика по ячейке, если необходимо//
        }

        private void labelStore_Click(object sender, EventArgs e)
        {
            // Обработка клика по метке, если необходимо
        }
    }
}