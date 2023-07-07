using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace DeliverySystem.Test
{
    [TestClass]
    public class DeliveryTest
    {
        [TestInitialize]
        public void Setup()
        {
            if (File.Exists("couriers.bin"))
                File.Delete("couriers.bin");
            if (File.Exists("orders.bin"))
                File.Delete("orders.bin");
        }

        /// <summary>
        /// Все курьеры свободны и могут доставить заказ, находим ближайшего
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            MainController mainController = new MainController(new MinimalDistanceStrategy());

            Courier courier1 = new FootCourier("Иванов Иван", "34533", 20);
            courier1.Location = new GeoCoordinate(1, 1);
            Courier courier2 = new FootCourier("Петров Олег", "123", 10);
            courier2.Location = new GeoCoordinate(10, 10);
            Courier courier3 = new FootCourier("Попов Артем", "643", 15);
            courier3.Location = new GeoCoordinate(15, 10);

            mainController.AddCourier(courier1);
            mainController.AddCourier(courier2);
            mainController.AddCourier(courier3);

            Order order = mainController.AddOrder(3, new GeoCoordinate(2, 3), new GeoCoordinate(5, 4));

            bool res = mainController.AssignCourier(order);

            Assert.IsTrue(res);
            Assert.AreEqual(courier1, order.Courier);
            Assert.IsFalse(courier1.IsAvailable);
            Assert.AreEqual(1, courier1.Orders.Count);
        }

        /// <summary>
        /// Ближайший курьер занят, берем следующего
        /// </summary>
        [TestMethod]
        public void TestMethod2()
        {
            MainController mainController = new MainController(new MinimalDistanceStrategy());

            Courier courier1 = new FootCourier("Иванов Иван", "34533", 20);
            courier1.Location = new GeoCoordinate(1, 1);
            courier1.IsAvailable = false;
            Courier courier2 = new FootCourier("Петров Олег", "123", 10);
            courier2.Location = new GeoCoordinate(10, 10);
            Courier courier3 = new FootCourier("Попов Артем", "643", 15);
            courier3.Location = new GeoCoordinate(15, 10);

            mainController.AddCourier(courier1);
            mainController.AddCourier(courier2);
            mainController.AddCourier(courier3);

            Order order = mainController.AddOrder(3, new GeoCoordinate(2, 3), new GeoCoordinate(5, 4));

            bool res = mainController.AssignCourier(order);

            Assert.IsTrue(res);
            Assert.AreEqual(courier2, order.Courier);
            Assert.IsFalse(courier2.IsAvailable);
            Assert.AreEqual(1, courier2.Orders.Count);
        }

        /// <summary>
        /// Ближайшие два курьера не могу унести такой вес заказа. берем третьего
        /// </summary>
        [TestMethod]
        public void TestMethod3()
        {
            MainController mainController = new MainController(new MinimalDistanceStrategy());

            Courier courier1 = new FootCourier("Иванов Иван", "34533", 5);
            courier1.Location = new GeoCoordinate(1, 1);
            Courier courier2 = new FootCourier("Петров Олег", "123", 3);
            courier2.Location = new GeoCoordinate(10, 10);
            Courier courier3 = new FootCourier("Попов Артем", "643", 15);
            courier3.Location = new GeoCoordinate(15, 10);

            mainController.AddCourier(courier1);
            mainController.AddCourier(courier2);
            mainController.AddCourier(courier3);

            Order order = mainController.AddOrder(8, new GeoCoordinate(2, 3), new GeoCoordinate(5, 4));

            bool res = mainController.AssignCourier(order);

            Assert.IsTrue(res);
            Assert.AreEqual(courier3, order.Courier);
            Assert.IsFalse(courier3.IsAvailable);
            Assert.AreEqual(1, courier3.Orders.Count);

            mainController.CompleteOrder(order);

            Assert.IsTrue(order.Courier.IsAvailable);
        }

        /// <summary>
        /// Все курьеры заняты
        /// </summary>
        [TestMethod]
        public void TestMethod4()
        {
            MainController mainController = new MainController(new MinimalDistanceStrategy());

            Courier courier1 = new FootCourier("Иванов Иван", "34533", 5);
            courier1.Location = new GeoCoordinate(1, 1);
            courier1.IsAvailable = false;

            Courier courier2 = new FootCourier("Петров Олег", "123", 3);
            courier2.Location = new GeoCoordinate(10, 10);
            courier2.IsAvailable = false;

            Courier courier3 = new FootCourier("Попов Артем", "643", 15);
            courier3.Location = new GeoCoordinate(15, 10);
            courier3.IsAvailable = false;

            mainController.AddCourier(courier1);
            mainController.AddCourier(courier2);
            mainController.AddCourier(courier3);

            Order order = mainController.AddOrder(8, new GeoCoordinate(2, 3), new GeoCoordinate(5, 4));

            bool res = mainController.AssignCourier(order);

            Assert.IsFalse(res);
            Assert.IsNull(order.Courier);
        }
    }
}
