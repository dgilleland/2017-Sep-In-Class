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
	var jobs = Jobs.Where(x=>!x.JobDateOut.HasValue);
	jobs.Dump("All jobs not out");
//	var outJobs = Jobs.Where(x=>x.JobDateOut.HasValue);
//	outJobs.Dump("All jobs out");
	Parts.Where(x=>x.Description.Contains("O-ring")).Dump();
}

// Define other methods and classes here