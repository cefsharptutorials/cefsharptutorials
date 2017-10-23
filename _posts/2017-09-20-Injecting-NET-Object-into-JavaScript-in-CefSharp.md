---
layout: post
featimg: InjectingNETintoJavaScriptHeader.jpg
title: Injecting .NET Object into JavaScript in CefSharp
tags: [JavaScript, WPF]
category: Articles
homedisplay: featimg
---
If we need to interact with the .NET side from the JavaScript without evaluating any scripts, for example, to handle some events, we can inject the .NET object into the JavaScript side.

The restriction of this approach is that the .NET object should be registered in the CefSharp browser before the browser is initialized. Because of this we cannot use a XAML editor for browser creation - in this case the browser will be initialized earlier than we inject the .NET object and an exception will be thrown.

So, in this tutorial we will create a browser directly from the C# code. However, there is still one point we need to do in the markup - set the name of the grid which will be used as the browser’s container.

The MainWindow.xaml will look as follows:

<script src="https://gist.github.com/cefsharptutorials/570bc6d297cd132d8cceb3838958b68e.js"></script>

Now we need to create the .NET class which will be injected into the JavaScript side. Later we will call its methods using the JavaScript. The single method of this class will simply show the message box with the text passed through the argument. You can place it near the MainWindow class in the MainWindow.xaml.cs:

<script src="https://gist.github.com/cefsharptutorials/c4e4594e22c0cded4ec6f5b562954178.js"></script>

Then let's implement the MainWindow behavior:

<script src="https://gist.github.com/cefsharptutorials/82259b285dc15afac4ffe511b590f46b.js"></script>

The last step is creating an HTML file which will call the registered .NET object using JavaScript. The source code of the index.html is provided below.

<script src="https://gist.github.com/cefsharptutorials/24bd393414587877011faf8fe81f3023.js"></script>

Upon building and launching the application, in the loaded window we can type the text we want to be displayed in the message box into the input and press the ‘Show message’ button. The typed text will be handled by the JavaScript side, passed to the .NET object and the .NET object will invoke the MessageBox.Show method with the typed text.

The screenshot of the result is provided below.

![image-title-here](/img/InjectingNETintoJavaScriptOutput.png){:class="img-responsive"}
