using System.Collections.Generic;
using System.Linq;

namespace HovSalad
{
    //Classs untuk menyimpan data bahan yang dipilih pada sebuah item
    public class IngredientItem
    {
        public int IngredientID { get; set; }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string IngredientName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal SubTotal => Price * Quantity; //subtotal otmtatis hitung (price * quantity)
    }
    //class untuk menyimpan data item pesanan (salad / protein bowl)
    public class OrderItemDetail
    {
        public int SequenceNo { get; set; }
        public string ItemType { get; set; } //Salad / Protein Bowl
        public int Quantity { get; set; } = 1;
        public List<IngredientItem> Ingredients { get; set; } = new List<IngredientItem>();

        //harga 1 unit item = total harga seluruh bahannya 
        public decimal UnitPrice => Ingredients.Sum(i => i.SubTotal);

        //total price = harga 1 unit x jumlah item (quantity)
        public decimal TotalPrice => UnitPrice * Quantity;
    }
}