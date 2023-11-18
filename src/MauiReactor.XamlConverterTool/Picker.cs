// <auto-generated />
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace MauiReactor.XamlConverterTool;
public partial class MauiCodePicker : MauiCodeView
{
    public MauiCodePicker(XElement xamlElement) : base(xamlElement)
    {
        RegisterProperty("TextColor", "Microsoft.Maui.Graphics.Color", false);
        RegisterProperty("CharacterSpacing", "double", false);
        RegisterProperty("Title", "string", false);
        RegisterProperty("TitleColor", "Microsoft.Maui.Graphics.Color", false);
        RegisterProperty("SelectedIndex", "int", false);
        RegisterProperty("FontFamily", "string", false);
        RegisterProperty("FontSize", "double", false);
        RegisterProperty("FontAttributes", "Microsoft.Maui.Controls.FontAttributes", true);
        RegisterProperty("FontAutoScalingEnabled", "bool", false);
        RegisterProperty("HorizontalTextAlignment", "Microsoft.Maui.TextAlignment", true);
        RegisterProperty("VerticalTextAlignment", "Microsoft.Maui.TextAlignment", true);
    }
}