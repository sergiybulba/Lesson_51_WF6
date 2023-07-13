using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListviewExample
{
    public partial class Form1 : Form
    {
        ListView listView1;
        public Form1()
        {
            InitializeComponent();
            // Создаем новый ListView
            listView1 = new ListView();

            // Зададим размер и местоположение списка на форме
            listView1.Bounds = new Rectangle(new Point(10, 10), new Size(300, 200));

            // Установим табличный режим отображения
            listView1.View = View.Details;

            // Позволим пользователю редактировать поле элемента списка
            listView1.LabelEdit = true;

            // Позволим пользователю перемещать столбцы в табличном режиме
            listView1.AllowColumnReorder = true;

            // Возле каждого элемента списка будет флажок
            listView1.CheckBoxes = true;

            // При выборе элемента списка будет подсвечена вся строка
            listView1.FullRowSelect = true;

            // Отобразим линии сетки в табличном режиме
            listView1.GridLines = true;

            // Установим сортировку элементов в порядке возрастания
            listView1.Sorting = SortOrder.Ascending;

            // Создадим колонки (1 параметр - название столбца, 2 параметр - ширина столбца, выравнивание названия)
            listView1.Columns.Add("wish list", 100, HorizontalAlignment.Left);
            //listView1.Columns.Add("icon", 60, HorizontalAlignment.Left);
            listView1.Columns.Add("name", 60, HorizontalAlignment.Left);
            listView1.Columns.Add("price", 60, HorizontalAlignment.Center);

            // Создадим три элемента списка и три подэлемента для каждого из них 
            ListViewItem item1 = new ListViewItem("apple", 0);
            item1.Checked = true; // Флажок элемента списка будет включен
            item1.SubItems.Add("apple");
            item1.SubItems.Add("103");

            ListViewItem item2 = new ListViewItem("pear", 1);
            item2.Checked = true; // Флажок элемента списка будет включен
            item2.SubItems.Add("pear");
            item2.SubItems.Add("165");

            ListViewItem item3 = new ListViewItem("watermelon", 2);
            item3.Checked = true; // Флажок элемента списка будет включен
            item3.SubItems.Add("watermelon");
            item3.SubItems.Add("199");

            ListViewItem item4 = new ListViewItem("orange", 3);
            item4.Checked = true; // Флажок элемента списка будет включен
            item4.SubItems.Add("orange");
            item4.SubItems.Add("75");

            ListViewItem item5 = new ListViewItem("plum", 4);
            item5.Checked = true; // Флажок элемента списка будет включен
            item5.SubItems.Add("plum");
            item5.SubItems.Add("84");



            // Добавляем элементы в список
            listView1.Items.AddRange(new ListViewItem[] { item1, item2, item3, item4, item5 });

            // Создаем два пустых списка изображений для больших и малых значков
            ImageList imageListSmall = new ImageList();
            //ImageList imageListLarge = new ImageList();

            // Инициализируем списки изображений картинками
            imageListSmall.Images.Add(Bitmap.FromFile("apple.jpg"));
            imageListSmall.Images.Add(Bitmap.FromFile("pear.jpg"));
            imageListSmall.Images.Add(Bitmap.FromFile("watermelon.jpg"));
            imageListSmall.Images.Add(Bitmap.FromFile("orange.jpg"));
            imageListSmall.Images.Add(Bitmap.FromFile("plum.jpg"));

            // ассоциируем списки изображений с ListView
            //listView1.LargeImageList = imageListLarge;
            listView1.SmallImageList = imageListSmall;

            // Добавляем ListView в коллекцию элементов управления
            this.Controls.Add(listView1);

            Width = 350; // Ширина формы
            Height = 250; // Высота формы
        }
    }
}
