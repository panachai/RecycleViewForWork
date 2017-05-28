using System;
using System.Collections.Generic;
using Android.App;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using Square.Picasso;

namespace RecycleViewForWork {
	public class RecyclerViewDemoAdapter : RecyclerView.Adapter {

		Activity activity;
		List<DataModel> userList;

		public RecyclerViewDemoAdapter(Activity activity, List<DataModel> userList) {
			this.activity = activity;
			this.userList = userList;
		}

		public override int ItemCount {
			get {
				return userList.Count;
			}
		}

		public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position) {
			MyViewHolder vh = holder as MyViewHolder;

			vh.txtTitle.Text = userList[position].Title;
			vh.txtDes.Text = userList[position].Des;
			Picasso.With(activity)
				   	.Load(userList[position].Image)
					.Transform(new CircleTransform())
					.Into(vh.imvShow);
		}

		public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType) {
			// Inflate the CardView for the photo:
			View itemView = LayoutInflater.From(parent.Context).
						Inflate(Resource.Layout.listview_row2, parent, false);

			// Create a ViewHolder to hold view references inside the CardView:
			MyViewHolder vh = new MyViewHolder(itemView);
			return vh;
		}
	}

	public class MyViewHolder : RecyclerView.ViewHolder {
		public ImageView imvShow { get; set; }
		public TextView txtTitle { get; set; }
		public TextView txtDes { get; set; }

		public MyViewHolder(View v) : base(v) {
			imvShow = v.FindViewById<ImageView>(Resource.Id.imvShow);
			txtTitle = v.FindViewById<TextView>(Resource.Id.txtTitle);
			txtDes = v.FindViewById<TextView>(Resource.Id.txtDes);
		}
	}
}
