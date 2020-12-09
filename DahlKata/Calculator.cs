using System;
using System.Collections.Generic;
using System.Linq;

namespace DahlKata
{
    public class Calculator
    {
        public double Checkout(List<Book> basket, double totalPrice)
        {
            double totalBookPrice = 0;
            var uniqueBooks = basket.Distinct().ToList();

            double discount = getTotalPrice(uniqueBooks.Count);

            foreach (var book in uniqueBooks)
            {
                totalBookPrice += book.price;
                basket.Remove(book);
            }

            totalPrice += totalBookPrice - (totalBookPrice * discount);

            if (basket.Count != 0)
            {
                totalPrice = Checkout(basket, totalPrice);
            }

            return totalPrice;
        }

        private double getTotalPrice(int uniqueBooks)
        {
            DiscountsDictonary discounts = new DiscountsDictonary();

            double discountValue = discounts.discounts[uniqueBooks];

            return discountValue;
        }
    }
}