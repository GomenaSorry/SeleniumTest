Feature: SeleniumTest

A short summary of the feature

Background: 
	Given the user is in the Home Page

@tag1
Scenario: Open HTML Form Page
	When the user clicks the link HtmlFormPage
	Then the user is on the HtmlFormPage

Scenario: Submit user name and password
	When the user clicks the link HtmlFormPage
	Then the user is on the HtmlFormPage
	When the user types the username and password
	And the user clicks the submit button
	Then the user is the FormProcessorPage

Scenario: Submit user credentials and selections
	When the user clicks the link HtmlFormPage
	Then the user is on the HtmlFormPage
	When the user types the username and password
	And the user inputs test values
	And the user clicks the submit button
	Then the user is the FormProcessorPage