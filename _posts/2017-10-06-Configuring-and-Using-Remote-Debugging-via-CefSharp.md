---
layout: post
featimg: RemoteDebuggingHeader.png
title: Configuring and Using Remote Debugging via CefSharp
tags: [Chromium]
category: articles
homedisplay: featimg
---
CefSharp provides an ability to use remote debugging. To use this option we'll need to initialize the CefSharp component with the remote debugging port property.
Thus you can use this port not only with CefSharp, but also in another web browser.

As in the previous tutorial, we need to initalize the CefSharp library with non-default options, so we will not use the designer. However, we will define some markup in the MainWindow.xaml:

<script src="https://gist.github.com/cefsharptutorials/d7b86df5a8bc337046ac432f8a7639df.js"></script>

Then we'll implement the behavior of the MainWindow (MainWindow.xaml.cs):

<script src="https://gist.github.com/cefsharptutorials/2aa3566dd58220fb00ecce03bdebdbe6.js"></script>

Now we can build and launch the application. After the launch we can use the remote debugging aka ‘developer tools’ for the source browser (on the left in the preview) in the other browser (on the right in the preview).

![image-title-here](/img/RemoteDebuggingOutput.png){:class="img-responsive"}
