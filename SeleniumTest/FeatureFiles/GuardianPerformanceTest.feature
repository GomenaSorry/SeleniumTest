Feature: GuardianPerformanceTest

Guardian page load time demo

Background: 
	Given the user is a valid customer
	When the user navigates to the Guardian Log In Page

Scenario: Get the page load time of the Guardian Log In page
	Then the user is on the "Guardian" Page
	And the page should load not more than 4000 milliseconds

Scenario: Get the page load time of the Guardian Dashboard page
	Then the user is on the "Guardian" Page
	And the page should load not more than 4000 milliseconds
	And the web element "<element>" is present
	| element         |
	| btnSignIn       |
	| tbxEmailAddress |
	| tbxPassword     |
	When the user types the "ruzzell.fernandez@emerson.com" in the "tbxEmailAddress"
	And the user types the "ruzzellruzzell28" in the "tbxPassword"
	And the user clicks the Sign In button
	Then the user is on the "Dashboard" Page
	And the page should load not more than 4000 milliseconds

Scenario: Get the page load time of the Guardian KBA page
	Then the user is on the "Guardian" Page
	When the user types the "ruzzell.fernandez@emerson.com" in the "tbxEmailAddress"
	And the user types the "ruzzellruzzell28" in the "tbxPassword"
	And the user clicks the Sign In button
	Then the user is on the "Dashboard" Page
	# wait for ajax
	And the user should wait
	# tab_kba = KBA tab link for demo
	When the user clicks the "tab_kba" tab in the Dashboard page
	Then the user is on the "Knowledge Base" Page
	And the page should load not more than 4000 milliseconds


	
