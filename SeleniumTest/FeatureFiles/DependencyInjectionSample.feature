Feature: DependencyInjectionSample

A short summary of the feature

Background: 
	Given the user is in the HomePage
	And the HomePage header is present

Scenario: Submit user name and password
	When the user clicks the link HtmlFormPage
	Then the "Basic HTML Form Example" header element should be present
	When the user types the username "SeleniumUser2" and password "UnH4ck43Le"
	# When the user types the username and password
	And the user clicks the "submit" button
	Then the "Processed Form Details" header element should be present


