using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager
{
    class SameException:Exception
    {
        public SameException(String message) : base(message) { }
        public override string Message => base.Message;
    }

    public class Order:IComparable
    {
        private int id;//订单号
        private int turnId;//序列号
        private string time;//订单时间
        private float totalPrice;//订单总价
        private string buyerName;  //买家名称
        private string sellerName;  //卖家名称
        private List<OrderDetail> items;  //消费明细

        public Order()
        {
            this.id = -1;
            this.turnId = 0;
            this.time = DateTime.Now.ToString();
            this.buyerName = " ";
            this.sellerName = " ";
            this.items = new List<OrderDetail>(); 
            this.totalPrice = 0;
        }

        public Order(int num, string buyer, string seller)
        {
            if (num < 0 || buyer == null || seller == null)
            {
                throw new FormatException();
            }
            this.id = num;
            this.time = DateTime.Now.ToString();
            this.buyerName = buyer;
            this.sellerName = seller;
            this.items = new List<OrderDetail>();
            this.totalPrice = 0;
            this.turnId = 0;
        }

        public override bool Equals(object obj)
        {
            Order other = obj as Order;
            return other!=null && this.id == other.id;
        }

        public string ItemToString()
        {
            string info = "";
            int i = 0;
            foreach (OrderDetail item in this.items)
            {
                info = info + i + item.ToString();
                i += 1;
            }
            return info;
        }
        public string itemToString()
        {
            string info = "";
            int i = 0;
            foreach (OrderDetail item in this.items)
            {
                info = info + i + item.ToString();
                i += 1;
            }
            return info;
        }
        public override string ToString()
        {
            //返回整个订单的信息
            return $"订单号：{this.id}，订单时间：{this.time}，买家：{this.buyerName}，卖家：{this.sellerName}，订单总价：{this.TotalPrice}\n";
        }
        public int Id { get => id; set => id = value; }

        public string Time { get => time; set => time = value; }
        public string BuyerName { get => buyerName; set => buyerName = value; }
        public string SellerName { get => sellerName; set => sellerName = value; }
        public List<OrderDetail> Items { get => items; set => items = value; }
        public int itemId { get => itemId; set => itemId = value; }
        public float TotalPrice
        {
            get
            {
                float price = 0;
                if (this.items == null) return price;
                foreach (OrderDetail item in this.items)
                {
                    price += item.TotalPrice;
                }
                return price;
            }
        }
        public void AddItem(string name, float uPrice, int ticket)
        {
            //传入 货品名称，单价，数量
            try
            {
                OrderDetail obj = new OrderDetail(this.turnId, name, uPrice, ticket);
                foreach (OrderDetail item in this.items)
                {
                    if (item.Equals(obj))
                    {
                        throw new SameException(item.ToString());
                    }
                }
                this.items.Add(obj);
                this.turnId += 1;
            }
            catch (FormatException)
            {
                throw new FormatException();
            }

        }
        public void AddItem(OrderDetail item, string name, float uPrice, int ticket)
        {
            item.Id = this.itemId;
            this.ModifyItem(this.itemId, name, uPrice, ticket);
            this.itemId += 1;
        }
        public void ModifyItems(string oName, float oPrice, int oTicket, string name, float price, int ticket)
        {
            //修改所有符合条件的明细
            List<int> indexs = this.SearchItem(oName, oPrice, oTicket);
            for (int i = indexs.Count - 1; i >= 0; i--)
            {
                this.ModifyItem(indexs[i], name, price, ticket);
            }
        }
        public void ModifyItem(int index, string name, float price, int ticket)
        {
            //根据索引进行修改明细
            try
            {
                if (name != null && name != "") this.items[index].ItemName = name;
                if (price > 0) this.items[index].UnitPrice = price;
                if (ticket > 0) this.items[index].Tickettity = ticket;
            }
            catch (IndexOutOfRangeException)
            {
                throw new IndexOutOfRangeException();
            }
        }
        public void DeleteItems(string name, float price, int ticket)
        {
            //删除所有符合条件的明细
            List<int> indexs = this.SearchItem(name, price, ticket);
            for (int i = indexs.Count - 1; i >= 0; i--)
            {
                this.DeleteItem(indexs[i]);
            }
        }
        public void DeleteItem(int id)
        {
            //根据索引删除某条明细
            try
            {
                for (int i = 0; i < this.items.Count; i++)
                {
                    if (this.items[i].Id == id)
                    {
                        this.items.RemoveAt(i);
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                throw new IndexOutOfRangeException();
            }
        }
        private List<int> SearchItem(string name, float uPrice, int ticket)
        {
            //类内部删除、修改明细使用
            List<int> indexs = new List<int>();
            for (int i = 0; i < this.Items.Count; i++)
            {
                if (name != null && name != "" && name == this.Items[i].ItemName) indexs.Add(i);
                if (uPrice >= 0 && uPrice == this.Items[i].UnitPrice && !indexs.Contains(i)) indexs.Add(i);
                if (ticket > 0 && ticket == this.Items[i].Tickettity && !indexs.Contains(i)) indexs.Add(i);
            }
            return indexs;
        }
        public List<OrderDetail> SearchItems(string name, float uPrice, int ticket)
        {
            //外部查找明细使用,如果name为空、uPrice和ticket都小于0，默认返回所有items
            if (name == "" && uPrice < 0 && ticket <= 0) return this.items;
            var query = from item in this.items
                        where name != "" && item.ItemName == name
                        orderby item.TotalPrice
                        select item;
            if (name == "")
            {
                query = from item in this.items
                        orderby item.TotalPrice
                        select item;
            }

            if (uPrice >= 0)
            {
                query = from item in query
                        where uPrice >= 0 && item.UnitPrice == uPrice
                        orderby item.TotalPrice
                        select item;
            }
            else if (uPrice < 0 && name == "")
            {
                query = from item in this.items
                        orderby item.TotalPrice
                        select item;
            }
            if (ticket > 0)
            {
                query = from item in query
                        where ticket > 0 && item.Tickettity == ticket
                        orderby item.TotalPrice
                        select item;
            }
            return query.ToList();
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Order))
            {
                throw new ArgumentException();
            }
            Order od = (Order)obj;
            return this.Id.CompareTo(od.Id);
        }

    }
}