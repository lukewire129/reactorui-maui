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
public partial class MauiCodeImage : MauiCodeView
{
    public MauiCodeImage(XElement xamlElement) : base(xamlElement)
    {
        RegisterProperty("Source", "Microsoft.Maui.Controls.ImageSource", false);
        RegisterProperty("Aspect", "Microsoft.Maui.Aspect", true);
        RegisterProperty("IsOpaque", "bool", false);
        RegisterProperty("IsAnimationPlaying", "bool", false);
    }
}