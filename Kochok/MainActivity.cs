using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace Kochok
{
    [Activity(Label = "Kochok", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
     
        //private List<Exercise> myItems;
        //private ListView myListView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Log);
            /*
            myItems = new List<Exercise>();
            myListView = FindViewById<ListView>(Resource.Id.myListView);
            myItems.Add(new Exercise { nameExercise = "Kocka"});
            myItems.Add(new Exercise { nameExercise = "Tvorojok" });


            MyListViewAdapter adapter = new MyListViewAdapter(this, myItems);
            myListView.Adapter = adapter;

            myListView.ItemClick += myListView_ItemClick;
            myListView.ItemLongClick += MyListView_ItemLongClick;
            */
 
        }

        private void MyListView_ItemLongClick(object sender, AdapterView.ItemLongClickEventArgs e)
        {
            throw new NotImplementedException();
        }

        void myListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            //Console.WriteLine(myItems[e.Position].nameExercise);
        }
    }
}

