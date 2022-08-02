Feature: ArgumentSample

Passing arguments from feature file

Background: 
	Given the user is in the HomePage with URL "https://testpages.herokuapp.com/styled/index.html"
	And the "Test Pages For Automating" header element is present


Scenario: Submit user name and password
	When the user clicks the "HTML Form Example" link 
	Then the "Basic HTML Form Example" header element should be present
	When the user types the username "SeleniumUser2" and password "UnH4ck43Le"
	And the user clicks the "submit" button
	Then the "Processed Form Details" header element should be present
	

Scenario: Submit username, password, options
	When the user clicks the "HTML Form Example" link 
	Then the "Basic HTML Form Example" header element should be present
	When the user types the username "SeleniumUser2" and password "UnH4ck43Le"
	And the user provides the comment, checkbox, radio button, drop down items
	| Comment Box                                | Comment Message      | Checkbox              | Radio Button          | Drop Down | Drop Down Item |
	| //textarea[contains(text(),'Comments...')] | This is an automated | //input[@value='cb1'] | //input[@value='rd3'] | dropdown  | dd4            |
	And the user clicks the "submit" button
	Then the "Processed Form Details" header element should be present

Scenario Outline: Submit username, password, options in multiple scenarios
	When the user clicks the "HTML Form Example" link 
	Then the "Basic HTML Form Example" header element should be present
	When the user types the username "<username>" and password "<password>"
	And the user provides the "<Comment>" in "<CommentBox>", "<Checkbox>", "<RadioButton>", "<DropDown>" in "<DropDownItem>" items
	And the user clicks the "submit" button
	Then the "Processed Form Details" header element should be present
	Examples:
	| username      | password | Comment                  | CommentBox                                 | Checkbox              | RadioButton           | DropDown | DropDownItem |
	| SeleniumUser1 | Aw3som3! | This is auto generated 1 | //textarea[contains(text(),'Comments...')] | //input[@value='cb1'] | //input[@value='rd3'] | dropdown | dd6          |
	| SeleniumUser2 | P4ssc0de | This is auto generated 2 | //textarea[contains(text(),'Comments...')] | //input[@value='cb2'] | //input[@value='rd1'] | dropdown | dd3          |