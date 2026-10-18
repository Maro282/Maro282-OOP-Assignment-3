# Part 01 — answers

---

## ShippingCostCalculator

- What was the problem?
  => we have 3 strategies to perform the same service which is calculating cost of shipping based on Carrier name
- What did you change?
  => i used the strategy design pattern to seperate strategies from the base class and not depending on the name of carrier
  so i have created an Abstract reference could be any type of the provided strategies so at the runtime we decide which one will be used

---

## OrderProcessor

- What was the problem?
  => the class was violating the DIP principle because the class was creating low level modules objects by itself
- What did you change?
  => make the high level and low level depends on the abstraction (using interface)

---

## Notifications

- What was the problem?
  => the problem was class explosion which means that if we need to make a combination of two different ways for sending notification
  we will have to create a new class that represents this new
- What did you change?
  => used composition over inheritance => whatever notifier type i sent it will be performed

---

## Proof

- New carrier file(s):
- New notification channel file(s):
- Existing classes left unchanged? (yes/no):
