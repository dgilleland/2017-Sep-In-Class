<Query Kind="Program">
  <Connection>
    <ID>b5967f5c-8db4-4206-902b-e2abfbc3efba</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eBikes_DMIT 2018</Database>
  </Connection>
</Query>

// Display Purchasing Data Changes
void Main()
{
	var needing = from data in Parts
	              where data.QuantityOnHand + data.QuantityOnOrder <= data.ReorderLevel
//				  where data.QuantityOnHand + data.QuantityOnOrder >= data.ReorderLevel
				  select data;
	needing.Dump("Parts needing ordering");
	var open = PurchaseOrders.Where(x => !x.OrderDate.HasValue);
	open.Dump("Current open orders");
	
}

// Define other methods and classes here