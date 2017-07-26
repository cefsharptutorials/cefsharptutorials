---
layout: post
featimg: CefSharpBasicsDisplayanHTML5CSS3Webpage.png
title: One-Tabbed Browser with URL Navigation in WPF Application Using CefSharp
homedisplay: featimg
---
If we need to create a one-tabbed browser application with navigation ability, we should create a WPF Window with a browser element and Control elements, and then add some C# handlers for these elements.

As in the previous tutorial we’ll need to reference CefSharp NuGet package from the NuGet gallery.

And now we’ll create a simple browser window with navigation.

Markup of the MainWindow.xaml:

<script src="https://gist.github.com/cefsharptutorials/1e26ac1ff1dcefe112ce80c0592a44d8.js"></script>

The C# source code of the MainWindow:

<script src="https://gist.github.com/cefsharptutorials/86e630b9baa08a2d3b5e230a2d49afa8.js"></script>

As you can see, the explicit actions with the Browser are very simple and self-describing. We only need to check that action is available and perform it.
This sample contains Back, Forward, and Navigation actions. The AddressBox contains the navigated URL.

The resulting window will look as follows:

![image-title-here](/cefsharptutorials/img/URLNavigationUsingCefSharpOutput.png){:class="img-responsive"}
