Feature: Feature1
Feature: Login and validate user input of the HTML Form Page

A short summary of the feature

Background: Pre-condition
	Given User is at Home page
	And Header element is visible
	When User clicks the HTML Form Example Link
	Then User should be at Basic HTML Form Example Page

@tag1
Scenario: Navigate to the Form page and perform user login
	When User provides the username and password
	And User clicks the checkbox item2
	And User clicks the radio button1
	And User clears the Comments textbox
	And User provides the comment in the Comment field
	And User selects the dropdown item6
	And User clicks the button LoginButton
	Then User should be at Form Processing Page

@tag2
Scenario: Validate user input
	When User provides the username and password
	And User clicks the checkbox item2
	And User clicks the radio button1
	And User clears the Comments textbox
	And User provides the comment in the Comment field
	And User selects the dropdown item6
	And User clicks the button LoginButton
	Then User should be at Form Processing Page
	Then Username element should match the username value
	Then Password element should match the password value
	Then Comment element should match the comment value

@tag3
Scenario: User Logout
	When User provides the username and password
	And User clicks the button LoginButton
	Then User should be at Form Processing Page
	When User clicks the button ReturnButton
	Then User should be at Basic HTML Form Example Page

