using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderFinal
{
    public partial class Form1 : Form
    {
        static OrderManager orderManager = new OrderManager();
        static int orderID = 0;
        public Form1()
        {
            InitializeComponent();
            OrderManager order = new OrderManager();
        }

        private void btn_addOrder_Click(object sender, EventArgs e)
        {
            String buyer = txtbox_buyer.Text;
            String seller = txtbox_seller.Text;
            orderID = orderManager.AddOrder(buyer, seller);
            label_suc1.Text = "add order success";
        }

        private void btn_additem_Click(object sender, EventArgs e)
        {
            String name = txtbox_itemname.Text;
            int price = int.Parse(textBox_price.Text);
            int num =int.Parse(textBox_number.Text);
            int orderid = int.Parse(textBox_orderid.Text);
            orderManager.AddItem(name, price, num, orderid);
            label_suc2.Text = "add item success";
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            int orderid = int.Parse(txtbox_searchid.Text);
            Order order = orderManager.SearchOrderById(orderid);
            String output = $"订单号：{order.OrderId}，订单时间：{order.Time}，买家：{order.Buyer}，卖家：{order.Seller}";
            label_output.Text = output;
        }

        private void btn_delitem_Click(object sender, EventArgs e)
        {
            int orderid = int.Parse(txtbox_delOrderid.Text);
            String name = txtbox_itemname.Text;
            orderManager.DeleteItem(orderid, name);
        }

        private void btn_delorder_Click(object sender, EventArgs e)
        {
            int orderid = int.Parse(txtbox_delOrderid.Text);
            orderManager.DeleteOrder(orderid);
        }
    }
}
