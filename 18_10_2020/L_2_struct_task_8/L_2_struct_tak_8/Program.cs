using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*manual 3 task 1*/

namespace L_2_struct_task_8
{
   struct Article
   {       
        public int product_code;
        public string product_name;
        public double product_price;
        enum ArticleTips
        {
        refrigerator,
        microwave_oven,
        iron,
        toaster,
        washing_machine,
        vacuum_cleaner,
        TV_set
        }      
   }
    struct Client
    {
        private string last_name_first_name_patronymic;
        private int address;
        private int telephone;
        private int col_of_orders;
        private int all_sum_orders;
        enum ClientType
        {
        client_payment_up_to_100,
        client_payment_up_to_200,
        client_payment_up_to_500,
        client_payment_up_to_1000,
        client_VIP_more_1000
        }
    }
  struct RequestItem
  {
  private string product;
  public int quantity_product;     
  }
    /// <summary>
    /// use the get and set easy function to get sum_order (but it was not very easy function)
    /// </summary>
    struct Request
    {
        private int order_code;
        private string client;
        private int order_date;
        private int list_ordered_products;       

        private double sum_order;
        public double received_sum
        {
            get
            {
            return sum_order;
            }
            set
            {
            sum_order = value;
            }
        }
        enum PayType
        {
        non_cash,
        cash
        }
    }    
    class Program
    {
        static void Main(string[] args)
        {
        Article price = new Article();
        price.product_price = 20.40;

        RequestItem col = new RequestItem();
        col.quantity_product = 40;

        Request sum = new Request();

        sum.received_sum = price.product_price * col.quantity_product;
        Console.WriteLine(sum.received_sum);            
        }
    }
}
