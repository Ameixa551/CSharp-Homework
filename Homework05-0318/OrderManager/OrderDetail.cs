using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager
{
    public class OrderDetail
    {
        private int id; //id
        private string itemName;  //货物名称
        private float unitPrice;   //货物单价
        private int tickettity;  //货物数量
        private float totalPrice;  //货物总价

        public OrderDetail()
        {
            this.id = 0;
            this.itemName = "";
            this.unitPrice = 0;
            this.tickettity = 0;
            this.totalPrice = 0;
        }

        public OrderDetail(int id, string name, float uPrice, int quan)
        {
            if (name == null || name == "" || uPrice < 0 || quan <= 0)
            {
                throw new FormatException();
            }
            this.Id = id;
            this.ItemName = name;
            this.UnitPrice = uPrice;
            this.Tickettity = quan;
            this.totalPrice = uPrice * quan;
        }

        public override string ToString()
        {
            return $" 货物名称：{this.ItemName}，单价：{this.UnitPrice}，数量：{this.Tickettity}，总价：{this.TotalPrice}\n";
        }

        public override bool Equals(Object obj)
        {
            OrderDetail item = obj as OrderDetail;
            if (item != null && item.ItemName == this.ItemName && item.UnitPrice == this.UnitPrice && item.Tickettity == this.Tickettity && item.TotalPrice == this.TotalPrice)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return (int)this.UnitPrice + this.Tickettity * (int)this.TotalPrice;
        }

        public string ItemName { get => itemName; set => itemName = value; }

        public float UnitPrice { get => unitPrice; set => unitPrice = value; }

        public int Tickettity { get => tickettity; set => tickettity = value; }

        public float TotalPrice { get => this.Tickettity * this.UnitPrice; }
        public int Id { get => id; set => id = value; }
    }
}
