# SOLID
This repository is created to explain SOLID principles through code.

## SRP - Single Responsibility Principle
- A module should have one and only one reason to change
- A module should be responsible to one and only one user or stakeholder
- A module should be responsible to one and only one actor
- Separate the code that different actors depends on
- Bruteforce approach to achive SRP is to separate out each method into different classes which is not practical enough for larger projects.
- The idea is to keep all code/ methods that changes together for the same actor within the same scope/ class.
- Violatoion Example: Consider a student class that consists of all the methods related to student, course, payment, email sending, DB operations etc.. all scoped within a 
  single class. In normal terms, we call such type of classes to be a fat/ bulky class and such classes violates SRP.

## OCP - Open closed Principle
- A software artifact should be open for extension and closed for modification.
- Here, closed for modification does not mean that "you can never modify any of your code and you always have to extend your code".
- It simply means that if a change is required in a module, it's effect should be confined to barest minimum.
- OCP intends to restrict the impact of your change to the barest minimum so that other directly/ indirectly dependent modules are not impacted.
- There are several ways in which we can make sure that OCP is not violated.
  For example: Defining your dependencies in the correct order i.e.,
  If component A should be protected from changes in component B, then B should depend on A and not the other way around.
- In any software, business rules are the most sensitive parts and hence they are required to be protected from changes in any of the surrounding elements like Presenters
  (Ex: UI), Databases, Controllers, etc.
- In general, Business rules are considered the highest level elements and hence should not depend on any other elements. By doing these we provide a priviliged position to 
  the Business rules and hence are the most protected elements of the hierarchy.
  Whereas, other elements like Presenters are considered as the lowest level elements and they depend on multiple other elements directly/ indirectly like controllers,     
  Business rules, Databases, etc. and hence are the least protected elements of the hierarchy since any change in controllers, Business rules or Databses may impact the 
  Presenters directly or indirectly
- Higher level elements should be protected from the changes in the lower level elements.
- Interfaces can be used to invert the dependencies and point dependencies in the correct direction.
- Violation Example: Consider initially before COVID, there was only a single type of course (Offline) and for the same, we had a class for Course and had implemented some 
  methods to subscribe/ unsubscribe and CRUD operations. Now, after COVID we had to provide Offline Course as well and hence we added a new property in class Course called 
  type based on which, we would be writing our logic specific to Online/ Offline classes. 
  This is a violation of OCP since, in future, there might be a requirement that we need to support a third type of Course called Hybrid. In this case, since our logic is 
  conditional over a proerty of the Course class, we will require to change the class in a way that it will impact the other 2 types (Online/ Offline).

## LSP - Liskov Substitution Principle
-  A way of defining sub types
-  This is more of a guiding principle for inheritance which is required to be used to fix violations of other principles.
-  It says that a parent type object should be substitutable at any point of time by it's corresponding child type object keeping the behavior of the application same.
-  Violation examples
 - Square Rectangle problem
 - Consider that after 2 different modes of education (Online/ offilne) were introduced, a new requirement came for Offline students to check the availability of the 
   course in a certain area based on student's state. While solving LSP, we separated Online into a separate class than the normal Course class. Now, as the requirement 
   was primarily for the Offline students, as a first instinct, we would add this method in the course clas and won't touch the Online class. However, OnlineCourse class       inherits from Course class which has this new method to check the availability of the course based on Student's state and since we have not implemented that method in       the child class: Online Course, it will take the implementation from it's base/ parent class which is Course which will in turn provide an incorrect result when       
   invoked with an object of OnlineCourse class. Hence, this violated LSP.

 ## ISP - Interface segregation Principle
 - 
