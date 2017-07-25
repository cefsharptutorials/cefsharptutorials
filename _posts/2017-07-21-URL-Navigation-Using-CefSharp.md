---
layout: post
featimg: CefSharpBasicsDisplayanHTML5CSS3Webpage.png
title: URL Navigation Using CefSharp
homedisplay: featimg
---
If we need to create a one-tabbed browser window, we'll have to add some C# handlers for window elements. But they are very simple too.
As in the previous tutorial you need to reference CefSharp NuGet package from the NuGet gallery.
And now we’ll create a simple browser window with navigation.
Markup of the MainWindow.xaml (bold are the changes of template):

<script src="https://gist.github.com/cefsharptutorials/1e26ac1ff1dcefe112ce80c0592a44d8.js"></script>

The C# source code of the MainWindow:

<script src="https://gist.github.com/cefsharptutorials/86e630b9baa08a2d3b5e230a2d49afa8.js"></script>

As you can see, the explicit actions with the Browser are very simple and self-describing. We only need to make sure that action is available and perform it.
This sample contains Back, Forward, and Navigation actions. Also the AddressBox contains the navigated URL.
Here is what the output of this example looks like:
![image-title-here](/cefsharptutorials/img/URLNavigationUsingCefSharpOutput.png){:class="img-responsive"}
