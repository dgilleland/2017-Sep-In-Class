<Query Kind="Program">
  <Connection>
    <ID>b5967f5c-8db4-4206-902b-e2abfbc3efba</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eBikes_DMIT 2018</Database>
  </Connection>
</Query>

// Display Jobs Data Changes
void Main()
{
	Parts.Where(x=>x.Description.Contains("O-ring")).Dump();
}

// Define other methods and classes here
