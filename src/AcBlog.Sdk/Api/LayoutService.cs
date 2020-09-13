﻿using AcBlog.Data.Models;
using AcBlog.Data.Models.Actions;
using AcBlog.Data.Repositories.Searchers;
using System.Net.Http;

namespace AcBlog.Sdk.Api
{
    internal class LayoutService : BaseRecordApiService<Layout, LayoutQueryRequest, ILayoutRepositorySearcher>, ILayoutService
    {
        public LayoutService(IBlogService blog, HttpClient httpClient) : base(blog, httpClient)
        {
        }

        protected override string PrepUrl => "/Layouts";
    }
}
