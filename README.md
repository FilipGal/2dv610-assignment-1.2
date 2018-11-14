# Course repository for the optional assigment in the course 2dv610

## Authors: Filip Gal - fg222ak & William Robertson - wr222ae

1. Language of choice: C#
2. Framework for unit-testing: xUnit.Net
3. Framework for mocking: Moq
4. Code coverage tool: TBD

# Project description

The program is a console based application which is based on the card game 21, the program has no user input.

## Single or Pair-wise student Assignment

This exercise contains elements that can either be done by a single student or a group of maximum 2 students.

Note that if you are working in a pair, the work should be a team effort. A recommended structure is pair programming where you take turns in implementing test cases and implementation methods. It is not important which student makes the commits to Github, but it is important that both students are equally active in the work.

However, examination of the assignment is done individually. The grade is also set individually.

This is an optional assignment for higher grades [E-A]. It is recommended that you finish Part one first.
Description

In A1 part one, you have tried a Unit Testing framework in PHP with simple examples. In A1 part two you are supposed to dive deeper into Unit-testing frameworks, Mocking frameworks, Code Coverage tools and also Test Driven Development. During this exercise, you will learn automated unit testing using Test Driven Development.

The assignment allows much freedom to choose how and what you want to do as long as you learn.

For example, you are to decide the following:

* Language of implementation (For example Java)
* Framework for unit-testing (For example JUnit 4)
* Framework for Mocking (For example Mockito)
* Code coverage tool (For example Code Cover)
* What sort of project you are going to code (For example a dice game)

There are however some minimum requirements that we want you to achieve. You should see these as guidelines to conduct a project of the right size and type.
In order to get a higher grade you need to show that you have:

1. Made commits to GitHub using a specific pattern that shows that you have worked using TDD, (at least 20 commits.) Make sure you are working in “Test Driven Development” manner. Make a git-commit after each step:

   1. Red: Write a test that fails. Make a commit with the word “RED” in commit message.
   2. Green: Change the implementation so that the test-suite succeeds. Make a commit with the word “GREEN”.
   3. Refactor: Rewrite the code. Make a commit with the word “REFACTOR”.

   At some point do a coverage measurement. If you make a code-coverage measurement do a commit separately for that named “COVERAGE”, make sure you save the measurement as a file in your GitHub repository. Could be a text file or a screenshot-image.

2. Show a project of proper size and complexity that illustrates your proficiency in the techniques. Our criteria is:

   1. In the final project show at least 4 SUT-classes with dependencies. The more classes the better
   2. You have used dependency injection
   3. You needed to mock or isolate dependencies so that only bugs in the class under test trigger a failing test and not a bug in other classes.
   4. Objects of classes are created, not only during setup
   5. The project has a UI (Console, GUI, or web)

3. Understand TDD, unit-testing, mocking and coverage
   1. Show expertice in the use of the XUnit framework, Mocking framework, coverage tool
   2. Test behaviour using mocks
   3. Show the use of different type of mocking
   4. Use a Code coverage tool

# Task: Write a small project using TDD

Write a small project and make sure you practice writing the test first!
Also, make sure you use mocking and calculates coverage!

## Examination criteria and Artifacts

### Artifacts that we want to see during examination

- Show a programming environment with a project that compiles with 100% unit test-coverage
- git-commit history that shows that you have worked in TDD way
- In that project show examples of how mocking is used to test behaviour and to isolate testing of dependent units
- Show that you can find code not covered by any test by code-coverage
- Show source-code for classes and test-classes in GIT
