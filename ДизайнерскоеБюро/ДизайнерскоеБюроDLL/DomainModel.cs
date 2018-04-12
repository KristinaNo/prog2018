using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ДизайнерскоеБюроDLL
{
    /// <summary>
    /// Информация о заказе
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Номер заказа
        /// </summary>
        public string numOrder { get; set; }
        /// <summary>
        /// Дата заказа
        /// </summary>
        public DateTime dtOrder { get; set; }
        /// <summary>
        /// Заказчик
        /// </summary>
        public Customer customer { get; set; }
        /// <summary>
        /// Требования заказа
        /// </summary>
        public List<OrderRequirements> orderRequirements { get; set; }
        /// <summary>
        /// Исполнители
        /// </summary>
        public List<PeopleExec> peopleExec { get; set; }
        /// <summary>
        /// Стоимость
        /// </summary>
        public decimal price { get; set; }
    }

    /// <summary>
    /// Информация о заказчике
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Наименование (ФИО)
        /// </summary>
        public string nameCustomer { get; set; }
        /// <summary>
        /// Адрес
        /// </summary>
        public string address { get; set; }
        /// <summary>
        /// Телефон
        /// </summary>
        public string phone { get; set; }
    }

    /// <summary>
    /// Требование заказа
    /// </summary>
    public class OrderRequirements
    {
        /// <summary>
        /// Объект заказа
        /// </summary>
        public OrderObject orderObject { get; set; }
        /// <summary>
        /// Требование
        /// </summary>
        public string requirement { get; set; }
        /// <summary>
        /// Коэффициент сложности
        /// </summary>
        public decimal koef { get; set; }

        public override string ToString()
        {
            return string.Format("{0} | {1} | {2}", orderObject, requirement, koef);
        }

        public OrderRequirements Clone()
        {
            return new OrderRequirements { orderObject = orderObject, requirement = requirement, koef = koef };
        }
    }

    /// <summary>
    /// Объект заказа
    /// </summary>
    public enum OrderObject
    {
        Logo,
        SiteLayout,
        BusinessCard,
        Banner
    }

    /// <summary>
    /// Исполнитель заказа
    /// </summary>
    public class PeopleExec
    {
        /// <summary>
        /// ФИО
        /// </summary>
        public string namePeople { get; set; }
        /// <summary>
        /// Должность
        /// </summary>
        public string post { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1} ", namePeople, post);
        }

        public PeopleExec Clone()
        {
            return new PeopleExec { namePeople = namePeople, post = post };
        }
    }
}
