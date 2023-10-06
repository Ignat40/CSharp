using System;
using System.Collections.Generic;

namespace Lists
{

    struct Post
    {
        public string Content; //Heap
        public int Likes; // Stack: Like is an int, a value type.

        public Post(string content)
        {
            Content = content; // Heap: Initialize content
            Likes = 0;
        }

        public void LikePost()
        {
            ++Likes;
        }

    }


    class Program
    {

        //Stack: Pass by reference to modify value type 
        public static void LikeAPost(ref Post postToLike)
        {
            //stack: calls a value type (a struct's mathod)
            postToLike.LikePost();
        }

        //Heap & Stack: posts is a reference type. 
        public static void DisplayPosts(List<Post> posts)
        {
            foreach (var post in posts)
            {
                Console.WriteLine($"Content {post.Content}, Likes: {post.Likes}");
            }
        }

        static List<Post> profilePosts = new();

        public static void Main(string[] args)
        {
            if (args.Length > 0) //Stack: Checks arguments
            {
                if (args[0] == "like")//Heap: 
                {
                    int index = 0;
                    bool isValid = int.TryParse(args[1], out index);
                    //Stack & Heap: Count is 
                    if (isValid && index < profilePosts.Count)
                    {
                        //Stack: Use ref to modify the original value type.
                        Post postToLike = profilePosts[index];
                        LikeAPost(ref postToLike);
                        // The same thing as this code -> LikeAPost(ref profilePosts[index]);
                    }
                }
            }

        while(true)
        {
            Console.WriteLine("Do you want to create a post (y/n)?");

            //Heap: Readline returns a string
            string? answer = Console.ReadLine();
            if(answer != null && answer.ToLower().Equals("y"))
            {
                Console.WriteLine($"Enter the content of your post: ");
                //Heap: Readline return a string
                string? content = Console.ReadLine();

                //Heap & Stack: newPost is a struct, a value type (stack)
                //contenct is a string, a reference type (heap)
                Post newPost = new Post(content);

                //Heap: Add new post to a list in the heap 
                profilePosts.Add(newPost);
            }
            else
            {
                break;
            }
        }
        }
    }
}