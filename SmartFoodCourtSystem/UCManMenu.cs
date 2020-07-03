using System;
using SmartFoodCourtSystem.DAO;
using SmartFoodCourtSystem.DTO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartFoodCourtSystem.Properties;

namespace SmartFoodCourtSystem
{
    public partial class UCManMenu : UserControl
    {
        public UCManMenu()
        {
            InitializeComponent();
        }

        private int category = 1;
        Panel Dish(Food food)
        {
            Panel paneldish = new Panel();
            paneldish.Width = 782;
            paneldish.Height = 119;
            paneldish.BackColor = Color.White;
            /////
            Label name = new Label();
            name.Text = food.name;
            name.Font = new Font("Century Gothic", 14.0f, FontStyle.Bold);
            name.Location = new Point(120, 21);
            name.AutoSize = true;
            /////
            PictureBox pic = new PictureBox();
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.Location = new Point(3, 3);
            pic.Margin = new Padding(3, 3, 3, 3);
            pic.Size = new Size(111, 113);
            pic.Tag = food;
            try
            {
                pic.Image = Image.FromFile(food.image);

            }
            catch (Exception a)
            {

                pic.Image = Resources.dishdefault;
            }
            /////
            Label price = new Label();
            price.Location = new Point(120, 88);
            price.AutoSize = true;
            price.Text = food.price.ToString() + "VND";
            price.Font = new Font("Century Gothic", 10.0f);
            price.ForeColor = Color.Black;
            /////
            Button edit = new Button();
            edit.Location = new Point(739, 3);
            edit.BackgroundImage = Properties.Resources.edit_property_26px;
            edit.BackgroundImageLayout = ImageLayout.Zoom;
            edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(94)))));
            edit.Size = new Size(40, 40);
            edit.FlatStyle = FlatStyle.Flat;
            /////
            Button delete = new Button();
            delete.Location = new Point(739, 76);
            delete.BackgroundImage = Properties.Resources.delete_bin_30px;
            delete.BackgroundImageLayout = ImageLayout.Zoom;
            delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(94)))));
            delete.Size = new Size(40, 40);
            delete.FlatStyle = FlatStyle.Flat;
            /////
            ///
            paneldish.Controls.Add(name);
            paneldish.Controls.Add(price);
            paneldish.Controls.Add(pic);
            paneldish.Controls.Add(edit);
            paneldish.Controls.Add(delete);


            return paneldish;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FManAddDish f = new FManAddDish();
            f.ShowDialog();
        }
         
        public void LoadMenu()
        {

            flwMenu.Controls.Clear();
            List<Food> t = FoodDAO.Instance.getFoodbyCategory(category);
            foreach (Food i in t)
            {
                Panel a = Dish(i);
                flwMenu.Controls.Add(a);
            }
        }

        private void UCManMenu_Load(object sender, EventArgs e)
        {
            LoadMenu();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            category = 1;
            UCManMenu_Load(sender, e);
            btnFood.BackColor = SystemColors.Highlight;
            btnDrink.BackColor = Color.White;
            btnFood.ForeColor = Color.White;
            btnDrink.ForeColor = Color.Black;
        }

        private void btnDrink_Click(object sender, EventArgs e)
        {
            category = 0;
            UCManMenu_Load(sender, e);
            btnDrink.BackColor = SystemColors.Highlight;
            btnFood.BackColor = Color.White;
            btnFood.ForeColor = Color.Black;
            btnDrink.ForeColor = Color.White;
        }
    }
}
