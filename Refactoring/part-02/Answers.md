# Part 02 — answers

---

## Reports

- What was the problem?
  => The problem was that we have 3 classes have the same algorithm to create a report except one intermediate step which is the formating step
  so why repeating the same code ?
- What did you change?
  => i have created a an abstract class to be inherited from other 3 reporting classes and each one create it's own implementation of the format method
- Why did you choose that approach?
  => because we have an arranged algorithm in clear steps so we choose this approach over interface because we need to make sure that ever step
  happened in it's order

---

## Enrollment

- What was the problem?
 => the problem was that the client which is program.cs had to create objects from four classes 
    to manage enroll a student in a course , create invoice and then send verification mail 
- What did you change?
 => i only have created a class which will be the interface that the client deals with without caring
    about the steps or the services had done
- Why did you choose that approach?
 => to simplify using 
