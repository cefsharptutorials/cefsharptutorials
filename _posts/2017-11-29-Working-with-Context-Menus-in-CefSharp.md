---
layout: post
featimg: WorkingWithContextMenusHeader.jpg
title: Working with Context Menus in CefSharp
tags: [Chromium]
category: Articles
homedisplay: featimg
---
This tutorial demonstrates how to build your own context menu in .NET application by means of CefSharp.

Lets try to search the selected text via some search engine. Usually, we need to select the text, copy it, open the search engine, paste text and press ‘Search’.

Using the context menus this can be done much easier.

So, the MainWindow.xaml just contains the ChromiumWebBrowser component:

<script src="https://gist.github.com/cefsharptutorials/0300c31b1fd81097c001e198f61fbe88.js"></script>

And here is the MainWindow.xaml.cs with the context menu handler implementation:

<script src="https://gist.github.com/cefsharptutorials/e199f207195fddbdb6273547bc15a3a9.js"></script>

The context menu appears on the right click on the selected text:

![image-title-here](/img/WorkingWithContextMenusOutput1.png){:class="img-responsive"}

And the new window with the search results is opened upon a click:

![image-title-here](/img/WorkingWithContextMenusOutput2.png){:class="img-responsive"}
