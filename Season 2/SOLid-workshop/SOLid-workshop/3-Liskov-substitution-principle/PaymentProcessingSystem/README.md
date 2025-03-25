# Refactor the PaymentProcessor

**L - Liskov Substitution Principle**  
Objects in a program should be replaceable with instances of their subtypes without altering the correctness of that program.

## Overview

Refactor a program to adhere to the **Liskov Substitution Principle (LSP)** by
redesigning the structure using inheritance. In the current implementation,
the `PaymentProcessor` base class assumes that all payment methods support
online transactions. This design flaw leads to unexpected behavior when a
subclass like `CashPayment` (which does not support online transactions) is
substituted where a `PaymentProcessor` is expected. Your task is to use
inheritance (abstract classes) to introduce a clear abstraction, ensuring that
all subclasses behave predictably in line with LSP.

## Starter Solution

The **`PaymentProcessingSystem`** project contains the non-refactored implementation.

### Current Project Structure

- **`PaymentProcessor`**: A base class that assumes all payment methods support online transactions.
- **`CreditCardPayment`**: A subclass that supports online payments.
- **`CashPayment`**: A subclass that raises an exception when attempting to
process online payments.

#### Problem:

The `CashPayment` class violates LSP because it does not fulfill the contract
of the `PaymentProcessor` base class. When `CashPayment` is used in place of
`PaymentProcessor`, it results in unexpected behavior (e.g., exceptions).

## Tasks

1. **Analyze the Problem**
   - Identify why the current implementation violates the Liskov Substitution
   Principle (LSP).

2. **Refactor the Code**
   - **Introduce an Abstraction via Inheritance:** Create an abstract base
   class (using inheritance) to differentiate between online and offline
   payment processing. This abstraction should clearly separate the
   responsibilities of processing online versus offline payments.
   - Create separate classes (via subclassing) for each payment type:
     - One for online payment processing.
     - One for offline payment processing.
   - Refactor the existing `PaymentProcessor` so that all subclasses behave
   consistently and predictably, adhering to the LSP.

3. **Add a New Payment Method**
   - Add a new payment method (e.g., `CryptoPayment`) that processes online payments.
   - Verify that your refactored structure allows for this extension without modifying existing code.

## Bonus Task

- Add an `OfflineGiftCardPayment` method that processes offline payments and confirm it integrates seamlessly with your refactored implementation.

Good luck, and happy refactoring!
