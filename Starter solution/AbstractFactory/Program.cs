Console.Title = "Abstract Factory";

// create an abstract factory pattern to create discount services for two different countries Belgium and France. Take advantage of the abstract factory pattern to create a family of related objects without specifying their concrete classes.

// 1. Create an abstract factory class called DiscountFactory that has a method called CreateDiscountService that returns a DiscountService object.

// 2. Create two concrete factory classes called BelgiumDiscountFactory and FranceDiscountFactory that inherit from DiscountFactory.

// 3. Create an abstract class called DiscountService that has a property called DiscountPercentage.

// 4. Create two concrete classes called BelgiumDiscountService and FranceDiscountService that inherit from DiscountService.

// 5. BelgiumDiscountService should return a discount of 20% if the country identifier is "BE" and 10% otherwise.

// 6. FranceDiscountService should return a discount of 15% if the country identifier is "FR" and 5% otherwise.

// 7. Create a client class called Client that has a method called GetDiscount that takes a country identifier and returns the discount percentage for that country.

// 8. Create an instance of the Client class and call the GetDiscount method with the country identifiers "BE" and "FR".

// 9. Print the results to the console.

// 10. Run the program and observe the output.

// 11. Bonus: Add a new country and create a new concrete factory and service class for that country.

// 12. Bonus: Add a new discount service that returns a fixed discount percentage for a given code.

// 13. Bonus: Add a new concrete factory class for the new discount service.

// 14. Bonus: Update the client class to support the new discount service.

// 15. Bonus: Run the program and observe the output.

// 16. Bonus: Refactor the code to use the abstract factory pattern to create the discount services.

// 17. Bonus: Run the program and observe the output.



