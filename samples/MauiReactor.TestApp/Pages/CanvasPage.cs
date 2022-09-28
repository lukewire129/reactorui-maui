﻿using MauiReactor.Canvas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiReactor.TestApp.Pages
{
    class CanvasPage : Component
    {
        public override VisualNode Render()
        {
            return new ContentPage("Canvas Test Page")
            {
                new CanvasView
                {
                    new Row
                    {
                        new Box()
                        {
                            new Picture("MauiReactor.TestApp.Resources.Images.Embedded.norway_1.jpeg")
                                .Aspect(Aspect.AspectFill)
                        }
                        .Margin(new Thickness(10))
                        .BackgroundColor(Colors.Green)
                        .CornerRadius(10)
                        ,

                        new Align
                        {
                            new Box()
                            {
                                new Text("Text")
                                    .FontSize(14f)
                                    .FontColor(Colors.Bisque)
                                    .VerticalAlignment(VerticalAlignment.Center)
                                    .HorizontalAlignment(HorizontalAlignment.Center)
                            }
                            .Margin(new Thickness(10))
                            .BackgroundColor(Colors.Red)
                            .CornerRadius(10)
                        }
                        .Height(300)
                        .VerticalAlignment(Microsoft.Maui.Primitives.LayoutAlignment.Center)
                    }
                    .Columns("100, *")
                }
            };
        }
    }
}
