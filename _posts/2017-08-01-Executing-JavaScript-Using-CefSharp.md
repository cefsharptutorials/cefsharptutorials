---
layout: post
featimg: ExecutingJavaScriptHeader.jpg
title: Executing JavaScript Using CefSharp
category: JavaScript
homedisplay: featimg
---
JavaScript handles sufficient part of work with web pages' content, allowing to access, modify, and interact with it.
In this tutorial we’ll create a WPF application which can execute custom JavaScript on the web page.

First of all, we'll need create a WPF project and add the CefSharp NuGet package to that project.

The next step is markup of the MainWindow. The source code of the MainWindow.xaml is provided below.

<script src="https://gist.github.com/cefsharptutorials/2c47cbe1fc51c7f1aa19b98cc034e2dc.js"></script>

Now let's implement the behavior of the MainWindow. The source code of the MainWindow.xaml.cs is provided below.

<script src="https://gist.github.com/cefsharptutorials/2dc0fee571fdfa4d25c19804bd5e8a2a.js"></script>

The application now can be built and launched. After the web page is loaded we can type the JavaScript code we need to be executed and press the “Execute” button.

Here's what the result will look like:

![image-title-here](/img/ExecutingJavaScriptOutput.png){:class="img-responsive"}
