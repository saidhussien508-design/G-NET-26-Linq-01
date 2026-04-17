

namespace assiment_.linq1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> p = new List<Product>()
            {
                new Product(){ProductName="Seafood",ProductID=10,UnitPrice=50,Category="say",UnitsInStock=10},
                new Product(){ProductName="sea",ProductID=20,UnitPrice=20,Category="say",UnitsInStock=50},
                  new Product(){ProductName="sead",ProductID=30,UnitPrice=40,Category="say",UnitsInStock=30}
            };
            #region qution1



            //var res= p.Where(s => s.ProductName == "Seafood");
            // foreach (var item in res)
            // {
            //     Console.WriteLine($"name is ={item.ProductName} price is ={item.UnitPrice} ");
            // }
            #endregion
            #region test
            //==================================================
            //var res = Enumerable.Where(p, s => s.ProductName == "Seafood");

            //foreach (var item in res)
            //{
            //    Console.WriteLine($"name is ={item.ProductName} price is ={item.UnitPrice} ");
            //}
            //================================================
            //var ras = Enumerable.Where(p, s => s.UnitPrice == 50);
            //foreach (var item in ras)
            //{
            //    Console.WriteLine($"name is ={item.ProductName} price is ={item.UnitPrice} ");
            //}
            ////===============================================
            //var res = from s in p
            //          where s.UnitsInStock == 10
            //          select s;
            //foreach (var item in res)
            //{
            //    Console.WriteLine($"name is ={item.ProductName} price is ={item.UnitPrice} ");
            //}

            //===========================================
            //var ras=from a in p
            //        where a.ProductName == "Seafood"
            //        select a;
            //foreach (var item in ras)
            //{
            //    Console.WriteLine($"name is ={item.ProductName} price is ={item.UnitPrice} ");
            //}
            #endregion
            #region qution2

            //var ras=p.Select(x=>x.ProductName);
            //foreach(var r in ras)
            //{
            //    Console.WriteLine(r);
            //}
            //=================================
            //var res=from s in p
            //        select s.ProductName;
            //foreach (var r in res)
            //{
            //    Console.WriteLine(r);
            //}
            #endregion
            #region qution3
            //var ras = p.OrderBy(s=>s.UnitPrice);


            //foreach(var r in ras)
            //{
            //    Console.WriteLine($"name={r.ProductName} price={r.UnitPrice}");
            //}
            //==========================================
            //var ras = from s in p
            //          orderby s.UnitPrice
            //          select s;
            //foreach (var r in ras)
            //{
            //    Console.WriteLine($"name={r.ProductName} price={r.UnitPrice}");
            //}
            #endregion
            #region qution4

            //var ras = p.Where(s => s.UnitPrice > 10 && s.UnitPrice < 30);
            ////foreach (var r in ras)
            ////{
            ////    Console.WriteLine(r);
            ////}
            /////================================
            //var ras = from s in p
            //          where s.UnitPrice > 10 && s.UnitPrice < 30
            //          select s;
            //foreach (var r in ras)
            //{
            //    Console.WriteLine(r);
            //}
            #endregion
            #region qution5

            //var ras = p.Where(s => s.UnitsInStock >0 && s.Category== "Condiments");
            //foreach (var r in ras)
            //{
            //    Console.WriteLine(r);
            //}
            //==================================
            //var res =from s in p
            //         where s.UnitsInStock>0&&s.Category== "Condiments"
            //         select s;
            //foreach (var r in res)
            //{
            //    Console.WriteLine(r);
            //}
            #endregion
            #region qution6
            //var ras = p.Select(s => new { name = s.ProductName, price = s.UnitPrice, stockstatus = s.UnitsInStock > 0 ? "Available" :
            //    "Out of Stock" }) ;

            //foreach (var r in ras)
            //{
            //    Console.WriteLine(r.name);
            //    Console.WriteLine(r.price);
            //    Console.WriteLine(r.stockstatus);
            //}
            #endregion
            #region qution7
            //var ras = p.Select(x => x.ProductName);
            //int z = 1;
            //foreach (var r in ras)
            //{
            //    Console.WriteLine($"{z}:{r}");
            //    z++;
            //}

            #endregion
            #region qution8
            //var ras = p.OrderBy(x => x.Category).ThenByDescending(x => x.UnitPrice);
            //foreach(var item in ras)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region qution9
            //var res = p.Where(x => x.Category == "Beverages").OrderByDescending(x => x.UnitsInStock);
            //foreach(var x in res)
            //{
            //    Console.WriteLine($"name is={x.ProductName} stock is={x.UnitsInStock}");
            //}
            #endregion
            #region qution10

            #endregion

        }
    }
}