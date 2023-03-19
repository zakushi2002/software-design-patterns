using FactoryMethod.Animal;
using FactoryMethod.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryMethod
{
    public partial class FormDemo : Form
    {
        IAnimalFactory factory;
        static string filePath = "D:\\Learningspace\\HK2_2022-2023_N3\\Software_Design_Patterns-12g30-16g00\\Assignment\\FactoryMethod\\FactoryMethod\\Images\\";
        public FormDemo()
        {
            InitializeComponent();
            
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            // Kiểm tra comboBox có rỗng không?
            if (comboBoxSelect.Text != "")
            {
                // Kiểm tra dữ liệu truyền vào comboBox
                string testIndex = comboBoxSelect.Text.ToString().ToLower().Trim();
                int type;
                if (!testIndex.Equals("lion") && !testIndex.Equals("horse") && !testIndex.Equals("panda"))
                {
                    MessageBox.Show("The program hasn't created this animal yet!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Kiểm tra text nhập vào khi type = -1
                    type = comboBoxSelect.SelectedIndex;
                    if (testIndex.Equals("lion") && type ==-1)
                    {
                        type = 0;
                    }
                    else if (testIndex.Equals("horse") && type == -1)
                    {
                        type = 1;
                    }
                    else if (testIndex.Equals("panda") && type == -1) 
                    {
                        type = 2; 
                    }
                    factory = new BasicAnimalFactory(type);
                    labelCreate.Visible = true;
                    labelCreate.Text = factory.createAnimal().getName();
                    pictureBoxCreate.Image = Image.FromFile(filePath + factory.createAnimal().getImage());
                }
                 
                
            }
            else
            {
                MessageBox.Show("Please do not leave it blank!", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonRandomCreate_Click(object sender, EventArgs e)
        {
            factory = new RandomAnimalFactory();
            labelRandom.Visible = true;
            labelRandom.Text = factory.createAnimal().getName();
            pictureBoxCreateRadom.Image = Image.FromFile(filePath + factory.createAnimal().getImage());
        }
    }
}
