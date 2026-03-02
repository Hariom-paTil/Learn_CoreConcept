# 📘 Asymptotic Notations

## 1️⃣ Simple Definition (In Very Easy Words)

Asymptotic Notations are mathematical tools used to describe:
👉 How fast an algorithm grows
👉 How its time or space increases when input size becomes very large

In simple words:
**Asymptotic Notation tells us the growth rate of an algorithm.**

We mainly use:
- **Big-O (O)** → Worst Case
- **Big-Omega (Ω)** → Best Case
- **Big-Theta (Θ)** → Average / Exact Growth

## 2️⃣ Why We Need This? (Problem It Solves)

Imagine two algorithms:
- Algorithm A → 5n
- Algorithm B → n²

If n = 5 → A = 25, B = 25 (Same 🤔)
If n = 1000 → A = 5000, B = 1,000,000 (Huge difference 😲)

So we need a way to measure growth behavior, not exact numbers.

**Problems It Solves:**
- Removes machine dependency
- Ignores constant values
- Helps compare algorithms fairly
- Predicts performance for large inputs

## 3️⃣ Real-Life Example

Imagine:
You walk to college 🚶
Your friend uses bike 🏍

For short distance:
Both reach at similar time.

For long distance:
Bike is much faster.

👉 Asymptotic notation focuses on long-distance behavior (large input size).

## 4️⃣ Basic Example (Normal Example With Explanation)

Example:
```csharp
for(int i = 0; i < n; i++)
{
    Console.WriteLine(i);
}
```

- If n = 10 → runs 10 times
- If n = 100 → runs 100 times
- If n = 1,000 → runs 1,000 times

Growth depends on n.
👉 **This is written as: O(n)**

## 5️⃣ Step-by-Step Working

Let’s understand different notations.

**Example Function:**
f(n) = 3n² + 5n + 10

**Step 1:** Ignore constants
→ 3n² becomes n²

**Step 2:** Remove smaller terms
→ n² dominates over n

**Final: O(n²)**

Because n² grows fastest when n becomes large.

## 6️⃣ Syntax / Code Example (C#)

**Example 1: O(1) – Constant Time**
```csharp
int GetFirstElement(int[] arr)
{
    return arr[0];
}
```
Runs only once → **O(1)**

**Example 2: O(n)**
```csharp
void PrintAll(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
}
```
Runs n times → **O(n)**

**Example 3: O(n²)**
```csharp
void PrintPairs(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        for(int j = 0; j < arr.Length; j++)
        {
            Console.WriteLine(arr[i] + "," + arr[j]);
        }
    }
}
```
- Outer loop → n
- Inner loop → n
- Total → n × n = n²
So → **O(n²)**

## 7️⃣ Time Complexity (Explain How and Why)

Asymptotic Notations describe Time Complexity in 3 ways:

🔹 **1. Big-O (O) → Worst Case**
Definition: Maximum time algorithm can take.
Example: Linear Search (Worst case → element at last position)
Time = **O(n)**

🔹 **2. Big-Omega (Ω) → Best Case**
Definition: Minimum time algorithm can take.
Example: Linear Search (Best case → element at first position)
Time = **Ω(1)**

🔹 **3. Big-Theta (Θ) → Exact / Average Case**
Definition: Tight bound (both upper and lower bound).
Example: f(n) = 2n + 5
This grows exactly linear → **Θ(n)**

## 8️⃣ Space Complexity

Asymptotic Notation also applies to memory.

Example:
```csharp
int[] arr = new int[n];
```
Space increases with n → **O(n)**

If no extra memory used:
```csharp
int sum = 0;
```
Space → **O(1)**

## 9️⃣ Advantages

✅ Helps compare algorithms
✅ Platform independent
✅ Predicts large input behavior
✅ Removes unnecessary constants
✅ Important in interviews

## 🔟 Disadvantages

❌ Does not show exact running time
❌ Not useful for small input
❌ Can be confusing at beginning

## 1️⃣1️⃣ When To Use It

✔ Comparing two algorithms
✔ Writing optimized code
✔ Large datasets
✔ Interview preparation
✔ Competitive programming

## 1️⃣2️⃣ When NOT To Use It

❌ Very small programs
❌ When performance does not matter
❌ Small input size

## 1️⃣3️⃣ Common Interview Questions

- What is Big-O notation?
- Difference between O(n) and O(n²)?
- Difference between O, Ω, and Θ?
- Why do we ignore constants?
- Which grows faster: O(n log n) or O(n²)?
- What is tight bound?
- What is worst case of Binary Search?
- Why is Binary Search O(log n)?

## 1️⃣4️⃣ Important Points To Remember

⭐ Focus on growth rate
⭐ Ignore constants
⭐ Ignore lower order terms
⭐ Always consider large input (n → ∞)
⭐ Big-O represents worst case

Example:
10n² + 100n + 500 → **O(n²)**
Because n² dominates for large n.

## 1️⃣5️⃣ Small Practice Questions

**🟢 Easy**
- What is time complexity?
```csharp
for(int i = 0; i < n; i++)
    Console.WriteLine(i);
```
- What is complexity of accessing array element?

**🟡 Medium**
- Find complexity:
```csharp
for(int i = 0; i < n; i++)
{
    for(int j = 0; j < i; j++)
    {
        Console.WriteLine(i + j);
    }
}
```
- What is Big-O of: `5n³ + 2n² + 100`

**🔴 Hard**
- Find complexity:
```csharp
for(int i = 1; i < n; i = i * 2)
{
    Console.WriteLine(i);
}
```
- If algorithm runs `n log n + n²`, What is final Big-O?
