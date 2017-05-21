Feature: Login functionality

	In order to consult my mail
	As I got an active gmail account
	I want to be able to login

Background: 
	Given I open gmail website
@positive
Scenario: Successful Login with Valid Credentials
	
	When I entered my Email and Password 
	| Email                       | Password       |
	| mohamed.elaazioui@gmail.com | CHOCOpeche-123 |
	When I clicked on sign button 
	Then the result should be see compose button
