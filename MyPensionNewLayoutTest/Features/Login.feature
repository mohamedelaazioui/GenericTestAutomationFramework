Feature: Login functionality

	In order to consult my mail
	As I got an active gmail account
	I want to be able to login

@mytag
Scenario: Successful Login with Valid Credentials
	Given I open gmail website
	When I entered my username and password 
	And I clicked on next button 
	Then the result should be see compose button
