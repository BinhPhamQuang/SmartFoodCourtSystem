﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartFoodCourtSystem.DTO;
using SmartFoodCourtSystem.DAO;
using SmartFoodCourtSystem.Properties;


namespace SmartFoodCourtSystem
{
    public partial class UCpayment : UserControl
    {
         Panel  PanelItem(Food food)
        {
            Panel panel = new Panel();
            panel.Size = new Size(525,75);
            panel.BackColor = SystemColors.InactiveCaption;
           

            Label lbName = new Label();
            lbName.Text = food.name ;
            lbName.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular);
            lbName.Location = new Point(8, 40);
            lbName.AutoSize = true;

            Label lbDiscount = new Label();
            lbDiscount.Text = food.discount.ToString() + "%";
            lbDiscount.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular);
            lbDiscount.ForeColor = Color.Red;
            lbDiscount.Location = new Point(248, 35);
            lbDiscount.AutoSize = true;

            Label lbsize = new Label();
            lbsize.Text = "Size:";
            lbsize.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular);
            lbsize.Location = new Point(100, 35);
            lbsize.AutoSize = true;


            Label lbQuantity = new Label();
            lbQuantity.Text = food.quantity.ToString();
            lbQuantity.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular);
            lbQuantity.Location = new Point(357,35);
            lbQuantity.AutoSize = true;

            Label lbPrice = new Label();
            lbPrice.Text = food.price.ToString();
            lbPrice.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular);
            lbPrice.Location = new Point(450,35);
            lbPrice.AutoSize = true;

            
            panel.Controls.Add(lbName);
            panel.Controls.Add(lbDiscount);
            panel.Controls.Add(lbQuantity);
            panel.Controls.Add(lbPrice);
            return panel;

        }
            public UCpayment()
        {
            InitializeComponent();
            
         
        }
        public void pictureBoxMouseClickEventHandler(object sender, EventArgs e)
        {
            if ( (sender as PictureBox).BackColor != Color.Lime)
            { 

              (sender as PictureBox).BackColor = Color.Lime;
             }
            else 
                (sender as PictureBox).BackColor =Color.White;
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        { 
            if (pictureBox1.BackColor == Color.Lime || pictureBox2.BackColor == Color.Lime)
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(uC_PayMethod1);
                uC_PayMethod1.Show();
            }
            else
            {
                MessageBox.Show("Select a payment method");
            }
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void uC_PayMethod1_Load(object sender, EventArgs e)
        {
            panel1.Show();
            uC_PayMethod1.Hide();
            for (int i = 0; i < 10; i++)
            {

                Food food = new Food();
                food.name = "Egg Tart";
                food.discount = 0;
                food.price = 2000;
                food.quantity = 2;
                food.image = @"D:\SMF.vs5\SmartFoodCourtSystem\SmartFoodCourtSystem\Resources\1.jpg";
            
                flp_foodlist.Controls.Add(PanelItem(food));
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.MouseClick += new MouseEventHandler(pictureBoxMouseClickEventHandler);
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.MouseClick += new MouseEventHandler(pictureBoxMouseClickEventHandler);
            
        }

        private void flp_foodlist_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UCpayment_Load(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbpayment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
