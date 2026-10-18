
# Task 2.1

#### 1- what is each one ? 

 Dictionary => its a concrete collection using to store data in a key value pairs
 Sorted Dictionary => it's a concrete collection also used to store data in a key value pairs also but sorted
 IreadOnlyDictionary => it's like an interface only to show data stored in a dictionary whatever it sorted or not

#### 2- how is IReadOnlyDictionary different from Dictionary, and why would a public method return one instead of a Dictionary ?

as i mentioned before ireadonlydictionary used for displaying data or check that dictionary has a specific data without adding or removing or updating data inside the concrete dictionary.. so if we need to share data with any other class it's better to not sharing dictionary itself we should return an Ireadonlydictionary to prevent any manipulation could happen on the data

#### 3- how is SortedDictionary different from Dictionary in ordering and in lookup speed; and when would you choose it?

as i mentioned both used for soring data in a key value pair but Sorted dictionary used when we need to save data sorted and displaying it in a Asc order . Sorted dictionary sorting data by key only and by default the ordering is ASC . Dictionary may faster than Sorted one in all actions (Add , lookup , remove , update ) at the average it's complexity is O(1) . on the other hand Sorted dictionary's time Complexity is 0(n) 


# Task 2.2

S1 Find a student by national ID — thousands of times a day.
Dictionary

S2 Keep the tags of a course. The same tag must never be stored twice. 
  HashSet it's prevent duplication 


S3 Keep a student's grades in the order they were entered. The same grade can appear more than once. 

LIST it's not depending on hashing so it's not preventing duplication


S4 A public method returns the course price list. Callers can read prices but must not add or change any. 

IReadOnlyDictionary => it prevents data manipulation. it only allowing read or lookup




S5 A timetable keyed by session start time. Sessions are added at any moment, and it must always print in time order.

SortedDictionary




S6 A method returns results that the caller only loops over once — and may stop early.

IEnumerable 