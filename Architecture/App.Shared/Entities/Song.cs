using System;
using App.Shared.Interfaces;

namespace App.Data
{
	public enum Genres
	{
		Rock,
		Pop,
	}

	public class Song : IEntity
	{
		#region IEntity implementation

		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }

		#endregion

		public string Title { get; set; }
		public string Artist { get; set; }
		public Genres Genre { get; set; }
		public int Rating { get; set; }
	}
}

