﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService orderservice = new OrderService();
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("输入add增加订单，输入del删除订单，输入search查询订单，输入show查看所有订单，输入sort根据订单号为订单排序,输入exit退出");
                string choose = Console.ReadLine();
                switch(choose)
                {
                    case "add":orderservice.AddOrder();break;
                    case "del":
                        Console.WriteLine("请输入需要删除的id");
                        int id = Convert.ToInt32(Console.ReadLine());
                        orderservice.DeleteOrder(id);break;
                    case "search":
                        Console.WriteLine("请输入查找的订单的买家");
                        string buyer = Console.ReadLine();
                        Console.WriteLine("请输入查找的订单的卖家");
                        string seller  = Console.ReadLine();
                        orderservice.SearchOrders(buyer, seller);
                        break;
                    case "show":
                        orderservice.Disp();break;
                    case "sort":
                        orderservice.orders.Sort();break;
                }
            }

        }
    }
}
