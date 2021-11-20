using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThucHanhTuan5.Models
{
    public class Storectx 
    {
        public string ConnectionString { get; set; }

        public Storectx(string connectionstring)
        {
            this.ConnectionString = connectionstring;
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
        public List<Object> Cau3 ()
        {//Liệt kê các Product (ProductName) có ProductName bắt đầu bằng chữ “G”
            NORTHWNDContext _context = new NORTHWNDContext();
            var query=from p in _context.Products
                         where p.ProductName.StartsWith("G") 
                         select new Products
                         {
                             ProductName = p.ProductName
                         };
            return query.ToList<Object>();
        }
        public List<Object> Cau4()
        {//Liệt kê các Product (ProductName) do CompanyName “Tokyo Traders” cung cấp
            NORTHWNDContext _context = new NORTHWNDContext();
            var query = from p in _context.Products
                        join s in _context.Suppliers  on p.SupplierId equals s.SupplierId
                        where  s.CompanyName == "Tokyo Traders"
                        select new Products
                        {
                            ProductName = p.ProductName
                        };
            return query.ToList<Object>();
        }
        public List<Object> Cau5()
        {//Liệt kê các Customer (ContactName) ở City là “Berlin”.
            NORTHWNDContext _context = new NORTHWNDContext();
            var query = from s in _context.Suppliers 
                        where s.City == "Berlin"
                        select new Suppliers
                        {
                            ContactName = s.ContactName
                        };
            return query.ToList<Object>();
        }
        public List<Object> Cau6()
        {//Liệt kê tất cả các Products (ProductID, ProductName) của CategoryName =“Meat/Poultry”
            NORTHWNDContext _context = new NORTHWNDContext();
            var query = from p in _context.Products
                        join c in _context.Categories on p.CategoryId equals c.CategoryId
                        where c.CategoryName == "Meat/Poultry"
                        select new Products
                        {   ProductId=p.ProductId,
                            ProductName = p.ProductName
                        };
            return query.ToList<Object>();
        }
        public List<Object> Cau7()
        {//Liệt kê tất cả các Order (OrderDate, ShipName) được ship đến ShipCountry là “Germany”
            NORTHWNDContext _context = new NORTHWNDContext();
            var query = from o in _context.Orders
                        where o.ShipCountry == "Germany"
                        select new Orders
                        {
                            OrderDate = o.OrderDate,
                            ShipName = o.ShipName
                        };
            return query.ToList<Object>();
        }
        public List<Object> Cau8()
        {//Liệt kê các Product (ProductID, ProductName) chưa được đặt hàng (UnitsOnOrder=0)
            NORTHWNDContext _context = new NORTHWNDContext();
            var query = from p in _context.Products
                        where p.UnitsInStock == 0
                        select new Products
                        {
                            ProductId = p.ProductId,
                            ProductName = p.ProductName
                        };
            return query.ToList<Object>();
        }
        public List<Object> Cau9()
        {//Liệt kê các Supplier (CompanyName, ContactName) cung cấp 10 Product trở lên (ProductName, UnitPrice, UnitsInStock).
            NORTHWNDContext _context = new NORTHWNDContext();
            var query = from p in _context.Products
                        join s in _context.Suppliers on p.SupplierId equals s.SupplierId
                        group s by new 
                        {
                            s.ContactName,
                            s.CompanyName
                        } into g
                        where g.Count()>10
                        select new
                        {
                            ContactName = g.Key.CompanyName,
                            CompanyName = g.Key.CompanyName
                        };
            return query.ToList<Object>();
        }
        public List<Object> Cau13()
        {//Đếm số Product của từng Category (CatagoryName, QuantityPro)
            NORTHWNDContext _context = new NORTHWNDContext();
            var query = from p in _context.Products
                        join c in _context.Categories on p.CategoryId equals c.CategoryId
                        group c by new
                        {
                            c.CategoryId,
                            c.CategoryName
                        } into g
                        select new 
                        {                
                            CategoryName = g.Key.CategoryName,
                            QuantityPro = g.Count(),
                        };
            return query.ToList<Object>();
        }
        public List<Object> Cau14()
        {//Đếm số Product của từng Supplier (CompanyName, QuantityPro)
            NORTHWNDContext _context = new NORTHWNDContext();
            var query = from p in _context.Products
                        join s in _context.Suppliers on p.SupplierId equals s.SupplierId
                        group s by new
                        {
                            s.SupplierId,
                            s.CompanyName
                        } into g
                        select new
                        {
                            CompanyName = g.Key.CompanyName,
                            QuantityPro = g.Count(),
                        };
            return query.ToList<Object>();
        }
        public List<Object> Cau17()
        {//Đếm số lần mua hàng của Customer (ContactName, Quantity)
            NORTHWNDContext _context = new NORTHWNDContext();
            var query = from c in _context.Customers
                        join o in _context.Orders on c.CustomerId equals o.CustomerId
                        group c by new
                        {
                            c.CustomerId,
                            c.ContactName
                        } into g
                        select new
                        {
                            ContactName = g.Key.ContactName,
                            Quantity = g.Count(),
                        };
            return query.ToList<Object>();
        }

    }
}
