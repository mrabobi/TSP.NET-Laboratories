using Database.Models;
using Microsoft.EntityFrameworkCore;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Database
{
    public class API
    {
        public static Post AddPost(Post post)
        {
            PostCommentContext context = new PostCommentContext();
            context.Posts.Add(post);
            context.SaveChanges();
            return post;
        }
        public static Post UpdatePost(Post newPost)
        {
            throw new NotImplementedException();
        }
        public static void DeletePost(Guid id)
        {
            PostCommentContext context = new PostCommentContext();
            Post post = GetPostById(id);
            if (post == null)
                throw new NotFoundException();
            context.Posts.Remove(post);
            context.SaveChanges();
        }
        public static Post GetPostById(Guid id)
        {
            PostCommentContext context = new PostCommentContext();
            return context.Posts.Where(p => p.PostId == id).FirstOrDefault();
        }
        public static List<Post> GetAllPosts()
        {
            PostCommentContext context = new PostCommentContext();
            return context.Posts.Include(p => p.Comments).ToList();
        }
        public static Comment AddComment(Comment comment)
        {
            PostCommentContext context = new PostCommentContext();
            context.Comments.Add(comment);
            context.SaveChanges();
            return comment;
        }
        public static Comment UpdateComment(Comment newComment)
        {
            throw new NotImplementedException();
        }
        public static Comment GetCommentById(Guid id)
        {
            PostCommentContext context = new PostCommentContext();
            return context.Comments.Where(c => c.CommentId == id).FirstOrDefault();
        }
    }
}
