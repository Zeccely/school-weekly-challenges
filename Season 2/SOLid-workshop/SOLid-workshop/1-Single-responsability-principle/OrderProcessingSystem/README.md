# Refactor the OrderManager

**S - Single Responsibility Principle**  
A class should have one, and only one, reason to change.

## Overview

You are tasked with refactoring a simple program to improve its design by
adhering to the **Single Responsibility Principle (SRP)**. The provided code
violates SRP by assigning multiple responsibilities to a single class,
`OrderManager`. Your job is to split these responsibilities into separate
classes and create a cleaner, more modular design.

## Starter Solution

You are provided with a starter solution containing the
`OrderProcessingSystem` project, which contains the current (non-refactored)
implementation of the `OrderManager` class.

### Current Project Structure

- **`OrderManager`**: Handles the logic for managing orders. This class violates SRP by managing multiple concerns.
- **`Product`**: Represents a product with properties like name, price, and quantity. It encapsulates product-related data and operations such as quantity updates.
- **`ProductName` Enum**: Describes the different products available in the store.

## Tasks

1. **Understand the Problem**
   - Review the provided code in `OrderProcessingSystem`.
   - Identify the multiple responsibilities handled by the `OrderManager` class.

2. **Refactor the Code**
   - Split the responsibilities of `OrderManager` into separate classes
   - Refactor the `OrderManager` class to act as a coordinator, delegating tasks to the new classes.

Good luck, and happy refactoring!
