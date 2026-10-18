# Part 03 — answers

---

## BlockedUsers

- Time complexity before: O(n^2)
- Time (ms) before: 36 ms
- What did you change? changed List to hashset 
- Time complexity after:  O(n)
- Time (ms) after: 3 ms

---

## Students

- What was the problem? the problem was that we created the list first and then printing the students till we reach 3 printed students
- What did you change?  used yield return to return one by one once created and if we reached 3 we will break and not creating another student anymore
