using System;
using System.Collections.Generic;

namespace AthletesRating.Models
{
	public class Medal
	{
		#region Fields and Options
		public int Place { get; private set; }
		public string Name { get; private set; }
		public string Level { get; private set; }
		public DateTime ReceiveYear { get; private set; }
		#endregion

		public Medal(int place, string name, string level, DateTime receiveYear)
		{
			Place = place;
			Name = name;
			Level = level;
			ReceiveYear = receiveYear;
		}
        
		public static List<Medal> ToList(Medal[] medal)
        {
			List<Medal> list = new List<Medal>();
			for(int i = 0; i < medal.Length; i++)
            {
				list.Add(medal[i]);
            }
			return list;
        }
	}
}
