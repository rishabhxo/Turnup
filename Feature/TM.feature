Feature: TM
	As TurnUp portal admin
    I would like to manage Time and Materials records in a single page
    
	
@mytag
Scenario: I would like to create new material with valid details
	Given I have logged in to time and material page successfully
	And I have navigated to TM page
	Then I should be able to create new material with valid details successfully
