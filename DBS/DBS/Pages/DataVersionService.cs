namespace DBS.Pages
{
	public class DataVersionService
	{
			public int DataVersion { get; set; } = 1;
			public void IncrementDataVersion()
			{
				DataVersion++;
			}
		
	}
}
