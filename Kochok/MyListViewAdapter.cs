using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Kochok
{
    class MyListViewAdapter : BaseAdapter<Exercise>
    {
        private List<Exercise> myItems;
        private Context myContext;

        public MyListViewAdapter(Context context, List<Exercise> items)
        {
            myItems = items;
            myContext = context;
        }

        public override int Count
        {
            get { return myItems.Count; }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override Exercise this[int position]
        {
            get { return myItems[position]; }
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;

            if (row == null)
            {
                row = LayoutInflater.From(myContext).Inflate(Resource.Layout.row, null, false);
            }

            TextView txtName = row.FindViewById<TextView>(Resource.Id.txtName);
            txtName.Text = myItems[position].nameExercise;

            return row;
        }
    }
}