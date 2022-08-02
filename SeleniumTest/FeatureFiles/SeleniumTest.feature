Feature: SeleniumTest

Sample tests

Background: 
	Given the user is in the HomePage
	And the HomePage header is present

@tag1
Scenario: Open HTML Form Page
	When the user clicks the link HtmlFormPage
	Then the user is on the HtmlFormPage

Scenario: Submit user name and passwordWhen the user clicks the link HtmlFormPage
	
	Then the user is on the HtmlFormPage
	When the user types the username and password
	And the user clicks the submit button
	Then the user is on the FormProcessorPage

Scenario: Submit user credentials and selections and check the values
	When the user clicks the link HtmlFormPage
	Then the user is on the HtmlFormPage
	When the user types the username and password
	And the user inputs test values
	And the user clicks the submit button
	Then the user is on the FormProcessorPage
	Then the username value is equal to input
	Then the password value is equal to input
	Then the first checkbox value is equal to input
	Then the second checkbox value is equal to input
	Then the radio value is equal to input
	Then the comment is equal to input
	Then the dropdown item selected is equal to input

Scenario: Enter user credentials and cancel submit
	When the user clicks the link HtmlFormPage
	Then the user is on the HtmlFormPage
	When the user types the username and password
	And the user clicks the submit button
	Then the user is on the FormProcessorPage
	When the user clicks the return button
	Then the user is on the HtmlFormPage