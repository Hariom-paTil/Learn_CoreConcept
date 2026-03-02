# 📘 Analysis of Algorithm

## 1️⃣ Simple Definition (In Very Easy Words)

Analysis of Algorithm means:
👉 Checking how fast an algorithm runs
👉 Checking how much memory it uses

In simple words:
It is a way to measure the performance of an algorithm.

We mainly measure:
⏱ **Time Complexity** (execution time)
💾 **Space Complexity** (memory usage)

## 2️⃣ Why We Need This? (Problem It Solves)

Imagine:
You write two programs to sort 1,000,000 numbers.
Both give correct output.
But one takes 1 second, and another takes 10 seconds.
Which one is better? 🤔

Without analysis:
- We cannot compare algorithms properly.
- We cannot know which works better for large input.

**Problems It Solves:**
- Helps choose the best algorithm
- Predicts performance for large inputs
- Prevents slow programs
- Saves memory

## 3️⃣ Real-Life Example

Imagine you are searching for a book in a library 📚

- **Method 1:** Check each book one by one.
- **Method 2:** Go to the correct section → Then correct shelf → Then book.

Second method is faster.

👉 Analysis of algorithm helps us understand which method is faster and why.

## 4️⃣ Basic Example (Normal Example With Explanation)

**Example:** Find maximum number in array
```csharp
int[] arr = { 5, 3, 8, 2, 9 };
```

We check each element once.
This means:
- If array size = 5 → 5 comparisons
- If array size = 100 → 100 comparisons
- If array size = n → n comparisons

So time depends on n.
👉 **This is called O(n)**

## 5️⃣ Step-by-Step Working

Let’s understand with example:

```csharp
int max = arr[0];

for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
}
```

**Steps:**
1. Assume first element is maximum
2. Compare with second element
3. Update max if needed
4. Continue until end

If array size = n:
- Loop runs n-1 times
- So total operations ≈ n

## 6️⃣ Syntax / Code Example (C#)

**Example:** Linear Search
```csharp
using System;

class Program
{
    static int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
                return i;
        }
        return -1;
    }

    static void Main()
    {
        int[] arr = { 10, 20, 30, 40, 50 };
        int result = LinearSearch(arr, 30);
        Console.WriteLine("Index: " + result);
    }
}
```

## 7️⃣ Time Complexity (Explain How and Why)

Time Complexity tells:
How running time increases as input size increases.

**Common Time Complexities:**

| Notation | Meaning | Example |
| :--- | :--- | :--- |
| **O(1)** | Constant | Access array element |
| **O(n)** | Linear | Linear Search |
| **O(n²)** | Quadratic | Bubble Sort |
| **O(log n)** | Logarithmic | Binary Search |
| **O(n log n)** | Fast sorting | Merge Sort |

**Why Linear Search is O(n)?**
Because:
In the worst case, we check all elements.
If n elements → n comparisons.
So growth = n. Therefore = **O(n)**

## 8️⃣ Space Complexity

Space Complexity tells:
How much extra memory an algorithm uses.

**Example:**
```csharp
int sum = 0;
```
Uses only one variable. So: **Space = O(1)**

If we create another array of size n:
```csharp
int[] temp = new int[n];
```
Then: **Space = O(n)**

## 9️⃣ Advantages

✅ Helps compare algorithms
✅ Helps write optimized code
✅ Saves memory
✅ Important for interviews
✅ Required for large systems

## 🔟 Disadvantages

❌ Sometimes difficult to calculate
❌ Does not give exact time (only approximation)
❌ Ignores constants

Example:
- O(2n) → Written as O(n)
- O(1000n) → Still O(n)

## 1️⃣1️⃣ When To Use It

✔ When designing new algorithm
✔ When comparing two solutions
✔ When working with large data
✔ During coding interviews
✔ Competitive programming

## 1️⃣2️⃣ When NOT To Use It

❌ Very small programs
❌ Small input size (n < 10)
❌ When performance does not matter

## 1️⃣3️⃣ Common Interview Questions

- What is Time Complexity?
- Difference between O(1) and O(n)?
- What is worst case, best case, average case?
- Why do we ignore constants?
- What is Big-O notation?
- What is difference between Time and Space complexity?
- Why is Binary Search O(log n)?
- Compare O(n²) and O(n log n)

## 1️⃣4️⃣ Important Points To Remember

⭐ Big-O measures worst case
⭐ Focus on growth rate
⭐ Ignore constants
⭐ Drop lower order terms

Example:
n² + n + 10  →  **O(n²)**
Because: n² grows fastest

## 1️⃣5️⃣ Small Practice Questions

**🟢 Easy**
- What is time complexity of:
```csharp
for(int i = 0; i < n; i++)
{
    Console.WriteLine(i);
}
```
- What is space complexity of storing n integers?

**🟡 Medium**
- Find time complexity:
```csharp
for(int i = 0; i < n; i++)
{
    for(int j = 0; j < n; j++)
    {
        Console.WriteLine(i + j);
    }
}
```
- What is time complexity of Binary Search?

**🔴 Hard**
- Find time complexity:
```csharp
for(int i = 0; i < n; i++)
{
    for(int j = 0; j < i; j++)
    {
        Console.WriteLine(i + j);
    }
}
```
- If algorithm takes: `3n² + 5n + 100`, What is its Big-O?
