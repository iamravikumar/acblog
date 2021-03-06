﻿using AcBlog.Data.Models;
using System;

#pragma warning disable IDE1006 // 命名样式

namespace AcBlog.Tools.Sdk.Models.Text
{
    public class LayoutMetadata : MetadataBase<Layout>
    {
        public string id { get; set; } = string.Empty;

        public string creationTime { get; set; } = string.Empty;

        public string modificationTime { get; set; } = string.Empty;

        public LayoutMetadata() { }

        public LayoutMetadata(Layout data)
        {
            id = data.Id;
            creationTime = data.CreationTime.ToString();
            modificationTime = data.ModificationTime.ToString();
        }

        public override Layout ApplyTo(Layout data)
        {
            data = data with { Id = id };
            if (DateTimeOffset.TryParse(creationTime, out var _creationTime))
            {
                data = data with { CreationTime = _creationTime };
            }
            if (DateTimeOffset.TryParse(modificationTime, out var _modificationTime))
            {
                data = data with { ModificationTime = _modificationTime };
            }
            return data;
        }
    }
}
