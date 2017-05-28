using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace RecycleViewForWork {
	[Activity(Label = "RecycleViewForWork", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity {
		ListView listShow;
		List<DataModel> userList;

		protected override void OnCreate(Bundle savedInstanceState) {
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			AddData();
			Process();
		}

		void Process() {
			listShow = FindViewById<ListView>(Resource.Id.lvShow);
			CustomListView employeeProfileAdapter = new CustomListView(this, userList);
			listShow.Adapter = employeeProfileAdapter;
		}

		void AddData() {

			userList = new List<DataModel>();

			userList.Add(new DataModel() {
				Image = "http://i.imgur.com/DvpvklR.png",
				Title = "รูปที่",
				Des = "เทสภาษาไทย"
			});

			userList.Add(new DataModel() {
				Image = "http://i.imgur.com/DvpvklR.png",
				Title = "รูปที่",
				Des = "ทำอะไรได้บ้าง"
			});

			userList.Add(new DataModel() {
				Image = "http://i.imgur.com/DvpvklR.png",
				Title = "รูปที่",
				Des = "ทำอะไรได้บ้าง"
			});

			userList.Add(new DataModel() {
				Image = "http://i.imgur.com/DvpvklR.png",
				Title = "รูปที่",
				Des = "ทำอะไรได้บ้าง"
			});

			userList.Add(new DataModel() {
				Image = "http://i.imgur.com/DvpvklR.png",
				Title = "รูปที่",
				Des = "ทำอะไรได้บ้าง"
			});

			userList.Add(new DataModel() {
				Image = "http://i.imgur.com/DvpvklR.png",
				Title = "รูปที่",
				Des = "ทำอะไรได้บ้าง"
			});

			userList.Add(new DataModel() {
				Image = "http://i.imgur.com/DvpvklR.png",
				Title = "รูปที่",
				Des = "ทำอะไรได้บ้าง"
			});

			userList.Add(new DataModel() {
				Image = "http://i.imgur.com/DvpvklR.png",
				Title = "รูปที่",
				Des = "ทำอะไรได้บ้าง"
			});

			userList.Add(new DataModel() {
				Image = "http://i.imgur.com/DvpvklR.png",
				Title = "รูปที่",
				Des = "ทำอะไรได้บ้าง"
			});

		}
	}
}

