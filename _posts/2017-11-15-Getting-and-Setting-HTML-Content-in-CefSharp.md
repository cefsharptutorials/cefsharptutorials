---
layout: post
featimg: GettingSettingHTMLHeader.jpg
title: Getting and Setting HTML Content in CefSharp
tags: [Chromium, HTML]
category: Articles
homedisplay: featimg
---
In CefSharp we can load content in several ways: request the web address, request the local file, or directly set the HTML content of the browser. In this tutorial we’ll use the latter approach.

The Window markup should contain the ChromiumWebBrowser element, text box which will contain the HTML content, and a button which will send the HTML content to the browser.

There also should be the ‘FrameLoadEnd’ event handler. This handler will update the HTML content in the text box after the browser has any content loaded. This markup is provided below (MainWindow.xaml):

<script src="https://gist.github.com/cefsharptutorials/ae3976e287d69fac68fed75a68f87f93.js"></script>

The following source code is the implementation of the MainWindow (MainWindow.xaml.cs):

<script src="https://gist.github.com/cefsharptutorials/42da4d1722ecf39d7f72d6d05fd232b6.js"></script>

The result should look as follows:

![image-title-here](/img/GettingSettingHTMLOutput.png){:class="img-responsive"}
