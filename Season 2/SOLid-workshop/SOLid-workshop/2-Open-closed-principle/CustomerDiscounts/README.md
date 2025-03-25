# Refactor the DiscountCalculator

**O - Open/Closed Principle**  
Software entities should be open for extension, but closed for modification.

## Overview

Refactor a program to adhere to the **Open-Closed Principle (OCP)**. The current 
`DiscountCalculator` class violates OCP by requiring modifications whenever a new 
discount type is added. Your task is to redesign it to allow extensions without 
changing existing code.

## Starter Solution

The **`CustomerDiscounts`** project contains the non-refactored implementation.

### Current Project Structure

- **`DiscountCalculator`**: Calculates the final amount after applying a discount using a switch statement.
- **`CustomerType` Enum**: Defines customer types (e.g., Regular, VIP, Seasonal).

## Tasks

1. **Analyze the Problem**
   - Identify why the current code violates OCP.

2. **Refactor the Code**
   - Introduce an abstraction (e.g., `IDiscountStrategy`).
   - Create classes for each discount type.
   - Refactor `DiscountCalculator` to use the strategy pattern while retaining its role of calculating the final amount.

3. **Add a New Discount**
   - Add a `BlackFridayDiscount` without modifying existing code.

Good luck, and happy refactoring!
