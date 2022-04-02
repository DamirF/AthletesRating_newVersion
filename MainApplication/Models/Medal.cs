using System.Collections.Generic;

namespace AthletesRating.Models
{
	public class Medal
	{
		private int Place;
		private int ReceiveYear;

		public Medal(int place, int receiveYear)
		{
			Place = place;
			ReceiveYear = receiveYear;
		}

		public int GetPlace() => Place;
		public int GetReceiveYear() => ReceiveYear;

		public static List<Medal> ToList(Medal[] medals)
        {
			List<Medal> list = new List<Medal>();
			for(int i = 0; i < medals.Length; i++)
            {
				list.Add(medals[i]);
            }
			return list;
        }
	}
}
