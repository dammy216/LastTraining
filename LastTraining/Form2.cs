using System;
using System.Windows.Forms;

namespace LastTraining
{
    public partial class Form2 : Form
    {

        private FoodManager manager = new FoodManager();

        public Form2()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            foreach (RadioButton control1 in foodGroup.Controls)
            {
                foreach (RadioButton control2 in sizeGroup.Controls)
                {
                    Size size = (Size)Enum.Parse(typeof(Size), control2.Text);

                    if (control1.Checked == true && control2.Checked == true)
                    {
                        if (custardButton.Checked)
                        {
                            manager.Add(new Custard(control1.Text, size));
                            continue;
                        }
                    }
                    foreach (RadioButton control3 in ankoGroup.Controls)
                    {
                        if (control1.Checked == true && control2.Checked == true && control3.Checked == true)
                        {
                            if (azukiButton.Checked)
                                manager.Add(new Azuki(control1.Text, size, control3.Text));
                            if (kuriButton.Checked)
                                manager.Add(new Kuri(control1.Text, size, control3.Text));
                        }
                    }
                }
            }
            Form1 form = new Form1();  // 新しいForm1インスタンスを作成
            form.AddFoodItem(manager);
            form.ShowDialog();
        }

        private void custardButton_CheckedChanged(object sender, EventArgs e)
        {
            ankoGroup.Enabled = !custardButton.Checked;
        }

        private void azukiButton_CheckedChanged(object sender, EventArgs e)
        {
            koshiButton.Checked = true;
        }

        private void kuriButton_CheckedChanged(object sender, EventArgs e)
        {
            tsubuButton.Checked = true;
        }
    }
}
