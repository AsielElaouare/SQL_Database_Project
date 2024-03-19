namespace SomerenModel
{
	public class Room
	{
		public int roomId { get; set; }       // database id
		public int size { get; set; }     // number of beds, either 4, 6, 8, 12 or 16
		public string roomType { get; set; }  // student = false, teacher = true
		public string roomName { get; set; }
	}
}