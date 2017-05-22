Feature: Search
	In order to easily find todos items
	As a 21st century user
	I want to be able to find todo item via search 

Background: :
	Given I opened todos app
@functional

Scenario: Search for a todo item
	
	When I fill in s in txtSearch element
	Then one todo item should be found
