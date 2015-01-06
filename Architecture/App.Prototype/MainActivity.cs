using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.IO;
using Tasky.DL.SQLite;
using App.Shared;
using App.Android;
using App.Data;
using System.Linq;


namespace App.Prototype
{
	[Activity (Label = "App.Prototype", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

//			var sqliteFilename = "TaskDB.db3";
//			string libraryPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
//			var path = Path.Combine(libraryPath, sqliteFilename);
//			var conn = new Connection(path);
//		
//			// create the tables
//			conn.CreateTable<Task>();
//			UnitOfWork uow = new UnitOfWork ();
//
			Configurator cfg = new Configurator ();
			UnitOfWork uow = cfg.GetUnitOfWork ();

			SongRepository songs = (SongRepository)uow.GetRepository<Song> ();
			songs.Add (new Song (){ Title = "Highway to Hell", Artist = "AC/DC", Genre = Genres.Rock, Rating = 10 });
			uow.Commit ();

			AndroidApp app = new AndroidApp ();
			app.RateSong("Highway to Hell", 5);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			var song = songs.GetAll().Where(x => x.Artist == "AC/DC").First ();

			TextView View1 = FindViewById<TextView> (Resource.Id.textView10);
			View1.Text = song.Title;

			TextView View2 = FindViewById<TextView> (Resource.Id.textView11);
			View2.Text = song.Artist;

			TextView View3 = FindViewById<TextView> (Resource.Id.textView12);
			View3.Text = song.Rating.ToString ();

			// Get our button from the layout resource,
			// and attach an event to it
//			Button button = FindViewById<Button> (Resource.Id.myButton);
//			
//			button.Click += delegate {
//				button.Text = string.Format ("{0} clicks!", count++);
//			};




		}
	}
}


