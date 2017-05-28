using System;
using System.Collections.Generic;
using Android.App;
using Android.Views;
using Android.Widget;
using Java.Lang;
using Square.Picasso;

namespace RecycleViewForWork {
	public class CustomListView : BaseAdapter {
		Activity activity;
		List<DataModel> userList;

		public CustomListView(Activity activity, List<DataModel> userList) {
			this.activity = activity;
			this.userList = userList;
		}

		public override int Count {
			get {
				return userList.Count;
			}
		}

		public override Java.Lang.Object GetItem(int position) {
			return position;
		}

		public override long GetItemId(int position) {
			return position;
		}

		public override View GetView(int position, View convertView, ViewGroup parent) {

			View view = convertView;
			ViewHolder viewHolder;

			if (view == null) {       //activity.LayoutInflater.Inflate(Android.Resource.Layout.listview_row, null);
				view = convertView ?? activity.LayoutInflater.Inflate(Resource.Layout.listview_row2, parent, false);
				viewHolder = new ViewHolder();

				viewHolder.imvShow = view.FindViewById<ImageView>(Resource.Id.imvShow);
				viewHolder.txtTitle = view.FindViewById<TextView>(Resource.Id.txtTitle);
				viewHolder.txtDes = view.FindViewById<TextView>(Resource.Id.txtDes);

				view.Tag = viewHolder;
			} else {
				viewHolder = (ViewHolder)view.Tag; //don't know..
			}

			viewHolder.txtTitle.Text = userList[position].Title;
			viewHolder.txtDes.Text = userList[position].Des; //string.Format("{0}", userList[position].Des)

			Picasso.With(activity)
				   	.Load(userList[position].Image)
					.Transform(new CircleTransform())
					.Into(viewHolder.imvShow);
			return view;
		}

		private class ViewHolder : Java.Lang.Object {
			public ImageView imvShow;
			public TextView txtTitle;
			public TextView txtDes;
		}
	}

}
