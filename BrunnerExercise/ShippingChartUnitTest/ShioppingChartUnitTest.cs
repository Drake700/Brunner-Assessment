using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BrunnerExercise.Item;
using System.Collections.Generic;
using BrunnerExercise.Shopping_Cart;

namespace ShippingChartUnitTest
{
    [TestClass]
    public class ShioppingChartUnitTest
    {
        //test method for calculate all cost without any offer
        [TestMethod]
        public void GetTotalTest()
        {
            //initial mock data
            List<CartItem> cartItem = new List<CartItem>();
            cartItem.Add(new CartItem {ItemId = 1, ItemName = "Apple", Quantity = 5, UnitPrice = 0.45M });
            cartItem.Add(new CartItem { ItemId = 2, ItemName = "Orange", Quantity = 10, UnitPrice = 0.65M });

            //instance required class and get the expect value with input parameters
            ShoppingCart sc = new ShoppingCart();
            var checkTest = sc.GetTotal(cartItem, false, false);

            //check the result if match expect result 8.75M
            Assert.AreEqual(8.75M, checkTest);


        }

        //test method for no item in the cart
        [TestMethod]
        public void ZeroItemTest()
        {
            //inital mock data
            List<CartItem> cartItem = new List<CartItem>();

            //instance required class and get the expect value with input parameters
            ShoppingCart sc = new ShoppingCart();
            var checkTest = sc.GetTotal(cartItem, false, false);

            //check the result if match expect result 0.00M
            Assert.AreEqual(0.00m, checkTest);
        }

        //test method for Apple offer select only
        [TestMethod]
        public void WithAppleOfferTest()
        {
            //initial mock data
            List<CartItem> cartItem = new List<CartItem>();
            cartItem.Add(new CartItem { ItemId = 1, ItemName = "Apple", Quantity = 5, UnitPrice = 0.45M });
            cartItem.Add(new CartItem { ItemId = 2, ItemName = "Orange", Quantity = 10, UnitPrice = 0.65M });

            //instance required class and get the expect value with input parameters
            ShoppingCart sc = new ShoppingCart();
            var checkTest = sc.GetTotal(cartItem, true, false);

            //check the result if match expect result 7.85M
            Assert.AreEqual(7.85M, checkTest);

        }

        //test method for Orange offer select only
        [TestMethod]
        public void WithOrangeOfferTest()
        {
            //initial mock data
            List<CartItem> cartItem = new List<CartItem>();
            cartItem.Add(new CartItem { ItemId = 1, ItemName = "Apple", Quantity = 5, UnitPrice = 0.45M });
            cartItem.Add(new CartItem { ItemId = 2, ItemName = "Orange", Quantity = 10, UnitPrice = 0.65M });

            //instance required class and get the expect value with input parameters
            ShoppingCart sc = new ShoppingCart();
            var checkTest = sc.GetTotal(cartItem, false, true);

            //check the result if match, expect reslut 6.80
            Assert.AreEqual(6.80M, checkTest);
        }

        //test method for both offer select
        [TestMethod]
        public void WithAppleandOrangeOfferTest()
        {
            //initial mock data
            List<CartItem> cartItem = new List<CartItem>();
            cartItem.Add(new CartItem { ItemId = 1, ItemName = "Apple", Quantity = 5, UnitPrice = 0.45M });
            cartItem.Add(new CartItem { ItemId = 2, ItemName = "Orange", Quantity = 10, UnitPrice = 0.65M });

            //instance required class and get the expect value with input parameters
            ShoppingCart sc = new ShoppingCart();
            var checkTest = sc.GetTotal(cartItem, true, true);

            //check the result if match, expect reslut 5.90M
            Assert.AreEqual(5.90M, checkTest);
        }

    }
}
