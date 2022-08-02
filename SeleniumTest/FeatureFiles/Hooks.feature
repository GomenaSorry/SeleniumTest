Feature: Hooks

Demo hook functionality

@tag1 @smoke
Scenario: Add two numbers
	Given I have entered 50 in the calculator
	And I have entered 70 in the calculator
	When I press add
	Then the result should be 120 on the screen

Scenario: Subtract two numbers
	Given I have entered 70 in the calculator
	And I have entered 50 in the calculator
	When I press subtract
	Then the result should be 20 on the screen
