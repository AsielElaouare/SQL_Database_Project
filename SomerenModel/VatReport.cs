namespace SomerenModel
{
	public class VatReport
	{
		public decimal VatLow { get; set; }
		public decimal VatHigh { get; set; }
		public decimal VatTotal { get { return VatLow + VatHigh; } }
	}
}
