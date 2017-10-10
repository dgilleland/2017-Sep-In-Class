<Query Kind="Statements">
  <Connection>
    <ID>e5af68a8-d464-4274-880d-fcab824d01aa</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>Northwind_DMIT2018</Database>
  </Connection>
</Query>

// TODO: 5) Most Popular products sold (qty), by year and month
var ProductQuantitiesByYearAndMonth =
    from soldItem in OrderDetails
	group soldItem by new 
					  {
					  	soldItem.Product.ProductName,
						soldItem.Order.OrderDate.Value.Year,
						soldItem.Order.OrderDate.Value.Month
					  }
		into groupedOrderDetails
	orderby groupedOrderDetails.Key.Year, groupedOrderDetails.Key.Month
	// temp where clause, for a single months worth
//	where 
//	      groupedOrderDetails.Key.Year == 1996
//	   && groupedOrderDetails.Key.Month == 7
	select new
		   {
		   		Product = groupedOrderDetails.Key.ProductName,
				Year = groupedOrderDetails.Key.Year,
				Month = groupedOrderDetails.Key.Month,
				TotalQtySold = groupedOrderDetails.Sum(detailItem => detailItem.Quantity)
		   };
// see the output
//ProductQuantitiesByYearAndMonth.Dump("Intermediate results");
var maxQty = ProductQuantitiesByYearAndMonth.Max(x => x.TotalQtySold);
maxQty.Dump("Max for the whole collection");
var maxItem = from product in ProductQuantitiesByYearAndMonth
              where product.TotalQtySold == maxQty
              select product;
maxItem.Dump("Max Item");

var finalResults = from item in ProductQuantitiesByYearAndMonth
                   group item by new {item.Year, item.Month} into groupedItem
				   select new
				   {
				       Year = groupedItem.Key.Year,
					   Month = groupedItem.Key.Month,
					   MostPopular = (from thing in groupedItem
					                 where thing.TotalQtySold == groupedItem.Max(x=>x.TotalQtySold)
									 select new
									{
										thing.Product,
										thing.TotalQtySold
									}).Single()
				   };
finalResults.Dump("Most Popular products sold (qty), by year and month");				   



//from item in Products
//select new
//{
//	Name = item.ProductName,
//	TotalQuantities = item.OrderDetails.Sum(soldItem => soldItem.Quantity),
//	OrderQuantities = from soldItem in item.OrderDetails
//	                  select soldItem.Quantity,
//	OrderQuantitiesByYearAndMonth =
//	                  from soldItem in item.OrderDetails
//					  group soldItem by new { Year = soldItem.Order.OrderDate.Value.Year,
//					                          Month = soldItem.Order.OrderDate.Value.Month }
//				       		into groupedOrderDetails
//					  select new
//					  {
//					  		Year = groupedOrderDetails.Key.Year,
//							Month = groupedOrderDetails.Key.Month,
//							Quantities = groupedOrderDetails.Sum(detail => detail.Quantity)
//					  },
//}