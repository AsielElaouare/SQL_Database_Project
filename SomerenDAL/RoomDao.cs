using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;

namespace SomerenDAL
{
	public class RoomDao : BaseDao
	{
		public List<Room> GetAllRooms()
		{
			string query = "SELECT roomId, size, roomType, roomName FROM [Room]";
			SqlParameter[] sqlParameters = new SqlParameter[0];
			return ReadTables(ExecuteSelectQuery(query, sqlParameters));
		}

		private List<Room> ReadTables(DataTable dataTable)
		{
			List<Room> rooms = new List<Room>();

			foreach (DataRow dr in dataTable.Rows)
			{
				Room room = new Room()
				{
					roomId = (int)dr["roomId"],
					size = (int)dr["size"],
					roomName = dr["roomType"].ToString(),
					roomType = dr["roomName"].ToString()
				};
				rooms.Add(room);
			}
			return rooms;
		}
	}
}