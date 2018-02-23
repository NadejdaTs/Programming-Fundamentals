using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.AndreyBilliard
{
    class AndreyBilliard
    {
        static void Main(string[] args)
        {
            var amountOfGoods = int.Parse(Console.ReadLine());
            var goods = new Dictionary<string, double>();
            List<Customer> customers = new List<Customer>();

            for (int i = 0; i < amountOfGoods; i++)
            {
                var good = Console.ReadLine()
                    .Split('-');

                var goodName = good[0];
                var price = good[1];

                if (!goods.ContainsKey(goodName))
                {
                    goods[goodName] = 0.0d;
                }
                goods[goodName] = double.Parse(price);
            }

            while (true)
            {
                var customerOrder = Console.ReadLine()
                    .Split('-', ',');

                if (customerOrder.Contains("end of clients"))
                {
                    break;
                }

                var custName = customerOrder[0];
                var custGood = customerOrder[1];
                var custAmt = int.Parse(customerOrder[2]);

                if (!goods.ContainsKey(custGood)) { continue; }             //new

                Customer currCustomer = new Customer();               
                currCustomer.ShopList = new Dictionary<string, double>();
                currCustomer.Name = custName;
                currCustomer.ShopList.Add(custGood, custAmt);

                if (customers.Any(c => c.Name == custName))
                {
                    Customer existingCustomer = customers.First(c => c.Name == custName);
                    if (existingCustomer.ShopList.ContainsKey(custGood))
                    {
                        existingCustomer.ShopList[custGood] += custAmt;
                    }
                    else
                    {
                        existingCustomer.ShopList[custGood] = custAmt;
                    }
                }
                else
                {
                    customers.Add(currCustomer);
                }
            }

            foreach (var customer in customers)
            {
                foreach (var item in customer.ShopList)
                {

                    foreach (var product in goods)
                    {
                        if (item.Key == product.Key) { customer.Bill += item.Value * product.Value; }
                    }
                }
            }

            var ordered = customers
                            .OrderBy(x => x.Name)
                            .ThenBy(x => x.Bill)
                            .ToList();

            foreach (var customer in ordered)
            {
                Console.WriteLine(customer.Name);
                foreach (KeyValuePair<string, double> item in customer.ShopList)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                }
                Console.WriteLine($"Bill: {customer.Bill:F2}");
            }
            Console.WriteLine($"Total bill: {customers.Sum(c => c.Bill):F2}");
            //Console.WriteLine("Total bill: {0:F2}", allCustomers.Sum(c => c.Bill)); - equal to previous row
        }
    }
}
