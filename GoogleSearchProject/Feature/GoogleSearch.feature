@Search Functionality
Feature: GoogleSearch
As a user I want to search Aviva in Google
So that I can see number of links and link text

@Positive
Scenario: Count of links displayed after Searching Aviva in Google
	Given I open browser
	And I go to Google homepage
	When I enter "Aviva" to search
	And I hit the Enter button
	Then I should see links in first search page
	And I print the link text of the 5th link
	
	
@Negative
Scenario Outline: Count of links for searching other than Aviva in Google

	Given I open browser
	And I go to Google homepage
	When I enter <keyword> to search
	And I hit the Enter button
	Then I should not see previous links in first search page
	And I print the link text of the 5th link
	Examples:
	|keyword|
	| Aivva1    |