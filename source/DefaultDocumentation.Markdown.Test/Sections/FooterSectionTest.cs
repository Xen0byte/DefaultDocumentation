﻿using DefaultDocumentation.Markdown.Extensions;
using DefaultDocumentation.Model;
using NFluent;
using Xunit;

namespace DefaultDocumentation.Markdown.Sections
{
    public sealed class FooterSectionTest : ASectionTest<FooterSection>
    {
        private static readonly AssemblyDocItem _assemblyItem = new("dummy", "dummy", null);

        [Fact]
        public void Name_should_be_Footer() => Check.That(Name).IsEqualTo("Footer");

        [Fact]
        public void Write_should_not_write_When_not_PageItem() => Test(
            w => w.SetCurrentItem(_assemblyItem),
            string.Empty);

        [Fact]
        public void Write_should_write() => Test(
@"---
Generated by [DefaultDocumentation](https://github.com/Doraku/DefaultDocumentation 'https://github.com/Doraku/DefaultDocumentation')");

        [Fact]
        public void Write_should_write_newline_When_needed() => Test(
            w => w.Append("pouet"),
@"pouet

---
Generated by [DefaultDocumentation](https://github.com/Doraku/DefaultDocumentation 'https://github.com/Doraku/DefaultDocumentation')");
    }
}
