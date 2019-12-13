# Workshops

This Repo holds a collection of documents and presentations targeting different topics a developer faces in his daily work. The topics mainly focus on developing **C#** applications.

Each topic lives in a dedicated directory. This *readme* only gives an overview about the structure of each topic, but does not contain detailed information.

Single Topics may also contain source code which is used in the workshop.

1. [Asynchronous Programming](#asynchronous-programming)
   1. [Introduction](#introduction)
   2. [Basics](#basics)
   3. [Advanced Stuff](#advanced-stuff)
   4. [Conclusion](#conclusion)

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
