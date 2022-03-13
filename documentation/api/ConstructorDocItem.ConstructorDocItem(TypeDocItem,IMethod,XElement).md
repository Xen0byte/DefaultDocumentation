#### [DefaultDocumentation.Api](index.md 'index')
### [DefaultDocumentation.Models.Members](index.md#DefaultDocumentation.Models.Members 'DefaultDocumentation.Models.Members').[ConstructorDocItem](ConstructorDocItem.md 'DefaultDocumentation.Models.Members.ConstructorDocItem')

## ConstructorDocItem(TypeDocItem, IMethod, XElement) Constructor

Initialize a new instance of the [ConstructorDocItem](ConstructorDocItem.md 'DefaultDocumentation.Models.Members.ConstructorDocItem') type.

```csharp
public ConstructorDocItem(DefaultDocumentation.Models.Types.TypeDocItem parent, IMethod method, System.Xml.Linq.XElement? documentation);
```
#### Parameters

<a name='DefaultDocumentation.Models.Members.ConstructorDocItem.ConstructorDocItem(DefaultDocumentation.Models.Types.TypeDocItem,IMethod,System.Xml.Linq.XElement).parent'></a>

`parent` [TypeDocItem](TypeDocItem.md 'DefaultDocumentation.Models.Types.TypeDocItem')

The [TypeDocItem](TypeDocItem.md 'DefaultDocumentation.Models.Types.TypeDocItem') parent type of the constructor.

<a name='DefaultDocumentation.Models.Members.ConstructorDocItem.ConstructorDocItem(DefaultDocumentation.Models.Types.TypeDocItem,IMethod,System.Xml.Linq.XElement).method'></a>

`method` [ICSharpCode.Decompiler.TypeSystem.IMethod](https_//docs.microsoft.com/en-us/dotnet/api/ICSharpCode.Decompiler.TypeSystem.IMethod 'ICSharpCode.Decompiler.TypeSystem.IMethod')

The [IMethod](https_//github.com/icsharpcode/ILSpy 'ICSharpCode.Decompiler.TypeSystem.IMethod') of the constructor.

<a name='DefaultDocumentation.Models.Members.ConstructorDocItem.ConstructorDocItem(DefaultDocumentation.Models.Types.TypeDocItem,IMethod,System.Xml.Linq.XElement).documentation'></a>

`documentation` [System.Xml.Linq.XElement](https_//docs.microsoft.com/en-us/dotnet/api/System.Xml.Linq.XElement 'System.Xml.Linq.XElement')

The [System.Xml.Linq.XElement](https_//docs.microsoft.com/en-us/dotnet/api/System.Xml.Linq.XElement 'System.Xml.Linq.XElement') documentation element of the constructor.

#### Exceptions

[System.ArgumentNullException](https_//docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[parent](ConstructorDocItem.ConstructorDocItem(TypeDocItem,IMethod,XElement).md#DefaultDocumentation.Models.Members.ConstructorDocItem.ConstructorDocItem(DefaultDocumentation.Models.Types.TypeDocItem,IMethod,System.Xml.Linq.XElement).parent 'DefaultDocumentation.Models.Members.ConstructorDocItem.ConstructorDocItem(DefaultDocumentation.Models.Types.TypeDocItem, IMethod, System.Xml.Linq.XElement).parent') or [method](ConstructorDocItem.ConstructorDocItem(TypeDocItem,IMethod,XElement).md#DefaultDocumentation.Models.Members.ConstructorDocItem.ConstructorDocItem(DefaultDocumentation.Models.Types.TypeDocItem,IMethod,System.Xml.Linq.XElement).method 'DefaultDocumentation.Models.Members.ConstructorDocItem.ConstructorDocItem(DefaultDocumentation.Models.Types.TypeDocItem, IMethod, System.Xml.Linq.XElement).method') is null.