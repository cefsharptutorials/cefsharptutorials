---
layout: post
featimg: CefSharpBasicsDisplayanHTML5CSS3Webpage.png
title: CefSharp Basics. Display an HTML5/CSS3 Webpage
homedisplay: featimg
---
.NET Framework contains the default WebBrowser component which allows to display the web pages inside of your desktop applications. But if you need to display the perfect interactive web page with HTML5 / CSS3 / Flash / whatever else, there are a lot of issues, because the built-in WebBrowser component does not support these features.  
I have found a few solutions and chose an open-source CefSharp. It is pretty easy to install and get it work with WinForms/WPF application (the sample below is for WPF). There's a restriction to be aware of: the .NET Framework version should be at least 4.5.2.  
This component is provided in the NuGet.org gallery, so you can add it to your solution via the Package Manager:  

![image-title-here](/cefsharptutorials/img/CefSharpBasicsPackageManager.png){:class="img-responsive"}

Please note that you need to select specific x64/x68 configuration because the CefSharp should define which native binaries are needed.  
After you referenced CefSharp package, you can use it. The source code of WPF window is provided below. The bold lines are only changes in MainWindow in the default WPF app template:  

<script src="https://gist.github.com/cefsharptutorials/293648782c1c41d1bb589816a3d4ce49.js"></script>  

And it works!

![image-title-here](/cefsharptutorials/img/CefSharpBasicsOutput.png){:class="img-responsive"}
