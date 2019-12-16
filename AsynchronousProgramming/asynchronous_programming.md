class: center, middle

# Asynchronous Programming

---

# Agenda

 1. [Introduction](#introduction)
 2. [Basics](#basics)
 3. [Deep-Dive](#deep-dive)
 4. [Conclusion](#conclusion)

---

layout: true

# Introduction

---
name: introduction

## Synchronous programming

- statements are executed one after the other
- the next statement starts executing after the preceding is finished

--
count: false

The following code:

```csharp
public static void Main(string[] args)
{
    var stopWatch = new StopWatch();
    stopWatch.Start();

    runningAFiveSecondLastingTask();

    stopWatch.Stop();
    Console.WriteLine($"Execution took {stopWatch.ElapsedMilliseconds} ms");
}
```

produces the output:

```sh
Execution took 5003 ms
```

---

## Asynchronous programming

- if a statement is executed asynchronously, the next statement can start immediately without waiting for it to finish

--
count: false

The following code:

```csharp
public static void Main(string[] args)
{
    var stopWatch = new StopWatch();
    stopWatch.Start();

*   runningAFiveSecondLastingTaskAsync();

    stopWatch.Stop();
    Console.WriteLine($"Execution took {stopWatch.ElapsedMilliseconds} ms");
}
```

produces the output:

```sh
Execution took 13 ms
```


---
layout: false
layout: true

# Basics

---
name: basics

### `async/await`

- `async`
- `await`
  
---

### `Task.Run()`

- `Task.Run()`

---
layout: false

name: deep-dive

# Deep-Dive

- Collections of tasks (`Task.WaitAll()`, `Task.WhenAll()`)
- Asynchronous programming and *LINQ* (`.Select(), .ForEach()`)
- Cancellation
- Progress notification
- `ConfigureAwait()`
- `Task.Yield()`
  
---

name: conclusion

# Conclusion

- Best practices
- When do we need asynchronous programming?
- When not to use asynchronous programming?
- Common mistakes
