﻿using System.Collections.Generic;
using System.Linq;
using DefaultDocumentation.Api;
using DefaultDocumentation.Markdown.Extensions;
using DefaultDocumentation.Markdown.UrlFactories;
using DefaultDocumentation.Models;
using NFluent;
using Xunit;

namespace DefaultDocumentation.Markdown.Sections
{
    public sealed class PropertiesSectionTest : ASectionTest<PropertiesSection>
    {
        protected override IReadOnlyDictionary<string, DocItem> GetItems() =>
            AssemblyInfo.ClassDocItem.IntoEnumerable<DocItem>()
            .Concat(AssemblyInfo.PropertyDocItem)
            .ToDictionary(i => i.Id);

        protected override IUrlFactory[] GetUrlFactories() => new IUrlFactory[]
        {
            new DocItemFactory()
        };

        protected override ISection[] GetSections() => new ISection[]
        {
            new TitleSection()
        };

        [Fact]
        public void Name_should_be_Properties() => Check.That(Name).IsEqualTo("Properties");

        [Fact]
        public void Write_should_write_When_TypeDocItem() => Test(
            AssemblyInfo.ClassDocItem,
@"| Properties | |
| :--- | :--- |
| [Property](Property 'DefaultDocumentation.AssemblyInfo.Property') | |
");
    }
}
