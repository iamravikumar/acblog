﻿using AcBlog.Data.Documents;
using AcBlog.Data.Models;
using System;

namespace Test.Data
{
    public static class Generator
    {
        static Random Random { get; set; } = new Random();

        public static string GetString()
        {
            return Random.Next().ToString();
        }

        public static DateTimeOffset GetDateTimeOffset()
        {
            return new DateTimeOffset(Random.Next(), TimeSpan.Zero);
        }

        public static Document GetDocument()
        {
            return new Document
            {
                Raw = GetString(),
                Tag = GetString()
            };
        }

        public static Category GetCategory()
        {
            return new Category
            {
                Items = new string[]
                {
                    GetString(),
                    GetString()
                }
            };
        }

        public static Keyword GetKeyword()
        {
            return new Keyword
            {
                Items = new string[]
                {
                    GetString(),
                    GetString()
                }
            };
        }

        public static Feature GetFeature()
        {
            return new Feature
            {
                Items = new string[]
                {
                    GetString(),
                    GetString()
                }
            };
        }

        public static Layout GetLayout()
        {
            return new Layout
            {
                Id = GetString(),
                Template = GetString(),
                CreationTime = GetDateTimeOffset(),
                ModificationTime = GetDateTimeOffset()
            };
        }

        public static File GetFile()
        {
            return new File
            {
                Id = GetString(),
                Uri = GetString()
            };
        }

        public static Page GetPage()
        {
            return new Page
            {
                Id = GetString(),
                Title = GetString(),
                Content = GetString(),
                Features = GetFeature(),
                Route = GetString(),
                CreationTime = GetDateTimeOffset(),
                ModificationTime = GetDateTimeOffset()
            };
        }

        public static Comment GetComment()
        {
            return new Comment
            {
                Id = GetString(),
                Author = GetString(),
                Content = GetString(),
                Email = GetString(),
                Link = GetString(),
                Extra = GetString(),
                Uri = GetString(),
                CreationTime = GetDateTimeOffset(),
                ModificationTime = GetDateTimeOffset()
            };
        }

        public static Statistic GetStatistic()
        {
            return new Statistic
            {
                Id = GetString(),
                Category = GetString(),
                Payload = GetString(),
                Uri = GetString(),
                CreationTime = GetDateTimeOffset(),
                ModificationTime = GetDateTimeOffset()
            };
        }

        public static Post GetPost()
        {
            var types = Enum.GetValues(typeof(PostType));
            return new Post
            {
                Id = GetString(),
                Author = GetString(),
                Content = GetDocument(),
                Title = GetString(),
                Category = GetCategory(),
                Keywords = GetKeyword(),
                CreationTime = GetDateTimeOffset(),
                ModificationTime = GetDateTimeOffset(),
                Type = (PostType)types.GetValue(Random.Next(types.Length)),
            };
        }
    }
}
