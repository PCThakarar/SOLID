# SOLID
This repository is created to explain SOLID principles through code.

## SRP - Single Responsibility Principle
- A module should have one and only one reason to change
- A module should be responsible to one and only one user or stakeholder
- A module should be responsible to one and only one actor
- Separate the code that different actors depends on
- Brute force approach to achieve SRP is to separate out each method into different classes which is not practical enough for larger projects.
- The idea is to keep all code/ methods that changes together for the same actor within the same scope/ class.
- Violation Example: Consider a student class that consists of all the methods related to student, course, payment, email sending, DB operations etc.. all scoped within a 
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
- In general, Business rules are considered the highest level elements and hence should not depend on any other elements. By doing these we provide a privileged position to 
  the Business rules and hence are the most protected elements of the hierarchy.
  Whereas, other elements like Presenters are considered as the lowest level elements and they depend on multiple other elements directly/ indirectly like controllers,     
  Business rules, Databases, etc. and hence are the least protected elements of the hierarchy since any change in controllers, Business rules or Databases may impact the 
  Presenters directly or indirectly
- Higher level elements should be protected from the changes in the lower level elements.
- Interfaces can be used to invert the dependencies and point dependencies in the correct direction.
- Violation Example: Consider initially before COVID, there was only a single type of course (Offline) and for the same, we had a class for Course and had implemented some 
  methods to subscribe/ unsubscribe and CRUD operations. Now, after COVID we had to provide Offline Course as well and hence we added a new property in class Course called 
  type based on which, we would be writing our logic specific to Online/ Offline classes. 
  This is a violation of OCP since, in future, there might be a requirement that we need to support a third type of Course called Hybrid. In this case, since our logic is 
  conditional over a property of the Course class, we will require to change the class in a way that it will impact the other 2 types (Online/ Offline).

## LSP - Liskov Substitution Principle
-  A way of defining sub types
-  This is more of a guiding principle for inheritance which is required to be used to fix violations of other principles.
-  It says that a subtype should be substitutable for its parent type in all possible cases. Any violation of this substitution property can pollute a system with a     
   significant amount of extra mechanisms.
-  Violation examples
- Square Rectangle problem
- Consider that after 2 different modes of education (Online/ offline) were introduced, a new requirement came for Offline students to check the availability of the 
  course in a certain area based on student's state. While solving LSP, we separated Online into a separate class than the normal Course class. Now, as the requirement 
  was primarily for the Offline students, as a first instinct, we would add this method in the course class and won't touch the Online class. However, OnlineCourse class inherits from Course class which has this new 
  method to check the availability of the course based on Student's state and since we have not implemented that method in the child class: Online Course, it will take the implementation from it's base/ parent 
  class which is Course which will in turn provide an incorrect result when invoked with an object of OnlineCourse class. Hence, this violates LSP.

 ## ISP - Interface segregation Principle
 - ISP is a language issue (occurs in statically typed languages like Java, .NET, etc.)
 - ISP says that you should not depend on things that you don't need.
 - ISP violation can cause unnecessary recompilation and redeployment.
 - Interfaces should only contain those methods that are most likely to be used together or for same context.
 - The lesson here is that depending on something that carries baggage that you don't need can cause you troubles that you didn't expect.
 - Violation Example: Consider a database repository interface for Students. All the operations pertaining to student and their corresponding course are clubbed together in a single interface. Now let's say a new 
   course has been introduced in the curriculum and is required to be added by the school/ university teachers. At this point of time, the only requirement is to add a new Course and no Student dependency is 
   intended. However, since we have a common interface for Student and Course, the teachers have to depend on the entire interface which also contains methods for CRUD operations of Students along with CRUD 
   operations of Course. Hence, this violates ISP.

 ## DIP - Dependency Inversion Principle
 - Refer/ Depend only to/ on abstractions and not concretions.
 - This is not a hard core rule. For example: String class in Java is concrete but its least likely to change. Hence we can depend on String class.
 - DIP mainly says that we should not depend on Volatile Concrete elements.
 - It also says that all abstractions should be least volatile since any change in abstractions can trigger changes in their corresponding concrete implementations.
 - Try to add functionalities to concrete implementations without making changes to corresponding abstractions.
 - Don't refer to volatile concrete classes.
 - Don't derive from volatile concrete classes.
 - Don't override concrete functions.
 - However, this never mean that your entire software can be stable and can never depend on any concrete implementations.
 - Creation of volatile concrete objects requires special handling for example implementing an abstract factory.
 - DIP violations of depending on concrete implementations cannot be entirely removed but they are gathered into a small number of concrete components and kept separate     
   from the rest of the system.
 - Violation Example: Consider a database repository for Student class which is being used for CRUD operations by the Student class. Now, suddenly there was a request from the DB team that we need to change our Database 
   from SQL to Postgres for some valid reasons. By doing this change in the concrete implementations of the Student Repository, it will impact all other components that depend on Student Repository to change (Here,   
   Student class). This happens because we are depending on the volatile concrete implementation of Student Repository within Student class. Hence, this violates DIP. 
