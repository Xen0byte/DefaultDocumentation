﻿using System.Collections.Generic;
using System.Linq;
using DefaultDocumentation.Api;
using DefaultDocumentation.Models;
using Xunit;

namespace DefaultDocumentation.Markdown.Sections.HeaderSectionTests;

public sealed class WriteShould : BaseSectionTester<HeaderSection>
{
    protected override GeneratedPages GetGeneratedPages()
        => GeneratedPages.Assembly
        | GeneratedPages.Namespaces
        | GeneratedPages.Types
        | GeneratedPages.Members;

    protected override IReadOnlyCollection<DocItem> GetItemsWithOwnPage() => [AssemblyInfo.AssemblyDocItem, AssemblyInfo.NamespaceDocItem];

    protected override IReadOnlyDictionary<string, DocItem> GetItems() => new DocItem[] { AssemblyInfo.AssemblyDocItem }.ToDictionary(item => item.Id);

    [Fact]
    public void NotWriteWhenNotPageItem() => Test(
        w => w.SetCurrentItem(AssemblyInfo.NamespaceDocItem),
        string.Empty);

    [Fact]
    public void Write() => Test(
        AssemblyInfo.MethodWithReturnDocItem,
@"#### [Test](Test 'Test')
### [DefaultDocumentation](N:DefaultDocumentation 'DefaultDocumentation').[AssemblyInfo](T:DefaultDocumentation.AssemblyInfo 'DefaultDocumentation\.AssemblyInfo')");

    [Fact]
    public void WriteNewlineWhenNeeded() => Test(
        AssemblyInfo.MethodWithReturnDocItem,
        w => w.Append("pouet"),
@"pouet
#### [Test](Test 'Test')
### [DefaultDocumentation](N:DefaultDocumentation 'DefaultDocumentation').[AssemblyInfo](T:DefaultDocumentation.AssemblyInfo 'DefaultDocumentation\.AssemblyInfo')");
}
