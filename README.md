# SOLID Principles Example Project

This project demonstrates the implementation of the SOLID principles in object-oriented design. The SOLID principles are a set of five principles that aim to make software designs more understandable, flexible, and maintainable.

## Contents

- [Overview](#overview)
- [Folder Structure](#folder-structure)
- [SOLID Principles Demonstrated](#solid-principles-demonstrated)
- [Usage](#usage)

## Overview

The project contains examples of code before and after adhering to each of the five SOLID principles: Single Responsibility Principle (SRP), Open-Closed Principle (OCP), Liskov Substitution Principle (LSP), Interface Segregation Principle (ISP), and Dependency Inversion Principle (DIP).

Each principle is demonstrated in its own namespace within the project, with `Avant` representing code before adhering to the principle and `Apres` representing code after adhering to the principle.

## Folder Structure
-DIP
  Avant
  Apres
-ISP
  Avant
  Apres
-LSP
  Avant
  Apres
-OCP
  Avant
  Apres
-SRP
  Avant
  Apres

## SOLID Principles Demonstrated

1. **Single Responsibility Principle (SRP)**:
   - Demonstrated by separating responsibilities into distinct classes and ensuring that each class has only one reason to change.

2. **Open-Closed Principle (OCP)**:
   - Demonstrated by designing classes that are open for extension but closed for modification, allowing for easy addition of new functionalities without altering existing code.

3. **Liskov Substitution Principle (LSP)**:
   - Demonstrated by ensuring that objects of a superclass can be replaced with objects of its subclasses without affecting the correctness of the program.

4. **Interface Segregation Principle (ISP)**:
   - Demonstrated by creating interfaces that are specific to the needs of the clients, preventing clients from being forced to depend on methods they do not use.

5. **Dependency Inversion Principle (DIP)**:
   - Demonstrated by depending on abstractions rather than concrete implementations, allowing for easier substitution of dependencies and reducing coupling between classes.

## Usage

To run the code examples, simply navigate to the `Program.cs` file within each namespace and execute the `Main` method.
