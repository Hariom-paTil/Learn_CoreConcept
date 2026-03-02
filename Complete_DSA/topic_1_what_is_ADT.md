# 📘 Abstract Data Type (ADT)

## 1️⃣ Simple Definition (in very easy words)

An Abstract Data Type (ADT) is a blueprint of a data structure.
It tells **what operations** we can perform.
But it does NOT tell **how** those operations are implemented.

👉 In simple words:
**ADT = What to do (not How to do)**

## 2️⃣ Why We Need This? (Problem it solves)

When building programs:
- We want to focus on what a data structure should do
- Not worry about how it is internally built

**Problems ADT Solves:**
✅ Hides internal implementation
✅ Makes code clean and organized
✅ Makes maintenance easier
✅ Allows changing implementation without changing usage

**Example:**
You use `List.Add()`. You don’t care how it stores data internally. That is abstraction.

## 3️⃣ Real-Life Example
**🏧 ATM Machine**

When you use an ATM:
- You press Withdraw
- You press Deposit
- You check Balance

You don’t know:
- How bank servers work
- How database stores money
- How network works

👉 You only know the operations available. That’s ADT in real life.

## 4️⃣ Basic Example (Normal example with explanation)
**Stack ADT**

Stack supports:
- `Push()` → Add element
- `Pop()` → Remove element
- `Peek()` → See top element
- `IsEmpty()` → Check empty or not

Stack does NOT define:
- Whether we use array
- Or linked list

That is implementation detail.
So:
**Stack ADT = Operations only**

## 5️⃣ Step-by-Step Working

Let’s understand Stack ADT example:

**Step 1: Define Operations**
- Push
- Pop
- Peek
- IsEmpty

**Step 2: Choose Implementation (optional)**
- Array
- Linked List

**Step 3: User Only Uses Operations**
User does:
```csharp
stack.Push(10);
stack.Push(20);
stack.Pop();
```
User doesn’t know how it works internally.

## 6️⃣ Syntax / Code Example (in C#)

Here is a simple Stack ADT implementation:

```csharp
using System;

class StackADT
{
    private int[] arr;
    private int top;
    private int capacity;

    public StackADT(int size)
    {
        capacity = size;
        arr = new int[capacity];
        top = -1;
    }

    // Push Operation
    public void Push(int value)
    {
        if (top == capacity - 1)
        {
            Console.WriteLine("Stack Overflow");
            return;
        }

        arr[++top] = value;
    }

    // Pop Operation
    public int Pop()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack Underflow");
            return -1;
        }

        return arr[top--];
    }

    // Peek Operation
    public int Peek()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is Empty");
            return -1;
        }

        return arr[top];
    }

    public bool IsEmpty()
    {
        return top == -1;
    }
}
```

👉 This is implementation.
But ADT means only defining operations, not internal array.

## 7️⃣ Time Complexity (Explain how and why)

For Stack ADT (Array Implementation):

| Operation | Time Complexity | Why? |
| :--- | :--- | :--- |
| Push | O(1) | Direct index insertion |
| Pop | O(1) | Direct index removal |
| Peek | O(1) | Access top element |
| IsEmpty | O(1) | Simple condition check |

All operations are constant time.

## 8️⃣ Space Complexity

Uses an array of size n.
So space complexity = **O(n)**
Because memory depends on number of elements.

## 9️⃣ Advantages

✅ Hides internal details
✅ Improves code security
✅ Easy to modify implementation
✅ Makes large systems manageable
✅ Encourages modular programming

## 🔟 Disadvantages

❌ Slightly more complex for beginners
❌ Sometimes extra abstraction adds overhead
❌ May reduce flexibility if poorly designed

## 11️⃣ When To Use It

Use ADT when:
- Designing large systems
- Creating reusable components
- Writing library code
- You want clean architecture
- You want to separate logic from implementation

## 12️⃣ When NOT To Use It

Avoid heavy abstraction when:
- Writing very small programs
- Performance-critical low-level systems
- When full control over implementation is required

## 13️⃣ Common Interview Questions on This Topic

- What is Abstract Data Type?
- Difference between ADT and Data Structure?
- Is Stack an ADT or Data Structure?
- How is ADT different from Class?
- Can ADT have multiple implementations?
- Give real-life example of ADT.
- What is abstraction in DSA?

## 14️⃣ Important Points To Remember

🔹 ADT defines behavior, not implementation.
🔹 Data Structure is implementation of ADT.
🔹 Stack, Queue, List are ADTs.
🔹 Array, Linked List are implementations.
🔹 ADT supports abstraction principle of OOP.

## 15️⃣ Small Practice Questions

**🟢 Easy**
- Define ADT in your own words.
- Give two real-life examples of ADT.
- Is Array an ADT? Why?

**🟡 Medium**
- Explain difference between ADT and Data Structure.
- Implement Queue ADT using array.
- Can one ADT have multiple implementations? Explain.

**🔴 Hard**
- Design a List ADT and write its operations.
- Implement Stack ADT using Linked List.
- Explain how ADT improves system design in large software.
- Create your own custom ADT for a Library Management System.
