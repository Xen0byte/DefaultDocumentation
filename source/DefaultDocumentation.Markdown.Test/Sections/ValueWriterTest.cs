﻿using System;
using System.Xml.Linq;
using DefaultDocumentation.Model;
using DefaultDocumentation.Model.Member;
using ICSharpCode.Decompiler.TypeSystem;
using NFluent;
using Xunit;

namespace DefaultDocumentation.Markdown.Sections
{
    public sealed class ValueWriterTest : ASectionWriterTest<ValueWriter>
    {
        private static int Property { get; }

        [Fact]
        public void Name_should_be_value() => Check.That(Name).IsEqualTo("value");

        [Fact]
        public void Write_should_not_write_When_not_PropertyDocItem() => Test(
            default(DocItem),
            string.Empty);

        [Fact]
        public void Write_should_write() => Test(
            new PropertyDocItem(null, AssemblyInfo.Get<IProperty>($"P:{typeof(ValueWriterTest).FullName}.{nameof(Property)}"), null),
            $"#### Property Value{Environment.NewLine}[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')");

        [Fact]
        public void Write_should_write_value_When_present() => Test(
            new PropertyDocItem(null, AssemblyInfo.Get<IProperty>($"P:{typeof(ValueWriterTest).FullName}.{nameof(Property)}"), new XElement("doc", new XElement("value", "test"))),
            $"#### Property Value{Environment.NewLine}[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32'){Environment.NewLine}{Environment.NewLine}test");

        [Fact]
        public void Write_should_write_newline_When_needed() => Test(
            new PropertyDocItem(null, AssemblyInfo.Get<IProperty>($"P:{typeof(ValueWriterTest).FullName}.{nameof(Property)}"), null),
            w => w.Append("pouet"),
            $"pouet{Environment.NewLine}{Environment.NewLine}#### Property Value{Environment.NewLine}[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')");
    }
}
