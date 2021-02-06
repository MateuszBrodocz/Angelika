# Online Store

## Story

Your team was asked to write a complex tool that enables users to take a part in virtual walks through the virtual shopping center. Your PM has gathered all business requirements. This time you won't inherit any legacy code - you will start from scratch. 

Your next task is to create an Online Shop service for the worldwide company "Allegretto".  

Your company architect was able to deliver initial UML diagram - it's not mandatory - you can use it as an example of how to separate layers of software's logic, but you can draw your own (or modify the existing one).

![Example UML diagram for online shop](/media/csharp/online_shop_UML.png)

## What are you going to learn?

You will learn:

- How to utilize Azure DevOps board (or similar tool)
- How to maintain code within Azure DevOps 
- How to work with SCRUM methodology 
- How to use Entity Framework Core - ORM tool with Code First Approach 
- How to follow the SOLID principles
- How to implement stable object-oriented architectures

## Tasks

1. Get familiar with Azure DevOps - discover SCRUM tools that offers and utilize them to strengthen your development process. Open the Online Shop project in Azure boards.
    - User stories are located in the board's backlog. User stories are defined and come from the online shop requirements part. 
    - Each user story in the backlog has an assigned estimation. All estimates are direct results from the planning poker session.
    - Each user story has been discussed and defined as urgent or not urgent.

2. Discuss you scrum methodology actions.
    - In the developer team, there is a Scrum Master role assigned to one of the team members.
    - In the developer team, there is a Product Owner role assigned to one of the team members.
    - During the sprint, Scrum Master is responsible for organizing daily stand-ups and retrospective meetings.

3. Read all the requirements, discuss them with team members and visualize the product's architecture.
    - Project has an use case diagram assigned according to the user stories.
    - Project uses the UML class diagram which is based on the example.

4. As most of the contemporary apps, online shops differentiate types of account.  Implement admin features regarding the product in shop according to the requirements below.
    - Admin user can create new product category or new featured product category.
    - Admin is able to edit the name of an existing product category or feature a product category.
    - Admin is able to deactive a product.
    - Admin can create a new product.
    - Admin can edit a product - its name, price, quantity.
    - Admin can give a limited discount on some products

5. As most of the contemporary apps, online shops differentiate types of account.  Implement admin features regarding orders in shop according to the requirements below.
    - Admin can see the list of ongoing orders with their statuses: `submitted`, `paid`, `on the way`, `delivered`.

6. As most of the contemporary apps, online shops differentiate types of account. Implement admin features regarding feedbacks on products in shop according to the requirements below.
    - Admin can collect feedback from customers and see its statistics. Statistics should be discussed by speaking with client directly. 

7. Implement the shopping cart features for the regular app users.
    - User can add a product to his/her shopping cart.
    - User can edit the product's quantity in shopping cart.
    - User can delete a product from his/her shopping cart.
    - User can see all products in his/her shopping cart.

8. Implement order features for the regular app user.
    - User can submit an order.
    - User can see previous orders.
    - User can see the statistics of his/her orders.

9. Implement product based features for the regular app user.
    - User can get a list of all available products with their prices.
    - User can get a list of all products from the specific product category.
    - User can check the availability of a specific product.
    - User can rate products with the 5-stars scale after receiving order.

## General requirements

- Project's repository utilizes branching model (can be custom)
- All data required is stored in a SQL Server database.
- Persistance layer is based on the ORM - Entity Framework. Code First Approach was used to generate database structure.
- Project follows SOLID principles and utilizes all four pillars of OOP.
- Project implements the DAO pattern.

## Hints

1. In a more complex project planning phase is crutial! Please remember to analyse the requirements, forge atomic tasks and assign them to each other!
2. Don't rush! It seems like there is plenty of work to do, but understanding the "big picture" of the required solution is as important as delivering it! Read the task, do a brainstorming session among the team members and discuss any doubts with your lead mentor. 
3. You can extend the initial UML in any way, but please discuss the changes with your mentor.
  ![Initial UML](media/csharp/onlineshopUML.png)

## Background materials

- <i class="far fa-book-open"></i> [EF Core introduction](https://docs.microsoft.com/en-gb/ef/core/get-started/?tabs=netcore-cli)
- <i class="far fa-video"></i> [EF Core microsoft tutorial](https://www.youtube.com/watch?v=xx5_pVsLP44)
- <i class="far fa-exclamation_mark"></i> [Planning Poker online tool](https://scrumpoker.online/)
- <i class="far fa-book-open"></i> [Azure board usage tutorial](https://docs.microsoft.com/en-us/azure/devops/boards/get-started/?view=azure-devops)
- <i class="far fa-book-open"></i> [.NET design patterns enlisted with example](https://www.dofactory.com/net/design-patterns)
- <i class="far fa-book-open"></i> [MVC implementation example](http://congeritc.blogspot.com/2013/01/mvc-example-with-c-console-program.html)
- <i class="far fa-video"></i> [Amazing frontal from Uncle Bob on SOLID rules](https://www.youtube.com/watch?v=zHiWqnTWsn4)
