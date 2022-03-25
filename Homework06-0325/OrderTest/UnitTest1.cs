using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OrderManager;

namespace OrderTest
{
    [TestClass]
    public class UnitTest1
    {
        public OrderService service;
        [TestInitialize]
        public void TestInit()
        {
            this.service = new OrderService();
        }
        [TestCleanup]
        public void PrintInfo()
        {
            this.service.Disp();
        }
        [TestMethod]
        public void OrderServiceTest()
        {
            Assert.IsNotNull(this.service.orders);
            Assert.AreEqual(this.service.Id, 0);
        }
        [TestMethod]
        public void TestPrint()
        {
            this.service.Disp();
        }
        [TestMethod]
        public void TestAdd()
        {
            string[] buyer = { "Alan", "Amy", "Tank" };
            string[] seller = { "HuaWei", "VIVO", "OPPO" };
            for (int i = 0; i < buyer.Length; i++)
            {
                this.service.AddOrder(buyer[i], seller[i]);
            }
            Assert.AreEqual(this.service.Id, buyer.Length);
        }
        public void TestDel()
        {
                this.TestAdd();
                this.PrintInfo();
                Console.WriteLine("删除订单");
                this.service.DeleteOrder(2);
                Assert.AreEqual(this.service.orders.Count, 2);
          
        }
        [TestMethod]
        public void TestDeloOrderItem()
        {
            this.TestAdd();
            this.PrintInfo();
            Console.WriteLine("删除具体订单中具体项目");
            this.service.DeleteOrderItem(2, 0);
        }
        [TestMethod()]
        public void TestDeleteItems()
        {
            this.TestAdd();
            this.PrintInfo();
            Console.WriteLine("删除具体订单中多个项目");
            this.service.DeleteOrderItems(1, "老坛酸菜面", 0, 0);
        }
        [TestMethod()]
        public void Test1SearchOrders()
        {
            this.TestAdd();
            this.PrintInfo();
            Console.WriteLine("查询：");
            this.service.SearchOrders(1, "老坛酸菜面", 0, 0).ForEach(order => Console.Write(order));
            Console.WriteLine("查询结束");
        }
        [TestMethod()]
        public void Test2SearchOrders()
        {
            this.TestAdd();
            this.PrintInfo();
            Console.WriteLine("查询：");
            this.service.SearchOrders("Alan", "Bob").ForEach(order => Console.Write(order));
            Console.WriteLine("查询结束");
        }
        [TestMethod()]
        public void ModifyOrderHeaderTest()
        {
            this.TestAdd();
            this.PrintInfo();
            Console.WriteLine("修改订单头");
            this.service.ModifyOrderHeader(1, "Mark", "Seller");
        }

        [TestMethod()]
        public void ModifyOrderItemTest()
        {
            this.TestAdd();
            this.PrintInfo();
            Console.WriteLine("修改具体订单当中的具体条目");
            this.service.ModifyOrderItem(0, 1, "手机", 1800, 100);
        }

        [TestMethod()]
        public void ModifyOrderItemsTest()
        {
            this.TestAdd();
            this.PrintInfo();
            Console.WriteLine("修改一个订单当中的多个条目");
            this.service.ModifyOrderItems(2, "耳机", 0, 0, "手机", 0, 0);
        }
    }
}