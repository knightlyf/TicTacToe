﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------


Namespace Global.App4

    Partial Public Class App
        Implements Global.Windows.UI.Xaml.Markup.IXamlMetadataProvider
        
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", " 10.0.17.0")>  _
        Private __appProvider As Global.App4.App4_XamlTypeInfo.XamlMetaDataProvider

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", " 10.0.17.0")>  _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Private ReadOnly Property _AppProvider() As Global.App4.App4_XamlTypeInfo.XamlMetaDataProvider
            Get
                If __appProvider Is Nothing
                    __appProvider = New Global.App4.App4_XamlTypeInfo.XamlMetaDataProvider()
                End If
                Return __appProvider
            End Get
        End Property

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", " 10.0.17.0")>  _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function GetXamlType(type as Global.System.Type) As Global.Windows.UI.Xaml.Markup.IXamlType Implements Global.Windows.UI.Xaml.Markup.IXamlMetadataProvider.GetXamlType
            Return _AppProvider.GetXamlType(type)
        End Function

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", " 10.0.17.0")>  _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function GetXamlType(fullName As String) As Global.Windows.UI.Xaml.Markup.IXamlType Implements Global.Windows.UI.Xaml.Markup.IXamlMetadataProvider.GetXamlType
            return _AppProvider.GetXamlType(fullName)
        End Function

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", " 10.0.17.0")>  _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function GetXmlnsDefinitions() As Global.Windows.UI.Xaml.Markup.XmlnsDefinition() Implements Global.Windows.UI.Xaml.Markup.IXamlMetadataProvider.GetXmlnsDefinitions
            Return _AppProvider.GetXmlnsDefinitions()
        End Function
    End Class

End Namespace

Namespace Global.App4.App4_XamlTypeInfo
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", " 10.0.17.0")>  _
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public NotInheritable Class XamlMetaDataProvider
        Implements Global.Windows.UI.Xaml.Markup.IXamlMetadataProvider
        Private _provider As Global.App4.App4_XamlTypeInfo.XamlTypeInfoProvider
        Private ReadOnly Property Provider As Global.App4.App4_XamlTypeInfo.XamlTypeInfoProvider
            Get
                If _provider Is Nothing
                    _provider = New Global.App4.App4_XamlTypeInfo.XamlTypeInfoProvider()
                End If
                Return _provider
            End Get
        End Property

        Public Function GetXamlType(type as Global.System.Type) As Global.Windows.UI.Xaml.Markup.IXamlType Implements Global.Windows.UI.Xaml.Markup.IXamlMetadataProvider.GetXamlType
            Return Provider.GetXamlTypeByType(type)
        End Function

        Public Function GetXamlType(fullName As String) As Global.Windows.UI.Xaml.Markup.IXamlType Implements Global.Windows.UI.Xaml.Markup.IXamlMetadataProvider.GetXamlType
            Return Provider.GetXamlTypeByName(fullName)
        End Function

        Public Function GetXmlnsDefinitions() As Global.Windows.UI.Xaml.Markup.XmlnsDefinition() Implements Global.Windows.UI.Xaml.Markup.IXamlMetadataProvider.GetXmlnsDefinitions
            Return New Global.Windows.UI.Xaml.Markup.XmlnsDefinition() {}
        End Function
    End Class

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", " 10.0.17.0")>  _
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Friend Class XamlTypeInfoProvider
        Private _provider As Global.Microsoft.UI.Xaml.Markup.ReflectionXamlMetadataProvider
        Private ReadOnly Property Provider As Global.Microsoft.UI.Xaml.Markup.ReflectionXamlMetadataProvider
            Get
                If _provider Is Nothing
                    _provider = New Global.Microsoft.UI.Xaml.Markup.ReflectionXamlMetadataProvider()
                End If
                Return _provider
            End Get
        End Property

        Public Function GetXamlTypeByType(ByVal type As Global.System.Type) As Global.Windows.UI.Xaml.Markup.IXamlType
            Return Provider.GetXamlType(type)
        End Function

        Public Function GetXamlTypeByName(ByVal typeName As String) As Global.Windows.UI.Xaml.Markup.IXamlType
            Return Provider.GetXamlType(typeName)
        End Function
    End Class
End Namespace

