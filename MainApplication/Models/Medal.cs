using System;
using System.Collections.Generic;

namespace AthletesRating.Models
{
	public class Medal
	{
		#region Fields and Options
		public int Place { get; private set; }
		public string Name { get; private set; }
		public string Lavel { get; private set; }
		public DateTime ReceiveYear { get; private set; }
		#endregion

		public Medal(int place, string name, string level, DateTime receiveYear)
		{
			Place = place;
			Name = name;
			Lavel = level;
			ReceiveYear = receiveYear;
		}

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
