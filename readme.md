# Workshops

This Repo holds a collection of documents and slideshows targeting different topics a developer faces in his daily work. The topics mainly focus on developing **C#** applications.

Each topic lives in a dedicated directory. This *readme* only gives an overview about the structure of each topic, but does not contain detailed information.

Next to the slideshows, each topic's directory also contains the referenced source code.

1. [Prerequisites](#prerequisites)
   1. [Running the code examples](#running-the-code-examples)
      1. [Console Applications](#console-applications)
      2. [UI Apps](#ui-apps)
   2. [Running the Slideshows locally](#running-the-slideshows-locally)
      1. [Google Chrome](#google-chrome)
      2. [Microsoft Edge](#microsoft-edge)
      3. [Other browsers](#other-browsers)
2. [Asynchronous Programming](#asynchronous-programming)
   1. [Introduction](#introduction)
   2. [Basics](#basics)
   3. [Advanced Stuff](#advanced-stuff)
   4. [Conclusion](#conclusion)

## Prerequisites

### Running the code examples

#### Console Applications

- .NET Core 3

#### UI Apps

- Visual Studio 2017+
- .NET Framework 4.7.2

### Running the Slideshows locally

#### Google Chrome

To run the [remark](https://github.com/gnab/remark) slideshows in Google Chrome, a local webserver serving either the content of the root of this repository or at least the content of the subdirectory which contains the topic's slideshow is required. The easiest solution is to install [Web Server for Chrome](https://chrome.google.com/webstore/detail/web-server-for-chrome/ofhbbkphhbklhfoeikjpcbhemlocgigb) and set the desired directory.

#### Microsoft Edge

Opening the `index.html` in Microsoft Edge works out of the box.

#### Other browsers

UNTESTED!

## Asynchronous Programming

[**SlideShow**](https://rodoering.github.io/Workshops/AsynchronousProgramming/index.html)

### Introduction

- What is asynchronous programming?

### Basics

- `async`
- `await`
- `Task.Run()`

### Advanced Stuff

- Collections of tasks (`Task.WaitAll()`, `Task.WhenAll()`)
- Asynchronous programming and *LINQ* (`.Select(), .ForEach()`)
- Cancellation
- Progress notification
- `ConfigureAwait()`
- `Task.Yield()`
  
### Conclusion

- Best practices
- When do we need asynchronous programming?
- When not to use asynchronous programming?
- Common mistakes
