﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFoodCourtSystem.DTO
{
    class Cart
    {
        private static Cart instance;
        public static Cart Instance
        {
            get { if (instance == null) instance = new Cart(); return Cart.instance; }
            private set { Cart.instance = value; }
        }
        private Cart() { }
        private List<Food> listFood = new List<Food>();
        public void addFood(Food food)
        {
            foreach(Food i in listFood)
            {
                //increase quantity
                if(i.idFood==food.idFood)
                {
                    i.quantity += food.quantity;
                    return;
                }
            }
            listFood.Add(food);
        }
        public bool editCart(Food food)
        {
            foreach(Food i in listFood)
            {
                if(i.idFood==food.idFood)
                {
                    if(food.quantity==0)
                    {
                        listFood.Remove(i);
                        return true;
                    }
                    else
                    {
                        listFood.Add(food);
                        listFood.Remove(i);
                        return true;
                    }
                }
            }
            return false;
        }
        public List<Food> getListFood()
        {
            return listFood;
        }
        public void DeleteCart()
        {
            listFood.Clear();
        }
        public void DeleteFood(Food food)
        {
            foreach(Food i in listFood)
            {
                if(i.idFood==food.idFood)
                {
                    listFood.Remove(i);
                    return;
                }
            }
        }
        
    }
}