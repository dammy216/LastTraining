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
            foreach (var control1 in foodGroup.Controls)
            {
                RadioButton radioButton1 = control1 as RadioButton;
                foreach (var control2 in sizeGroup.Controls)
                {
                    RadioButton radioButton2 = control2 as RadioButton;
                    if (radioButton1.Checked == true && radioButton2.Checked == true)
                    {
                        Size size = (Size)Enum.Parse(typeof(Size), radioButton2.Text);

                        if (radioButton1.Text == "あずき")
                            manager.Add(new Azuki(radioButton1.Text, size));
                        if (radioButton1.Text == "カスタード")
                            manager.Add(new Custard(radioButton1.Text, size));
                        if (radioButton1.Text == "栗")
                            manager.Add(new Kuri(radioButton1.Text, size));
                    }
                }
            }
            Form1 form = new Form1();  // 新しいForm1インスタンスを作成
            form.AddFoodItem(manager);
        }
    }
}
