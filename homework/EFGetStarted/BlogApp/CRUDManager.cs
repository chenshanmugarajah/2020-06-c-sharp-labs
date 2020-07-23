using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EFGetStarted;
using Microsoft.EntityFrameworkCore.Internal;

namespace BlogApp
{
    public class CRUDManager
    {
        public Post SelectedPost { get; set; }
        public Blog SelectedBlog { get; set; }

        public List<Post> ReadPosts(Blog blog)
        {
            using (var db = new BloggingContext())
            {
                return db.Posts.Where(p => p.BlogId.Equals(blog.BlogId)).ToList();
            }
        }
        public List<Post> ReadPosts()
        {
            using (var db = new BloggingContext())
            {
                return db.Posts.ToList();
            }
        }
        public void CreatePost(String title, String content)
        {
            if (SelectedBlog != null)
            {
                using (var db = new BloggingContext())
                {
                    var blog = db.Blogs.Where(b => b.BlogId == SelectedBlog.BlogId).FirstOrDefault();
                    blog.Posts.Add(
                        new Post
                        {
                            Title = title,
                            Content = content
                        });
                    db.SaveChanges();
                }
            }
        }
        public void UpdatePost(String newTitle, String newContent)
        {
            if (SelectedPost != null)
            {
                using (var db = new BloggingContext())
                {
                    var target = db.Posts.Where(p => p.PostId == SelectedPost.PostId).FirstOrDefault();
                    target.Title = newTitle;
                    target.Content = newContent;
                    db.SaveChanges();
                    SetCurrentPost(target);
                }
            }
        }
        public void DeletePost(Post post)
        {
            if (SelectedPost != null)
            {
                using (var db = new BloggingContext())
                {
                    db.Remove(post);
                    db.SaveChanges();
                }
            }
        }

        public List<Blog> ReadBlogs()
        {
            using (var db = new BloggingContext())
            {
                return db.Blogs.ToList();
            }
        }
        public void CreateBlog(String name)
        {
            using (var db = new BloggingContext())
            {
                var doesExist = db.Blogs.Where(b => b.Url == $"http://www.{name}.com").FirstOrDefault();

                if (doesExist == null)
                {
                    db.Add(new Blog { Url = $"http://www.{name}.com" });
                    db.SaveChanges();
                }
            }
        }
        public void DeleteBlog()
        {
            if (SelectedBlog != null)
            {
                using (var db = new BloggingContext())
                {
                    var blog = db.Blogs.Where(b => b.BlogId == SelectedBlog.BlogId).FirstOrDefault();
                    db.Remove(blog);
                    db.SaveChanges();
                }
            }
        }

        public void SetCurrentBlog(object selectedItem)
        {
            SelectedBlog = (Blog)selectedItem;
        }
        public void SetCurrentPost(object selectedItem)
        {
            
            SelectedPost = (Post)selectedItem;
        }

    }
}
