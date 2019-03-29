using System;
using System.Collections.Generic;
using System.Linq;

namespace FriendLikesPost
{
    class Program
    {
        static void Main(string[] args)
        {
            var friendNames = new List<string>();
            while (true)
            {
                Console.WriteLine("Type your friends' names. Hit Enter after each name.");
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    break;
                }
                friendNames.Add(input);
            }

            int numberOfFriends = friendNames.Count;
            if (numberOfFriends == 0)
            {
                return;
            }
            else if (numberOfFriends == 1)
            {
                Console.WriteLine(friendNames.First() + " likes your post");
                Console.ReadLine();
            }
            else if (numberOfFriends == 2)
            {
                Console.WriteLine("{0} and {1} like your post", friendNames.First(), friendNames.ElementAt(1));
                Console.ReadLine();
            }
            else if (numberOfFriends >= 3)
            {
                Console.WriteLine("{0}, {1} and {2} other(s) like your post", friendNames.First(), friendNames.ElementAt(1), numberOfFriends - 2);
                Console.ReadLine();
            }           
        }
    }
}
