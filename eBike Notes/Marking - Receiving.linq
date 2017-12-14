<Query Kind="Program">
  <Connection>
    <ID>b5967f5c-8db4-4206-902b-e2abfbc3efba</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eBikes_DMIT 2018</Database>
  </Connection>
</Query>

// Display Receiving Data Changes
void Main()
{
	var orders = PurchaseOrders.Where(x=>x.PurchaseOrderNumber == 130 || x.PurchaseOrderNumber == 131);
	orders.Dump();
	var unordered = UnorderedPurchaseItemCarts;
	unordered.Dump();
	var parts = Parts.Where(x=>x.Description.Contains("Air"));
	parts.Dump();
}

// Define other methods and classes here
