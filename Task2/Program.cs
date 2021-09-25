using System;
using System.Collections.Generic;
namespace Task2
{
    class Program
    {
		public static void Merge(Post[] posts, int start, int mid, int end)
		{
			//Kreira se privremeni niz
			Post[] temp = new Post[end - start + 1];

			int i = start, j = mid + 1, k = 0;

			while (i <= mid && j <= end)
			{
				if (posts[i].Date <= posts[j].Date)
				{
					temp[k] = posts[i];
					k ++; i ++;
				}
				else
				{
					temp[k] = posts[j];
					k ++; j ++;
				}
			}
			
			while (i <= mid)
			{
				temp[k] = posts[i];
				k ++; i ++;
			}
 
			while (j <= end)
			{
				temp[k] = posts[j];
				k ++; j ++;
			}

			for (i = start; i <= end; i += 1)
			{
				posts[i] = temp[i - start];
			}
		}

		public static void Sort(Post[] posts, int start, int end)
		{

			if (start < end)
			{
				int mid = (start + end) / 2;
				Sort(posts, start, mid);
				Sort(posts, mid + 1, end);
				Merge(posts, start, mid, end);
			}
		}

		public static Post FindPost(Dictionary<int, Post> posts, int id)
        {
			Post pom = new Post();
			if (posts.TryGetValue(id, out pom))
            {
				return posts[id];
			}
			return null;
        }

		static void Main(string[] args)
        {

			Dictionary<int, Post> postsDic = new Dictionary<int, Post>();

            Post post1 = new Post(1, "Post1", "Aut", "Con", new DateTime(2014, 1, 1));
			postsDic.Add(post1.ID, post1);
            Post post2 = new Post(2, "Post2", "Aut", "Con", new DateTime(2016, 1, 1));
			postsDic.Add(post2.ID, post2);
			Post post3 = new Post(3, "Post3", "Aut", "Con", new DateTime(2012, 1, 1));
			postsDic.Add(post3.ID, post3);
			Post post4 = new Post(4, "Post4", "Aut", "Con", new DateTime(2009, 1, 1));
			postsDic.Add(post4.ID, post4);
			Post post5 = new Post(5, "Post5", "Aut", "Con", new DateTime(2010, 1, 1));
			postsDic.Add(post5.ID, post5);
			Post post6 = new Post(666, "Post6", "Aut", "Con", new DateTime(2019, 1, 1));
			postsDic.Add(post6.ID, post6);
			Post post7 = new Post(7, "Post7", "Aut", "Con", new DateTime(2017, 1, 1));
			postsDic.Add(post7.ID, post7);
			Post post8 = new Post(8, "Post8", "Aut", "Con", new DateTime(2008, 1, 1));
			postsDic.Add(post8.ID, post8);
			Post post9 = new Post(9, "Post9", "Aut", "Con", new DateTime(2020, 1, 1));
			postsDic.Add(post9.ID, post9);
			Post post10 = new Post(10, "Post10", "Aut", "Con", new DateTime(2018, 1, 1));
			postsDic.Add(post10.ID, post10);

			Post[] posts = { post1, post2, post3, post4, post5, post6, post7, post8, post9, post10 };

            Sort(posts, 0, 9);

            foreach(Post el in posts)
            {
                el.Stampa();
            }

			//FindPost(postsDic, 666).Stampa();

			Console.WriteLine("Unesite ID Post-a za kog zelite informacije:\n");
			int id = Int32.Parse(Console.ReadLine());
			Post pomPost = FindPost(postsDic, id);
			if (pomPost == null)
			{
				Console.WriteLine("Nepostoji post sa zadatim ID");
			}
			else
            {
				pomPost.Stampa();
            }

        }

    }


}
