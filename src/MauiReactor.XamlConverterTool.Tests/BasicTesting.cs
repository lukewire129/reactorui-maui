using System.Xml.Linq;

namespace MauiReactor.XamlConverterTool.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var xaml = """
                <?xml version="1.0" encoding="utf-8" ?>
                <ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                             x:Class="MauiApp16.MainPage">

                    <ScrollView>
                        <VerticalStackLayout
                            Padding="30,0"
                            Spacing="25">
                            <Image
                                Source="dotnet_bot.png"
                                HeightRequest="185"
                                Aspect="AspectFit"
                                SemanticProperties.Description="dot net bot in a race car number eight" />

                            <Label
                                Text="Hello, World!"
                                Style="{StaticResource Headline}"
                                SemanticProperties.HeadingLevel="Level1" />

                            <Label
                                Text="Welcome to &#10;.NET Multi-platform App UI"
                                Style="{StaticResource SubHeadline}"
                                SemanticProperties.HeadingLevel="Level2"
                                SemanticProperties.Description="Welcome to dot net Multi platform App U I" />

                            <Button
                                x:Name="CounterBtn"
                                Text="Click me" 
                                SemanticProperties.Hint="Counts the number of times you click"
                                Clicked="OnCounterClicked"
                                HorizontalOptions="Fill" />
                        </VerticalStackLayout>
                    </ScrollView>

                </ContentPage>
                """;

            var xamlDocument = XDocument.Parse(xaml);

            var codeBuilder = new MauiReactorCodeBuilder(xamlDocument);

            var generatedCode = codeBuilder.GenerateCode();

            Assert.Pass();
        }
    }
}