using Decorator.Core;
using Decorator.Decorators;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decorator
{
    public partial class DecoratorDemo : Form
    {
        static string filePath = "D:\\Learningspace\\HK2_2022-2023_N3\\Software_Design_Patterns-12g30-16g00\\Done\\software-design-patterns\\Decorator\\Images\\";
        Pizza pizza = new Pizza();
        IPizza temp;
        IPizza buy;
        string extra;
        public DecoratorDemo()
        {
            InitializeComponent();
            buy = pizza;
            pictureBoxIngredient.SizeMode = PictureBoxSizeMode.StretchImage;
            /*IPizza pizzaMushroom = new Mushroom(pizza);
            IPizza pizzaTomato = new Tomato(pizza);
            IPizza pizzaShrimp = new Shrimp(pizza);
            IPizza pizzaSquid = new Squid(pizza);
            IPizza pizzaMushroomTomato = new Tomato(new Mushroom(pizza));
            IPizza pizzaMushroomShrimp = new Shrimp(new Mushroom(pizza));
            IPizza pizzaMushroomSquid = new Squid(new Mushroom(pizza));
            IPizza pizzaTomatoShrimp = new Shrimp(new Tomato(pizza));
            IPizza pizzaTomatoSquid = new Squid(new Mushroom(pizza));
            IPizza pizzaShrimpSquid = new Squid(new Shrimp(pizza));
            IPizza pizzaMushroomTomatoShrimp = new Shrimp(new Tomato(new Mushroom(pizza)));
            IPizza pizzaTomatoShrimpSquid = new Shrimp(new Tomato(new Squid(pizza)));
            IPizza pizzaShrimpSquidMushroom = new Squid(new Shrimp(new Mushroom(pizza)));
            IPizza pizzaMushroomTomatoSquid = new Squid(new Tomato(new Mushroom(pizza)));
            IPizza pizzaMushroomTomatoShrimpSquid = new Squid(new Shrimp(new Tomato(new Mushroom(pizza))));*/

            //IPizza pizzaSausage = new Shrimp(pizza);
            /*IPizza pizzaMushroomSausage = new Sausage(new Mushroom(pizza));
            IPizza pizzaTomatoSausage = new Sausage(new Mushroom(pizza));
            IPizza pizzaShrimpSausage = new Sausage(new Shrimp(pizza));
            IPizza pizzaSausageSquid = new Squid(new Sausage(pizza));*/
            /*IPizza pizzaMushroomTomatoSausage = new Sausage(new Tomato(new Mushroom(pizza)));
            IPizza pizzaTomatoShrimpSausage = new Sausage(new Shrimp(new Tomato(pizza)));*/
            /*IPizza pizzaShrimpSquidSausage = new Squid(new Sausage(new Shrimp(pizza)));
            IPizza pizzaSquidMushroomSausage = new Squid(new Sausage(new Mushroom(pizza)));
            IPizza pizzaMushroomSausageShrimp = new Sausage(new Shrimp(new Mushroom(pizza)));
            IPizza pizzaSquidTomatoSausage = new Sausage(new Tomato(new Squid(pizza)));*/
            //IPizza pizzaMushroomTomatoShrimpSausage = new Sausage(new Shrimp(new Tomato(new Mushroom(pizza))));
            //IPizza pizzaTomatoShrimpSausageSquid = new Squid(new Sausage(new Shrimp(new Tomato(pizza))));
            //IPizza pizzaShrimpSausageSquidMushroom = new Squid(new Sausage(new Shrimp(new Mushroom(pizza))));
            // IPizza pizzaMushroomTomatoShrimpSausageSquid = new Squid(new Sausage(new Shrimp(new Tomato(new Mushroom(pizza)))));
            //IPizza pizzaSausageSquidMushroomTomato = new Squid(new Sausage(new Mushroom(new Tomato(pizza))));


            /*pictureBox1.Controls.Add(pictureBox2);
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.BackColor = Color.Transparent;*/
        }

        private void checkBoxSquid_CheckStateChanged(object sender, EventArgs e)
        {
            // PictureBox tạm thời
            string item = filePath + "squid.png";
            if (((CheckBox)sender).Checked)
            {
                pictureBoxIngredient.Image = Image.FromFile(item);
                pictureBoxIngredient.SizeMode = PictureBoxSizeMode.CenterImage;

            }
            else
            {
                pictureBoxIngredient.Image = Image.FromFile(filePath + "question.jpg"); ;
                pictureBoxIngredient.SizeMode = PictureBoxSizeMode.StretchImage;
                buy = null;
            }
            
            if (checkBoxSquid.Checked && checkBoxMurshroom.Checked && checkBoxShrimp.Checked && checkBoxTomato.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaMushroomTomatoShrimpSquid.png");
                buy = new Squid(new Shrimp(new Tomato(new Mushroom(pizza))));
            }
            else if (checkBoxSquid.Checked && checkBoxMurshroom.Checked && checkBoxTomato.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaMushroomTomatoSquid.png");
                buy = new Squid(new Tomato(new Mushroom(pizza)));
            }
            else if (checkBoxShrimp.Checked && checkBoxMurshroom.Checked && checkBoxSquid.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaShrimpSquidMushroom.png");
                buy = new Squid(new Shrimp(new Mushroom(pizza)));
            }
            else if (checkBoxShrimp.Checked && checkBoxSquid.Checked && checkBoxTomato.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaTomatoShrimpSquid.png");
                buy = new Shrimp(new Tomato(new Squid(pizza)));
            }
            else if (checkBoxShrimp.Checked && checkBoxMurshroom.Checked && checkBoxTomato.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaMushroomTomatoShrimp.png");
                buy = new Shrimp(new Tomato(new Mushroom(pizza)));
            }
            else if (checkBoxShrimp.Checked && checkBoxSquid.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaShrimpSquid.png");
                buy = new Squid(new Shrimp(pizza));
            }
            else if (checkBoxTomato.Checked && checkBoxSquid.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaTomatoSquid.png");
                buy = new Squid(new Mushroom(pizza));
            }
            else if (checkBoxTomato.Checked && checkBoxShrimp.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaTomatoShrimp.png");
                buy = new Shrimp(new Tomato(pizza));
            }
            else if (checkBoxMurshroom.Checked && checkBoxSquid.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaMushroomSquid.png");
                buy = new Squid(new Mushroom(pizza));
            }
            else if (checkBoxMurshroom.Checked && checkBoxShrimp.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaMushroomShrimp.png");
                buy = new Shrimp(new Mushroom(pizza));
            }
            else if (checkBoxMurshroom.Checked && checkBoxTomato.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaMushroomTomato.png");
                buy = new Tomato(new Mushroom(pizza));
            }
            else if (checkBoxMurshroom.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaMushroom.png");
                buy = new Mushroom(pizza);
            }
            else if (checkBoxTomato.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaTomato.png");
                buy = new Tomato(pizza);
            }
            else if (checkBoxShrimp.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaShrimp.png");
                buy = new Shrimp(pizza);
            }
            else if (checkBoxSquid.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaSquid.png");
                buy = new Squid(pizza);
            } 
            else
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "pizza.png");
                buy = pizza;
            }
            labelPrice.Text = "Price: " + buy.Cost().ToString() + "vnd";
            extra = buy.getDescription();
        }

        private void checkBoxMurshroom_CheckStateChanged(object sender, EventArgs e)
        {
            // PictureBox tạm thời
            string item = filePath + "mushroom.png";
            if (((CheckBox)sender).Checked)
            {
                pictureBoxIngredient.Image = Image.FromFile(item);
                pictureBoxIngredient.SizeMode = PictureBoxSizeMode.CenterImage;

            }
            else
            {
                pictureBoxIngredient.Image = Image.FromFile(filePath + "question.jpg"); ;
                buy = null;
                pictureBoxIngredient.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (checkBoxSquid.Checked && checkBoxMurshroom.Checked && checkBoxShrimp.Checked && checkBoxTomato.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaMushroomTomatoShrimpSquid.png");
                buy = new Squid(new Shrimp(new Tomato(new Mushroom(pizza))));
            }
            else if (checkBoxSquid.Checked && checkBoxMurshroom.Checked && checkBoxTomato.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaMushroomTomatoSquid.png");
                buy = new Squid(new Tomato(new Mushroom(pizza)));
            }
            else if (checkBoxShrimp.Checked && checkBoxMurshroom.Checked && checkBoxSquid.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaShrimpSquidMushroom.png");
                buy = new Squid(new Shrimp(new Mushroom(pizza)));
            }
            else if (checkBoxShrimp.Checked && checkBoxSquid.Checked && checkBoxTomato.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaTomatoShrimpSquid.png");
                buy = new Shrimp(new Tomato(new Squid(pizza)));
            }
            else if (checkBoxShrimp.Checked && checkBoxMurshroom.Checked && checkBoxTomato.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaMushroomTomatoShrimp.png");
                buy = new Shrimp(new Tomato(new Mushroom(pizza)));
            }
            else if (checkBoxShrimp.Checked && checkBoxSquid.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaShrimpSquid.png");
                buy = new Squid(new Shrimp(pizza));
            }
            else if (checkBoxTomato.Checked && checkBoxSquid.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaTomatoSquid.png");
                buy = new Squid(new Mushroom(pizza));
            }
            else if (checkBoxTomato.Checked && checkBoxShrimp.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaTomatoShrimp.png");
                buy = new Shrimp(new Tomato(pizza));
            }
            else if (checkBoxMurshroom.Checked && checkBoxSquid.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaMushroomSquid.png");
                buy = new Squid(new Mushroom(pizza));
            }
            else if (checkBoxMurshroom.Checked && checkBoxShrimp.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaMushroomShrimp.png");
                buy = new Shrimp(new Mushroom(pizza));
            }
            else if (checkBoxMurshroom.Checked && checkBoxTomato.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaMushroomTomato.png");
                buy = new Tomato(new Mushroom(pizza));
            }
            else if (checkBoxMurshroom.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaMushroom.png");
                buy = new Mushroom(pizza);
            }
            else if (checkBoxTomato.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaTomato.png");
                buy = new Tomato(pizza);
            }
            else if (checkBoxShrimp.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaShrimp.png");
                buy = new Shrimp(pizza);
            }
            else if (checkBoxSquid.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaSquid.png");
                buy = new Squid(pizza);
            }
            else
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "pizza.png");
                buy = pizza;
            }
            labelPrice.Text = "Price: " + buy.Cost().ToString() + "vnd";
            extra = buy.getDescription();
        }

        private void checkBoxShrimp_CheckStateChanged(object sender, EventArgs e)
        {
            // PictureBox tạm thời
            string item = filePath + "shrimp.png";
            if (((CheckBox)sender).Checked)
            {
                pictureBoxIngredient.SizeMode = PictureBoxSizeMode.CenterImage;
                pictureBoxIngredient.Image = Image.FromFile(item);
            }
            else
            {
                pictureBoxIngredient.Image = Image.FromFile(filePath + "question.jpg"); ;
                pictureBoxIngredient.SizeMode = PictureBoxSizeMode.StretchImage;
                buy = null;
            }
            if (checkBoxSquid.Checked && checkBoxMurshroom.Checked && checkBoxShrimp.Checked && checkBoxTomato.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaMushroomTomatoShrimpSquid.png");
                buy = new Squid(new Shrimp(new Tomato(new Mushroom(pizza))));
            }
            else if (checkBoxSquid.Checked && checkBoxMurshroom.Checked && checkBoxTomato.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaMushroomTomatoSquid.png");
                buy = new Squid(new Tomato(new Mushroom(pizza)));
            }
            else if (checkBoxShrimp.Checked && checkBoxMurshroom.Checked && checkBoxSquid.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaShrimpSquidMushroom.png");
                buy = new Squid(new Shrimp(new Mushroom(pizza)));
            }
            else if (checkBoxShrimp.Checked && checkBoxSquid.Checked && checkBoxTomato.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaTomatoShrimpSquid.png");
                buy = new Shrimp(new Tomato(new Squid(pizza)));
            }
            else if (checkBoxShrimp.Checked && checkBoxMurshroom.Checked && checkBoxTomato.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaMushroomTomatoShrimp.png");
                buy = new Shrimp(new Tomato(new Mushroom(pizza)));
            }
            else if (checkBoxShrimp.Checked && checkBoxSquid.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaShrimpSquid.png");
                buy = new Squid(new Shrimp(pizza));
            }
            else if (checkBoxTomato.Checked && checkBoxSquid.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaTomatoSquid.png");
                buy = new Squid(new Mushroom(pizza));
            }
            else if (checkBoxTomato.Checked && checkBoxShrimp.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaTomatoShrimp.png");
                buy = new Shrimp(new Tomato(pizza));
            }
            else if (checkBoxMurshroom.Checked && checkBoxSquid.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaMushroomSquid.png");
                buy = new Squid(new Mushroom(pizza));
            }
            else if (checkBoxMurshroom.Checked && checkBoxShrimp.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaMushroomShrimp.png");
                buy = new Shrimp(new Mushroom(pizza));
            }
            else if (checkBoxMurshroom.Checked && checkBoxTomato.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaMushroomTomato.png");
                buy = new Tomato(new Mushroom(pizza));
            }
            else if (checkBoxMurshroom.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaMushroom.png");
                buy = new Mushroom(pizza);
            }
            else if (checkBoxTomato.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaTomato.png");
                buy = new Tomato(pizza);
            }
            else if (checkBoxShrimp.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaShrimp.png");
                buy = new Shrimp(pizza);
            }
            else if (checkBoxSquid.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaSquid.png");
                buy = new Squid(pizza);
            }
            else
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "pizza.png");
                buy = pizza;
            }
            labelPrice.Text = "Price: " + buy.Cost().ToString() + "vnd";
            extra = buy.getDescription();

        }

        private void checkBoxTomato_CheckStateChanged(object sender, EventArgs e)
        {
            // PictureBox tạm thời
            string item = filePath + "tomato.png";
            if (((CheckBox)sender).Checked)
            {
                pictureBoxIngredient.SizeMode = PictureBoxSizeMode.CenterImage;
                pictureBoxIngredient.Image = Image.FromFile(item);
            }
            else
            {
                pictureBoxIngredient.Image = Image.FromFile(filePath + "question.jpg");
                pictureBoxIngredient.SizeMode = PictureBoxSizeMode.StretchImage;
                buy = null;
            }
            if (checkBoxSquid.Checked && checkBoxMurshroom.Checked && checkBoxShrimp.Checked && checkBoxTomato.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaMushroomTomatoShrimpSquid.png");
                buy = new Squid(new Shrimp(new Tomato(new Mushroom(pizza))));
            }
            else if (checkBoxSquid.Checked && checkBoxMurshroom.Checked && checkBoxTomato.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaMushroomTomatoSquid.png");
                buy = new Squid(new Tomato(new Mushroom(pizza)));
            }
            else if (checkBoxShrimp.Checked && checkBoxMurshroom.Checked && checkBoxSquid.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaShrimpSquidMushroom.png");
                buy = new Squid(new Shrimp(new Mushroom(pizza)));
            }
            else if (checkBoxShrimp.Checked && checkBoxSquid.Checked && checkBoxTomato.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaTomatoShrimpSquid.png");
                buy = new Shrimp(new Tomato(new Squid(pizza)));
            }
            else if (checkBoxShrimp.Checked && checkBoxMurshroom.Checked && checkBoxTomato.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaMushroomTomatoShrimp.png");
                buy = new Shrimp(new Tomato(new Mushroom(pizza)));
            }
            else if (checkBoxShrimp.Checked && checkBoxSquid.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaShrimpSquid.png");
                buy = new Squid(new Shrimp(pizza));
            }
            else if (checkBoxTomato.Checked && checkBoxSquid.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaTomatoSquid.png");
                buy = new Squid(new Mushroom(pizza));
            }
            else if (checkBoxTomato.Checked && checkBoxShrimp.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaTomatoShrimp.png");
                buy = new Shrimp(new Tomato(pizza));
            }
            else if (checkBoxMurshroom.Checked && checkBoxSquid.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaMushroomSquid.png");
                buy = new Squid(new Mushroom(pizza));
            }
            else if (checkBoxMurshroom.Checked && checkBoxShrimp.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaMushroomShrimp.png");
                buy = new Shrimp(new Mushroom(pizza));
            }
            else if (checkBoxMurshroom.Checked && checkBoxTomato.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaMushroomTomato.png");
                buy = new Tomato(new Mushroom(pizza));
            }
            else if (checkBoxMurshroom.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaMushroom.png");
                buy = new Mushroom(pizza);
            }
            else if (checkBoxTomato.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaTomato.png");
                buy = new Tomato(pizza);
            }
            else if (checkBoxShrimp.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaShrimp.png");
                buy = new Shrimp(pizza);
            }
            else if (checkBoxSquid.Checked)
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "Pizza\\pizzaSquid.png");
                buy = new Squid(pizza);
            }
            else
            {
                pictureBoxPizza.Image = Image.FromFile(filePath + "pizza.png");
                buy = pizza;
            }
            labelPrice.Text = "Price: " + buy.Cost().ToString() + "vnd";
            extra = buy.getDescription();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            DialogResult confirm;
            if (buy.Cost() == 49000) 
            {
                confirm = MessageBox.Show("Do you want to buy a Plain pizza?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else
            {
                confirm = MessageBox.Show("Do you want to buy a " + extra + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            if (confirm == DialogResult.Yes)
            {
                MessageBox.Show("We will deliver to you as soon as possible. Thank you for your order.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }
    }
}
