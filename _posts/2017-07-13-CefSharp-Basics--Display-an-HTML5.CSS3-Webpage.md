---
layout: post
featimg: CefSharpBasicsHeader.jpg
title: CefSharp Basics. Display an HTML5/CSS3 Webpage
category: Basics
homedisplay: featimg
---
.NET Framework contains the default WebBrowser component which allows to display the web pages inside of desktop applications. But if you need to display the perfect interactive web page with HTML5 / CSS3 or other fancy features, you’ll face a lot of complications, since the built-in WebBrowser does not support these standards.

Having done some research and testing and I have found a few solutions for this issue.  One of them – an open-source CefSharp works pretty good for my own projects. It is easy to install and get it work with WinForms/WPF application (the sample below is for WPF). It comes with a restriction though: the .NET Framework version should be at least 4.5.2.

This component is provided in the NuGet.org gallery, so you can add it to your solution via the Package Manager:

![image-title-here](/img/CefSharpBasicsPackageManager.png){:class="img-responsive"}

Please note that you'll need to select a specific x64/x68 configuration because CefSharp should define which native binaries are needed.

After you referenced the CefSharp package, you can use it. The source code of the WPF window is provided below.

<script src="https://gist.github.com/cefsharptutorials/293648782c1c41d1bb589816a3d4ce49.js"></script>

And it works!

![image-title-here](/img/CefSharpBasicsOutput.png){:class="img-responsive"}
