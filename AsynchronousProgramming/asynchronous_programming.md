class: center, middle

# Asynchronous Programming

---

# Agenda

 1. [Introduction](#introduction)
 2. [Basics](#basics)
 3. [Deep-Dive](#deep-dive)
 4. [Conclusion](#conclusion)

---

name: introduction

# Introduction

- What is synchronous programming?
- What is asynchronous programming?

---

name: basics
layout: true

# Basics

---

### `async/await`

- `async`
- `await`
  
---

### `Task.Run()`


---

## bas2

<!-- template: basics -->

- `Task.Run()`

---

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

---
