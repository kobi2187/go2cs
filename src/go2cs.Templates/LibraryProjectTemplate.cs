﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace go2cs.Templates
{
    using go2cs;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\Projects\go2cs\src\go2cs.Templates\LibraryProjectTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class LibraryProjectTemplate : TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 1 "D:\Projects\go2cs\src\go2cs.Templates\LibraryProjectTemplate.tt"
 // This template creates a <AssemblyName>.csproj file 
            
            #line default
            #line hidden
            this.Write("<Project Sdk=\"Microsoft.NET.Sdk\">\r\n\r\n  <PropertyGroup>\r\n    <OutputType>Library</" +
                    "OutputType>\r\n    <TargetFramework>netcoreapp3.1</TargetFramework>\r\n    <RootName" +
                    "space>go</RootNamespace>\r\n    <AssemblyName>");
            
            #line 14 "D:\Projects\go2cs\src\go2cs.Templates\LibraryProjectTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AssemblyName));
            
            #line default
            #line hidden
            this.Write("</AssemblyName>\r\n    <Product>go2cs</Product>\r\n    <Copyright>Copyright © ");
            
            #line 16 "D:\Projects\go2cs\src\go2cs.Templates\LibraryProjectTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DateTime.UtcNow.ToString("yyyy")));
            
            #line default
            #line hidden
            this.Write(@"</Copyright>
    <PackageProjectUrl>https://github.com/GridProtectionAlliance/go2cs</PackageProjectUrl>
    <RepositoryUrl>https://github.com/GridProtectionAlliance/go2cs</RepositoryUrl>
    <PackageLicenseExpression>MIT</PackageLicenseExpression>
    <Nullable>enable</Nullable>
    <NoWarn>660;661;IDE1006</NoWarn>
    <Version>0.1.0</Version>
  </PropertyGroup>

  <ItemGroup>
    <ProjectReference Include=""..\golib\golib.csproj"" /><!--Condition=""'$(Configuration)'=='Debug'""-->
    <!--<PackageReference Include=""go.lib"" Version=""0.1.0"" Condition=""'$(Configuration)'=='Release'"" />-->
  </ItemGroup>

</Project>
");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 31 "D:\Projects\go2cs\src\go2cs.Templates\LibraryProjectTemplate.tt"

// Template Parameters
public string AssemblyName;  // File name without extension

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
}
