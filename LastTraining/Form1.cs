using System;
using System.Windows.Forms;

namespace LastTraining
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void AddFoodItem(FoodManager manager)
        {
            foreach (var m in manager.Foods)
            {
                ListViewItem item = new ListViewItem();
                if (m is IAnko)
                    item.Text = $"{m.Name}({m.ProductSize}){(m as IAnko).Anko}";
                else
                    item.Text = $"{m.Name}({m.ProductSize})";

                ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem();
                subItem.Text = m.TotalPrice.ToString();

                item.SubItems.Add(subItem);
                listView.Items.Add(item);
            }
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
