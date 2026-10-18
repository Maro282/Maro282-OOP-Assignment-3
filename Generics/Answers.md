#### Step 2
The two stores are common in : - 
1- they have list to keep data 
2- both have the same 4 methods with same logic
3- both classes have Id property
Two stores different in : -
1- StudentStore stores data about student & CourseStore stores data about Coures
2- they are different in the list type
3- student only has id and name but course has id title and price


#### Step 3
error 1 
CS1061: 'T' does not contain a definition for 'Id' and no accessible
extension method 'Id' accepting a first argument of type 'T' could be found
(are you missing a using directive or an assembly reference?)

why it happened ?  
the compiler doesn't sure about the type of T because it may be student or course or int so there is no guarantee that T will be type that has Id property so we built the IHasId Interface and made student and course implement it and also make T implements IHasId


error2
CS0403: Cannot convert null to type parameter 'T' because it could be a
non-nullable value type. Consider using 'default(T)' instead.

the compiler doesn't sure that T will be nullable type so it crashes . to solve this we return default or make T : class



#### Step 7
Cannot use string as a parameter for class<T> or Method<T> because it doesn't implement IHasId


The class that i have made in step 4 and 5 is called GENERIC REPOSITORY 