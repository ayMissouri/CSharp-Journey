# Value vs Reference

## Value Type

* Store actual data directly
* Typically stored in the stack
* Include int, float, long, double, char, bool, decimal, struct, enum
* Nullable versions available (int?, double?)
* Can be stored in heap if part of a reference type

![](https://www.tutlane.com/images/csharp/csharp_value_type_memory_allocation_example.png)

## Reference Type

* Stores the memory location of the actual data instead of storing the value in memory directly
* The variable here stores the memory reference of the data and not the data directly
* Include string, class, Array etc...
* When we copy this reference type of a data type it will just copy the memory address of the data so we will then have two variables pointing to the same data

![](https://www.tutlane.com/images/csharp/csharp_reference_type_memory_allocation_example.png)